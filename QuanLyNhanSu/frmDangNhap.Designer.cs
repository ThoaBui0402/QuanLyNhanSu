
namespace QuanLyNhanSu
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtDanhNhap = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.Label();
            this.txtQLNS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 498);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Location = new System.Drawing.Point(202, 312);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 42);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDN
            // 
            this.btnDN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDN.Location = new System.Drawing.Point(51, 310);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(104, 42);
            this.btnDN.TabIndex = 20;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMatKhau.Location = new System.Drawing.Point(51, 258);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(252, 22);
            this.txtMatKhau.TabIndex = 19;
            this.txtMatKhau.Text = "444";
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtDanhNhap
            // 
            this.txtDanhNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDanhNhap.Location = new System.Drawing.Point(52, 191);
            this.txtDanhNhap.Name = "txtDanhNhap";
            this.txtDanhNhap.Size = new System.Drawing.Size(252, 22);
            this.txtDanhNhap.TabIndex = 18;
            this.txtDanhNhap.Text = "TPKT";
            this.txtDanhNhap.TextChanged += new System.EventHandler(this.txtDanhNhap_TextChanged);
            // 
            // txtMK
            // 
            this.txtMK.AutoSize = true;
            this.txtMK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMK.Location = new System.Drawing.Point(50, 231);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(83, 21);
            this.txtMK.TabIndex = 17;
            this.txtMK.Text = "Mật Khẩu";
            this.txtMK.Click += new System.EventHandler(this.txtMK_Click);
            // 
            // txtTK
            // 
            this.txtTK.AutoSize = true;
            this.txtTK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTK.Location = new System.Drawing.Point(50, 162);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(88, 21);
            this.txtTK.TabIndex = 16;
            this.txtTK.Text = "Tài Khoản";
            this.txtTK.Click += new System.EventHandler(this.txtTK_Click);
            // 
            // txtQLNS
            // 
            this.txtQLNS.AutoSize = true;
            this.txtQLNS.BackColor = System.Drawing.Color.White;
            this.txtQLNS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQLNS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtQLNS.Location = new System.Drawing.Point(100, 120);
            this.txtQLNS.Name = "txtQLNS";
            this.txtQLNS.Size = new System.Drawing.Size(158, 19);
            this.txtQLNS.TabIndex = 15;
            this.txtQLNS.Text = "Thông tin đăng nhập";
            this.txtQLNS.Click += new System.EventHandler(this.txtQLNS_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 492);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.txtTK);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.txtDanhNhap);
            this.panel2.Controls.Add(this.txtQLNS);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.btnDN);
            this.panel2.Controls.Add(this.txtMK);
            this.panel2.Location = new System.Drawing.Point(445, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 492);
            this.panel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 498);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtDanhNhap;
        private System.Windows.Forms.Label txtMK;
        private System.Windows.Forms.Label txtTK;
        private System.Windows.Forms.Label txtQLNS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}