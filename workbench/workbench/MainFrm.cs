using System;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace workbench
{
    public partial class MainFrm : MetroForm
    {
        private System.Data.DataTable date_table = null;
        private string filepath = null;

        public MainFrm()
        {
            InitializeComponent();   
        }


        //DB접근 RACK 조회
        public void DB_Search(string rack)
        {
            try
            {
                lock (DBHelper.DBConn)
                {
                    if (!DBHelper.IsDBConnected)
                    {
                        MessageBox.Show("Database 연결을 확인하세요.");
                        return;
                    }
                    else
                    {
                        //DB 연결 후
                        SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM " + rack, DBHelper.DBConn);
                        date_table = new System.Data.DataTable();

                        try
                        {
                            adapter.Fill(date_table);
                            DataGridView1.DataSource = date_table;

                            //DataGridView 사이즈에 맞게 자동 조절
                            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }

                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message, "그리드 뷰 로드 에러");
                        }
                        DBHelper.Close();
                    }
                }
            }
            catch (ArgumentException ane)
            {
                MessageBox.Show(ane.Message, "그리드 뷰 로드 에러");
            }
        }

        //재고 추가
        private void TSMI_Add_Click(object sender, EventArgs e)
        {
            NewFrm AddFrm = new NewFrm();
            AddFrm.ShowDialog();
        }

        //RACK01 조회
        private void TSMI_RACK01_Click(object sender, EventArgs e)
        {
            string rack01 = "dbo.RACK1";
            DB_Search(rack01);
        }

        private void TSMI_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMI_ExcelLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                filepath = OFD.FileName;
                Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = application.Workbooks.Open(Filename: @filepath);
                Worksheet worksheet1 = workbook.Worksheets.get_Item("member");
                application.Visible = false;
                Range range = worksheet1.UsedRange;
                String data = "";

                for (int i = 1; i <= range.Rows.Count; ++i)
                {
                    for (int j = 1; j <= range.Columns.Count; ++j)
                    {
                        data += (range.Cells[i, j] as Range).Value2.ToString() + " ";
                    }
                    data += "\n";
                }

                DataGridView1.DataSource = data;

                DeleteObject(worksheet1);
            }
        }

        private void DeleteObject(object obj) {
            try {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            } catch (Exception ex) {
                obj = null;
                MessageBox.Show("메모리 할당을 해제하는 중 문제가 발생하였습니다." + ex.ToString(), "경고!");
            } finally {
                GC.Collect();
            }
        }

        
    }
}
