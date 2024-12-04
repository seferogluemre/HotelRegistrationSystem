using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegistrationSystem.form
{
    public class Sql
    {
        public SqlConnection sqlConnection()
        {
            SqlConnection bgl = new SqlConnection("Data Source=EMRE_SEFEROGLU\\SQLEXPRESS;Initial Catalog=PansiyonSistemi;Integrated Security=True;Encrypt=False");
            bgl.Open();
            return bgl;
        }
    }
}
