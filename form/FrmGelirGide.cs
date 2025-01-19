using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRegistrationSystem.form
{
    public partial class FrmGelirGide : Form
    {
        public FrmGelirGide()
        {
            InitializeComponent();
        }
        Sql connection = new Sql();

        private void FrmGelirGide_Load(object sender, EventArgs e)
        {
            //Kasa toplam ücret hesaplama
            SqlCommand komut = new SqlCommand("Select sum(ücret) as toplam from MüsteriTable", connection.sqlConnection());
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                LblTotalPrice.Text = dataReader["toplam"].ToString();
            }
            connection.sqlConnection().Close();

            //Personel maaş hesaplama
            int personel;
            personel = Convert.ToInt16(TxtPerson.Text.Trim());
            LblPersonelMaaş.Text = (personel * 1500).ToString();


            //Gıdaların toplam tutarın hesaplanması
            SqlCommand komut2 = new SqlCommand("Select sum(Gıdalar,Icecekler,Atistirmaliklar) as (t1,t2,t3) from TblAlınanÜrünler", connection.sqlConnection());
            SqlDataReader dataReader2 = komut2.ExecuteReader();
            if (dataReader2.Read())
            {
                LblGıda.Text = dataReader2["t1"].ToString();
                LblIçecek.Text = dataReader2["t2"].ToString();
                LblAtistirmalık.Text = dataReader2["t3"].ToString();
            }
            connection.sqlConnection().Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }
    }
}
