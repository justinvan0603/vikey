using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViKey
{
    public partial class BangGoTat : MetroForm
    {
        
        public BangGoTat()
        {
            InitializeComponent();
            this.LoadData();
            this.Hide();
            IsChanged = false;
           
        }
        private string line;
        private string tuviettat;       //vn
        private string tuduocviettat;   //việt nam
        private bool IsChanged;
        private string UserShortcutWordFilePath = Application.StartupPath + @"\GoTat.txt";
        private void LoadData()
        {
            if(File.Exists(UserShortcutWordFilePath) == false)
            {
                File.WriteAllText(UserShortcutWordFilePath, "");
            }
            StreamReader streamReader = new StreamReader(UserShortcutWordFilePath);   
            while ((line = streamReader.ReadLine()) != null)
            {
                tuviettat = line;
                tuduocviettat = streamReader.ReadLine();
                DataGridViewRowCollection row = this.dataGridViewBanggotat.Rows;
                object[] viettat = new object[] { tuviettat, tuduocviettat };
                row.Add(viettat);
            }
            streamReader.Close();
        }
        public void SaveChange()
        {
            if (this.IsChanged == true)
            {
                if (File.Exists(UserShortcutWordFilePath) == false)
                {
                    File.WriteAllText(UserShortcutWordFilePath, "");
                }
                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\Gotat.txt");
                int i = 0;
                while (i < this.dataGridViewBanggotat.Rows.Count)
                {
                    tuviettat = this.dataGridViewBanggotat[0, i].Value.ToString();
                    tuduocviettat = this.dataGridViewBanggotat[1, i].Value.ToString();
                    streamWriter.WriteLine(tuviettat);
                    streamWriter.WriteLine(tuduocviettat);
                    i++;
                }
                streamWriter.Flush();
                streamWriter.Close();
            }
        }
        
        private void ClearText()
        {
            this.metroTextBoxTuduocviettat.Clear();
            this.metroTextBoxTuviettat.Clear();
        }
        private bool CheckContent()
        {
            if (this.metroTextBoxTuduocviettat.Text == "" || this.metroTextBoxTuviettat.Text == "")
            {
                MessageBox.Show("Bạn phải nhập cả hai ô !!", "Lỗi");
                return false;
            }
            int i = 0;
            while (i < this.metroTextBoxTuviettat.Text.Length)
            {
                if (this.metroTextBoxTuviettat.Text[i] == ' ')
                {
                    MessageBox.Show("Từ viết tắt không được chứa khoảng trắng !!", "Lỗi");
                    return false;
                }
                i++;
            }
            return true;
        }
        private void metroButtonThem_Click(object sender, EventArgs e)
        {
            this.metroTextBoxTuviettat.Text = this.metroTextBoxTuviettat.Text.ToLower();
            if (this.CheckContent())
            {
                int i = 0;
                while (i < this.dataGridViewBanggotat.Rows.Count)
                {
                    if (this.dataGridViewBanggotat[0, i].Value.ToString() == this.metroTextBoxTuviettat.Text)
                    {
                        MessageBox.Show("Định nghĩa gõ tắt này đã tồn tại !!", "Lỗi");
                        return;
                    }
                    i++;
                }
                DataGridViewRowCollection row = this.dataGridViewBanggotat.Rows;
                object[] viettat = new object[] { this.metroTextBoxTuviettat.Text.ToLower(), this.metroTextBoxTuduocviettat.Text };
                row.Add(viettat);
                this.ClearText();
                this.IsChanged = true;
            }
        }

        private void metroButtonXoa_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewBanggotat.SelectedCells.Count != 1)
                MessageBox.Show("Bạn phải chọn từ cần xóa !!", "Lỗi");
            else
            {
                this.dataGridViewBanggotat.Rows.RemoveAt(this.dataGridViewBanggotat.SelectedCells[0].RowIndex);
                this.IsChanged = true;
            }
        }

        private void dataGridViewBanggotat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                this.metroTextBoxTuviettat.Text = this.dataGridViewBanggotat[0, e.RowIndex].Value.ToString();
                this.metroTextBoxTuduocviettat.Text = this.dataGridViewBanggotat[1, e.RowIndex].Value.ToString();
            }
        }

        private void metroButtonSua_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewBanggotat.SelectedCells.Count != 1)
            {
                MessageBox.Show("Bạn phải chọn từ cần sửa !!", "Lỗi");
                return;
            }
            this.metroTextBoxTuviettat.Text = this.metroTextBoxTuviettat.Text.ToLower();
            if (this.CheckContent())
            {
                int i = 0;
                while (i < this.dataGridViewBanggotat.Rows.Count)
                {
                    if (this.dataGridViewBanggotat.SelectedCells[0].RowIndex != i && this.dataGridViewBanggotat[0, i].Value.ToString() == this.metroTextBoxTuviettat.Text)
                    {
                        MessageBox.Show("Định nghĩa gõ tắt này đã tồn tại !!", "Lỗi");
                        return;
                    }
                    i++;
                }
                this.dataGridViewBanggotat[0, this.dataGridViewBanggotat.SelectedCells[0].RowIndex].Value = this.metroTextBoxTuviettat.Text.ToLower();
                this.dataGridViewBanggotat[1, this.dataGridViewBanggotat.SelectedCells[0].RowIndex].Value = this.metroTextBoxTuduocviettat.Text;
                this.ClearText();
                this.IsChanged = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
