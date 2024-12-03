using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {

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
