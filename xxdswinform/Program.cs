namespace xxdswinform
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using System.Security.Principal;
    using System.Windows.Forms;

    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if (principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                if (true || RunningInstance() == null)
                {
                    Application.Run(new loginWindow());
                }
                else
                {
                    MessageBox.Show("你已经打开了一个窗口，不能重复打开");
                }
            }
            else
            {
                ProcessStartInfo startInfo = new ProcessStartInfo {
                    UseShellExecute = true,
                    WorkingDirectory = Environment.CurrentDirectory,
                    FileName = Application.ExecutablePath,
                    Verb = "runas"
                };
                try
                {
                    Process.Start(startInfo);
                }
                catch
                {
                    return;
                }
                Application.Exit();
            }
        }

        private static Process RunningInstance()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
            foreach (Process process2 in processesByName)
            {
                if ((process2.Id != currentProcess.Id) && (Assembly.GetExecutingAssembly().Location.Replace("/", @"\") == currentProcess.MainModule.FileName))
                {
                    return process2;
                }
            }
            return null;
        }
    }
}

