using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bible2PPT.Controls
{
    public class AssemblyIconForm : Form
    {
        private static readonly IntPtr _iconHandle;

        static AssemblyIconForm()
        {
            unsafe
            {
                // ExtractAssociatedIcon은 경로 버퍼(MAX_PATH)에 값을 쓸 수 있으므로 문자열을 복사한 버퍼를 넘김
                var path = Application.ExecutablePath;
                var buffer = new char[Math.Max(path.Length + 1, 260)];
                path.CopyTo(0, buffer, 0, path.Length);
                fixed (char* iconPath = buffer)
                {
                    ushort iconId = 0;
                    // 폼이 살아있는 동안 계속 사용하므로 아이콘 핸들은 해제하지 않음
                    _iconHandle = Windows.Win32.PInvoke.ExtractAssociatedIcon(default, iconPath, &iconId);
                }
            }
        }

        public AssemblyIconForm()
        {
            Icon = Icon.FromHandle(_iconHandle);
        }
    }
}
