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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select sum(ücret) as toplam from MüsteriTable", connection.sqlConnection());
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                LblTotalPrice.Text = dataReader["toplam"].ToString();
            }
            connection.sqlConnection().Close();

            int personel;
            personel = Convert.ToInt16(TxtPerson.Text.Trim());
            LblPersonelMaaş.Text = (personel * 1500).ToString();    
        }
    }
}
