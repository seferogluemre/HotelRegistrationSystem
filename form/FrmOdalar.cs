using HotelRegistrationSystem.form.Class;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotelRegistrationSystem.form
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }


        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            var odaHandler = new Method();

            // Kontrolleri metoda gönder
            odaHandler.GetCustomerAndRoomsData(this.Controls);
        }
    }
}
