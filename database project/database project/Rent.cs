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
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            browse1 add = new browse1();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Return add = new Return();
            add.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            update1 add = new update1();
            add.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            LOGINFORM add = new LOGINFORM();
            add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(160, 20, 0, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-OPHR8RM;Initial Catalog=FRMORCOUS;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO RENT Values (" + textBox2.Text + "," + textBox3.Text + "," + textBox1.Text + "," + textBox2.Text + "," + dateTimePicker1.Value + " );";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
