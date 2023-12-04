using System.Data;

namespace HotelManagement
{
    public partial class Form1 : Form
    {
        Function fn = new();
        string query;
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_passowrd.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return;
            }
            query = $"SELECT * FROM employee WHERE username='{txt_username.Text}' AND pass='{txt_passowrd.Text}' ";
            DataSet ds = fn.getDataSet(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DashBoard db = new();
                db.Show();
                db.BringToFront();
                this.Hide();
            }
            else
            {
                lb_error.Visible = true;
            }


        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}