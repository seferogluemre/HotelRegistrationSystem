using HotelRegistrationSystem.form;
using HotelRegistrationSystem.icons;
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

namespace HotelRegistrationSystem
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        Sql baglantı = new Sql();

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYeniMüşteriEkle frm = new FrmYeniMüşteriEkle();

            if(txtPassword.Text != "" && txtUsername.Text != "")
            {
                SqlCommand komut = new SqlCommand("select * from UsersTable where Username=@username and Password=@password",baglantı.sqlConnection());
                komut.Parameters.AddWithValue("@username", txtUsername.Text);
                komut.Parameters.AddWithValue("@password", txtPassword.Text);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Hoşgeldiniz" + txtUsername.Text, "Giriş Başarılı", MessageBoxButtons.OK);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı tekrar deneyiniz", "Hatalı giriş", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Alanları Kontrol ediniz", "Boş Alan bırakılamaz", MessageBoxButtons.OK);
            }
        }

        /* Şifre gizleme gösterme */
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }
        /* Şifre gizleme gösterme */
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }
    }
}
