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
    public partial class Update : Form
    {
        SqlConnection con11;
        SqlCommand cmd11;
        public Update()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Adding_game add = new Adding_game();
            add.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            LOGINFORM add = new LOGINFORM();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            con11 = new SqlConnection("Data Source=DESKTOP-OPHR8RM;Initial Catalog=FRMORCOUS;Integrated Security=True");
            cmd11 = new SqlCommand("UPDATE GAME SET GAME_NAME = @GAME_NAME, PLATFORM= @PLATFORM,CATEGORY = @CATEGORY,YEARG = @YEARG, vendor_name=@vendor,RATE=@rate, WHERE GAME_ID = @GAMEID", con11);
            cmd11.Parameters.AddWithValue("@GAMEID", Convert.ToInt32(maskedTextBox2.Text));
            cmd11.Parameters.AddWithValue("@GAME_NAME", maskedTextBox3.Text);
            cmd11.Parameters.AddWithValue("@RATE", Convert.ToInt32(maskedTextBox4.Text));
            cmd11.Parameters.AddWithValue("@CATEGORY", textBox7.Text);
            cmd11.Parameters.AddWithValue("@PLATFORM", textBox1.Text);
            cmd11.Parameters.AddWithValue("@vendor", textBox2.Text);
            cmd11.Parameters.AddWithValue("@YEARG", Convert.ToInt32(maskedTextBox5.Text));

            con11.Open();
            cmd11.ExecuteNonQuery();
            con11.Close();
            this.Hide();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
