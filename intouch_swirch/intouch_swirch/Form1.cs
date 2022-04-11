using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;



namespace intouch_swirch
{
    public partial class Form1 : Form
    {
        //github
        IntPtr hWnd;
        string m = "0";
        int order, cycle = 0;
 

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filepath);
        static string path = "c:\\intouch.ini";


        //인터치 프로젝트 실행
        private void find(string head)
        {
            hWnd = FindWindow(null, head);
            

            if (hWnd.ToString() != m)
            {
                label1.Text = hWnd.ToString();
                if (!hWnd.Equals(IntPtr.Zero))
                {
                    ShowWindowAsync(hWnd, SW_SHOWMAXIMIZED);
                    SetForegroundWindow(hWnd);
                }
            }
            if (hWnd.ToString() != m && order == 1)
            {
                /*
                for (int i = 0; i < 10; i++)
                {
                    SendKeys.SendWait("{down}{down}{down}{down}{down}{down}{down}{down}");
                    if (head == "InTouch - Application Manager - [C:\\Users\\user\\Desktop\\SUV!!!\\SHN1SFHMSUV(150324)\\SHN1SFHMSUV(150324)]")
                    {
                        SendKeys.SendWait("^v");
                        label1.Text = "1번선택";
                    }
                    SendKeys.SendWait("{up}");
                }
                */
                SendKeys.SendWait("{down}{down}{down}{down}{down}{down}{down}{down}");
                SendKeys.SendWait("^v");
            }
            if (hWnd.ToString() != m && order == 2)
            {
                /*
                for (int i = 0; i < 10; i++)
                {
                    SendKeys.SendWait("{down}{down}{down}{down}{down}{down}{down}{down}");

                    if (head == "InTouch - Application Manager - [C:\\Users\\user\\Desktop\\SUV!!!\\SHN1RMSUV(150325)\\SHN1RMSUV(150325)]")
                    {
                        SendKeys.SendWait("^v");
                        label1.Text = "2번선택";
                    }
                    SendKeys.SendWait("{up}");
                }
                */
                SendKeys.SendWait("{down}{down}{down}{down}{down}{down}{down}{down}{up}");
                SendKeys.SendWait("^v");
            }

            
        }
        //딜레이
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        private string ReadIniFile(string section, string key, string path)
        {
            StringBuilder sb = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", sb, sb.Capacity, path);
            return sb.ToString();
        }


        

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SFHM_Click(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcessesByName("intouch");
            btn_RM.Enabled = false;
            btn_SFHM.Enabled = false;
            order = 1;
            if (processList.Length < 1)
            {
                Process p = new Process();
                p.StartInfo.FileName = ReadIniFile("INTOUCH", "EXEPATH", path);
                p.Start();
                
                Thread.Sleep(3000);
            }
            while (processList.Length < 1)
            {
                cycle = cycle + 1;
                processList = Process.GetProcessesByName("intouch");
                label2.Text = "Intouch 실행중";
                Thread.Sleep(1000);
                if (cycle > 5)
                {
                    label1.Text = "Intouch가 실행되지않아 사용할수 없습니다.";
                    return;
                }
            }

            find(ReadIniFile("TITLE", "title1", path));
            if (hWnd.ToString() != m)
            {
                label2.Text = "1번 작업종료";
                order = 0;
                Application.Exit();
            }
            find(ReadIniFile("TITLE", "title2", path));
            if (hWnd.ToString() != m)
            {
                label2.Text = "2번 작업종료";
                order = 0;
                Application.Exit();
            }
            find(ReadIniFile("TITLE", "title3", path));
            if (hWnd.ToString() != m)
            {
                label2.Text = "3번 작업종료";
                order = 0;
                Application.Exit();
            }
        }

        private void btn_RM_Click(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcessesByName("intouch");

            btn_RM.Enabled = false;
            btn_SFHM.Enabled = false;
            order = 2;
            if (processList.Length < 1)
            {
                Process p = new Process();
                p.StartInfo.FileName = ReadIniFile("INTOUCH", "EXEPATH", path);
                p.Start();
                
                Thread.Sleep(3000);
            }
            
            while (processList.Length < 1)
            {
                cycle = cycle + 1;
                processList = Process.GetProcessesByName("intouch");
                label2.Text = "Intouch 실행중";
                Thread.Sleep(1000);
                if (cycle > 5)
                {
                    label1.Text = "Intouch가 실행되지않아 사용할수 없습니다.";
                    return;
                }
            }

            find(ReadIniFile("TITLE", "title1", path));
            if (hWnd.ToString() != m)
            {
                label2.Text = "1번 작업종료";
                order = 0;
                Application.Exit();
            }
            find(ReadIniFile("TITLE", "title2", path));
            if (hWnd.ToString() != m)
            {
                label2.Text = "2번 작업종료";
                order = 0;
                Application.Exit();
            }
            find(ReadIniFile("TITLE", "title3", path));
            if (hWnd.ToString() != m)
            {
                label2.Text = "3번 작업종료";
                order = 0;
                Application.Exit();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Delay(5000);
            if (btn_RM.Enabled == true)
            {
                btn_RM.PerformClick();
            }
        }

    }
}

