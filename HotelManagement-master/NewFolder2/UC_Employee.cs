using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.NewFolder2
{
    public partial class UC_Employee : UserControl
    {
        Function fn = new();
        string query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }


        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtGender.Text != "" && txtMobile.Text != ""
                && txtName.Text != "" && txtPassWord.Text != "" && txtUserName.Text != "")
            {
                string name = txtName.Text;
                string username = txtUserName.Text;
                string gender = txtGender.Text;
                string password = txtPassWord.Text;
                string email = txtEmail.Text;
                Int64 mobile = Convert.ToInt64(txtMobile.Text);
                query = $"INSERT INTO employee(ename, mobile, gender, emailid, username, pass) values ('{name}',{mobile},'{gender}','{email}','{username}','{password}') ";
                fn.setDataSet(query, "Đăng kí thành viên thành công");
                clearAll();
                getMaxID();

            }
            else
            {

            }

        }
        private void getMaxID()
        {
            query = "SELECT MAX(eid) FROM employee ";
            DataSet ds = fn.getDataSet(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();

            }

        }
        private void clearAll()
        {
            txtName.Text = "";
            txtMobile.Text = "";
            txtGender.SelectedIndex = 0;
            txtEmail.Text = "";
            txtUserName.Text = "";
            txtPassWord.Text = "";
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                getEmployee(guna2DataGridView1);
            }
            if (tabEmployee.SelectedIndex == 2)
            {
                getEmployee(guna2DataGridView2);
            }
        }
        private void getEmployee(DataGridView dgv)
        {
            query = "SELECT * FROM employee";
            DataSet ds = fn.getDataSet(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa nhân viên này không", "Box", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    query = $"DELETE FROM employee where eid='{txtID.Text}'";
                    fn.setDataSet(query, "Xóa nhâ viên thành công");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }
    }
}

