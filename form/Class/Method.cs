using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRegistrationSystem.form.Class
{
    public class Method
    {

        Sql sql = new Sql();
        public void GetCustomerAndRoomsData(Control.ControlCollection controls)
        {
            // SQL sorgusu: Odalar tablosu ile MusteriTable'ı TC'ye göre birleştirme
            string query = @"SELECT O.Oda_No, O.Oda_Durumu, M.Customer_Name, M.Customer_Surname
                         FROM Odalar O
                         LEFT JOIN MüsteriTable M ON O.OdadaKalanKisi_Tc = M.Customer_Tc";

            SqlCommand cmd = new SqlCommand(query, sql.sqlConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string odaNo = reader["Oda_No"].ToString();
                string durum = reader["Oda_Durumu"].ToString();

                // Ad ve Soyadı birleştirme
                string adSoyad = reader["Customer_Name"] != DBNull.Value && reader["Customer_Surname"] != DBNull.Value
                                ? $"{reader["Customer_Name"]} {reader["Customer_Surname"]}"
                                : null;

                Button btnOda =controls.Find($"btn{odaNo}", true).FirstOrDefault() as Button;

                if (btnOda != null)
                {

                    if (durum == "Dolu" && adSoyad != null)
                    {
                        btnOda.Text = $"{odaNo}\n{adSoyad}";
                        btnOda.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        btnOda.Text = odaNo;
                        btnOda.BackColor = Color.LightGreen;
                    }
                }
            }
        }


    }
}
