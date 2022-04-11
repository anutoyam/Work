using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace workbench
{
    public class DBHelper
    {

        //커넥션 객체
        private static SqlConnection conn = null;
        public static string DBConnString { get; private set; }
        public static bool bDBConnCheck = false;
        private static int errorBoxCount = 0;

        /// <summary>
        /// 생성자
        /// </summary>

        public DBHelper() { }

        public static SqlConnection DBConn
        {
            get
            {
                if (!ConnectToDB())
                {
                    return null;
                }
                return conn;
            }
        }

        /// <summary>
        /// Database 접속 시도
        /// </summary>
        /// <returns></returns>

        public static bool ConnectToDB()
        {
            if (conn == null)
            {
                //서버명, 초기 DB명, 인증 방법
                DBConnString = String.Format("Data Source=({0});Initial Catalog={1};Integrated Security={2}; Timeout=3", "local", "WareHouse", "SSPI");
                conn = new SqlConnection(DBConnString);
            }
            try
            {
                if (!IsDBConnected)
                {
                    conn.Open();

                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        bDBConnCheck = true;
                    }
                    else
                    {
                        bDBConnCheck = false;
                    }
                }
            }
            catch (SqlException e)
            {
                errorBoxCount++;
                if (errorBoxCount == 1)
                {
                    MessageBox.Show(e.Message, "DBHelper - ConnectToDB()");
                }

                return false;

            }

            return true;

        }

        /// <summary>
        /// Database Open 여부 확인
        /// </summary>
        public static bool IsDBConnected
        {
            get
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Database 해제
        /// </summary>
        public static void Close()
        {
            if (IsDBConnected)
                DBConn.Close();
        }
    }

}
