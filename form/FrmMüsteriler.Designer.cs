namespace HotelRegistrationSystem.form
{
    partial class FrmMüsteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMüsteriler));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnVerileriGoster = new System.Windows.Forms.Button();
            this.BtnVerileriSil = new System.Windows.Forms.Button();
            this.BtnVeriGüncelleme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtTcSorgu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtRoomNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTcNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DateEntryPicker = new System.Windows.Forms.DateTimePicker();
            this.DateExitPicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 255);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1033, 197);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 59;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cinsiyet";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon No";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 83;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tc Kimlik No";
            this.columnHeader7.Width = 117;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Oda No";
            this.columnHeader8.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Fiyat";
            this.columnHeader9.Width = 78;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Giriş Tarihi";
            this.columnHeader10.Width = 112;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Çıkış Tarihi";
            this.columnHeader11.Width = 112;
            // 
            // BtnVerileriGoster
            // 
            this.BtnVerileriGoster.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnVerileriGoster.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnVerileriGoster.FlatAppearance.BorderSize = 0;
            this.BtnVerileriGoster.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnVerileriGoster.Location = new System.Drawing.Point(883, 10);
            this.BtnVerileriGoster.Name = "BtnVerileriGoster";
            this.BtnVerileriGoster.Size = new System.Drawing.Size(137, 33);
            this.BtnVerileriGoster.TabIndex = 1;
            this.BtnVerileriGoster.Text = "Verileri göster";
            this.BtnVerileriGoster.UseVisualStyleBackColor = false;
            this.BtnVerileriGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnVerileriSil
            // 
            this.BtnVerileriSil.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnVerileriSil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnVerileriSil.FlatAppearance.BorderSize = 0;
            this.BtnVerileriSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnVerileriSil.Location = new System.Drawing.Point(883, 53);
            this.BtnVerileriSil.Name = "BtnVerileriSil";
            this.BtnVerileriSil.Size = new System.Drawing.Size(137, 33);
            this.BtnVerileriSil.TabIndex = 2;
            this.BtnVerileriSil.Text = "Verileri Sil";
            this.BtnVerileriSil.UseVisualStyleBackColor = false;
            this.BtnVerileriSil.Click += new System.EventHandler(this.BtnVerileriSil_Click);
            // 
            // BtnVeriGüncelleme
            // 
            this.BtnVeriGüncelleme.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnVeriGüncelleme.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnVeriGüncelleme.FlatAppearance.BorderSize = 0;
            this.BtnVeriGüncelleme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnVeriGüncelleme.Location = new System.Drawing.Point(883, 92);
            this.BtnVeriGüncelleme.Name = "BtnVeriGüncelleme";
            this.BtnVeriGüncelleme.Size = new System.Drawing.Size(137, 33);
            this.BtnVeriGüncelleme.TabIndex = 3;
            this.BtnVeriGüncelleme.Text = "Verileri Güncelle";
            this.BtnVeriGüncelleme.UseVisualStyleBackColor = false;
            this.BtnVeriGüncelleme.Click += new System.EventHandler(this.BtnVeriGüncelleme_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(978, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TxtTcSorgu
            // 
            this.TxtTcSorgu.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTcSorgu.Location = new System.Drawing.Point(792, 190);
            this.TxtTcSorgu.MaxLength = 11;
            this.TxtTcSorgu.Name = "TxtTcSorgu";
            this.TxtTcSorgu.Size = new System.Drawing.Size(180, 33);
            this.TxtTcSorgu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(73, 10);
            this.TxtId.MaxLength = 500;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(164, 29);
            this.TxtId.TabIndex = 8;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(73, 62);
            this.TxtName.MaxLength = 500;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(164, 29);
            this.TxtName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adı:";
            // 
            // TxtGender
            // 
            this.TxtGender.Location = new System.Drawing.Point(73, 165);
            this.TxtGender.MaxLength = 500;
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Size = new System.Drawing.Size(164, 29);
            this.TxtGender.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-4, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cinsiyet:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(73, 113);
            this.TxtSurname.MaxLength = 500;
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(164, 29);
            this.TxtSurname.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tel No:";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(353, 165);
            this.TxtPrice.MaxLength = 500;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(164, 29);
            this.TxtPrice.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fiyat:";
            // 
            // TxtRoomNo
            // 
            this.TxtRoomNo.Location = new System.Drawing.Point(353, 113);
            this.TxtRoomNo.MaxLength = 500;
            this.TxtRoomNo.Name = "TxtRoomNo";
            this.TxtRoomNo.Size = new System.Drawing.Size(164, 29);
            this.TxtRoomNo.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Oda No:";
            // 
            // TxtTcNo
            // 
            this.TxtTcNo.Location = new System.Drawing.Point(353, 62);
            this.TxtTcNo.MaxLength = 500;
            this.TxtTcNo.Name = "TxtTcNo";
            this.TxtTcNo.Size = new System.Drawing.Size(164, 29);
            this.TxtTcNo.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "TC No:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(353, 10);
            this.TxtMail.MaxLength = 500;
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(164, 29);
            this.TxtMail.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(534, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Giriş Tarihi:";
            // 
            // DateEntryPicker
            // 
            this.DateEntryPicker.Location = new System.Drawing.Point(618, 10);
            this.DateEntryPicker.Name = "DateEntryPicker";
            this.DateEntryPicker.Size = new System.Drawing.Size(227, 29);
            this.DateEntryPicker.TabIndex = 26;
            // 
            // DateExitPicker
            // 
            this.DateExitPicker.Location = new System.Drawing.Point(618, 59);
            this.DateExitPicker.Name = "DateExitPicker";
            this.DateExitPicker.Size = new System.Drawing.Size(227, 29);
            this.DateExitPicker.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(534, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "Çıkış Tarihi:";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClear.Location = new System.Drawing.Point(883, 131);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(137, 33);
            this.BtnClear.TabIndex = 29;
            this.BtnClear.Text = "Alanları Temizle";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(74, 214);
            this.TxtPhoneNumber.Mask = "(999) 000-0000";
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(163, 29);
            this.TxtPhoneNumber.TabIndex = 31;
            // 
            // FrmMüsteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 453);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.DateExitPicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DateEntryPicker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtRoomNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtTcNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTcSorgu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnVeriGüncelleme);
            this.Controls.Add(this.BtnVerileriSil);
            this.Controls.Add(this.BtnVerileriGoster);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMüsteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button BtnVerileriGoster;
        private System.Windows.Forms.Button BtnVerileriSil;
        private System.Windows.Forms.Button BtnVeriGüncelleme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtTcSorgu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtRoomNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTcNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DateEntryPicker;
        private System.Windows.Forms.DateTimePicker DateExitPicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.MaskedTextBox TxtPhoneNumber;
    }
}