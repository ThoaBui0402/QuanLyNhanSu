namespace QuanLiNhanSu
{
    partial class frmNhanVien
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
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HSNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịDanhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnHienThi = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaPB = new DevComponents.DotNetBar.ButtonX();
            this.labTimKiem = new DevComponents.DotNetBar.LabelX();
            this.txtDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtTG = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.txtSDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtMaPB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateNS = new System.Windows.Forms.DateTimePicker();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.txtTenNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.txtCMT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBangCap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.txtDC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupbox.Controls.Add(this.dgvNhanVien);
            this.groupbox.Location = new System.Drawing.Point(38, 83);
            this.groupbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox.Name = "groupbox";
            this.groupbox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox.Size = new System.Drawing.Size(600, 357);
            this.groupbox.TabIndex = 0;
            this.groupbox.TabStop = false;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 10);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(589, 339);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.SelectionChanged += new System.EventHandler(this.dgvNhanVien_SelectionChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(424, 22);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(234, 20);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "DANH SÁCH NHÂN VIÊN";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNhânViênToolStripMenuItem,
            this.xóaNhânViênToolStripMenuItem,
            this.sửaThôngTinNhânViênToolStripMenuItem,
            this.HSNVToolStripMenuItem,
            this.hiểnThịDanhSáchNhânViênToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Image = global::QuanLiNhanSu.Properties.Resources.mail_new1;
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Image = global::QuanLiNhanSu.Properties.Resources.contact_new;
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Thêm nhân viên";
            this.danhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // xóaNhânViênToolStripMenuItem
            // 
            this.xóaNhânViênToolStripMenuItem.Image = global::QuanLiNhanSu.Properties.Resources.gnome_edit_delete__1_;
            this.xóaNhânViênToolStripMenuItem.Name = "xóaNhânViênToolStripMenuItem";
            this.xóaNhânViênToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.xóaNhânViênToolStripMenuItem.Text = "Xóa nhân viên";
            // 
            // sửaThôngTinNhânViênToolStripMenuItem
            // 
            this.sửaThôngTinNhânViênToolStripMenuItem.Image = global::QuanLiNhanSu.Properties.Resources.modify;
            this.sửaThôngTinNhânViênToolStripMenuItem.Name = "sửaThôngTinNhânViênToolStripMenuItem";
            this.sửaThôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.sửaThôngTinNhânViênToolStripMenuItem.Text = "Sửa thông tin nhân viên";
            this.sửaThôngTinNhânViênToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinNhânViênToolStripMenuItem_Click);
            // 
            // HSNVToolStripMenuItem
            // 
            this.HSNVToolStripMenuItem.Image = global::QuanLiNhanSu.Properties.Resources.text_directory1;
            this.HSNVToolStripMenuItem.Name = "HSNVToolStripMenuItem";
            this.HSNVToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.HSNVToolStripMenuItem.Text = "Hồ sơ nhân viên";
            this.HSNVToolStripMenuItem.Click += new System.EventHandler(this.HSNVToolStripMenuItem_Click);
            // 
            // hiểnThịDanhSáchNhânViênToolStripMenuItem
            // 
            this.hiểnThịDanhSáchNhânViênToolStripMenuItem.Image = global::QuanLiNhanSu.Properties.Resources.list_all_participants;
            this.hiểnThịDanhSáchNhânViênToolStripMenuItem.Name = "hiểnThịDanhSáchNhânViênToolStripMenuItem";
            this.hiểnThịDanhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.hiểnThịDanhSáchNhânViênToolStripMenuItem.Text = "Hiển thị danh sách nhân viên";
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimKiem.Location = new System.Drawing.Point(177, 48);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(303, 22);
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Image = global::QuanLiNhanSu.Properties.Resources.exit1;
            this.btnThoat.Location = new System.Drawing.Point(822, 409);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 34);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 63;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienThi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHienThi.Image = global::QuanLiNhanSu.Properties.Resources.show_property;
            this.btnHienThi.Location = new System.Drawing.Point(736, 409);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(72, 34);
            this.btnHienThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHienThi.TabIndex = 62;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = global::QuanLiNhanSu.Properties.Resources.user_female_remove1;
            this.btnXoa.Location = new System.Drawing.Point(822, 371);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 34);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 61;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaPB
            // 
            this.btnSuaPB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaPB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaPB.Image = global::QuanLiNhanSu.Properties.Resources.settings2;
            this.btnSuaPB.Location = new System.Drawing.Point(736, 371);
            this.btnSuaPB.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPB.Name = "btnSuaPB";
            this.btnSuaPB.Size = new System.Drawing.Size(72, 34);
            this.btnSuaPB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaPB.TabIndex = 60;
            this.btnSuaPB.Text = "Sửa";
            this.btnSuaPB.Click += new System.EventHandler(this.btnSuaPB_Click);
            // 
            // labTimKiem
            // 
            // 
            // 
            // 
            this.labTimKiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimKiem.Image = global::QuanLiNhanSu.Properties.Resources.kappfinder2;
            this.labTimKiem.Location = new System.Drawing.Point(42, 48);
            this.labTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.labTimKiem.Name = "labTimKiem";
            this.labTimKiem.Size = new System.Drawing.Size(107, 26);
            this.labTimKiem.TabIndex = 7;
            this.labTimKiem.Text = "Tìm kiếm";
            // 
            // txtDT
            // 
            // 
            // 
            // 
            this.txtDT.Border.Class = "TextBoxBorder";
            this.txtDT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDT.Location = new System.Drawing.Point(734, 317);
            this.txtDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(200, 22);
            this.txtDT.TabIndex = 85;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(653, 313);
            this.labelX10.Margin = new System.Windows.Forms.Padding(2);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(72, 27);
            this.labelX10.TabIndex = 84;
            this.labelX10.Text = "Dân tộc";
            // 
            // txtTG
            // 
            // 
            // 
            // 
            this.txtTG.Border.Class = "TextBoxBorder";
            this.txtTG.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTG.Location = new System.Drawing.Point(734, 345);
            this.txtTG.Margin = new System.Windows.Forms.Padding(2);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(200, 22);
            this.txtTG.TabIndex = 83;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(654, 344);
            this.labelX11.Margin = new System.Windows.Forms.Padding(2);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(76, 18);
            this.labelX11.TabIndex = 82;
            this.labelX11.Text = "Tôn giáo";
            // 
            // txtSDT
            // 
            // 
            // 
            // 
            this.txtSDT.Border.Class = "TextBoxBorder";
            this.txtSDT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSDT.Location = new System.Drawing.Point(734, 287);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(200, 22);
            this.txtSDT.TabIndex = 81;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(653, 287);
            this.labelX12.Margin = new System.Windows.Forms.Padding(2);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(76, 21);
            this.labelX12.TabIndex = 80;
            this.labelX12.Text = "SĐT";
            // 
            // txtMaPB
            // 
            // 
            // 
            // 
            this.txtMaPB.Border.Class = "TextBoxBorder";
            this.txtMaPB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaPB.Location = new System.Drawing.Point(735, 237);
            this.txtMaPB.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(199, 22);
            this.txtMaPB.TabIndex = 79;
            // 
            // dateNS
            // 
            this.dateNS.Location = new System.Drawing.Point(736, 182);
            this.dateNS.Margin = new System.Windows.Forms.Padding(2);
            this.dateNS.Name = "dateNS";
            this.dateNS.Size = new System.Drawing.Size(199, 22);
            this.dateNS.TabIndex = 78;
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(643, 78);
            this.labelX13.Margin = new System.Windows.Forms.Padding(2);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(76, 18);
            this.labelX13.TabIndex = 64;
            this.labelX13.Text = "Mã nhân viên";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(653, 231);
            this.labelX14.Margin = new System.Windows.Forms.Padding(2);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(76, 26);
            this.labelX14.TabIndex = 77;
            this.labelX14.Text = "Mã Phòng Ban";
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.Class = "TextBoxBorder";
            this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNV.Location = new System.Drawing.Point(734, 83);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 22);
            this.txtMaNV.TabIndex = 65;
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(649, 155);
            this.labelX15.Margin = new System.Windows.Forms.Padding(2);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(76, 18);
            this.labelX15.TabIndex = 76;
            this.labelX15.Text = "Giới Tính";
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(648, 106);
            this.labelX16.Margin = new System.Windows.Forms.Padding(2);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(76, 18);
            this.labelX16.TabIndex = 66;
            this.labelX16.Text = "Tên nhân viên";
            // 
            // txtTenNV
            // 
            // 
            // 
            // 
            this.txtTenNV.Border.Class = "TextBoxBorder";
            this.txtTenNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenNV.Location = new System.Drawing.Point(734, 108);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(200, 22);
            this.txtTenNV.TabIndex = 67;
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(648, 132);
            this.labelX17.Margin = new System.Windows.Forms.Padding(2);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(76, 18);
            this.labelX17.TabIndex = 68;
            this.labelX17.Text = "Bằng cấp";
            // 
            // txtCMT
            // 
            // 
            // 
            // 
            this.txtCMT.Border.Class = "TextBoxBorder";
            this.txtCMT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCMT.Location = new System.Drawing.Point(735, 262);
            this.txtCMT.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(199, 22);
            this.txtCMT.TabIndex = 75;
            // 
            // txtBangCap
            // 
            // 
            // 
            // 
            this.txtBangCap.Border.Class = "TextBoxBorder";
            this.txtBangCap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBangCap.Location = new System.Drawing.Point(734, 132);
            this.txtBangCap.Margin = new System.Windows.Forms.Padding(2);
            this.txtBangCap.Name = "txtBangCap";
            this.txtBangCap.Size = new System.Drawing.Size(200, 22);
            this.txtBangCap.TabIndex = 69;
            // 
            // labelX18
            // 
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Location = new System.Drawing.Point(654, 264);
            this.labelX18.Margin = new System.Windows.Forms.Padding(2);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(65, 18);
            this.labelX18.TabIndex = 74;
            this.labelX18.Text = "CMTND";
            // 
            // labelX19
            // 
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Location = new System.Drawing.Point(649, 178);
            this.labelX19.Margin = new System.Windows.Forms.Padding(2);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(89, 18);
            this.labelX19.TabIndex = 70;
            this.labelX19.Text = "Ngày Sinh";
            // 
            // txtDC
            // 
            // 
            // 
            // 
            this.txtDC.Border.Class = "TextBoxBorder";
            this.txtDC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDC.Location = new System.Drawing.Point(734, 208);
            this.txtDC.Margin = new System.Windows.Forms.Padding(2);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(200, 22);
            this.txtDC.TabIndex = 73;
            // 
            // txtGT
            // 
            // 
            // 
            // 
            this.txtGT.Border.Class = "TextBoxBorder";
            this.txtGT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGT.Location = new System.Drawing.Point(734, 157);
            this.txtGT.Margin = new System.Windows.Forms.Padding(2);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(200, 22);
            this.txtGT.TabIndex = 71;
            // 
            // labelX20
            // 
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Location = new System.Drawing.Point(649, 208);
            this.labelX20.Margin = new System.Windows.Forms.Padding(2);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(76, 18);
            this.labelX20.TabIndex = 72;
            this.labelX20.Text = "Địa chỉ";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 456);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.txtTG);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.dateNS);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.labelX15);
            this.Controls.Add(this.labelX16);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.labelX17);
            this.Controls.Add(this.txtCMT);
            this.Controls.Add(this.txtBangCap);
            this.Controls.Add(this.labelX18);
            this.Controls.Add(this.labelX19);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.labelX20);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSuaPB);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.labTimKiem);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HSNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịDanhSáchNhânViênToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.LabelX labTimKiem;
        private DevComponents.DotNetBar.ButtonX btnSuaPB;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnHienThi;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDT;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTG;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSDT;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPB;
        private System.Windows.Forms.DateTimePicker dateNS;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNV;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNV;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCMT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBangCap;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDC;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGT;
        private DevComponents.DotNetBar.LabelX labelX20;
    }
}