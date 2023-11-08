using Guna.UI2.WinForms;
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
    public partial class UC_CheckOut : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_CheckOut()
        {
            InitializeComponent();
        }

        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            query = " select customer.cid , customer.cname , customer.mobile , customer.nationality , customer.gender , customer.dob , customer.idproof , customer.address , customer.checkin , rooms.roomNo , rooms.roomType , rooms.bed , rooms.price  from customer inner join rooms on customer.roomid  = rooms.roomid where chekout = 'NO' ";
            DataSet ds = fn.getDataSet(query); // trong vd thì người ta dùng getdata nhưng mà tui không sài dc do nó báo lỗi nên tui sài getDataSet nma vẫn run bth nha :))))
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = " select customer.cid , customer.cname , customer.mobile , customer.nationality , customer.gender , customer.dob , customer.idproof , customer.address , customer.checkin , rooms.roomNo , rooms.roomType , rooms.bed , rooms.price  from customer inner join rooms on customer.roomid  = rooms.roomid where cname like '" + txtName.Text + "%' and chekout = 'NO' ";
            DataSet ds = fn.getDataSet(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }
        int id;

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không ?", "Xác nhận ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    query = "update customer set chekout = 'YES' , checkout = '" + txtCheckOutDate + "' where cid = " + id + " update rooms set booked = 'NO' where roomNo = '" + txtRoom.Text + "'";
                fn.setDataSet(query, "Thanh Toán Thành Công ");
                UC_CheckOut_Load(this, null);
                clearAll();

            }
            else
            {
                MessageBox.Show("Không Có Khách Hành Nào Để Lựa Chọn", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
