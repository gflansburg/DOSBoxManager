using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOSBoxManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Process[] runningProcesses = Process.GetProcessesByName("DOSBoxManager");
            if (runningProcesses != null)
            {
                foreach (Process process in runningProcesses)
                {
                    if (process.Id != Process.GetCurrentProcess().Id)
                    {
                        //MessageBox.Show("DOSBox Manager is already running.", "DOSBox Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        IntPtr windowHandle = process.MainWindowHandle;
                        if (windowHandle == (IntPtr)0)
                        {
                            DOSBoxSettings settings = DOSBoxManagerForm.LoadSettings();
                            foreach (ProcessThread thread in Process.GetProcessById(process.Id).Threads)
                            {
                                NativeMethods.EnumThreadWindows(thread.Id, (hWnd, lParam) => 
                                {
                                    string title = NativeMethods.GetWindowText(hWnd);
                                    if (title.Equals(settings.ManagerName ?? "DOSBox Manager"))
                                    {
                                        windowHandle = hWnd;
                                        return false;
                                    }
                                    return true; 
                                }, IntPtr.Zero);
                            }
                        }
                        if (windowHandle != (IntPtr)0)
                        {
                            WINDOWPLACEMENT windowState = new WINDOWPLACEMENT();
                            NativeMethods.GetWindowPlacement(windowHandle, ref windowState);
                            if (windowState.showCmd == ShowWindowCommands.Hide || windowState.showCmd == ShowWindowCommands.Minimized)
                            {
                                NativeMethods.ShowWindowAsync(windowHandle, ShowWindowFlags.SW_RESTORE);
                            }
                            NativeMethods.ShowWindowAsync(windowHandle, ShowWindowFlags.SW_SHOW); 
                            NativeMethods.SetForegroundWindow(windowHandle);
                            NativeMethods.SetFocus(windowHandle);
                            return;
                        }
                    }
                }
            }
            Application.Run(new DOSBoxManagerForm());
        }
    }
}
