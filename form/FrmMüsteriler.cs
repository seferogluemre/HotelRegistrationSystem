using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelRegistrationSystem.form
{
    public partial class FrmMüsteriler : Form
    {
        public FrmMüsteriler()
        {
            InitializeComponent();
        }

        Sql bgl = new Sql();

        /// <summary>
        /// 
        /// </summary>
        private void DisplayData()
        {
            SqlCommand command = new SqlCommand("select * from MüsteriTable", bgl.sqlConnection());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                if (listView1.Items.Count > 0)
                {
                    MessageBox.Show("Müşteriler zaten gözüküyor");
                    return;
                }
                else
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    // Alt öğeleri ekleyin
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    item.SubItems.Add(dr[3].ToString());
                    item.SubItems.Add(dr[4].ToString());
                    item.SubItems.Add(dr[5].ToString());
                    item.SubItems.Add(dr[6].ToString());
                    item.SubItems.Add(dr[7].ToString());
                    item.SubItems.Add(dr[8].ToString());
                    item.SubItems.Add(dr[9].ToString());
                    item.SubItems.Add(dr[10].ToString());

                    // ListView'e öğeyi ekleyin
                    listView1.Items.Add(item);
                }
            }
            bgl.sqlConnection().Close();
        }


        private void FrmMüsteriler_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
