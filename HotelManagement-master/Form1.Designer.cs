namespace HotelManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            lb_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btn_login = new Guna.UI2.WinForms.Guna2Button();
            txt_passowrd = new Guna.UI2.WinForms.Guna2TextBox();
            txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label1 = new Label();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(guna2CircleButton1);
            guna2Panel1.Controls.Add(lb_error);
            guna2Panel1.Controls.Add(btn_login);
            guna2Panel1.Controls.Add(txt_passowrd);
            guna2Panel1.Controls.Add(txt_username);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.Controls.Add(guna2PictureBox1);
            guna2Panel1.CustomizableEdges = customizableEdges10;
            guna2Panel1.Location = new Point(406, 228);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges11;
            guna2Panel1.Size = new Size(1112, 550);
            guna2Panel1.TabIndex = 0;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.White;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Image = Properties.Resources.cancel_50px;
            guna2CircleButton1.ImageSize = new Size(30, 30);
            guna2CircleButton1.Location = new Point(3, 3);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(50, 50);
            guna2CircleButton1.TabIndex = 7;
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // lb_error
            // 
            lb_error.BackColor = Color.Transparent;
            lb_error.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_error.Location = new Point(565, 391);
            lb_error.Name = "lb_error";
            lb_error.Size = new Size(326, 22);
            lb_error.TabIndex = 6;
            lb_error.Text = "Thông tin đăng nhập không chính xác, vui lòng đăng nhập lại";
            lb_error.Visible = false;
            // 
            // btn_login
            // 
            btn_login.BorderRadius = 18;
            btn_login.CustomizableEdges = customizableEdges2;
            btn_login.DisabledState.BorderColor = Color.DarkGray;
            btn_login.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_login.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(565, 428);
            btn_login.Name = "btn_login";
            btn_login.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btn_login.Size = new Size(415, 56);
            btn_login.TabIndex = 5;
            btn_login.Text = "Đăng nhập";
            btn_login.Click += btn_login_Click;
            // 
            // txt_passowrd
            // 
            txt_passowrd.BorderRadius = 18;
            txt_passowrd.CustomizableEdges = customizableEdges4;
            txt_passowrd.DefaultText = "";
            txt_passowrd.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_passowrd.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_passowrd.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_passowrd.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_passowrd.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_passowrd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_passowrd.ForeColor = Color.FromArgb(193, 200, 207);
            txt_passowrd.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_passowrd.IconLeft = Properties.Resources.lock_25px;
            txt_passowrd.IconLeftSize = new Size(30, 30);
            txt_passowrd.Location = new Point(565, 317);
            txt_passowrd.Margin = new Padding(3, 4, 3, 4);
            txt_passowrd.Name = "txt_passowrd";
            txt_passowrd.PasswordChar = '*';
            txt_passowrd.PlaceholderText = "Mật khẩu";
            txt_passowrd.SelectedText = "";
            txt_passowrd.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txt_passowrd.Size = new Size(415, 67);
            txt_passowrd.TabIndex = 4;
            txt_passowrd.TextChanged += guna2TextBox2_TextChanged;
            // 
            // txt_username
            // 
            txt_username.BorderRadius = 18;
            txt_username.CustomizableEdges = customizableEdges6;
            txt_username.DefaultText = "";
            txt_username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.ForeColor = Color.FromArgb(193, 200, 207);
            txt_username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_username.IconLeft = Properties.Resources.user_25px;
            txt_username.IconLeftSize = new Size(30, 30);
            txt_username.Location = new Point(565, 242);
            txt_username.Margin = new Padding(3, 4, 3, 4);
            txt_username.Name = "txt_username";
            txt_username.PasswordChar = '\0';
            txt_username.PlaceholderText = "Tên đăng nhập";
            txt_username.SelectedText = "";
            txt_username.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txt_username.Size = new Size(415, 67);
            txt_username.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(738, 129);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(91, 54);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Login";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges8;
            guna2PictureBox1.Image = Properties.Resources.hotelicon;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(-115, -13);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2PictureBox1.Size = new Size(640, 640);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            guna2PictureBox1.TabIndex = 1;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.Click += guna2PictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(641, 86);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 8;
            label1.Text = "tom // 123";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1866, 808);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_passowrd;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_error;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Label label1;
    }
}