using ViKey.Properties;
namespace ViKey
{
    partial class ViKey
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViKey));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemBatHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBatCongCu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemBatKiemTraChinhTa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBatTinhNangGoTat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMoBangGoTat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxKieuGo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxBangMa = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemBangDieuKhien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemThoatChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabPageThongTin = new MetroFramework.Controls.MetroTabPage();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroTabPageCaiDatNangCao = new MetroFramework.Controls.MetroTabPage();
            this.checkBoxKhoidongcungwin = new System.Windows.Forms.CheckBox();
            this.checkBoxBatkhikhoidong = new System.Windows.Forms.CheckBox();
            this.checkBoxSudungsendkey = new System.Windows.Forms.CheckBox();
            this.checkBoxGotatkhitatTV = new System.Windows.Forms.CheckBox();
            this.checkBoxKiemtract = new System.Windows.Forms.CheckBox();
            this.checkBoxBodau = new System.Windows.Forms.CheckBox();
            this.checkBoxChophepgotat = new System.Windows.Forms.CheckBox();
            this.metroButtonBanggotat = new MetroFramework.Controls.MetroButton();
            this.metroButtonHuongdan = new MetroFramework.Controls.MetroButton();
            this.metroButtonThietlapmacdinh = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageDieuKhien = new MetroFramework.Controls.MetroTabPage();
            this.radioButtonALTZ = new System.Windows.Forms.RadioButton();
            this.radioButtonCTRLSHIFT = new System.Windows.Forms.RadioButton();
            this.comboBoxKieugo = new System.Windows.Forms.ComboBox();
            this.comboBoxBangma = new System.Windows.Forms.ComboBox();
            this.metroButtonExit = new MetroFramework.Controls.MetroButton();
            this.metroButtonTaskbar = new MetroFramework.Controls.MetroButton();
            this.metroLabelPhimChuyen = new MetroFramework.Controls.MetroLabel();
            this.metroLabelKieuGo = new MetroFramework.Controls.MetroLabel();
            this.metroLabelBangMa = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.contextMenuStrip1.SuspendLayout();
            this.metroTabPageThongTin.SuspendLayout();
            this.metroTabPageCaiDatNangCao.SuspendLayout();
            this.metroTabPageDieuKhien.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "ViKey đã được kích hoạt";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBatHuongDan,
            this.toolStripMenuItemBatCongCu,
            this.toolStripSeparator3,
            this.toolStripMenuItemBatKiemTraChinhTa,
            this.toolStripMenuItemBatTinhNangGoTat,
            this.toolStripMenuItemMoBangGoTat,
            this.toolStripSeparator2,
            this.toolStripComboBoxKieuGo,
            this.toolStripComboBoxBangMa,
            this.toolStripSeparator1,
            this.toolStripMenuItemBangDieuKhien,
            this.toolStripMenuItemThoatChuongTrinh});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(229, 230);
            this.contextMenuStrip1.Text = "Ê";
            // 
            // toolStripMenuItemBatHuongDan
            // 
            this.toolStripMenuItemBatHuongDan.Name = "toolStripMenuItemBatHuongDan";
            this.toolStripMenuItemBatHuongDan.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItemBatHuongDan.Text = "Hướng dẫn";
            this.toolStripMenuItemBatHuongDan.Click += new System.EventHandler(this.toolStripMenuItemBatHuongDan_Click);
            // 
            // toolStripMenuItemBatCongCu
            // 
            this.toolStripMenuItemBatCongCu.Name = "toolStripMenuItemBatCongCu";
            this.toolStripMenuItemBatCongCu.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItemBatCongCu.Text = "Công cụ";
            this.toolStripMenuItemBatCongCu.Click += new System.EventHandler(this.toolStripMenuItemBatCongCu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(225, 6);
            // 
            // toolStripMenuItemBatKiemTraChinhTa
            // 
            this.toolStripMenuItemBatKiemTraChinhTa.CheckOnClick = true;
            this.toolStripMenuItemBatKiemTraChinhTa.Name = "toolStripMenuItemBatKiemTraChinhTa";
            this.toolStripMenuItemBatKiemTraChinhTa.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItemBatKiemTraChinhTa.Text = "Bật kiểm tra chính tả";
            this.toolStripMenuItemBatKiemTraChinhTa.CheckedChanged += new System.EventHandler(this.toolStripMenuItemBatKiemTraChinhTa_CheckedChanged);
            // 
            // toolStripMenuItemBatTinhNangGoTat
            // 
            this.toolStripMenuItemBatTinhNangGoTat.CheckOnClick = true;
            this.toolStripMenuItemBatTinhNangGoTat.Name = "toolStripMenuItemBatTinhNangGoTat";
            this.toolStripMenuItemBatTinhNangGoTat.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItemBatTinhNangGoTat.Text = "Bật tính năng gõ tắt";
            this.toolStripMenuItemBatTinhNangGoTat.CheckedChanged += new System.EventHandler(this.toolStripMenuItemBatTinhNangGoTat_CheckedChanged);
            // 
            // toolStripMenuItemMoBangGoTat
            // 
            this.toolStripMenuItemMoBangGoTat.Name = "toolStripMenuItemMoBangGoTat";
            this.toolStripMenuItemMoBangGoTat.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItemMoBangGoTat.Text = "Bảng gõ tắt";
            this.toolStripMenuItemMoBangGoTat.Click += new System.EventHandler(this.toolStripMenuItemMoBangGoTat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(225, 6);
            // 
            // toolStripComboBoxKieuGo
            // 
            this.toolStripComboBoxKieuGo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxKieuGo.Items.AddRange(new object[] {
            "Telex",
            "VNI"});
            this.toolStripComboBoxKieuGo.Name = "toolStripComboBoxKieuGo";
            this.toolStripComboBoxKieuGo.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBoxKieuGo.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxKieuGo_SelectedIndexChanged);
            // 
            // toolStripComboBoxBangMa
            // 
            this.toolStripComboBoxBangMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxBangMa.Items.AddRange(new object[] {
            "Unicode",
            "TCVN3 (ABC)",
            "VNI Windows"});
            this.toolStripComboBoxBangMa.Name = "toolStripComboBoxBangMa";
            this.toolStripComboBoxBangMa.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBoxBangMa.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxBangMa_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // toolStripMenuItemBangDieuKhien
            // 
            this.toolStripMenuItemBangDieuKhien.Name = "toolStripMenuItemBangDieuKhien";
            this.toolStripMenuItemBangDieuKhien.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F5)));
            this.toolStripMenuItemBangDieuKhien.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItemBangDieuKhien.Text = "Bảng điều khiển";
            this.toolStripMenuItemBangDieuKhien.Click += new System.EventHandler(this.toolStripMenuItemBangDieuKhien_Click);
            // 
            // toolStripMenuItemThoatChuongTrinh
            // 
            this.toolStripMenuItemThoatChuongTrinh.Name = "toolStripMenuItemThoatChuongTrinh";
            this.toolStripMenuItemThoatChuongTrinh.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItemThoatChuongTrinh.Text = "Thoát chương trình";
            this.toolStripMenuItemThoatChuongTrinh.Click += new System.EventHandler(this.toolStripMenuItemThoatChuongTrinh_Click);
            // 
            // metroTabPageThongTin
            // 
            this.metroTabPageThongTin.Controls.Add(this.htmlLabel1);
            this.metroTabPageThongTin.HorizontalScrollbarBarColor = true;
            this.metroTabPageThongTin.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageThongTin.HorizontalScrollbarSize = 10;
            this.metroTabPageThongTin.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageThongTin.Name = "metroTabPageThongTin";
            this.metroTabPageThongTin.Size = new System.Drawing.Size(450, 177);
            this.metroTabPageThongTin.TabIndex = 2;
            this.metroTabPageThongTin.Text = "Thông tin";
            this.metroTabPageThongTin.VerticalScrollbarBarColor = true;
            this.metroTabPageThongTin.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageThongTin.VerticalScrollbarSize = 10;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(64, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(3, 3);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(444, 171);
            this.htmlLabel1.TabIndex = 2;
            this.htmlLabel1.Text = "htmlLabel1";
            // 
            // metroTabPageCaiDatNangCao
            // 
            this.metroTabPageCaiDatNangCao.Controls.Add(this.checkBoxKhoidongcungwin);
            this.metroTabPageCaiDatNangCao.Controls.Add(this.checkBoxBatkhikhoidong);
            this.metroTabPageCaiDatNangCao.Controls.Add(this.checkBoxSudungsendkey);
            this.metroTabPageCaiDatNangCao.Controls.Add(this.checkBoxGotatkhitatTV);
            this.metroTabPageCaiDatNangCao.Controls.Add(this.checkBoxKiemtract);
            this.metroTabPageCaiDatNangCao.Controls.Add(this.checkBoxBodau);
            this.metroTabPageCaiDatNangCao.Controls.Add(this.checkBoxChophepgotat);
            this.metroTabPageCaiDatNangCao.Controls.Add(this.metroButtonBanggotat);
            this.metroTabPageCaiDatNangCao.Controls.Add(this.metroButtonHuongdan);
            this.metroTabPageCaiDatNangCao.Controls.Add(this.metroButtonThietlapmacdinh);
            this.metroTabPageCaiDatNangCao.Controls.Add(this.metroLabel3);
            this.metroTabPageCaiDatNangCao.Controls.Add(this.metroLabel2);
            this.metroTabPageCaiDatNangCao.Controls.Add(this.metroLabel1);
            this.metroTabPageCaiDatNangCao.HorizontalScrollbarBarColor = true;
            this.metroTabPageCaiDatNangCao.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageCaiDatNangCao.HorizontalScrollbarSize = 10;
            this.metroTabPageCaiDatNangCao.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageCaiDatNangCao.Name = "metroTabPageCaiDatNangCao";
            this.metroTabPageCaiDatNangCao.Size = new System.Drawing.Size(450, 177);
            this.metroTabPageCaiDatNangCao.TabIndex = 1;
            this.metroTabPageCaiDatNangCao.Text = "Cài đặt nâng cao";
            this.metroTabPageCaiDatNangCao.VerticalScrollbarBarColor = true;
            this.metroTabPageCaiDatNangCao.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageCaiDatNangCao.VerticalScrollbarSize = 10;
            // 
            // checkBoxKhoidongcungwin
            // 
            this.checkBoxKhoidongcungwin.AutoSize = true;
            this.checkBoxKhoidongcungwin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxKhoidongcungwin.Location = new System.Drawing.Point(263, 53);
            this.checkBoxKhoidongcungwin.Name = "checkBoxKhoidongcungwin";
            this.checkBoxKhoidongcungwin.Size = new System.Drawing.Size(149, 17);
            this.checkBoxKhoidongcungwin.TabIndex = 2;
            this.checkBoxKhoidongcungwin.Text = "Khởi động cùng Windows";
            this.checkBoxKhoidongcungwin.UseVisualStyleBackColor = false;
            this.checkBoxKhoidongcungwin.CheckedChanged += new System.EventHandler(this.checkBoxKhoidongcungwin_CheckedChanged);
            // 
            // checkBoxBatkhikhoidong
            // 
            this.checkBoxBatkhikhoidong.AutoSize = true;
            this.checkBoxBatkhikhoidong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxBatkhikhoidong.Location = new System.Drawing.Point(263, 32);
            this.checkBoxBatkhikhoidong.Name = "checkBoxBatkhikhoidong";
            this.checkBoxBatkhikhoidong.Size = new System.Drawing.Size(173, 17);
            this.checkBoxBatkhikhoidong.TabIndex = 1;
            this.checkBoxBatkhikhoidong.Text = "Bật hội thoại này khi khởi động";
            this.checkBoxBatkhikhoidong.UseVisualStyleBackColor = false;
            // 
            // checkBoxSudungsendkey
            // 
            this.checkBoxSudungsendkey.AutoSize = true;
            this.checkBoxSudungsendkey.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxSudungsendkey.Location = new System.Drawing.Point(36, 75);
            this.checkBoxSudungsendkey.Name = "checkBoxSudungsendkey";
            this.checkBoxSudungsendkey.Size = new System.Drawing.Size(180, 17);
            this.checkBoxSudungsendkey.TabIndex = 3;
            this.checkBoxSudungsendkey.Text = "Sử dụng sendKey thay Clipboard";
            this.checkBoxSudungsendkey.UseVisualStyleBackColor = false;
            // 
            // checkBoxGotatkhitatTV
            // 
            this.checkBoxGotatkhitatTV.AutoSize = true;
            this.checkBoxGotatkhitatTV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxGotatkhitatTV.Location = new System.Drawing.Point(36, 138);
            this.checkBoxGotatkhitatTV.Name = "checkBoxGotatkhitatTV";
            this.checkBoxGotatkhitatTV.Size = new System.Drawing.Size(148, 17);
            this.checkBoxGotatkhitatTV.TabIndex = 5;
            this.checkBoxGotatkhitatTV.Text = "Gõ tắt cả khi tắt tiếng việt";
            this.checkBoxGotatkhitatTV.UseVisualStyleBackColor = false;
            // 
            // checkBoxKiemtract
            // 
            this.checkBoxKiemtract.AutoSize = true;
            this.checkBoxKiemtract.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxKiemtract.Location = new System.Drawing.Point(36, 54);
            this.checkBoxKiemtract.Name = "checkBoxKiemtract";
            this.checkBoxKiemtract.Size = new System.Drawing.Size(107, 17);
            this.checkBoxKiemtract.TabIndex = 2;
            this.checkBoxKiemtract.Text = "Kiểm tra chính tả";
            this.checkBoxKiemtract.UseVisualStyleBackColor = false;
            this.checkBoxKiemtract.CheckedChanged += new System.EventHandler(this.checkBoxKiemtract_CheckedChanged);
            // 
            // checkBoxBodau
            // 
            this.checkBoxBodau.AutoSize = true;
            this.checkBoxBodau.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxBodau.Location = new System.Drawing.Point(36, 33);
            this.checkBoxBodau.Name = "checkBoxBodau";
            this.checkBoxBodau.Size = new System.Drawing.Size(164, 17);
            this.checkBoxBodau.TabIndex = 1;
            this.checkBoxBodau.Text = "Bỏ dấu uỳ, oà (thay vì ùy, òa)";
            this.checkBoxBodau.UseVisualStyleBackColor = false;
            // 
            // checkBoxChophepgotat
            // 
            this.checkBoxChophepgotat.AutoSize = true;
            this.checkBoxChophepgotat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxChophepgotat.Location = new System.Drawing.Point(36, 117);
            this.checkBoxChophepgotat.Name = "checkBoxChophepgotat";
            this.checkBoxChophepgotat.Size = new System.Drawing.Size(102, 17);
            this.checkBoxChophepgotat.TabIndex = 4;
            this.checkBoxChophepgotat.Text = "Cho phép gõ tắt";
            this.checkBoxChophepgotat.UseVisualStyleBackColor = false;
            this.checkBoxChophepgotat.CheckedChanged += new System.EventHandler(this.checkBoxChophepgotat_CheckedChanged);
            // 
            // metroButtonBanggotat
            // 
            this.metroButtonBanggotat.Location = new System.Drawing.Point(299, 117);
            this.metroButtonBanggotat.Name = "metroButtonBanggotat";
            this.metroButtonBanggotat.Size = new System.Drawing.Size(121, 23);
            this.metroButtonBanggotat.TabIndex = 14;
            this.metroButtonBanggotat.Text = "Bảng gõ tắt";
            this.metroButtonBanggotat.UseSelectable = true;
            this.metroButtonBanggotat.Click += new System.EventHandler(this.metroButtonBanggotat_Click);
            // 
            // metroButtonHuongdan
            // 
            this.metroButtonHuongdan.Location = new System.Drawing.Point(299, 146);
            this.metroButtonHuongdan.Name = "metroButtonHuongdan";
            this.metroButtonHuongdan.Size = new System.Drawing.Size(121, 23);
            this.metroButtonHuongdan.TabIndex = 13;
            this.metroButtonHuongdan.Text = "Hướng dẫn";
            this.metroButtonHuongdan.UseSelectable = true;
            this.metroButtonHuongdan.Click += new System.EventHandler(this.metroButtonHuongdan_Click);
            // 
            // metroButtonThietlapmacdinh
            // 
            this.metroButtonThietlapmacdinh.Location = new System.Drawing.Point(299, 88);
            this.metroButtonThietlapmacdinh.Name = "metroButtonThietlapmacdinh";
            this.metroButtonThietlapmacdinh.Size = new System.Drawing.Size(121, 23);
            this.metroButtonThietlapmacdinh.TabIndex = 12;
            this.metroButtonThietlapmacdinh.Text = "Thiết lập mặc định";
            this.metroButtonThietlapmacdinh.UseSelectable = true;
            this.metroButtonThietlapmacdinh.Click += new System.EventHandler(this.metroButtonThietlapmacdinh_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(243, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Hệ thống";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Tùy chọn gõ tắt";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Xuất tiếng việt";
            // 
            // metroTabPageDieuKhien
            // 
            this.metroTabPageDieuKhien.Controls.Add(this.radioButtonALTZ);
            this.metroTabPageDieuKhien.Controls.Add(this.radioButtonCTRLSHIFT);
            this.metroTabPageDieuKhien.Controls.Add(this.comboBoxKieugo);
            this.metroTabPageDieuKhien.Controls.Add(this.comboBoxBangma);
            this.metroTabPageDieuKhien.Controls.Add(this.metroButtonExit);
            this.metroTabPageDieuKhien.Controls.Add(this.metroButtonTaskbar);
            this.metroTabPageDieuKhien.Controls.Add(this.metroLabelPhimChuyen);
            this.metroTabPageDieuKhien.Controls.Add(this.metroLabelKieuGo);
            this.metroTabPageDieuKhien.Controls.Add(this.metroLabelBangMa);
            this.metroTabPageDieuKhien.HorizontalScrollbarBarColor = true;
            this.metroTabPageDieuKhien.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageDieuKhien.HorizontalScrollbarSize = 10;
            this.metroTabPageDieuKhien.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageDieuKhien.Name = "metroTabPageDieuKhien";
            this.metroTabPageDieuKhien.Size = new System.Drawing.Size(450, 177);
            this.metroTabPageDieuKhien.TabIndex = 0;
            this.metroTabPageDieuKhien.Text = "Điều khiển";
            this.metroTabPageDieuKhien.VerticalScrollbarBarColor = true;
            this.metroTabPageDieuKhien.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageDieuKhien.VerticalScrollbarSize = 10;
            // 
            // radioButtonALTZ
            // 
            this.radioButtonALTZ.AutoSize = true;
            this.radioButtonALTZ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonALTZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonALTZ.Location = new System.Drawing.Point(325, 49);
            this.radioButtonALTZ.Name = "radioButtonALTZ";
            this.radioButtonALTZ.Size = new System.Drawing.Size(64, 17);
            this.radioButtonALTZ.TabIndex = 14;
            this.radioButtonALTZ.TabStop = true;
            this.radioButtonALTZ.Text = "ALT + Z";
            this.radioButtonALTZ.UseVisualStyleBackColor = false;
            // 
            // radioButtonCTRLSHIFT
            // 
            this.radioButtonCTRLSHIFT.AutoSize = true;
            this.radioButtonCTRLSHIFT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonCTRLSHIFT.Location = new System.Drawing.Point(325, 72);
            this.radioButtonCTRLSHIFT.Name = "radioButtonCTRLSHIFT";
            this.radioButtonCTRLSHIFT.Size = new System.Drawing.Size(96, 17);
            this.radioButtonCTRLSHIFT.TabIndex = 13;
            this.radioButtonCTRLSHIFT.TabStop = true;
            this.radioButtonCTRLSHIFT.Text = "CTRL + SHIFT";
            this.radioButtonCTRLSHIFT.UseVisualStyleBackColor = false;
            // 
            // comboBoxKieugo
            // 
            this.comboBoxKieugo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxKieugo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKieugo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKieugo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKieugo.FormattingEnabled = true;
            this.comboBoxKieugo.Items.AddRange(new object[] {
            "Telex",
            "VNI"});
            this.comboBoxKieugo.Location = new System.Drawing.Point(89, 68);
            this.comboBoxKieugo.Name = "comboBoxKieugo";
            this.comboBoxKieugo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxKieugo.TabIndex = 12;
            this.comboBoxKieugo.SelectedIndexChanged += new System.EventHandler(this.comboBoxKieugo_SelectedIndexChanged);
            // 
            // comboBoxBangma
            // 
            this.comboBoxBangma.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxBangma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBangma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBangma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBangma.Items.AddRange(new object[] {
            "Unicode",
            "TCVN3 (ABC)",
            "VNI Windows"});
            this.comboBoxBangma.Location = new System.Drawing.Point(89, 25);
            this.comboBoxBangma.Name = "comboBoxBangma";
            this.comboBoxBangma.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBangma.TabIndex = 11;
            this.comboBoxBangma.SelectedIndexChanged += new System.EventHandler(this.comboBoxBangma_SelectedIndexChanged);
            // 
            // metroButtonExit
            // 
            this.metroButtonExit.Location = new System.Drawing.Point(230, 133);
            this.metroButtonExit.Name = "metroButtonExit";
            this.metroButtonExit.Size = new System.Drawing.Size(116, 32);
            this.metroButtonExit.TabIndex = 10;
            this.metroButtonExit.Text = "Thoát hoàn toàn";
            this.metroButtonExit.UseSelectable = true;
            this.metroButtonExit.Click += new System.EventHandler(this.metroButtonExit_Click);
            // 
            // metroButtonTaskbar
            // 
            this.metroButtonTaskbar.Location = new System.Drawing.Point(89, 133);
            this.metroButtonTaskbar.Name = "metroButtonTaskbar";
            this.metroButtonTaskbar.Size = new System.Drawing.Size(116, 32);
            this.metroButtonTaskbar.TabIndex = 9;
            this.metroButtonTaskbar.Text = "Thu xuống Taskbar";
            this.metroButtonTaskbar.UseSelectable = true;
            this.metroButtonTaskbar.Click += new System.EventHandler(this.metroButtonTaskbar_Click);
            // 
            // metroLabelPhimChuyen
            // 
            this.metroLabelPhimChuyen.AutoSize = true;
            this.metroLabelPhimChuyen.Location = new System.Drawing.Point(293, 27);
            this.metroLabelPhimChuyen.Name = "metroLabelPhimChuyen";
            this.metroLabelPhimChuyen.Size = new System.Drawing.Size(86, 19);
            this.metroLabelPhimChuyen.TabIndex = 6;
            this.metroLabelPhimChuyen.Text = "Phím chuyển:";
            // 
            // metroLabelKieuGo
            // 
            this.metroLabelKieuGo.AutoSize = true;
            this.metroLabelKieuGo.Location = new System.Drawing.Point(18, 68);
            this.metroLabelKieuGo.Name = "metroLabelKieuGo";
            this.metroLabelKieuGo.Size = new System.Drawing.Size(56, 19);
            this.metroLabelKieuGo.TabIndex = 3;
            this.metroLabelKieuGo.Text = "Kiểu gõ:";
            // 
            // metroLabelBangMa
            // 
            this.metroLabelBangMa.AutoSize = true;
            this.metroLabelBangMa.Location = new System.Drawing.Point(18, 27);
            this.metroLabelBangMa.Name = "metroLabelBangMa";
            this.metroLabelBangMa.Size = new System.Drawing.Size(65, 19);
            this.metroLabelBangMa.TabIndex = 2;
            this.metroLabelBangMa.Text = "Bảng mã:";
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPageDieuKhien);
            this.metroTabControl.Controls.Add(this.metroTabPageCaiDatNangCao);
            this.metroTabControl.Controls.Add(this.metroTabPageThongTin);
            this.metroTabControl.Location = new System.Drawing.Point(23, 54);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(458, 219);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            // 
            // ViKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(504, 277);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViKey";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "ViKey 2015";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViKey_FormClosing);
            this.Load += new System.EventHandler(this.ViKey_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.metroTabPageThongTin.ResumeLayout(false);
            this.metroTabPageCaiDatNangCao.ResumeLayout(false);
            this.metroTabPageCaiDatNangCao.PerformLayout();
            this.metroTabPageDieuKhien.ResumeLayout(false);
            this.metroTabPageDieuKhien.PerformLayout();
            this.metroTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBatHuongDan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBatCongCu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBatKiemTraChinhTa;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBatTinhNangGoTat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMoBangGoTat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBangDieuKhien;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemThoatChuongTrinh;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxKieuGo;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxBangMa;
        private MetroFramework.Controls.MetroTabPage metroTabPageThongTin;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPageCaiDatNangCao;
        private System.Windows.Forms.CheckBox checkBoxKhoidongcungwin;
        private System.Windows.Forms.CheckBox checkBoxBatkhikhoidong;
        private System.Windows.Forms.CheckBox checkBoxSudungsendkey;
        private System.Windows.Forms.CheckBox checkBoxGotatkhitatTV;
        private System.Windows.Forms.CheckBox checkBoxKiemtract;
        private System.Windows.Forms.CheckBox checkBoxBodau;
        private System.Windows.Forms.CheckBox checkBoxChophepgotat;
        private MetroFramework.Controls.MetroButton metroButtonBanggotat;
        private MetroFramework.Controls.MetroButton metroButtonHuongdan;
        private MetroFramework.Controls.MetroButton metroButtonThietlapmacdinh;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPageDieuKhien;
        private System.Windows.Forms.RadioButton radioButtonALTZ;
        private System.Windows.Forms.RadioButton radioButtonCTRLSHIFT;
        private System.Windows.Forms.ComboBox comboBoxKieugo;
        private System.Windows.Forms.ComboBox comboBoxBangma;
        private MetroFramework.Controls.MetroButton metroButtonExit;
        private MetroFramework.Controls.MetroButton metroButtonTaskbar;
        private MetroFramework.Controls.MetroLabel metroLabelPhimChuyen;
        private MetroFramework.Controls.MetroLabel metroLabelKieuGo;
        private MetroFramework.Controls.MetroLabel metroLabelBangMa;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
    }
}

