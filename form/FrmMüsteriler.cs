using System;
using System.Data;
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
        /// 

        private void ClearAreas()
        {
            TxtId.Clear();
            TxtName.Clear();
            TxtSurname.Clear();
            TxtPrice.Clear();
            TxtPhoneNumber.Clear();
            TxtMail.Clear();
            TxtRoomNo.Clear();
            TxtTcNo.Clear();
            TxtGender.Clear();
            TxtTcSorgu.Clear();
            DateExitPicker.Text = "";
            DateEntryPicker.Text = "";
        }

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


        private void button1_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string selectDataQuery = "select * from MüsteriTable where Customer_Tc=" + TxtTcSorgu.Text;

            SqlCommand selectCommand = new SqlCommand(selectDataQuery, bgl.sqlConnection());
            SqlDataReader dataReader = selectCommand.ExecuteReader();
            if (dataReader.Read())
            {
                TxtId.Text = dataReader[0].ToString();
                TxtName.Text= dataReader[1].ToString();
                TxtSurname.Text = dataReader[2].ToString();
                TxtGender.Text= dataReader[3].ToString();
                TxtPhoneNumber.Text= dataReader[4].ToString(); 
                TxtMail.Text= dataReader[5].ToString();
                TxtTcNo.Text= dataReader[6].ToString();
                TxtRoomNo.Text = dataReader[7].ToString();
                TxtPrice.Text = dataReader[8].ToString();
                DateExitPicker.Text= dataReader[9].ToString();
                DateEntryPicker.Text = dataReader[10].ToString();
            }
            bgl.sqlConnection().Close();
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
                    ClearAreas();
                }
                else if (tepki == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void BtnVeriGüncelleme_Click(object sender, EventArgs e)
        {
            if (TxtId.Text != "")
            {
                string updatedDataQuery = "UPDATE MüsteriTable SET " +
                                          "Customer_Name = @CustomerName, " +
                                          "Customer_Surname = @CustomerSurname, " +
                                          "Customer_Mail = @CustomerEmail, " +
                                          "Customer_PhoneNumber = @CustomerPhone, " +
                                          "Customer_Gender = @CustomerGender, " +
                                          "Customer_Tc = @CustomerTc, " +
                                          "Customer_RoomNo = @CustomerRoomNo, " +
                                          "Customer_Price = @CustomerPrice, " +
                                          "Customer_EntryDate = @CustomerEntryDate, " +
                                          "Customer_ExitDate = @CustomerExitDate " +
                                          "WHERE Customer_Id = @CustomerID";

                SqlCommand command = new SqlCommand(updatedDataQuery, bgl.sqlConnection());

                // Parametreleri ekle
                command.Parameters.AddWithValue("@CustomerName", TxtName.Text);
                command.Parameters.AddWithValue("@CustomerSurname", TxtSurname.Text);
                command.Parameters.AddWithValue("@CustomerEmail", TxtMail.Text);
                command.Parameters.AddWithValue("@CustomerPhone", TxtPhoneNumber.Text);
                command.Parameters.AddWithValue("@CustomerGender", TxtGender.Text);
                command.Parameters.AddWithValue("@CustomerTc", TxtTcNo.Text);
                command.Parameters.AddWithValue("@CustomerRoomNo", TxtRoomNo.Text);
                command.Parameters.AddWithValue("@CustomerPrice", TxtPrice.Text);

                // Tarih parametreleri
                command.Parameters.AddWithValue("@CustomerEntryDate", DateEntryPicker.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@CustomerExitDate", DateExitPicker.Value.ToString("yyyy-MM-dd"));

                // ID parametresi
                command.Parameters.AddWithValue("@CustomerID", int.TryParse(TxtId.Text, out int customerId) ? customerId : 0);

                // Bağlantıyı kontrol et ve aç
                SqlConnection conn = bgl.sqlConnection();
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                // Sorguyu çalıştır
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Müşteri bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güncellenecek müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAreas();
        }
    }
}
