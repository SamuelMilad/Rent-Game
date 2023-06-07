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
    public partial class sign_up_ad : Form
    {
        public sign_up_ad()
        {
            InitializeComponent();
        }

        private void sign_up_ad_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(160, 20, 0, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(160, 20, 0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
           LOGINFORM add = new LOGINFORM();
            add.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-OPHR8RM;Initial Catalog=FRMORCOUS;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO CLIENT Values (" + maskedTextBox2.Text + ",'" + maskedTextBox1.Text + ",'" + textBox1.Text + "' ,'" + textBox2.Text + "',  '" + textBox3.Text + "',  '" + textBox4.Text + "', " + DATE.Text + ",  " + textBox6.Text + ", " + textBox5.Text + " );";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
