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
    public partial class Return : Form
    {
        SqlConnection con11;
        SqlCommand cmd11;
        public Return()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            browse1 add = new browse1();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Rent add = new Rent();
            add.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            con11 = new SqlConnection("Data Source=DESKTOP-OPHR8RM;Initial Catalog=FRMORCOUS;Integrated Security=True");
            cmd11 = new SqlCommand("UPDATE GAME SET ReturnDate=@date, WHERE gameID = @GAMEID", con11);
            cmd11.Parameters.AddWithValue("@GAMEID", Convert.ToInt32(textBox1.Text));
            cmd11.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());

            con11.Open();
            cmd11.ExecuteNonQuery();
            con11.Close();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
