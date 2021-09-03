
namespace QuanLyNhanSu
{
    partial class frmHopDong
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
            this.btnTV = new DevComponents.DotNetBar.ButtonX();
            this.dateKT = new System.Windows.Forms.DateTimePicker();
            this.dateBD = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenHD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbnThem = new DevComponents.DotNetBar.ButtonX();
            this.tbnSua = new DevComponents.DotNetBar.ButtonX();
            this.tbnGiaHan = new DevComponents.DotNetBar.ButtonX();
            this.tbnThoat = new DevComponents.DotNetBar.ButtonX();
            this.tbnXoa = new DevComponents.DotNetBar.ButtonX();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTV
            // 
            this.btnTV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTV.Location = new System.Drawing.Point(29, 499);
            this.btnTV.Margin = new System.Windows.Forms.Padding(4);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(100, 28);
            this.btnTV.TabIndex = 64;
            this.btnTV.Text = "Thoát Tác vụ";
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // dateKT
            // 
            this.dateKT.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateKT.CustomFormat = "dd/MM/yyyy";
            this.dateKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKT.Location = new System.Drawing.Point(157, 202);
            this.dateKT.Margin = new System.Windows.Forms.Padding(4);
            this.dateKT.Name = "dateKT";
            this.dateKT.Size = new System.Drawing.Size(132, 22);
            this.dateKT.TabIndex = 63;
            // 
            // dateBD
            // 
            this.dateBD.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateBD.CustomFormat = "dd/MM/yyyy";
            this.dateBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBD.Location = new System.Drawing.Point(157, 169);
            this.dateBD.Margin = new System.Windows.Forms.Padding(4);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(132, 22);
            this.dateBD.TabIndex = 62;
            // 
            // txtMaHD
            // 
            // 
            // 
            // 
            this.txtMaHD.Border.Class = "TextBoxBorder";
            this.txtMaHD.Location = new System.Drawing.Point(157, 277);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(133, 22);
            this.txtMaHD.TabIndex = 61;
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(29, 274);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(100, 28);
            this.labelX7.TabIndex = 60;
            this.labelX7.Text = "Mã Hợp Đồng";
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.Class = "TextBoxBorder";
            this.txtMaNV.Location = new System.Drawing.Point(157, 242);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(133, 22);
            this.txtMaNV.TabIndex = 59;
            // 
            // txtTenNV
            // 
            // 
            // 
            // 
            this.txtTenNV.Border.Class = "TextBoxBorder";
            this.txtTenNV.Location = new System.Drawing.Point(157, 135);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(133, 22);
            this.txtTenNV.TabIndex = 58;
            // 
            // txtTenHD
            // 
            // 
            // 
            // 
            this.txtTenHD.Border.Class = "TextBoxBorder";
            this.txtTenHD.Location = new System.Drawing.Point(157, 94);
            this.txtTenHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(133, 22);
            this.txtTenHD.TabIndex = 57;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(29, 238);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(100, 28);
            this.labelX6.TabIndex = 56;
            this.labelX6.Text = "Mã Nhân Viên";
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(29, 202);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(100, 28);
            this.labelX5.TabIndex = 55;
            this.labelX5.Text = "Ngày Kết Thúc";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(29, 167);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 28);
            this.labelX4.TabIndex = 54;
            this.labelX4.Text = "Ngày Bắt Đầu";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(29, 131);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(100, 28);
            this.labelX3.TabIndex = 53;
            this.labelX3.Text = "Tên Nhân Viên";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(29, 92);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 28);
            this.labelX2.TabIndex = 52;
            this.labelX2.Text = "Tên Hợp Đồng";
            // 
            // tbnThem
            // 
            this.tbnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbnThem.Location = new System.Drawing.Point(29, 389);
            this.tbnThem.Margin = new System.Windows.Forms.Padding(4);
            this.tbnThem.Name = "tbnThem";
            this.tbnThem.Size = new System.Drawing.Size(100, 28);
            this.tbnThem.TabIndex = 51;
            this.tbnThem.Text = "Thêm";
            // 
            // tbnSua
            // 
            this.tbnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbnSua.Location = new System.Drawing.Point(190, 389);
            this.tbnSua.Margin = new System.Windows.Forms.Padding(4);
            this.tbnSua.Name = "tbnSua";
            this.tbnSua.Size = new System.Drawing.Size(100, 28);
            this.tbnSua.TabIndex = 50;
            this.tbnSua.Text = "Sửa";
            // 
            // tbnGiaHan
            // 
            this.tbnGiaHan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbnGiaHan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbnGiaHan.Location = new System.Drawing.Point(190, 445);
            this.tbnGiaHan.Margin = new System.Windows.Forms.Padding(4);
            this.tbnGiaHan.Name = "tbnGiaHan";
            this.tbnGiaHan.Size = new System.Drawing.Size(100, 28);
            this.tbnGiaHan.TabIndex = 49;
            this.tbnGiaHan.Text = "Gia hạn";
            // 
            // tbnThoat
            // 
            this.tbnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbnThoat.Location = new System.Drawing.Point(190, 499);
            this.tbnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.tbnThoat.Name = "tbnThoat";
            this.tbnThoat.Size = new System.Drawing.Size(100, 28);
            this.tbnThoat.TabIndex = 48;
            this.tbnThoat.Text = "Thoát";
            // 
            // tbnXoa
            // 
            this.tbnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbnXoa.Location = new System.Drawing.Point(29, 445);
            this.tbnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.tbnXoa.Name = "tbnXoa";
            this.tbnXoa.Size = new System.Drawing.Size(100, 28);
            this.tbnXoa.TabIndex = 47;
            this.tbnXoa.Text = "Xóa";
            this.tbnXoa.Click += new System.EventHandler(this.tbnXoa_Click);
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienThi.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Location = new System.Drawing.Point(357, 94);
            this.dgvHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.RowHeadersWidth = 51;
            this.dgvHienThi.Size = new System.Drawing.Size(873, 441);
            this.dgvHienThi.TabIndex = 46;
            this.dgvHienThi.SelectionChanged += new System.EventHandler(this.dgvHienThi_SelectionChanged);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(380, 19);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(468, 28);
            this.labelX1.TabIndex = 45;
            this.labelX1.Text = "HỢP ĐỒNG LÀM VIỆC CỦA NHÂN VIÊN";
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 555);
            this.Controls.Add(this.btnTV);
            this.Controls.Add(this.dateKT);
            this.Controls.Add(this.dateBD);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtTenHD);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tbnThem);
            this.Controls.Add(this.tbnSua);
            this.Controls.Add(this.tbnGiaHan);
            this.Controls.Add(this.tbnThoat);
            this.Controls.Add(this.tbnXoa);
            this.Controls.Add(this.dgvHienThi);
            this.Controls.Add(this.labelX1);
            this.Name = "frmHopDong";
            this.Text = "Hợp đồng";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnTV;
        private System.Windows.Forms.DateTimePicker dateKT;
        private System.Windows.Forms.DateTimePicker dateBD;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHD;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenHD;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX tbnThem;
        private DevComponents.DotNetBar.ButtonX tbnSua;
        private DevComponents.DotNetBar.ButtonX tbnGiaHan;
        private DevComponents.DotNetBar.ButtonX tbnThoat;
        private DevComponents.DotNetBar.ButtonX tbnXoa;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}