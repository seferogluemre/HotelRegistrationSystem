using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using HotelRegistrationSystem.form;


namespace HotelRegistrationSystem.icons
{
    public partial class FrmYeniMüşteriEkle : Form
    {

        Sql bgl = new Sql();
    
        public FrmYeniMüşteriEkle()
        {
            InitializeComponent();
        }


        private void Btn101_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "101";
        }

        private void Btn102_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "102";
        }

        private void Btn103_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "103";
        }

        private void Btn104_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "104";
        }

        private void Btn105_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "105";
        }

        private void Btn106_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "106";
        }

        private void Btn107_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "107";
        }

        private void Btn108_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "108";
        }

        private void Btn109_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "109";
        }

        private void Btn110_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "110";
        }

        private void Btn111_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "111";
        }

        private void Btn112_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "112";
        }

        private void Btn113_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "113";
        }

        private void Btn114_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "114";
        }

        private void Btn115_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "115";
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar dolu odaları gösterir","Mesaj");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar boş odaları gösterir","Mesaj");
        }

        private void DateExıt_ValueChanged(object sender, EventArgs e)
        {
            int price = 0;
            DateTime smallDate = Convert.ToDateTime(DateEntrance.Text);
            DateTime bigDate = Convert.ToDateTime(DateExıt.Text);

            TimeSpan result = bigDate - smallDate;

            label11.Text = result.TotalDays.ToString() + " Gün Kalıcaksınız.";
            label11.Visible = true;

            // Gün sayısını kullanarak fiyat hesapla
            price = Convert.ToInt32(result.TotalDays) * 50;
            TxtPrice.Text = price.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand Komut = new SqlCommand("insert into MüsteriTable (Customer_Name, Customer_Surname, Customer_Gender, Customer_PhoneNumber, Customer_Mail, Customer_Tc, Customer_RoomNo, Customer_Price, Customer_EntryDate, Customer_ExitDate) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.sqlConnection());

            // Parametreleri ekleyin
            Komut.Parameters.AddWithValue("@p1", TxtName.Text);
            Komut.Parameters.AddWithValue("@p2", TxtSurname.Text);
            Komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            Komut.Parameters.AddWithValue("@p4", MskPhoneNmber.Text);
            Komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            Komut.Parameters.AddWithValue("@p6", TxtTcNo.Text);
            Komut.Parameters.AddWithValue("@p7", TxtRoomNo.Text);
            Komut.Parameters.AddWithValue("@p8", TxtPrice.Text);

            DateTime entryDate, exitDate;
            if (DateTime.TryParse(DateEntrance.Text, out entryDate) && DateTime.TryParse(DateExıt.Text, out exitDate))
            {
                Komut.Parameters.AddWithValue("@p9", entryDate);
                Komut.Parameters.AddWithValue("@p10", exitDate);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tarih formatı girin.");
                return; // Hata durumunda işlemi durdurun
            }

            Komut.ExecuteNonQuery();
            bgl.sqlConnection().Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");
        }
    }
}
