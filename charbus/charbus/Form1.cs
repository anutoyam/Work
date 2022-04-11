using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using System.Threading;
using ZedGraph;


namespace charbus
{
    public partial class Form1 : Form
    {
        //전역 변수 설정
        ModbusClient MBClient;
        private Thread rdTh;
        private bool threadrun = false;


        public Form1()
        {
            InitializeComponent();

            //접속상태 1초마다 확인
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(ChkConnect);

            //그래프 초기화
            GraphPane gp = chart1.GraphPane;
            gp.Title.IsVisible = false;
            gp.XAxis.Title.IsVisible = false;
            gp.YAxis.Title.IsVisible = false;

            gp.XAxis.Scale.Max = 10000;
            gp.XAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 10000;
            gp.YAxis.Scale.Min = 0;

            button2.Enabled = false;
            button3.Enabled = false;
        }
        //Con 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            MBClient = new ModbusClient(textBox2.Text, 502);
            if (MBClient.Connected != true)
            {
                MBClient.Connect();
                if(MBClient.Connected == true)
                {
                    button1.Enabled = false;
                    button2.Enabled = true;
                    button3.Enabled = false;
                    button4.Enabled = true;
                }   
            }
        }
        //Start 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "동작중";
            label1.ForeColor = Color.Red;
            threadrun = true;
            rdTh = new Thread(HRread);
            rdTh.Start();
            button2.Enabled = false;
            button3.Enabled = true;
        }
        //Stop 버튼
        private void button3_Click(object sender, EventArgs e)
        {

            label1.Text = "정지중";
            label1.ForeColor = Color.Black;
            threadrun = false;
            rdTh.Join();
            //rdTh.Abort();

            button2.Enabled = true;
            button3.Enabled = false;

        }
        //Discon 버튼
        private void button4_Click(object sender, EventArgs e)
        {
            if (MBClient.Connected == true)
            {
                MBClient.Disconnect();
                listBox1.Items.Clear();
                label1.Text = "정지중";
                label1.ForeColor = Color.Black;
                threadrun = false;
                rdTh.Join();

                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }

        }
        //그래프 초기화
        private void button5_Click(object sender, EventArgs e)
        {
            chart1.GraphPane.CurveList.Clear();
            chart1.AxisChange();
            chart1.Invalidate();
            chart1.Refresh();
        }
        //폼 닫을때 쓰레드 자동종료
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MBClient.Connected == true)
                {
                    MBClient.Disconnect();
                    threadrun = false;
                    rdTh.Join();
                }
            }
            catch
            {
            }
        }
        //100 Discrete bit On
        private void button6_Click(object sender, EventArgs e)
        {
            MBClient.WriteSingleCoil(100, true);
        }

        //method
        //접속 확인 메서드
        void ChkConnect(object sender, EventArgs e)
        {
            try
            {
                if (MBClient.Connected == true)
                {
                    label4.Text = "접속완료";
                }
                else
                {
                    label4.Text = "접속해제";
                }
            }
            catch
            {
                label4.Text = "@@@";
            }

        }
        //모드버스 40100,40101 addr read 후 그래프 출력
        public void HRread()
        {
            try
            {
                int rate = Convert.ToInt32(textBox1.Text);
                while (threadrun)
                {
                    if (listBox1.InvokeRequired)
                    {
                        listBox1.Invoke(new MethodInvoker(delegate ()
                        {
                            int[] location = MBClient.ReadHoldingRegisters(100, 20);
                            listBox1.Items.Clear();
                            foreach (int EA in location)
                            {
                                listBox1.Items.Add(EA);
                            }
                        }));
                    }
                    else
                    {
                        listBox1.Invoke(new MethodInvoker(delegate ()
                        {
                            int[] location = MBClient.ReadHoldingRegisters(100, 20);
                            listBox1.Items.Clear();
                            foreach (int EA in location)
                            {
                                listBox1.Items.Add(EA);
                            }
                        }));
                    }

                    if (chart1.InvokeRequired)
                    {
                        chart1.Invoke(new MethodInvoker(delegate ()
                        {
                            int PTx, PTy;
                            GraphPane gp = chart1.GraphPane;


                            PointPairList list = new PointPairList();

                            for (int i = 0; i < 10; i++)
                            {
                                PTx = (int)listBox1.Items[0 + i];
                                PTy = (int)listBox1.Items[10 + i];
                                list.Add(PTx, PTy);
                            }

                            LineItem curve1 = gp.AddCurve("test", list, Color.Red, SymbolType.Circle);
                            curve1.Symbol.Size = 2;
                            curve1.Symbol.Fill.Type = FillType.Solid;
                            curve1.Line.IsVisible = false;
                            curve1.Label.IsVisible = false;
                            chart1.AxisChange();
                            chart1.Invalidate();
                            chart1.Refresh();
                        }));
                    }
                    else
                    {
                        chart1.Invoke(new MethodInvoker(delegate ()
                        {
                            int PTx, PTy;
                            GraphPane gp = chart1.GraphPane;

                            PointPairList list = new PointPairList();
                            for (int i = 0; i < 10; i++)
                            {
                                PTx = (int)listBox1.Items[0 + i];
                                PTy = (int)listBox1.Items[2*i];
                                list.Add(PTx, PTy);
                            }

                            LineItem curve1 = gp.AddCurve("test", list, Color.Red, SymbolType.Circle);
                            curve1.Symbol.Size = 2;
                            curve1.Symbol.Fill.Type = FillType.Solid;
                            curve1.Line.IsVisible = false;
                            curve1.Label.IsVisible = false;
                            chart1.AxisChange();
                            chart1.Invalidate();
                            chart1.Refresh();
                        }));
                    }

                    //주기 시간 설정
                    Thread.Sleep(rate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }




}
