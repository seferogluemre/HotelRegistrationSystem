namespace HotelRegistrationSystem.form
{
    partial class FrmGelirGide
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtPerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPersonelMaaş = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblGıda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblIçecek = new System.Windows.Forms.Label();
            this.LblAtistirmalık = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasadaki toplam tutar:";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Location = new System.Drawing.Point(221, 36);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(27, 21);
            this.LblTotalPrice.TabIndex = 1;
            this.LblTotalPrice.Text = "TL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(495, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtPerson
            // 
            this.TxtPerson.Location = new System.Drawing.Point(479, 33);
            this.TxtPerson.Name = "TxtPerson";
            this.TxtPerson.Size = new System.Drawing.Size(190, 29);
            this.TxtPerson.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Sayısı:";
            // 
            // LblPersonelMaaş
            // 
            this.LblPersonelMaaş.AutoSize = true;
            this.LblPersonelMaaş.Location = new System.Drawing.Point(221, 93);
            this.LblPersonelMaaş.Name = "LblPersonelMaaş";
            this.LblPersonelMaaş.Size = new System.Drawing.Size(27, 21);
            this.LblPersonelMaaş.TabIndex = 6;
            this.LblPersonelMaaş.Text = "TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Personel Maaşları";
            // 
            // LblGıda
            // 
            this.LblGıda.AutoSize = true;
            this.LblGıda.Location = new System.Drawing.Point(244, 161);
            this.LblGıda.Name = "LblGıda";
            this.LblGıda.Size = new System.Drawing.Size(27, 21);
            this.LblGıda.TabIndex = 8;
            this.LblGıda.Text = "TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Alınan ürünlerin toplamı:";
            // 
            // LblIçecek
            // 
            this.LblIçecek.AutoSize = true;
            this.LblIçecek.Location = new System.Drawing.Point(325, 161);
            this.LblIçecek.Name = "LblIçecek";
            this.LblIçecek.Size = new System.Drawing.Size(27, 21);
            this.LblIçecek.TabIndex = 9;
            this.LblIçecek.Text = "TL";
            // 
            // LblAtistirmalık
            // 
            this.LblAtistirmalık.AutoSize = true;
            this.LblAtistirmalık.Location = new System.Drawing.Point(406, 161);
            this.LblAtistirmalık.Name = "LblAtistirmalık";
            this.LblAtistirmalık.Size = new System.Drawing.Size(27, 21);
            this.LblAtistirmalık.TabIndex = 10;
            this.LblAtistirmalık.Text = "TL";
            // 
            // FrmGelirGide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 512);
            this.Controls.Add(this.LblAtistirmalık);
            this.Controls.Add(this.LblIçecek);
            this.Controls.Add(this.LblGıda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblPersonelMaaş);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPerson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmGelirGide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir Giderler";
            this.Load += new System.EventHandler(this.FrmGelirGide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPersonelMaaş;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblGıda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblIçecek;
        private System.Windows.Forms.Label LblAtistirmalık;
    }
}