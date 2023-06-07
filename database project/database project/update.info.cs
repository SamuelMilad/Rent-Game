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
    public partial class update1 : Form
    {
        SqlConnection con11;
        SqlCommand cmd11;
        public update1()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {

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
            Form add = new Form();
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
            con11 = new SqlConnection("Data Source=DESKTOP-OPHR8RM;Initial Catalog=FRMORCOUS;Integrated Security=True");
            cmd11 = new SqlCommand("UPDATE CLIENT SET FIRST_NAMEC = @FIRST_NAME, SECOND_NAMEC= @SECOND_NAME,EMAILC = @EMAILC,YEARC = @YEARG, PASSWORDC=PASS,DAYC=@day,MONTHC=@month,ADDRESS=@add, WHERE CLIENT_ID = @client", con11);
            cmd11.Parameters.AddWithValue("@client", Convert.ToInt32(maskedTextBox2.Text));
            cmd11.Parameters.AddWithValue("@FIRST_NAME", maskedTextBox1.Text);
  
            cmd11.Parameters.AddWithValue("@SECOND_NAME", textBox1.Text);
            cmd11.Parameters.AddWithValue("@EMAILC", textBox2.Text);
            cmd11.Parameters.AddWithValue("@pass", textBox3.Text);
            cmd11.Parameters.AddWithValue("@YEARc", Convert.ToInt32(maskedTextBox4.Text));
            cmd11.Parameters.AddWithValue("@day", Convert.ToInt32(maskedTextBox3.Text));
            cmd11.Parameters.AddWithValue("@month", Convert.ToInt32(maskedTextBox5.Text));
            cmd11.Parameters.AddWithValue("@add", textBox4.Text);

            con11.Open();
            cmd11.ExecuteNonQuery();
            con11.Close();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
