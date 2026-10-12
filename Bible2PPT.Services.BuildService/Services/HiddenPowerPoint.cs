using System.Runtime.InteropServices;
using Microsoft.Office.Interop.PowerPoint;

namespace Bible2PPT.Services;

public class HiddenPowerPoint : IDisposable
{
    public Application Instance { get; private set; }

    public HiddenPowerPoint()
    {
        Instance = new Application();
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
                }
            }
            // 파워포인트가 이미 종료되었거나 연결이 끊겼으면 정리할 것이 없음
            catch (COMException)
            {
            }
            Instance = null!;
        }
    }
}
