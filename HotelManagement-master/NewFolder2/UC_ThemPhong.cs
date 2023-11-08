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
    public partial class UC_ThemPhong : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_ThemPhong()
        {
            InitializeComponent();
        }

        private void UC_ThemPhong_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM rooms";
            DataSet ds = fn.getDataSet(query);
            dgv_danhsach.DataSource = ds.Tables[0];


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_datphong_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_sophong.Text) && !string.IsNullOrEmpty(txt_loaiphong.Text) && !string.IsNullOrEmpty(txt_sogiuong.Text) && !string.IsNullOrEmpty(txt_thanhtien.Text))
            {
                string sophong = txt_sophong.Text;
                string loaiphong = txt_loaiphong.Text;
                string sogiuong = txt_sogiuong.Text;
                Int64 sotien = Int64.Parse(txt_thanhtien.Text);

                string query = "INSERT INTO rooms (roomNo, roomType, bed, price) VALUES ('" + sophong + "', '" + loaiphong + "', '" + sogiuong + "', " + sotien + ")";

                fn.setDataSet(query, "Them Phong");
                UC_ThemPhong_Load(this, null);
                clearAll();

            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin ","Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void clearAll()
        {
            txt_sophong.Text = string.Empty;
            txt_thanhtien.Text = string.Empty;
            txt_loaiphong.SelectedIndex = 0;
            txt_sogiuong.SelectedIndex = 0;


        }

        private void dgv_danhsach_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_ThemPhong_Enter(object sender, EventArgs e)
        {
            UC_ThemPhong_Load(this, null);
        }
    }
}
