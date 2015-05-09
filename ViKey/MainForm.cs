using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Net;
using System.Resources;
using System.Xml;
using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;
using ViKey.Properties;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ViKey
{
    public partial class ViKey : MetroForm
    {
        public ViKey()
        { 
            InitializeComponent();
            try
            {
                UserActivityHook actHook = new UserActivityHook(false, true);
                actHook.KeyDown += new KeyEventHandler(this.MyKeyDown);
                actHook.KeyPress += new KeyPressEventHandler(this.MyKeyPress);
                actHook.KeyUp += new KeyEventHandler(this.MyKeyUp);
                bangGotat = new BangGoTat();
                tiengViet = new TiengViet(Unicode, telex);
                // load setting from UserSetting.xml file
                this.LoadSetting();   
            }
            catch
            {
                MessageBox.Show("Đã có lỗi trong quá trình khởi động ViKey!!\nHãy tải và cài đặt lại ViKey.", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
        }
        
        //Phần khai báo biến
        private RegistryKey registrykeyApp = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
        private BangGoTat bangGotat;
        private TiengViet tiengViet;
        private bool goTiengViet;
        private string userSettingFilePath = Application.StartupPath + @"\UserSetting.xml";
        private const int cross = 4;
        private const int cross64 = 8;
        private string[] Unicode = new string[] { "a", "á", "à", "ã", "ả", "ạ", "ă", "ắ", "ằ", "ẵ", "ẳ", "ặ", "â", "ấ", "ầ", "ẫ", "ẩ", "ậ", "e", "é", "è", "ẽ", "ẻ", "ẹ", "ê", "ế", "ề", "ễ", "ể", "ệ", "i", "í", "ì", "ĩ", "ỉ", "ị", "o", "ó", "ò", "õ", "ỏ", "ọ", "ô", "ố", "ồ", "ỗ", "ổ", "ộ", "ơ", "ớ", "ờ", "ỡ", "ở", "ợ", "u", "ú", "ù", "ũ", "ủ", "ụ", "ư", "ứ", "ừ", "ữ", "ử", "ự", "y", "ý", "ỳ", "ỹ", "ỷ", "ỵ", "đ", "A", "Á", "À", "Ã", "Ả", "Ạ", "Ă", "Ắ", "Ằ", "Ẵ", "Ẳ", "Ặ", "Â", "Ấ", "Ầ", "Ẫ", "Ẩ", "Ậ", "E", "É", "È", "Ẽ", "Ẻ", "Ẹ", "Ê", "Ế", "Ề", "Ễ", "Ể", "Ệ", "I", "Í", "Ì", "Ĩ", "Ỉ", "Ị", "O", "Ó", "Ò", "Õ", "Ỏ", "Ọ", "Ô", "Ố", "Ồ", "Ỗ", "Ổ", "Ộ", "Ơ", "Ớ", "Ờ", "Ỡ", "Ở", "Ợ", "U", "Ú", "Ù", "Ũ", "Ủ", "Ụ", "Ư", "Ứ", "Ừ", "Ữ", "Ử", "Ự", "Y", "Ý", "Ỳ", "Ỹ", "Ỷ", "Ỵ", "Đ" };
        private string[] TCVN3 = new string[] { "a", "¸", "µ", "·", "¶", "¹", "¨", "¾", "»", "½", "¼", "Æ", "©", "Ê", "Ç", "É", "È", "Ë", "e", "Ð", "Ì", "Ï", "Î", "Ñ", "ª", "Õ", "Ò", "Ô", "Ó", "Ö", "i", "Ý", "×", "Ü", "Ø", "Þ", "o", "ã", "ß", "â", "á", "ä", "«", "è", "å", "ç", "æ", "é", "¬", "í", "ê", "ì", "ë", "î", "u", "ó", "ï", "ò", "ñ", "ô", "­", "ø", "õ", "÷", "ö", "ù", "y", "ý", "ú", "ü", "û", "þ", "®", "A", "¸", "µ", "·", "¶", "¹", "¡", "¾", "»", "½", "¼", "Æ", "¢", "Ê", "Ç", "É", "È", "Ë", "E", "Ð", "Ì", "Ï", "Î", "Ñ", "£", "Õ", "Ò", "Ô", "Ó", "Ö", "I", "Ý", "×", "Ü", "Ø", "Þ", "O", "ã", "ß", "â", "á", "ä", "¤", "è", "å", "ç", "æ", "é", "¥", "í", "ê", "ì", "ë", "î", "U", "ó", "ï", "ò", "ñ", "ô", "¦", "ø", "õ", "÷", "ö", "ù", "Y", "ý", "ú", "ü", "û", "þ", "§", };
        private string[] VNIWindow = new string[] { "a", "aù", "aø", "aõ", "aû", "aï", "aê", "aé", "aè", "aü", "aú", "aë", "aâ", "aá", "aà", "aã", "aå", "aä", "e", "eù", "eø", "eõ", "eû", "eï", "eâ", "eá", "eà", "eã", "eå", "eä", "i", "í", "ì", "ó", "æ", "ò", "o", "où", "oø", "oõ", "oû", "oï", "oâ", "oá", "oà", "oã", "oå", "oä", "ô", "ôù", "ôø", "ôõ", "ôû", "ôï", "u", "uù", "uø", "uõ", "uû", "uï", "ö", "öù", "öø", "öõ", "öû", "öï", "y", "yù", "yø", "yõ", "yû", "î", "ñ", "A", "AÙ", "AØ", "AÕ", "AÛ", "AÏ", "AÊ", "AÉ", "AÈ", "AÜ", "AÚ", "AË", "AÂ", "AÁ", "AÀ", "AÃ", "AÅ", "AÄ", "E", "EÙ", "EØ", "EÕ", "EÛ", "EÏ", "EÂ", "EÁ", "EÀ", "EÃ", "EÅ", "EÄ", "I", "Í", "Ì", "Ó", "Æ", "Ò", "O", "OÙ", "OØ", "OÕ", "OÛ", "OÏ", "OÂ", "OÁ", "OÀ", "OÃ", "OÅ", "OÄ", "Ô", "ÔÙ", "ÔØ", "ÔÕ", "ÔÛ", "ÔÏ", "U", "UÙ", "UØ", "UÕ", "UÛ", "UÏ", "Ö", "ÖÙ", "ÖØ", "ÖÕ", "ÖÛ", "ÖÏ", "Y", "YÙ", "YØ", "YÕ", "YÛ", "Î", "Ñ", };
        private char[] vni = new char[] { '0', '1', '2', '4', '3', '5', '6', ' ', ' ', ' ', ' ', ' ', '7', '8', '9' };
        private char[] telex = new char[] { 'z', 's', 'f', 'x', 'r', 'j', ' ', 'a', 'e', 'o', ' ', 'w', ' ', ' ', 'd' };
        private bool CtrlShift;
        private bool ShiftFirst;
        private bool Alt;
        private bool ShiftL;
        private bool ShiftR;
        private bool OtherKey;
        private bool Control;
        private string s = "";
        private string s1 = "";
        private string s2 = "";
        private string cache;
        private string goTat = "";
        private int xuat;
        private bool controlV;
        private int ngatTamThoi = -1;
        private int i;

        ///Hàm save dữ liệu xuống file UserSetting.xml
        private void SaveSetting()
        {
            if (File.Exists(userSettingFilePath) == false)
            {
                File.WriteAllText(userSettingFilePath, "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n <config>\r\n  <GoTiengViet>1</GoTiengViet>\r\n  <KieuGo>0</KieuGo>\r\n  <BangMa>0</BangMa>\r\n  <PhimChuyen>0</PhimChuyen>\r\n  <BoDau>0</BoDau>\r\n  <KiemTraChinhTa>1</KiemTraChinhTa>\r\n  <SuDungSendKey>0</SuDungSendKey>\r\n  <ChoPhepGoTat>0</ChoPhepGoTat>\r\n  <GoTatKhiTatTiengViet>0</GoTatKhiTatTiengViet>\r\n  <BatKhiKhoiDong>0</BatKhiKhoiDong>\r\n  <KhoiDongCungWin>0</KhoiDongCungWin>\r\n </config>");
            }
            XmlDocument xmlSetting = new XmlDocument();
            xmlSetting.Load(userSettingFilePath);

            if (this.goTiengViet == true)
            {
                xmlSetting.DocumentElement["GoTiengViet"].InnerText = "1";
            }
            else
            {
                xmlSetting.DocumentElement["GoTiengViet"].InnerText = "0";
            }

            xmlSetting.DocumentElement["KieuGo"].InnerText = this.comboBoxKieugo.SelectedIndex.ToString();
            xmlSetting.DocumentElement["BangMa"].InnerText = this.comboBoxBangma.SelectedIndex.ToString();

            if (this.radioButtonCTRLSHIFT.Checked == true)
            {
                xmlSetting.DocumentElement["PhimChuyen"].InnerText = "0";
            }
            else
            {
                xmlSetting.DocumentElement["PhimChuyen"].InnerText = "1";
            }

            if (this.checkBoxBodau.Checked == true)
            {
                xmlSetting.DocumentElement["BoDau"].InnerText = "1";
            }
            else
            {
                xmlSetting.DocumentElement["BoDau"].InnerText = "0";
            }

            if (this.checkBoxKiemtract.Checked == true)
            {
                xmlSetting.DocumentElement["KiemTraChinhTa"].InnerText = "1";
            }
            else
            {
                xmlSetting.DocumentElement["KiemTraChinhTa"].InnerText = "0";
            }

            if (this.checkBoxSudungsendkey.Checked == true)
            {
                xmlSetting.DocumentElement["SuDungSendKey"].InnerText = "1";
            }
            else
            {
                xmlSetting.DocumentElement["SuDungSendKey"].InnerText = "0";
            }
            if (this.checkBoxChophepgotat.Checked == true)
            {
                xmlSetting.DocumentElement["ChoPhepGoTat"].InnerText = "1";
            }
            else
            {
                xmlSetting.DocumentElement["ChoPhepGoTat"].InnerText = "0";
            }
            if (this.checkBoxGotatkhitatTV.Checked == true)
            {
                xmlSetting.DocumentElement["GoTatKhiTatTiengViet"].InnerText = "1";
            }
            else
            {
                xmlSetting.DocumentElement["GoTatKhiTatTiengViet"].InnerText = "0";
            }
            if (this.checkBoxBatkhikhoidong.Checked == true)
            {
                xmlSetting.DocumentElement["BatKhiKhoiDong"].InnerText = "1";
            }
            else
            {
                xmlSetting.DocumentElement["BatKhiKhoiDong"].InnerText = "0";
            }
            if (this.checkBoxKhoidongcungwin.Checked == true)
            {
                xmlSetting.DocumentElement["KhoiDongCungWin"].InnerText = "1";
            }
            else
            {
                xmlSetting.DocumentElement["KhoiDongCungWin"].InnerText = "0";
            }
            xmlSetting.Save(userSettingFilePath);
        }
        ///Hàm Load dữ liệu từ file UserSetting.xml
        private void LoadSetting()
        {
            if (File.Exists(userSettingFilePath) == false)
            {
                MessageBox.Show("Không tìm thấy file UserSetting.xml !!\n Chương trình sẽ được đặt thiết lập mặc định.", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.ThietLapMacDinh();
                return;
            }
            else
            {
                XmlDocument xmlSetting = new XmlDocument();
                xmlSetting.Load(userSettingFilePath);

                if (xmlSetting.DocumentElement["GoTiengViet"].InnerText == "1")
                {
                    this.goTiengViet = true;
                    this.notifyIcon.Icon = Resources.V;
                }
                else
                {
                    this.goTiengViet = false;
                    this.notifyIcon.Icon = Resources.E;
                }

                this.toolStripComboBoxKieuGo.SelectedIndex = this.comboBoxKieugo.SelectedIndex = Int32.Parse(xmlSetting.DocumentElement["KieuGo"].InnerText);
                this.toolStripComboBoxBangMa.SelectedIndex = this.comboBoxBangma.SelectedIndex = Int32.Parse(xmlSetting.DocumentElement["BangMa"].InnerText);


                if (xmlSetting.DocumentElement["PhimChuyen"].InnerText == "0")
                    this.radioButtonCTRLSHIFT.Checked = true;
                else
                    this.radioButtonALTZ.Checked = true;
                if (xmlSetting.DocumentElement["BoDau"].InnerText == "1")
                {
                    this.checkBoxBodau.Checked = true;
                }
                else
                    this.checkBoxBodau.Checked = false;
                if (xmlSetting.DocumentElement["KiemTraChinhTa"].InnerText == "1")
                {
                    this.checkBoxKiemtract.Checked = true;
                    this.toolStripMenuItemBatKiemTraChinhTa.Checked = true;
                }
                else
                {
                    this.checkBoxKiemtract.Checked = false;
                    this.toolStripMenuItemBatKiemTraChinhTa.Checked = false;
                }
                if (xmlSetting.DocumentElement["SuDungSendKey"].InnerText == "1")
                {
                    this.checkBoxSudungsendkey.Checked = true;
                }
                else
                    this.checkBoxSudungsendkey.Checked = false;
                if (xmlSetting.DocumentElement["ChoPhepGoTat"].InnerText == "1")
                {
                    this.checkBoxChophepgotat.Checked = true;
                    this.toolStripMenuItemBatTinhNangGoTat.Checked = true;
                }
                else
                {
                    this.checkBoxChophepgotat.Checked = false;
                    this.toolStripMenuItemBatTinhNangGoTat.Checked = false;
                }

                if (xmlSetting.DocumentElement["GoTatKhiTatTiengViet"].InnerText == "1")
                {
                    this.checkBoxGotatkhitatTV.Checked = true;
                }
                else
                    this.checkBoxGotatkhitatTV.Checked = false;
                if (xmlSetting.DocumentElement["BatKhiKhoiDong"].InnerText == "1")
                {
                    this.checkBoxBatkhikhoidong.Checked = true;
                }
                else
                    this.checkBoxBatkhikhoidong.Checked = false;
                if (xmlSetting.DocumentElement["KhoiDongCungWin"].InnerText == "1")
                {
                    this.checkBoxKhoidongcungwin.Checked = true;
                }
                else
                    this.checkBoxKhoidongcungwin.Checked = false;
            }
        }
        
        
        #region Xử lí phần group Hệ thống
        ///Khởi động cùng window
        private void checkBoxKhoidongcungwin_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxKhoidongcungwin.Checked)
            {
                this.registrykeyApp.SetValue("ViKey", Application.ExecutablePath.ToString());     
            }
            else
            {
                this.registrykeyApp.DeleteValue("ViKey", false);
            }
        }
        //Bật hộp thoại khi khởi động
        private void ViKey_Load(object sender, EventArgs e)
        {
            if (this.checkBoxBatkhikhoidong.Checked == false)
            {
                this.metroButtonTaskbar_Click(sender, e);
            }
            else
            {
                this.metroTabControl.SelectedTab = this.metroTabPageDieuKhien;
                this.Show();
            }
        }
        #endregion

        
        #region Xử lí phần tab Điều khiển
        private void metroButtonExit_Click(object sender, EventArgs e)
        {
            this.SaveSetting();
            this.bangGotat.SaveChange();
            this.Close();
        }

        private void metroButtonTaskbar_Click(object sender, EventArgs e)
        {
            this.SaveSetting();
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(50);
            this.Hide();
            this.ShowInTaskbar = false;
        }
        private void comboBoxBangma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxBangma.SelectedIndex == 0)
            {
                this.tiengViet.bangMa = Unicode;
            }
            else if (this.comboBoxBangma.SelectedIndex == 1)
            {
                this.tiengViet.bangMa = TCVN3;
            }
            else
            {
                this.tiengViet.bangMa = VNIWindow;
            }
            this.toolStripComboBoxBangMa.SelectedIndex = this.comboBoxBangma.SelectedIndex;
        }

        private void comboBoxKieugo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxKieugo.SelectedIndex == 0)
            {
                this.tiengViet.kieuGo = telex;
            } else if (this.comboBoxKieugo.SelectedIndex == 1)
            {
                this.tiengViet.kieuGo = vni;
            }
            this.toolStripComboBoxKieuGo.SelectedIndex = this.comboBoxKieugo.SelectedIndex;
        }

        private void ViKey_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveSetting();
        }

        #endregion


        #region Xử lí phần menu dưới taskbar
        private void toolStripMenuItemBatCongCu_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\CongCu\UnikeyToolkit.exe"))
            {
                base.Hide();
                Process.Start(Application.StartupPath + @"\CongCu\UnikeyToolkit.exe");
            }
            else
            {
                MessageBox.Show("Không tìm thấy file UnikeyToolkit.exe", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }      
        }
        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }


        private void toolStripMenuItemThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            this.SaveSetting();
            this.bangGotat.SaveChange();
            this.Close();
        }
        private void toolStripMenuItemBangDieuKhien_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            
            this.Show();
        }

        private void toolStripMenuItemBatKiemTraChinhTa_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItemBatKiemTraChinhTa.Checked)
                this.checkBoxKiemtract.Checked = true;
            else
                this.checkBoxKiemtract.Checked = false;
        }

        private void toolStripMenuItemBatTinhNangGoTat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.toolStripMenuItemBatTinhNangGoTat.Checked)
                this.checkBoxChophepgotat.Checked = true;
            else
                this.checkBoxChophepgotat.Checked = false;
        }
        private void toolStripMenuItemBatHuongDan_Click(object sender, EventArgs e)
        {
            this.metroButtonHuongdan_Click(sender, e);
        }

        private void toolStripMenuItemMoBangGoTat_Click(object sender, EventArgs e)
        {
            this.metroButtonBanggotat_Click(sender, e);
        }
        private void toolStripComboBoxKieuGo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxKieugo.SelectedIndex = this.toolStripComboBoxKieuGo.SelectedIndex;
        }

        private void toolStripComboBoxBangMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxBangma.SelectedIndex = this.toolStripComboBoxBangMa.SelectedIndex;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.goTiengViet == true)
                {
                    this.notifyIcon.Icon = Resources.E;
                }
                else
                {
                    this.notifyIcon.Icon = Resources.V;
                }
                this.goTiengViet = !this.goTiengViet;
            }
            ViKey.keybd_event(16, 0, 2u, UIntPtr.Zero);
            ViKey.keybd_event(17, 0, 2u, UIntPtr.Zero);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.ShowInTaskbar = true;
            this.Show();
            if (e.Button == MouseButtons.Left)
            {
                if (this.goTiengViet == true)
                {
                    this.notifyIcon.Icon = Resources.E;
                }
                else
                {
                    this.notifyIcon.Icon = Resources.V;
                }
                this.goTiengViet = !this.goTiengViet;
            }
        }

        #endregion

        
        #region Xử lí phần button tab cài đặt nâng cao
        private void ThietLapMacDinh()
        {
            this.comboBoxBangma.SelectedIndex = 0;
            this.comboBoxKieugo.SelectedIndex = 0;
            this.radioButtonCTRLSHIFT.Checked = true;
            this.checkBoxBodau.Checked = true;
            this.checkBoxKiemtract.Checked = true;
            this.checkBoxChophepgotat.Checked = true;
            this.checkBoxGotatkhitatTV.Checked = false;
            this.checkBoxKhoidongcungwin.Checked = true;
            this.checkBoxBatkhikhoidong.Checked = true;
        }
        private void metroButtonThietlapmacdinh_Click(object sender, EventArgs e)
        {
            this.ThietLapMacDinh();
        }
        private void metroButtonBanggotat_Click(object sender, EventArgs e)
        {
            bangGotat.ShowDialog();
        }
        private void metroButtonHuongdan_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\HuongDan\HuongDan.htm"))
            {
                Process.Start(Application.StartupPath + @"\HuongDan\HuongDan.htm");
            }
            else
            {
                MessageBox.Show("Không tìm thấy file hướng dẫn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion 



        #region Xử lí phần tuỳ chọn gõ tắt và kiểm tra chính tả
        private void checkBoxKiemtract_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKiemtract.Checked)
                this.toolStripMenuItemBatKiemTraChinhTa.Checked = true;
            else
                this.toolStripMenuItemBatKiemTraChinhTa.Checked = false;
        }

        private void checkBoxChophepgotat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxChophepgotat.Checked)
                this.toolStripMenuItemBatTinhNangGoTat.Checked = true;
            else
                this.toolStripMenuItemBatTinhNangGoTat.Checked = false;
        }
        #endregion




        #region Xử lý sự kiện chuột, bàn phím
        private void MyKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (this.GoTat(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (this.controlV || !this.goTiengViet)
                {
                    this.controlV = false;
                }
                else
                {
                    if ((!this.Control && (this.ShiftL || this.ShiftR)) && ((!this.Alt && (e.KeyChar == ' ')) && !this.ShiftFirst))
                    {
                        if (((this.s2 != null) && (this.s2 != "")) && (this.s2 != this.s1))
                        {
                            e.Handled = true;
                            this.XuatTiengViet(this.s2, this.s1,false);
                            this.s1 = this.cache = this.s2 = this.goTat = "";
                            this.ngatTamThoi = 0;
                        }
                    }
                    else
                    {
                        if (this.ShiftL || this.ShiftR)
                        {
                            this.ShiftFirst = true;
                        }
                        else
                        {
                            this.ShiftFirst = false;
                        }
                        if (this.tiengViet.KiemTraKetThucTu(e.KeyChar))
                        {
                            if (e.KeyChar == '\r')
                            {
                                if ((((this.checkBoxKiemtract.Checked) && !this.tiengViet.KiemTraChinhTa()) && (this.s1 != this.s2)) && ((this.tiengViet.chu.trungdau < 0) || this.tiengViet.KiemTraDauMuD()))
                                {
                                    this.XuatTiengViet(this.s2, this.s1, false);
                                }
                                this.cache = this.s1 = this.s2 = this.goTat = "";
                                this.ngatTamThoi = -1;
                            }
                            else if (e.KeyChar == '\b')
                            {
                                if ((!this.Control && !this.Alt) && (this.ShiftL || this.ShiftR))
                                {
                                    this.s = this.s1 = this.s2 = this.cache = this.goTat = "";
                                }
                                else if ((this.s2 == this.s1) && (this.s2 != ""))
                                {
                                    this.s2 = this.s2.Remove(this.s2.Length - 1);
                                    this.s = this.tiengViet.Convert(this.s2);
                                    e.Handled = true;
                                    this.XuatTiengViet(this.s, this.s1, false);
                                    this.s1 = this.s;
                                }
                                else if (this.s2 == "")
                                {
                                    this.i = this.cache.Length - 2;
                                    while (this.i >= 0)
                                    {
                                        if (this.tiengViet.KiemTraKetThucTu(this.cache[this.i]))
                                        {
                                            break;
                                        }
                                        this.i--;
                                    }
                                    if (this.i < 0)
                                    {
                                        if (this.cache != "")
                                        {
                                            this.s2 = this.cache.Remove(this.cache.Length - 1);
                                            this.cache = "";
                                            this.goTat = this.s2;
                                        }
                                        else
                                        {
                                            this.cache = this.s2 = "";
                                        }
                                    }
                                    else
                                    {
                                        this.s2 = this.cache.Substring(this.i + 1, (this.cache.Length - this.i) - 2);
                                        this.cache = this.cache.Remove(this.i + 1);
                                        this.goTat = this.s2;
                                    }
                                    this.s1 = this.tiengViet.Convert(this.s2);
                                    if (((this.checkBoxKiemtract.Checked) && !this.tiengViet.KiemTraChinhTa()) && ((this.tiengViet.chu.trungdau < 0) || this.tiengViet.KiemTraDauMuD()))
                                    {
                                        e.Handled = true;
                                        this.XuatTiengViet(this.s1, this.s2 + ' ', false);
                                    }
                                }
                                else if (this.tiengViet.chu.amCuoi != "")
                                {
                                    int startIndex = this.s2.LastIndexOf(this.tiengViet.chu.amCuoi[this.tiengViet.chu.amCuoi.Length - 1]);
                                    if (startIndex >= 0)
                                    {
                                        this.s2 = this.s2.Remove(startIndex, 1);
                                    }
                                    this.s = this.tiengViet.Convert(this.s2);
                                    e.Handled = true;
                                    this.XuatTiengViet(this.s, this.s1, false);
                                    this.s1 = this.s;
                                }
                                else if (this.tiengViet.chu.nguyenAm != "")
                                {
                                    this.tiengViet.chu.nguyenAm = this.tiengViet.chu.nguyenAm.Remove(this.tiengViet.chu.nguyenAm.Length - 1);
                                    if ((this.tiengViet.chu.nguyenAm == "") && ((this.tiengViet.chu.amDau.ToLower() == "gi") || (this.tiengViet.chu.amDau.ToLower() == "qu")))
                                    {
                                        this.tiengViet.chu.nguyenAm = this.tiengViet.chu.amDau[1].ToString();
                                        this.tiengViet.chu.amDau = this.tiengViet.chu.amDau[0].ToString();
                                    }
                                    this.s2 = this.tiengViet.ConvertNguoc();
                                    this.s = this.tiengViet.Convert(this.s2);
                                    e.Handled = true;
                                    this.XuatTiengViet(this.s, this.s1, false);
                                    this.s1 = this.s;
                                }
                                else if (this.tiengViet.chu.amDau != "")
                                {
                                    this.tiengViet.chu.amDau = this.tiengViet.chu.amDau.Remove(this.tiengViet.chu.amDau.Length - 1);
                                    this.s2 = this.tiengViet.ConvertNguoc();
                                    this.s = this.tiengViet.Convert(this.s2);
                                    e.Handled = true;
                                    this.XuatTiengViet(this.s, this.s1, false);
                                    this.s1 = this.s;
                                }
                                else
                                {
                                    this.tiengViet.chu.amDau = this.s1 = this.s2 = "";
                                }
                                if (this.ngatTamThoi >= 0)
                                {
                                    this.ngatTamThoi--;
                                }
                            }
                            else
                            {
                                this.cache = this.cache + this.s2 + e.KeyChar;
                                if (this.cache.Length > 100)
                                {
                                    this.cache = this.cache.Substring(50);
                                }
                                if ((((this.checkBoxKiemtract.Checked) && !this.tiengViet.KiemTraChinhTa()) && (this.s1 != this.s2)) && ((this.tiengViet.chu.trungdau < 0) || this.tiengViet.KiemTraDauMuD()))
                                {
                                    this.XuatTiengViet(this.s2, this.s1, false);
                                }
                                this.s = this.s1 = this.s2 = "";
                                this.ngatTamThoi = -1;
                            }
                        }
                        else if (this.ngatTamThoi >= 0)
                        {
                            this.ngatTamThoi++;
                        }
                        else if ((((this.tiengViet.kieuGo[14].ToString().ToLower() == e.KeyChar.ToString().ToLower()) && (this.s1.Length >= 2)) && (!this.tiengViet.KiemTraKetThucTu(this.s1[this.s1.Length - 2]) && !this.tiengViet.KiemTraNguyenAm(this.s1[this.s1.Length - 2]))) && ("dD".IndexOf(this.s1[this.s1.Length - 1]) >= 0))
                        {
                            if (this.s1[this.s1.Length - 1] == 'd')
                            {
                                this.s = this.tiengViet.bangMa[0x48];
                            }
                            else if (this.s1[this.s1.Length - 1] == 'D')
                            {
                                this.s = this.tiengViet.bangMa[0x91];
                            }
                            e.Handled = true;
                            this.XuatTiengViet(this.s, "d", false);
                            this.tiengViet.chu.D9 = true;
                            this.tiengViet.chu.amDau = this.s1[this.s1.Length - 1].ToString();
                            char ch5 = this.s1[this.s1.Length - 1];
                            this.s2 = this.cache = this.goTat = ch5.ToString() + e.KeyChar;
                            this.s1 = this.s;
                            this.tiengViet.Convert(this.s2);
                        }
                        else if (((this.tiengViet.kieuGo[14].ToString().ToLower() == e.KeyChar.ToString().ToLower()) && (this.s2.Length >= 2)) && (this.s2.Substring(this.s2.Length - 2).ToLower() == "dd"))
                        {
                            e.Handled = true;
                            this.XuatTiengViet(this.s2[this.s2.Length - 2] + e.KeyChar.ToString(), " ", false);
                            this.s2 = this.s1 = this.cache = this.goTat = e.KeyChar.ToString();
                            this.tiengViet.Convert(this.s2);
                        }
                        else
                        {
                            this.s2 = this.s2 + e.KeyChar;
                            this.s = this.tiengViet.Convert(this.s2);
                            if ((((this.checkBoxKiemtract.Checked == false) && this.tiengViet.KiemTraNguyenAm(e.KeyChar)) && ((this.tiengViet.chu.amCuoi != "") || (this.tiengViet.chu.trungdau >= 0))) && (this.s == (this.s1 + e.KeyChar)))
                            {
                                this.s = this.s1 = this.s2 = e.KeyChar.ToString();
                                this.cache = "";
                                this.tiengViet.Convert(this.s);
                            }
                            else if (((this.s != null) && (this.s != "")) && (this.s != (this.s1 + e.KeyChar)))
                            {
                                e.Handled = true;
                                this.XuatTiengViet(this.s, this.s1, false);
                                this.s1 = this.s;
                            }
                            else
                            {
                                this.s1 = this.s1 + e.KeyChar;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("loi key press", "loi");
            }
        }



        private void MyKeyUp(object sender, KeyEventArgs e)
        {
            
            if ((this.radioButtonALTZ.Checked && e.KeyCode == Keys.Z  && !this.Control) && ((!this.ShiftL && !this.ShiftR) && this.Alt))
            {
                if (this.goTiengViet)
                {
                    this.notifyIcon.Icon = Resources.E;
                    this.s1 = this.s2 = this.cache = "";
                }
                else
                {
                    this.notifyIcon.Icon = Resources.V;
                }
                this.goTiengViet = !this.goTiengViet;
            }
            if (e.KeyData.ToString().Contains("ControlKey"))
            {
                this.Control = false;
                if ((this.ShiftL || this.ShiftR) && !this.OtherKey)
                {
                    this.CtrlShift = true;
                }
            }
            else if (e.KeyData.ToString().Contains("LShiftKey"))
            {
                this.ShiftL = false;
                if (this.Control && !this.OtherKey)
                {
                    this.CtrlShift = true;
                }
            }
            else if (e.KeyData.ToString().Contains("RShiftKey"))
            {
                this.ShiftR = false;
                if (this.Control && !this.OtherKey)
                {
                    this.CtrlShift = true;
                }
            }
            else if (e.KeyData.ToString().Contains("Menu"))
            {
                this.Alt = false;
            }
            //if (e.KeyData.ToString().Contains("ControlKey")
            //{

            //}
            if ((this.radioButtonCTRLSHIFT.Checked && (e.KeyData.ToString().Contains("ControlKey") || e.KeyData.ToString().Contains("ShiftKey"))) && (((!this.Control && !this.ShiftL) && (!this.ShiftR && this.CtrlShift)) && (!this.Alt && !this.OtherKey)))
            {
                if (this.goTiengViet)
                {
                    this.notifyIcon.Icon = Resources.E;
                    this.s1 = this.s2 = this.cache = "";
                }
                else
                {
                    this.notifyIcon.Icon = Resources.V;
                }
                this.goTiengViet = !this.goTiengViet;
                this.Control = this.ShiftL = this.ShiftR = this.Alt = this.OtherKey = this.CtrlShift = false;
            }
            if ((!this.Control && !this.ShiftL) && !this.ShiftR)
            {
                this.OtherKey = false;
            }
        }
        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            string str = e.KeyData.ToString();
            if (str.Contains("ControlKey") && !this.controlV)
            {
                this.Control = true;
            }
            else if (str.Contains("LShiftKey"))
            {
                this.ShiftL = true;
            }
            else if (str.Contains("RShiftKey"))
            {
                this.ShiftR = true;
            }
            else if (str.Contains("Menu"))
            {
                this.Alt = true;
            }
            else
            {
                this.OtherKey = true;
            }
            if ((((str == "Home") || (str == "End")) || ((str == "Delete") || (str == "PageUp"))) || (((str == "Next") || (str == "Up")) || (((str == "Down") || (str == "Left")) || (str == "Right"))))
            {
                this.s1 = this.s2 = this.cache = this.goTat = "";
            }
            else if (str.Contains("NumPad"))
            {
                this.controlV = true;
            }
            if ((this.Control && !this.ShiftL) && (!this.ShiftR && !this.Alt))
            {
                this.s1 = this.s2 = this.cache = this.goTat = "";
            }
        }

        #endregion

        #region struct and enum
        public enum CF
        {
            Text = 1,
            Bitmap = 2,
            MetaFilePict = 3,
            Sylk = 4,
            Dif = 5,
            Tiff = 6,
            OemText = 7,
            Dib = 8,
            Palette = 9,
            Pendata = 10,
            Riff = 11,
            Wave = 12,
            UnicodeText = 13,
            EnhMetaFile = 14,
            HDrop = 15,
            Locale = 16,
            Dibv5 = 17,
            OwnerDisplay = 128,
            DspText = 129,
            DspBitmap = 130,
            DspMetaFilePict = 131,
            DspEnhMetaFile = 142,
            PrivateFirst = 512,
            PrivateLast = 767,
            GdiObjFirst = 768,
            GdiObjLast = 1023
        }
        private struct HARDWAREINPUT
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        };

        [StructLayout(LayoutKind.Explicit)]
        private struct INPUT
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(4)]
            public ViKey.MOUSEINPUT mi;
            [FieldOffset(4)]
            public ViKey.KEYBDINPUT ki;
            [FieldOffset(4)]
            public ViKey.HARDWAREINPUT hi;
        };

        [StructLayout(LayoutKind.Explicit)]
        private struct INPUT64
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(8)]
            public ViKey.MOUSEINPUT mi;
            [FieldOffset(8)]
            public ViKey.KEYBDINPUT ki;
            [FieldOffset(8)]
            public ViKey.HARDWAREINPUT hi;
        }
        [Flags]
        private enum MOUSEEVENTF
        {
            MOVE = 1,
            LEFTDOWN = 2,
            LEFTUP = 4,
            RIGHTDOWN = 8,
            RIGHTUP = 16,
            MIDDLEDOWN = 32,
            MIDDLEUP = 64,
            XDOWN = 128,
            XUP = 256,
            WHEEL = 2048,
            VIRTUALDESK = 16384,
            ABSOLUTE = 32768

        }
        private struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public IntPtr dwExtraInfo;
        };
        private enum KEYEVENTF
        {
            EXTENDEDKEY = 1,
            KEYUP = 2,
            UNICODE = 4,
            SCANCODE = 8
        }
        private struct KEYBDINPUT
        {
            public short wVk;
            public short wScan;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }
        private enum KeyModifiers : uint
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4
        }
        private enum InputType
        {
            INPUT_MOUSE,
            INPUT_KEYBOARD,
            INPUT_HARDWARE
        }
        #endregion
        //Import API gia lap phim
        #region keybd_event
        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        private static extern void keybd_event(byte bVK, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        #endregion

        //Import API thiet lap Clipboard
        #region Clipboard
        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern bool OpenClipboard(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern IntPtr SetClipboardData(CF Format, IntPtr hMem);
        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern void EmptyClipboard();
        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern void GetClipboardData(CF Format);
        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern void CloseClipboard();
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern void CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GlobalSize(IntPtr hMem);

        private void SetClipboardAPI(string s)
        {
            ViKey.OpenClipboard(IntPtr.Zero);
            ViKey.EmptyClipboard();
            ViKey.SetClipboardData(ViKey.CF.UnicodeText, Marshal.StringToCoTaskMemUni(s));
            ViKey.CloseClipboard();
        }
        #endregion
        #region Xuất dữ liệu bằng SendInput
        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false, SetLastError = true)]
        private static extern uint SendInput(uint nInputs, ViKey.INPUT[] pInputs, int cbSize);
        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false, SetLastError = true)]
        private static extern uint SendInput(uint nInputs, ViKey.INPUT64[] pInputs, int cbSize);
        private void SendAnsi(Keys _key)
        {
            if (IntPtr.Size == 4)
            {
                ViKey.INPUT input_down = default(ViKey.INPUT);
                input_down.type = 1;
                input_down.ki.wVk = (short)_key;
                ViKey.INPUT input_up = input_down;
                input_up.ki.dwFlags = 2;
                ViKey.INPUT[] input = new ViKey.INPUT[] { input_down, input_up };
                ViKey.SendInput(2u, input, Marshal.SizeOf(input_down));
                return;

            }
            else
            {
                ViKey.INPUT64 input_down_x64 = default(ViKey.INPUT64);
                input_down_x64.type = 1;
                input_down_x64.ki.wVk = (short)_key;
                ViKey.INPUT64 input_up_x64 = input_down_x64;
                input_up_x64.ki.dwFlags = 2;
                ViKey.INPUT64[] inputx64 = new ViKey.INPUT64[] { input_up_x64, input_down_x64 };
                ViKey.SendInput(2u, inputx64, Marshal.SizeOf(input_down_x64));
            }
        }
        private void SendUnicode(string _text)
        {
            if (IntPtr.Size == 4)
            {
                ViKey.INPUT[] input = new ViKey.INPUT[_text.Length * 2];
                for (int i = 0; i < _text.Length; i++)
                {
                    input[i * 2].type = 1;
                    input[i * 2].ki.wVk = 0;
                    input[i * 2].ki.wScan = (short)_text[i];
                    input[i * 2].ki.dwFlags = 4;
                    input[i * 2 + 1] = input[i * 2];
                    input[i * 2 + 1].ki.dwFlags = 6;
                }
                ViKey.SendInput((uint)input.Length, input, Marshal.SizeOf(input[0]));
                return;
            }
            else
            {
                ViKey.INPUT64[] inputx64 = new ViKey.INPUT64[_text.Length * 2];
                for (int i = 0; i < _text.Length; i++)
                {
                    inputx64[i * 2].type = 1;
                    inputx64[i * 2].ki.wVk = 0;
                    inputx64[i * 2].ki.wScan = (short)_text[i];
                    inputx64[i * 2].ki.dwFlags = 4;
                    inputx64[i * 2 + 1] = inputx64[i * 2];
                    inputx64[i * 2 + 1].ki.dwFlags = 6;
                }
                ViKey.SendInput((uint)inputx64.Length, inputx64, Marshal.SizeOf(inputx64[0]));
            }
        }
        #endregion










        private void XuatTiengViet(string s, string s1, bool autocomplete)
        {
            if (s != s1)
            {
                this.xuat = 0;
                this.i = 0;
                while (this.i < s.Length)
                {
                    if ((this.i >= s1.Length) || (s[this.i] != s1[this.i]))
                    {
                        break;
                    }
                    this.xuat++;
                    this.i++;
                }
                if (((s.Length == (s1.Length - 1)) && (this.goTat != null)) && (this.goTat.Length > 0))
                {
                    this.goTat = this.goTat.Remove(this.goTat.Length - 1);
                }
                if (!this.checkBoxSudungsendkey.Checked)
                {
                    if (autocomplete)
                    {
                        this.controlV = true;
                        keybd_event(0xc0, 0, 0, UIntPtr.Zero);
                        keybd_event(0xc0, 0, 2, UIntPtr.Zero);
                        this.i = 0;
                        while (this.i < ((s1.Length - this.xuat) + 1))
                        {
                            this.controlV = true;
                            keybd_event(8, 0, 0, UIntPtr.Zero);
                            keybd_event(8, 0, 2, UIntPtr.Zero);
                            this.i++;
                        }
                    }
                    else
                    {
                        this.i = 0;
                        while (this.i < (s1.Length - this.xuat))
                        {
                            this.controlV = true;
                            keybd_event(8, 0, 0, UIntPtr.Zero);
                            keybd_event(8, 0, 2, UIntPtr.Zero);
                            this.i++;
                        }
                    }
                    if (this.xuat != s.Length)
                    {
                        this.goTat = null;
                        this.SetClipboardAPI(s.Substring(this.xuat, s.Length - this.xuat));
                        if (this.ShiftR)
                        {
                            keybd_event(0x10, 0, 0, UIntPtr.Zero);
                            keybd_event(0x2d, 0, 1, UIntPtr.Zero);
                            keybd_event(0x2d, 0, 2, UIntPtr.Zero);
                            keybd_event(0x10, 0, 2, UIntPtr.Zero);
                        }
                        else if (this.ShiftL)
                        {
                            this.controlV = true;
                            keybd_event(160, 0, 2, UIntPtr.Zero);
                            keybd_event(0x11, 0, 0, UIntPtr.Zero);
                            keybd_event(0x56, 0, 0, UIntPtr.Zero);
                            keybd_event(0x56, 0, 2, UIntPtr.Zero);
                            keybd_event(0x11, 0, 2, UIntPtr.Zero);
                            keybd_event(160, 0, 0, UIntPtr.Zero);
                        }
                        else
                        {
                            this.controlV = true;
                            keybd_event(0x11, 0, 0, UIntPtr.Zero);
                            keybd_event(0x56, 0, 0, UIntPtr.Zero);
                            keybd_event(0x56, 0, 2, UIntPtr.Zero);
                            keybd_event(0x11, 0, 2, UIntPtr.Zero);
                        }
                    }
                }
                else
                {
                    if (autocomplete)
                    {
                        this.SendUnicode("`");
                        this.i = 0;
                        while (this.i < ((s1.Length - this.xuat) + 1))
                        {
                            this.controlV = true;
                            this.SendAnsi(Keys.Back);
                            this.i++;
                        }
                    }
                    else
                    {
                        this.i = 0;
                        while (this.i < (s1.Length - this.xuat))
                        {
                            this.controlV = true;
                            this.SendAnsi(Keys.Back);
                            this.i++;
                        }
                    }
                    if (this.xuat != s.Length)
                    {
                        this.goTat = null;
                        this.SendUnicode(s.Substring(this.xuat));
                    }
                }
            }
        }

        private string ChuyenBangMa(string tam)
        {
            string temp = "";
            if (this.comboBoxBangma.SelectedIndex == 0)
            {
                return tam;
            }
            for (int i = 0; i < tam.Length; i++)
            {
                int j = 0;
                while (j < this.Unicode.Length)
                {
                    if (this.Unicode[j][0] != tam[i])
                    {
                        j++;
                    }
                    else
                    {
                        s = string.Concat(s, this.tiengViet.bangMa[j]);
                        break;
                    }
                }
                if (j >= this.Unicode.Length)
                {
                    s = string.Concat(s, tam[i]);
                }
            }
            return temp;
        }

        private bool GoTat(char c)
        {
            if (!this.checkBoxChophepgotat.Checked || this.controlV)
            {
                return false;
            }
            if (!this.goTiengViet && !this.checkBoxGotatkhitatTV.Checked)
            {
                return false;
            }
            if ((c > ' ') && (c < '\x007f'))
            {
                if (this.goTat == null)
                {
                    return false;
                }
                this.goTat = this.goTat + c;
                if (true && (this.s1 == this.s2))
                {
                    this.s = this.goTat.ToLower();
                    for (int i = 0; i < this.bangGotat.dataGridViewBanggotat.Rows.Count; i++)
                    {
                        if (this.bangGotat.dataGridViewBanggotat[0, i].Value.ToString() == this.goTat.ToLower())
                        {
                            if (this.goTat == this.goTat.ToLower())
                            {
                                this.XuatTiengViet(this.ChuyenBangMa(this.bangGotat.dataGridViewBanggotat[1, i].Value.ToString()), this.goTat.Remove(this.goTat.Length - 1), false);
                            }
                            else if (this.goTat == this.goTat.ToUpper())
                            {
                                this.XuatTiengViet(this.ChuyenBangMa(this.bangGotat.dataGridViewBanggotat[1, i].Value.ToString().ToUpper()), this.goTat.Remove(this.goTat.Length - 1), false);
                            }
                            else
                            {
                                this.XuatTiengViet(this.ChuyenBangMa(this.bangGotat.dataGridViewBanggotat[1, i].Value.ToString().ToLower()), this.goTat.Remove(this.goTat.Length - 1), false);
                            }
                            this.s1 = this.s2 = this.cache = this.goTat = "";
                            return true;
                        }
                    }
                }
            }
            else
            {
                if (c == '\b')
                {
                    return false;
                }
                if ((true || !(this.s1 == this.s2)) || (this.goTat == null))
                {
                    this.goTat = this.s1;
                    for (int j = 0; j < this.bangGotat.dataGridViewBanggotat.Rows.Count; j++)
                    {
                        if (this.bangGotat.dataGridViewBanggotat[0, j].Value.ToString() == this.goTat.ToLower())
                        {
                            if (this.goTat == this.goTat.ToLower())
                            {
                                this.XuatTiengViet(this.ChuyenBangMa(this.bangGotat.dataGridViewBanggotat[1, j].Value.ToString()), this.goTat, false);
                            }
                            else if (this.goTat == this.goTat.ToUpper())
                            {
                                this.XuatTiengViet(this.ChuyenBangMa(this.bangGotat.dataGridViewBanggotat[1, j].Value.ToString().ToUpper()), this.goTat, false);
                            }
                            else
                            {
                                this.XuatTiengViet(this.ChuyenBangMa(this.bangGotat.dataGridViewBanggotat[1, j].Value.ToString().ToLower()), this.goTat, false);
                            }
                            this.s1 = this.s2 = this.cache = "";
                            break;
                        }
                    }
                }
                else
                {
                    for (int k = 0; k < this.bangGotat.dataGridViewBanggotat.Rows.Count; k++)
                    {
                        if (this.bangGotat.dataGridViewBanggotat[0, k].Value.ToString() == this.goTat.ToLower())
                        {
                            if (this.goTat == this.goTat.ToLower())
                            {
                                this.XuatTiengViet(this.ChuyenBangMa(this.bangGotat.dataGridViewBanggotat[1, k].Value.ToString()), this.goTat, false);
                            }
                            else if (this.goTat == this.goTat.ToUpper())
                            {
                                this.XuatTiengViet(this.ChuyenBangMa(this.bangGotat.dataGridViewBanggotat[1, k].Value.ToString().ToUpper()), this.goTat, false);
                            }
                            else
                            {
                                this.XuatTiengViet(this.ChuyenBangMa(this.bangGotat.dataGridViewBanggotat[1, k].Value.ToString().ToLower()), this.goTat, false);
                            }
                            this.s1 = this.s2 = this.cache = "";
                            break;
                        }
                    }
                    this.goTat = "";
                    return false;
                }
                this.goTat = "";
            }
            return false;
        }




    }
}
