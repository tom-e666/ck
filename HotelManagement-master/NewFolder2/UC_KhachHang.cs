using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.NewFolder2
{
    public partial class UC_KhachHang : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_KhachHang()
        {
            InitializeComponent();
        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
           
                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        combo.Items.Add(sdr.GetString(i));
                    }
                }
            
            sdr.Close();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();

        }

        int rid;
        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price , roomid from where roomNo = '" + txtRoomNo.Text + "' ";
            DataSet ds = fn.getDataSet(query); //dòng này khác với video nha
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and roomType = '" + txtRoomType + "' and booked = 'No' ";
            setComboBox(query, txtRoomNo);
        }

        

        

        private void btnAllotCustomer_Click(object sender, EventArgs e)
        {
            if (txtName.Text != " " && txtContact.Text != " " && txtNationality.Text != " " && txtGender.Text != " " && txtDob.Text != " " && txtIDProof.Text != " " && txtAddress.Text != " " && txtCheckIn.Text != " " && txtPrice.Text != " ")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String national = txtNationality.Text;
                String gender = txtGender.Text;
                String address = txtAddress.Text;
                String idproof = txtIDProof.Text;
                String dob = txtDob.Text;
                String checkin = txtCheckIn.Text;


                query = "insert into customer (cname , mobile , national , gender , address , idproof , dob , checkin ,roomid ) values ('" + name + "','" + mobile + "','" + national + "' , '" + gender + "' ,'" + address + "', '" + idproof + "' ,'" + dob + "' , '" + checkin + "', " + rid + ") update rooms set booked = 'YES' where roomNo = '" + txtRoomNo.Text + "' ";
                fn.setDataSet(query, " Số Phòng " + txtRoomNo + "Đăng ký khách hàng thành công ."); //khac vd nua ne
                clearAll();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin .", "Thông Tin ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIDProof.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtRoomType.SelectedIndex = -1;
            txtPrice.Clear();

        }

        private void UC_KhachHang_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
