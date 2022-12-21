using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CAR_RENTAL_SYSTEM1
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SANGOLA\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            try
            {
                //if (Con.State == 0) Con.Open();
                //string query = "select * from UserTbl";
                //SqlDataAdapter da = new SqlDataAdapter(query, Con);
                //SqlCommandBuilder builder = new SqlCommandBuilder(da);
                //var ds = new DataSet();
                //da.Fill(ds);
                //UserDGV.DataSource = ds.Tables[0];

                //if (Con.State == 0) Con.Open();
                string query = "select * from UserTbl";
                //SqlDataAdapter daa = new SqlDataAdapter(query, Con);
                //SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                Connection conncection = new Connection();
                var da = conncection.ExecuteSelectDBQuery(query);
                da.Fill(ds);
                UserDGV.DataSource = ds.Tables[0];
                Con.Close();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Con.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UName.Text==""||Upass.Text=="")
            {
                MessageBox.Show("Missing Detalis");
            }
            else
            {
                try
                {
                   if(Con.State==0)
                    {
                        Con.Open();
                    }                       
                   
                    string query = "insert into UserTbl values('"+ UName.Text + "','" + Upass.Text + "')";
                    SqlCommand cmd= new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User resgistered");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
                finally { Con.Close(); }
            }
        }

      

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
