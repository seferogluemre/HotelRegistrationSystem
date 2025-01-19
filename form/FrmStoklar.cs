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

        }
    }
}
