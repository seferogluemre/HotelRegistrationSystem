using HotelRegistrationSystem.icons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRegistrationSystem.form
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmYeniMüşteriEkle fr = new FrmYeniMüşteriEkle();
            fr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmOdalar frmOdalar = new FrmOdalar();
            frmOdalar.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmMüsteriler frm = new FrmMüsteriler();
            frm.Show();
        }
    }
}
