using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmNhanVien : Form
    {
        private GroupBox groupbox;
        private DataGridView dgvNhanVien;
        private BackgroundWorker backgroundWorker1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private ToolStripMenuItem xóaNhânViênToolStripMenuItem;
        private ToolStripMenuItem sửaThôngTinNhânViênToolStripMenuItem;
        private ToolStripMenuItem HSNVToolStripMenuItem;
        private ToolStripMenuItem hiểnThịDanhSáchNhânViênToolStripMenuItem;
        private DevComponents.DotNetBar.LabelX labTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDT;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTG;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSDT;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPB;
        private DateTimePicker dateNS;
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
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnHienThi;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSuaPB;
        private Panel panel1;
        private ToolStripMenuItem toolStripMenuItem4;

        public frmNhanVien()
        {
            InitializeComponent();
            this.dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.labTimKiem = new DevComponents.DotNetBar.LabelX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnHienThi = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaPB = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupbox.Controls.Add(this.dgvNhanVien);
            this.groupbox.Location = new System.Drawing.Point(38, 90);
            this.groupbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox.Name = "groupbox";
            this.groupbox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox.Size = new System.Drawing.Size(877, 601);
            this.groupbox.TabIndex = 86;
            this.groupbox.TabStop = false;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 19);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.Size = new System.Drawing.Size(871, 578);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            this.dgvNhanVien.SelectionChanged += new System.EventHandler(this.dgvNhanVien_SelectionChanged);
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(546, 32);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(156, 20);
            this.labelX1.TabIndex = 87;
            this.labelX1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1302, 28);
            this.menuStrip1.TabIndex = 88;
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
            this.chứcNăngToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.contract2_pencil;
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.list_add_user3;
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Thêm nhân viên";
            // 
            // xóaNhânViênToolStripMenuItem
            // 
            this.xóaNhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xóaNhânViênToolStripMenuItem.Image")));
            this.xóaNhânViênToolStripMenuItem.Name = "xóaNhânViênToolStripMenuItem";
            this.xóaNhânViênToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.xóaNhânViênToolStripMenuItem.Text = "Xóa nhân viên";
            // 
            // sửaThôngTinNhânViênToolStripMenuItem
            // 
            this.sửaThôngTinNhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sửaThôngTinNhânViênToolStripMenuItem.Image")));
            this.sửaThôngTinNhânViênToolStripMenuItem.Name = "sửaThôngTinNhânViênToolStripMenuItem";
            this.sửaThôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.sửaThôngTinNhânViênToolStripMenuItem.Text = "Sửa thông tin nhân viên";
            // 
            // HSNVToolStripMenuItem
            // 
            this.HSNVToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.preferences_contact_list__1_;
            this.HSNVToolStripMenuItem.Name = "HSNVToolStripMenuItem";
            this.HSNVToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.HSNVToolStripMenuItem.Text = "Hồ sơ nhân viên";
            // 
            // hiểnThịDanhSáchNhânViênToolStripMenuItem
            // 
            this.hiểnThịDanhSáchNhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hiểnThịDanhSáchNhânViênToolStripMenuItem.Image")));
            this.hiểnThịDanhSáchNhânViênToolStripMenuItem.Name = "hiểnThịDanhSáchNhânViênToolStripMenuItem";
            this.hiểnThịDanhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.hiểnThịDanhSáchNhânViênToolStripMenuItem.Text = "Hiển thị danh sách nhân viên";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 24);
            this.toolStripMenuItem1.Text = " ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(27, 24);
            this.toolStripMenuItem2.Text = " ";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(27, 24);
            this.toolStripMenuItem3.Text = " ";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(27, 24);
            this.toolStripMenuItem4.Text = " ";
            // 
            // labTimKiem
            // 
            this.labTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimKiem.Location = new System.Drawing.Point(41, 55);
            this.labTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.labTimKiem.Name = "labTimKiem";
            this.labTimKiem.Size = new System.Drawing.Size(81, 26);
            this.labTimKiem.TabIndex = 89;
            this.labTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Location = new System.Drawing.Point(141, 59);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(303, 22);
            this.txtTimKiem.TabIndex = 90;
            // 
            // txtDT
            // 
            // 
            // 
            // 
            this.txtDT.Border.Class = "TextBoxBorder";
            this.txtDT.Location = new System.Drawing.Point(138, 427);
            this.txtDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(200, 22);
            this.txtDT.TabIndex = 142;
            // 
            // labelX10
            // 
            this.labelX10.Location = new System.Drawing.Point(17, 423);
            this.labelX10.Margin = new System.Windows.Forms.Padding(2);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(72, 27);
            this.labelX10.TabIndex = 141;
            this.labelX10.Text = "Dân tộc";
            // 
            // txtTG
            // 
            // 
            // 
            // 
            this.txtTG.Border.Class = "TextBoxBorder";
            this.txtTG.Location = new System.Drawing.Point(136, 469);
            this.txtTG.Margin = new System.Windows.Forms.Padding(2);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(200, 22);
            this.txtTG.TabIndex = 140;
            // 
            // labelX11
            // 
            this.labelX11.Location = new System.Drawing.Point(19, 469);
            this.labelX11.Margin = new System.Windows.Forms.Padding(2);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(76, 18);
            this.labelX11.TabIndex = 139;
            this.labelX11.Text = "Tôn giáo";
            // 
            // txtSDT
            // 
            // 
            // 
            // 
            this.txtSDT.Border.Class = "TextBoxBorder";
            this.txtSDT.Location = new System.Drawing.Point(138, 381);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(200, 22);
            this.txtSDT.TabIndex = 138;
            // 
            // labelX12
            // 
            this.labelX12.Location = new System.Drawing.Point(19, 380);
            this.labelX12.Margin = new System.Windows.Forms.Padding(2);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(76, 21);
            this.labelX12.TabIndex = 137;
            this.labelX12.Text = "SĐT";
            // 
            // txtMaPB
            // 
            // 
            // 
            // 
            this.txtMaPB.Border.Class = "TextBoxBorder";
            this.txtMaPB.Location = new System.Drawing.Point(136, 291);
            this.txtMaPB.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(199, 22);
            this.txtMaPB.TabIndex = 136;
            // 
            // dateNS
            // 
            this.dateNS.Location = new System.Drawing.Point(138, 195);
            this.dateNS.Margin = new System.Windows.Forms.Padding(2);
            this.dateNS.Name = "dateNS";
            this.dateNS.Size = new System.Drawing.Size(199, 22);
            this.dateNS.TabIndex = 135;
            // 
            // labelX13
            // 
            this.labelX13.Location = new System.Drawing.Point(17, 43);
            this.labelX13.Margin = new System.Windows.Forms.Padding(2);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(99, 18);
            this.labelX13.TabIndex = 121;
            this.labelX13.Text = "Mã nhân viên";
            // 
            // labelX14
            // 
            this.labelX14.Location = new System.Drawing.Point(17, 287);
            this.labelX14.Margin = new System.Windows.Forms.Padding(2);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(89, 26);
            this.labelX14.TabIndex = 134;
            this.labelX14.Text = "Mã Phòng Ban";
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.Class = "TextBoxBorder";
            this.txtMaNV.Location = new System.Drawing.Point(137, 43);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 22);
            this.txtMaNV.TabIndex = 122;
            // 
            // labelX15
            // 
            this.labelX15.Location = new System.Drawing.Point(19, 160);
            this.labelX15.Margin = new System.Windows.Forms.Padding(2);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(76, 18);
            this.labelX15.TabIndex = 133;
            this.labelX15.Text = "Giới Tính";
            // 
            // labelX16
            // 
            this.labelX16.Location = new System.Drawing.Point(17, 83);
            this.labelX16.Margin = new System.Windows.Forms.Padding(2);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(99, 18);
            this.labelX16.TabIndex = 123;
            this.labelX16.Text = "Tên nhân viên";
            // 
            // txtTenNV
            // 
            // 
            // 
            // 
            this.txtTenNV.Border.Class = "TextBoxBorder";
            this.txtTenNV.Location = new System.Drawing.Point(137, 83);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(200, 22);
            this.txtTenNV.TabIndex = 124;
            // 
            // labelX17
            // 
            this.labelX17.Location = new System.Drawing.Point(17, 120);
            this.labelX17.Margin = new System.Windows.Forms.Padding(2);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(76, 18);
            this.labelX17.TabIndex = 125;
            this.labelX17.Text = "Bằng cấp";
            // 
            // txtCMT
            // 
            // 
            // 
            // 
            this.txtCMT.Border.Class = "TextBoxBorder";
            this.txtCMT.Location = new System.Drawing.Point(137, 337);
            this.txtCMT.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(199, 22);
            this.txtCMT.TabIndex = 132;
            // 
            // txtBangCap
            // 
            // 
            // 
            // 
            this.txtBangCap.Border.Class = "TextBoxBorder";
            this.txtBangCap.Location = new System.Drawing.Point(137, 120);
            this.txtBangCap.Margin = new System.Windows.Forms.Padding(2);
            this.txtBangCap.Name = "txtBangCap";
            this.txtBangCap.Size = new System.Drawing.Size(200, 22);
            this.txtBangCap.TabIndex = 126;
            // 
            // labelX18
            // 
            this.labelX18.Location = new System.Drawing.Point(19, 337);
            this.labelX18.Margin = new System.Windows.Forms.Padding(2);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(65, 18);
            this.labelX18.TabIndex = 131;
            this.labelX18.Text = "CMTND";
            // 
            // labelX19
            // 
            this.labelX19.Location = new System.Drawing.Point(17, 196);
            this.labelX19.Margin = new System.Windows.Forms.Padding(2);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(89, 18);
            this.labelX19.TabIndex = 127;
            this.labelX19.Text = "Ngày Sinh";
            // 
            // txtDC
            // 
            // 
            // 
            // 
            this.txtDC.Border.Class = "TextBoxBorder";
            this.txtDC.Location = new System.Drawing.Point(136, 244);
            this.txtDC.Margin = new System.Windows.Forms.Padding(2);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(200, 22);
            this.txtDC.TabIndex = 130;
            // 
            // txtGT
            // 
            // 
            // 
            // 
            this.txtGT.Border.Class = "TextBoxBorder";
            this.txtGT.Location = new System.Drawing.Point(139, 156);
            this.txtGT.Margin = new System.Windows.Forms.Padding(2);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(200, 22);
            this.txtGT.TabIndex = 128;
            // 
            // labelX20
            // 
            this.labelX20.Location = new System.Drawing.Point(17, 244);
            this.labelX20.Margin = new System.Windows.Forms.Padding(2);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(76, 18);
            this.labelX20.TabIndex = 129;
            this.labelX20.Text = "Địa chỉ";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(234, 539);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 34);
            this.btnThoat.TabIndex = 120;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienThi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHienThi.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThi.Image")));
            this.btnHienThi.Location = new System.Drawing.Point(119, 539);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(91, 34);
            this.btnHienThi.TabIndex = 119;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(234, 501);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 34);
            this.btnXoa.TabIndex = 118;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaPB
            // 
            this.btnSuaPB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaPB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaPB.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaPB.Image")));
            this.btnSuaPB.Location = new System.Drawing.Point(119, 501);
            this.btnSuaPB.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPB.Name = "btnSuaPB";
            this.btnSuaPB.Size = new System.Drawing.Size(91, 34);
            this.btnSuaPB.TabIndex = 117;
            this.btnSuaPB.Text = "Sửa";
            this.btnSuaPB.Click += new System.EventHandler(this.btnSuaPB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnHienThi);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnSuaPB);
            this.panel1.Controls.Add(this.labelX11);
            this.panel1.Controls.Add(this.labelX10);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtDT);
            this.panel1.Controls.Add(this.txtTG);
            this.panel1.Controls.Add(this.labelX12);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.labelX18);
            this.panel1.Controls.Add(this.labelX14);
            this.panel1.Controls.Add(this.labelX13);
            this.panel1.Controls.Add(this.labelX16);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.labelX17);
            this.panel1.Controls.Add(this.txtBangCap);
            this.panel1.Controls.Add(this.txtMaPB);
            this.panel1.Controls.Add(this.txtCMT);
            this.panel1.Controls.Add(this.labelX15);
            this.panel1.Controls.Add(this.dateNS);
            this.panel1.Controls.Add(this.txtGT);
            this.panel1.Controls.Add(this.labelX19);
            this.panel1.Controls.Add(this.labelX20);
            this.panel1.Controls.Add(this.txtDC);
            this.panel1.Location = new System.Drawing.Point(917, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 597);
            this.panel1.TabIndex = 91;
            // 
            // frmNhanVien
            // 
            this.ClientSize = new System.Drawing.Size(1302, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "frmNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = ConnectDatabase.getAllNhanVien();
        }
        public void load()

        {
            this.dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.DataSource = ConnectDatabase.getAllNhanVien();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVien temp = new NhanVien(txtMaNV.Text, txtTenNV.Text, txtBangCap.Text, txtGT.Text, dateNS.Value, txtDC.Text, txtMaPB.Text, txtCMT.Text, txtSDT.Text, txtDT.Text, txtTG.Text);
            ConnectDatabase.XoaNhanVien(temp);
            dgvNhanVien.DataSource = ConnectDatabase.getAllNhanVien();
            MessageBox.Show("Xóa nhân viên thành công!!");
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = ConnectDatabase.getAllNhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView table = sender as DataGridView;
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtBangCap.Text = row.Cells[2].Value.ToString();
                txtGT.Text = row.Cells[3].Value.ToString();
                dateNS.Value = row.Cells[4].Value == null ? DateTime.Now : (DateTime)row.Cells[4].Value;
                txtDC.Text = row.Cells[5].Value.ToString();
                txtMaPB.Text = row.Cells[6].Value.ToString();
                txtCMT.Text = row.Cells[7].Value.ToString();
                txtSDT.Text = row.Cells[8].Value.ToString();
                txtDT.Text = row.Cells[9].Value.ToString();
                txtTG.Text = row.Cells[10].Value.ToString();



            }
        }
        public void reset()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtBangCap.Text = "";
            txtGT.Text = "";
            dateNS.Text = "";
            txtDC.Text = "";
            txtMaPB.Text = "";
            txtCMT.Text = "";
            txtSDT.Text = "";
            txtDT.Text = "";
            txtTG.Text = "";
        }
        private void btnSuaPB_Click(object sender, EventArgs e)
        {
            NhanVien temp = new NhanVien(txtMaNV.Text, txtTenNV.Text, txtBangCap.Text, txtGT.Text, dateNS.Value, txtDC.Text, txtMaPB.Text, txtSDT.Text, txtCMT.Text, txtDT.Text, txtTG.Text);
            ConnectDatabase.SuaNhanVien(temp);
            dgvNhanVien.DataSource = ConnectDatabase.getAllNhanVien();
            MessageBox.Show("Sửa nhân viên thành công!!");
            reset();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtBangCap.Text = row.Cells[2].Value.ToString();
            txtGT.Text = row.Cells[3].Value.ToString();
            dateNS.Text = row.Cells[4].Value.ToString();
            txtDC.Text = row.Cells[5].Value.ToString();
            txtMaPB.Text = row.Cells[6].Value.ToString();
            txtCMT.Text = row.Cells[7].Value.ToString();
            txtSDT.Text = row.Cells[8].Value.ToString();
            txtDT.Text = row.Cells[9].Value.ToString();
            txtTG.Text = row.Cells[9].Value.ToString();
            txtMaNV.Enabled = false;
        }
    }
}
