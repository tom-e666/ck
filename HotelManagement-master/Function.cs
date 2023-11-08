using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.Common;

namespace HotelManagement
{
    internal class Function
    {
        protected SqlConnection GetConnection()// return connection or connection string?
        {
            string connectionString = "Data Source = LAPTOP-6H42QTM4\\SQLEXPRESS; Initial Catalog = dbMyHotel; Integrated Security = True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public DataSet getDataSet(string query)
        {
            SqlConnection con=GetConnection();  
            
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;  
        }
        public void setDataSet(string query, string message) {
            SqlConnection con=GetConnection();
            SqlCommand cmd=new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(message + " thanh cong");
        }
        public SqlDataReader getForCombo(string query)// dont understand much
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();    
            con.Close();
            return sdr;
        }
           
    }
}
