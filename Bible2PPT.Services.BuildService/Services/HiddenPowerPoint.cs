using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.PowerPoint;

namespace Bible2PPT.Services;

public class HiddenPowerPoint : IDisposable
{
    public Application Instance { get; private set; }

    /// <summary>
    /// 연결한 파워포인트의 프로세스 ID
    /// </summary>
    private readonly int? _processId;

    /// <summary>
    /// 정리할 때 파워포인트를 종료했는지 여부 (사용자가 연 문서가 있으면 종료하지 않음)
    /// </summary>
    public bool HasQuit { get; private set; }

    public HiddenPowerPoint()
    {
        Instance = new Application();
        _processId = GetProcessId(Instance);
    }

    /// <summary>
    /// 정리할 때 종료한 파워포인트 프로세스가 완전히 끝날 때까지 기다린다.
    /// </summary>
    /// <remarks>
    /// 파워포인트는 Quit 후에도 잠시 살아 있는데, 그 사이에 새 파워포인트를 요청하면 종료 중인 파워포인트에 연결되어
    /// 연결이 끊기는 오류(RPC_E_DISCONNECTED)가 발생하므로 프로그램을 연달아 실행할 때는 종료를 기다려야 한다.
    /// 남은 COM 참조가 모두 해제된 뒤에 호출해야 프로세스가 끝난다.
    /// </remarks>
    /// <returns>종료되었거나 기다릴 프로세스가 없으면 true</returns>
    public bool WaitForExit(TimeSpan timeout)
    {
        if (!HasQuit || _processId is not int processId)
        {
            return true;
        }

        try
        {
            using var process = Process.GetProcessById(processId);
            return process.WaitForExit(timeout);
        }
        // 이미 종료된 프로세스
        catch (ArgumentException)
        {
            return true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            try
            {
                if (Instance.Presentations.Count == 0)
                {
                    Instance.Quit();
                    HasQuit = true;
                }
            }
            // 파워포인트가 이미 종료되었거나 연결이 끊겼으면 정리할 것이 없음
            catch (COMException)
            {
            }
            Instance = null!;
        }
    }

    private static int? GetProcessId(Application application)
    {
        try
        {
            _ = GetWindowThreadProcessId(new IntPtr(application.HWND), out var processId);
            return processId == 0 ? null : (int)processId;
        }
        catch (COMException)
        {
            return null;
        }
    }

    [DllImport("user32.dll")]
    private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
}
