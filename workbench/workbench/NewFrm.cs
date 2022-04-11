using System;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workbench
{
    public partial class NewFrm : MetroForm
    {
        string Rack;
        string Position;
        string Brand;
        string Device;
        string Spec;
        int Qty;
        int Price;

        public NewFrm()
        {
            InitializeComponent();           
        }

        private void Btn_Add_Click(object sender, EventArgs e)
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
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        //DB 연결 후
                        //SqlCommand command = new SqlCommand("INSERT INTO dbo." + Cb_Rack.Text + "(Position,Brand,Device,Spec,Qty,Price)" +
                        //                        "VALUES (" + Tb_Position.Text + "," + Tb_Brand.Text + "," + Tb_Device.Text + "," + Tb_Spec.Text + "," + Tb_Qty.Text + "," + Tb_Price.Text + ")", DBHelper.DBConn);

                        Rack = Cb_Rack.Text;
                        Position = Tb_Position.Text;
                        Brand = Tb_Brand.Text;
                        Device = Tb_Device.Text;
                        Spec = Tb_Spec.Text;
                        Qty = Convert.ToInt32(Tb_Qty.Text);
                        Price = Convert.ToInt32(Tb_Price.Text);

                        SqlCommand command = new SqlCommand("INSERT INTO dbo." + Rack + "(Position,Brand,Device,Spec,Qty,Price)" +
                                                "VALUES ('" + Position + "','" + Brand + "','" + Device + "','" + Spec + "'," + Qty + "," + Price + ")", DBHelper.DBConn);

                        adapter.InsertCommand = command;
                        adapter.InsertCommand.ExecuteNonQuery();
                       
                        lb_Status.Text = Tb_Spec.Text +" 등록이 완료됐습니다.";
                        DBHelper.Close();
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("에러가 발생 했습니다!");
                lb_Status.Text = "양식을 확인해 주세요.";
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
