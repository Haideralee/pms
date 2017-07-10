using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace pms
{
    public class database
    {

        public SqlConnection con = new SqlConnection();

        public void conString()
        {
            if (con.State == ConnectionState.Open) con.Close();
            con.ConnectionString = @"Server=.\;AttachDbFilename=|DataDirectory|pms.mdf;Database=pms;Trusted_Connection=Yes;MultipleActiveResultSets=true;";
        }

    }
}
