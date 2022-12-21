using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR_RENTAL_SYSTEM1
{
    public class Connection
    {
        SqlConnection con;
        public Connection()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SANGOLA\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");
            if(con.State==0) con.Open();
        }



        public SqlDataAdapter ExecuteSelectDBQuery(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            
            return da;
        }
    }
}
