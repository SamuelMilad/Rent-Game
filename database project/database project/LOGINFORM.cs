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

namespace database_project
{
    public partial class LOGINFORM : Form
    {
        SqlConnection con;
        
        public LOGINFORM()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=DESKTOP-OPHR8RM;Initial Catalog=FRMORCOUS;Integrated Security=True";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(160, 20, 0, 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           ;

                this.Hide();
                browes add = new browes();
                add.Show();
            }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

    private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("Admin_login", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@uname", textBox1.Text);
                    cmd.Parameters.AddWithValue("@upass", textBox2.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        this.Hide();
                        MessageBox.Show("nice  Login");

                    }
                    else
                    {
                        MessageBox.Show("ERROR Login");
                    }
                }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void LOGINFORM_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.hide();
            sign_in_user add = new sign_in_user();
            add.Show()
        }
    }
