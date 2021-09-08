namespace QuanLyNhanSu
{
    partial class frmThemPB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThemPB = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenTp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtmaTP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnThemPB = new DevComponents.DotNetBar.ButtonX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaPB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenPB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.bnt_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemPB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThemPB
            // 
            this.dgvThemPB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThemPB.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThemPB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThemPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThemPB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThemPB.EnableHeadersVisualStyles = false;
            this.dgvThemPB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvThemPB.Location = new System.Drawing.Point(22, 80);
            this.dgvThemPB.Name = "dgvThemPB";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThemPB.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThemPB.RowHeadersWidth = 51;
            this.dgvThemPB.Size = new System.Drawing.Size(670, 373);
            this.dgvThemPB.TabIndex = 22;
            this.dgvThemPB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThemPB_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.bnt_them);
            this.groupBox1.Controls.Add(this.txtTenTp);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.txtmaTP);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnThemPB);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtMaPB);
            this.groupBox1.Controls.Add(this.txtTenPB);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Location = new System.Drawing.Point(730, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 382);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // txtTenTp
            // 
            // 
            // 
            // 
            this.txtTenTp.Border.Class = "TextBoxBorder";
            this.txtTenTp.Location = new System.Drawing.Point(151, 157);
            this.txtTenTp.Name = "txtTenTp";
            this.txtTenTp.Size = new System.Drawing.Size(194, 29);
            this.txtTenTp.TabIndex = 38;
            this.txtTenTp.TextChanged += new System.EventHandler(this.txtTenTp_TextChanged);
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(22, 157);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(122, 30);
            this.labelX6.TabIndex = 37;
            this.labelX6.Text = "Tên trưởng phòng";
            // 
            // txtmaTP
            // 
            // 
            // 
            // 
            this.txtmaTP.Border.Class = "TextBoxBorder";
            this.txtmaTP.Location = new System.Drawing.Point(151, 124);
            this.txtmaTP.Name = "txtmaTP";
            this.txtmaTP.Size = new System.Drawing.Size(194, 29);
            this.txtmaTP.TabIndex = 36;
            this.txtmaTP.TextChanged += new System.EventHandler(this.txtmaTP_TextChanged);
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(22, 119);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(108, 30);
            this.labelX5.TabIndex = 35;
            this.labelX5.Text = "Mã trưởng phòng";
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(261, 214);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 33);
            this.btnHuy.TabIndex = 34;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(261, 339);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 25);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Trở lại";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThemPB
            // 
            this.btnThemPB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemPB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemPB.Location = new System.Drawing.Point(151, 214);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(0, 0);
            this.btnThemPB.TabIndex = 31;
            this.btnThemPB.Text = "Thêm";
  //          this.btnThemPB.Click += new System.EventHandler(this.btnThemPB_Click);
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Location = new System.Drawing.Point(151, 93);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(194, 29);
            this.txtDiaChi.TabIndex = 30;
            // 
            // txtMaPB
            // 
            // 
            // 
            // 
            this.txtMaPB.Border.Class = "TextBoxBorder";
            this.txtMaPB.Location = new System.Drawing.Point(151, 62);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(194, 29);
            this.txtMaPB.TabIndex = 29;
            // 
            // txtTenPB
            // 
            // 
            // 
            // 
            this.txtTenPB.Border.Class = "TextBoxBorder";
            this.txtTenPB.Location = new System.Drawing.Point(151, 31);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(194, 29);
            this.txtTenPB.TabIndex = 28;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(33, 93);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(50, 30);
            this.labelX4.TabIndex = 27;
            this.labelX4.Text = "Địa chỉ";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(22, 63);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(108, 30);
            this.labelX3.TabIndex = 26;
            this.labelX3.Text = "Mã phòng ban";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(16, 31);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(128, 30);
            this.labelX2.TabIndex = 25;
            this.labelX2.Text = "Tên phòng ban";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX1.Location = new System.Drawing.Point(360, 25);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(232, 39);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "THÊM PHÒNG BAN MỚI";
            // 
            // bnt_them
            // 
            this.bnt_them.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bnt_them.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bnt_them.Location = new System.Drawing.Point(151, 213);
            this.bnt_them.Name = "bnt_them";
            this.bnt_them.Size = new System.Drawing.Size(80, 34);
            this.bnt_them.TabIndex = 40;
            this.bnt_them.Text = "Thêm";
            this.bnt_them.UseVisualStyleBackColor = false;
            this.bnt_them.Click += new System.EventHandler(this.bnt_them_Click);
            // 
            // frmThemPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1152, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThemPB);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemPB";
            this.Text = "ThemPB";
            this.Load += new System.EventHandler(this.frmThemPB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemPB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvThemPB;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnThemPB;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPB;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenPB;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenTp;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmaTP;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.Button bnt_them;
    }
}