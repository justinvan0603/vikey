namespace ViKey
{
    partial class BangGoTat
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
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroButtonXoa = new MetroFramework.Controls.MetroButton();
            this.metroButtonThem = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxTuduocviettat = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxTuviettat = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewBanggotat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButtonSua = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanggotat)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(108, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(104, 62);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(133, 23);
            this.htmlLabel2.TabIndex = 13;
            this.htmlLabel2.Text = "Cụm từ được viết tắt";
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(59, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(23, 63);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 12;
            this.htmlLabel1.Text = "Từ viết tắt";
            // 
            // metroButtonXoa
            // 
            this.metroButtonXoa.Location = new System.Drawing.Point(402, 116);
            this.metroButtonXoa.Name = "metroButtonXoa";
            this.metroButtonXoa.Size = new System.Drawing.Size(75, 23);
            this.metroButtonXoa.TabIndex = 11;
            this.metroButtonXoa.Text = "Xóa";
            this.metroButtonXoa.UseSelectable = true;
            this.metroButtonXoa.Click += new System.EventHandler(this.metroButtonXoa_Click);
            // 
            // metroButtonThem
            // 
            this.metroButtonThem.Location = new System.Drawing.Point(402, 87);
            this.metroButtonThem.Name = "metroButtonThem";
            this.metroButtonThem.Size = new System.Drawing.Size(75, 23);
            this.metroButtonThem.TabIndex = 10;
            this.metroButtonThem.Text = "Thêm";
            this.metroButtonThem.UseSelectable = true;
            this.metroButtonThem.Click += new System.EventHandler(this.metroButtonThem_Click);
            // 
            // metroTextBoxTuduocviettat
            // 
            this.metroTextBoxTuduocviettat.Lines = new string[0];
            this.metroTextBoxTuduocviettat.Location = new System.Drawing.Point(104, 87);
            this.metroTextBoxTuduocviettat.MaxLength = 32767;
            this.metroTextBoxTuduocviettat.Name = "metroTextBoxTuduocviettat";
            this.metroTextBoxTuduocviettat.PasswordChar = '\0';
            this.metroTextBoxTuduocviettat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTuduocviettat.SelectedText = "";
            this.metroTextBoxTuduocviettat.Size = new System.Drawing.Size(276, 23);
            this.metroTextBoxTuduocviettat.TabIndex = 8;
            this.metroTextBoxTuduocviettat.UseSelectable = true;
            // 
            // metroTextBoxTuviettat
            // 
            this.metroTextBoxTuviettat.Lines = new string[0];
            this.metroTextBoxTuviettat.Location = new System.Drawing.Point(23, 87);
            this.metroTextBoxTuviettat.MaxLength = 32767;
            this.metroTextBoxTuviettat.Name = "metroTextBoxTuviettat";
            this.metroTextBoxTuviettat.PasswordChar = '\0';
            this.metroTextBoxTuviettat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTuviettat.SelectedText = "";
            this.metroTextBoxTuviettat.Size = new System.Drawing.Size(75, 23);
            this.metroTextBoxTuviettat.TabIndex = 7;
            this.metroTextBoxTuviettat.UseSelectable = true;
            // 
            // dataGridViewBanggotat
            // 
            this.dataGridViewBanggotat.AllowUserToAddRows = false;
            this.dataGridViewBanggotat.AllowUserToDeleteRows = false;
            this.dataGridViewBanggotat.AllowUserToResizeColumns = false;
            this.dataGridViewBanggotat.AllowUserToResizeRows = false;
            this.dataGridViewBanggotat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBanggotat.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewBanggotat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBanggotat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanggotat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewBanggotat.Location = new System.Drawing.Point(23, 128);
            this.dataGridViewBanggotat.MultiSelect = false;
            this.dataGridViewBanggotat.Name = "dataGridViewBanggotat";
            this.dataGridViewBanggotat.ReadOnly = true;
            this.dataGridViewBanggotat.RowHeadersVisible = false;
            this.dataGridViewBanggotat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewBanggotat.Size = new System.Drawing.Size(357, 210);
            this.dataGridViewBanggotat.TabIndex = 14;
            this.dataGridViewBanggotat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBanggotat_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "Từ viết tắt";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cụm từ được viết tắt";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // metroButtonSua
            // 
            this.metroButtonSua.Location = new System.Drawing.Point(402, 145);
            this.metroButtonSua.Name = "metroButtonSua";
            this.metroButtonSua.Size = new System.Drawing.Size(75, 23);
            this.metroButtonSua.TabIndex = 15;
            this.metroButtonSua.Text = "Sửa";
            this.metroButtonSua.UseSelectable = true;
            this.metroButtonSua.Click += new System.EventHandler(this.metroButtonSua_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(402, 174);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "Thoát";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // BangGoTat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 361);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButtonSua);
            this.Controls.Add(this.dataGridViewBanggotat);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.metroButtonXoa);
            this.Controls.Add(this.metroButtonThem);
            this.Controls.Add(this.metroTextBoxTuduocviettat);
            this.Controls.Add(this.metroTextBoxTuviettat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BangGoTat";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Bảng gõ tắt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanggotat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton metroButtonXoa;
        private MetroFramework.Controls.MetroButton metroButtonThem;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTuduocviettat;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTuviettat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private MetroFramework.Controls.MetroButton metroButtonSua;
        private MetroFramework.Controls.MetroButton metroButton1;
        public System.Windows.Forms.DataGridView dataGridViewBanggotat;
    }
}