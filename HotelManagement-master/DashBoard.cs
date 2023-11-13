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

namespace HotelManagement
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }



        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            uC_ThemPhong1.Visible = false;
            uC_KhachHang1.Visible = false;
            uC_CheckOut1.Visible = false;
            uC_CustomerDetails1.Visible = false;
            uC_Employee1.Visible = false;
            btn_themphong.PerformClick();
            // string connectionString = "Data Source = LAPTOP-6H42QTM4\\SQLEXPRESS; Initial Catalog = dbMyHotel; Integrated Security = True";
        }

        private void uC_ThemPhong1_Load(object sender, EventArgs e)
        {

        }
        private void btn_themphong_Click(object sender, EventArgs e)
        {
            pn_select.Left = btn_themphong.Left + 10;
            uC_ThemPhong1.Visible = true;
            uC_ThemPhong1.BringToFront();
        }
        private void btn_dangkikhachhang_Click(object sender, EventArgs e)
        {
            pn_select.Left = btn_dangkikhachhang.Left + 10;
            uC_KhachHang1.Visible = true;
            uC_KhachHang1.BringToFront();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            pn_select.Left = btn_thanhtoan.Left + 10;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void btn_thongtinkhachahng_Click(object sender, EventArgs e)
        {
            pn_select.Left = btn_thongtinkhachahng.Left + 10;
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            pn_select.Left = btn_nhanvien.Left + 10;
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }
    }
}
