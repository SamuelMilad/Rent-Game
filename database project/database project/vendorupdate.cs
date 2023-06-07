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
   
    public partial class vendorupdate : Form
    {
        SqlConnection con11;
        SqlCommand cmd11;
        public vendorupdate()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            con11 = new SqlConnection("Data Source=DESKTOP-OPHR8RM;Initial Catalog=FRMORCOUS;Integrated Security=True");
            cmd11 = new SqlCommand("UPDATE GAME SET  CATEGORY=@CAT  ,vendor_name=@vend,PLATEFORM=@PLATE,YEARG=@YEAR,  WHERE GAME_NAME = @GAMENAME", con11);
            cmd11.Parameters.AddWithValue("@GAMENAME", textBox1.Text);
            cmd11.Parameters.AddWithValue("@CAT", textBox2.Text);
            cmd11.Parameters.AddWithValue("@vend", textBox1.Text);
            cmd11.Parameters.AddWithValue("@PLATE", textBox5.Text);
            cmd11.Parameters.AddWithValue("@YEAR", Convert.ToInt32(textBox4.Text));



        }
    }
}
