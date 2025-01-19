using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelRegistrationSystem.form
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        Sql connection = new Sql();

        private void veriler()
        {
            listView1.Items.Clear();
            SqlCommand sqlCommand = new SqlCommand("Select * from TblAlınanÜrünler", connection.sqlConnection());
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(); 
                item.Text = dataReader.GetString(0);
                item.SubItems.Add(dataReader.GetString(1).ToString());
                item.SubItems.Add(dataReader.GetString(2).ToString());
                listView1.Items.Add(item);
            }
            connection.sqlConnection().Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kommand = new SqlCommand("insert into TblAlınanÜrünler(Gıda,Icecek,Cerezler) values(@p1,@p2,@p3)", connection.sqlConnection());
            kommand.Parameters.AddWithValue("@p1", txtGidalar.Text.Trim());
            kommand.Parameters.AddWithValue("@p2", txtIcecekler.Text.Trim());
            kommand.Parameters.AddWithValue("@p3", txtAtistirmaliklar.Text.Trim());
            kommand.ExecuteNonQuery();
            connection.sqlConnection().Close();
            MessageBox.Show("Ürün raporu eklendi", "Başarılı kayıt", MessageBoxButtons.OK);
        }
    }
}
