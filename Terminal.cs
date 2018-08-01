using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
/// This libary is for the Windows Command Prompt, it enables rapid use of
/// the inbuilt command prompt with a single line of code.
namespace System.Konsole
{
    public class Terminal
    {
        public void RunWindowsCommand(string CommandArg, bool IsAdministrator, Label ExitCodeLabel)
        {
            string xArg, xVerb, xExe, xRun;
            xArg = CommandArg;
            xVerb = "";
            xExe = "cmd.exe";
            xRun = "/C " + xArg;
            using (Process xProcess = new Process())
            {
                ProcessStartInfo xInfo = new ProcessStartInfo();
                xInfo.WindowStyle = ProcessWindowStyle.Hidden;
                xInfo.FileName = xExe;
                if (IsAdministrator == true)
                {
                    xVerb = "runas";
                    xInfo.Verb = xVerb;
                }
                else if (IsAdministrator == false)
                {
                    xVerb = "";
                }
                xInfo.Arguments = xRun;
                xProcess.StartInfo = xInfo;
                xProcess.Start();
                //xProcess.WaitForExit();
                if (xProcess.HasExited == true)
                {
                    string ex = xProcess.ExitCode.ToString();
                    if (ExitCodeLabel.Text.Contains("Exit Code: "))
                    {
                        ExitCodeLabel.Text = "Exit Code: " + ex;
                    }
                }

            }
        }

        public void RunWindowsCommand(string CommandArg, bool IsAdministrator)
        {
            string xArg, xVerb, xExe, xRun;
            xArg = CommandArg;
            xVerb = "";
            xExe = "cmd.exe";
            xRun = "/C " + xArg;
            using (Process xProcess = new Process())
            {
                ProcessStartInfo xInfo = new ProcessStartInfo();
                xInfo.WindowStyle = ProcessWindowStyle.Hidden;
                xInfo.FileName = xExe;
                if (IsAdministrator == true)
                {
                    xVerb = "runas";
                    xInfo.Verb = xVerb;
                }
                else if (IsAdministrator == false)
                {
                    xVerb = "";
                }
                xInfo.Arguments = xRun;
                xProcess.StartInfo = xInfo;
                xProcess.Start();
                //xProcess.WaitForExit();
                //if (xProcess.HasExited == true)
                //{
                //    string ex = xProcess.ExitCode.ToString();
                //    if (ExitCodeLabel.Text.Contains("Exit Code: "))
                //    {
                //        ExitCodeLabel.Text = "Exit Code: " + ex;
                //    }
                //}

            }
        }

        public void RunWindowsCommand(string CommandArg, bool IsAdministrator, Label ExitCodeLabel, bool ShowWindow)
        {
            string xArg, xVerb, xExe, xRun;
            xArg = CommandArg;
            xVerb = "";
            xExe = "cmd.exe";
            xRun = "/C " + xArg;
            using (Process xProcess = new Process())
            {
                ProcessStartInfo xInfo = new ProcessStartInfo();
                if (ShowWindow == false)
                {
                    xInfo.WindowStyle = ProcessWindowStyle.Hidden;
                }
                else
                {
                    xInfo.WindowStyle = ProcessWindowStyle.Normal;
                }
                xInfo.FileName = xExe;
                if (IsAdministrator == true)
                {
                    xVerb = "runas";
                    xInfo.Verb = xVerb;
                }
                else if (IsAdministrator == false)
                {
                    xVerb = "";
                }
                xInfo.Arguments = xRun;
                xProcess.StartInfo = xInfo;
                xProcess.Start();
                //xProcess.WaitForExit();
                if (xProcess.HasExited == true)
                {
                    string ex = xProcess.ExitCode.ToString();
                    if (ExitCodeLabel.Text.Contains("Exit Code: "))
                    {
                        ExitCodeLabel.Text = "Exit Code: " + ex;
                    }
                }

            }
        }
    }
}
