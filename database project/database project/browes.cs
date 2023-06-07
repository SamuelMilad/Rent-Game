using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_project
{
    public partial class browes : Form
    {
        public browes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
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
    }
}
