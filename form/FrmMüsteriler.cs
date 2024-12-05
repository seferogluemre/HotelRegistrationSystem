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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            /*Seçilen Satırı alıyoruz ve listViewItem degişkenine aktardık */
            ListViewItem listViewItem = listView1.SelectedItems[0];

            TxtId.Text = listView1.SelectedItems[0].Text; // İlk sütun, genellikle ana öğedir (ID).

            TxtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TxtGender.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtPhoneNumber.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTcNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtRoomNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtPrice.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DateEntryPicker.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DateExitPicker.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnVerileriSil_Click(object sender, EventArgs e)
        {
            string deleteDataQuery = "delete  from MüsteriTable where Customer_Id=" + TxtId.Text;
            DialogResult tepki = new DialogResult();

            if (TxtId.Text != "")
            {
                tepki = MessageBox.Show(TxtName.Text + " Adlı Müşteriyi silmek istediginize emin misiniz?", "Silme işlemi", MessageBoxButtons.YesNo);
                if (tepki == DialogResult.Yes)
                {
                    SqlCommand kmt = new SqlCommand(deleteDataQuery, bgl.sqlConnection());
                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Silme işlemi tamamlandı");
                    bgl.sqlConnection().Close();
                    DisplayData();
                }
                else if (tepki == DialogResult.No)
                {
                    return;
                }
            }
        }
    }
}
