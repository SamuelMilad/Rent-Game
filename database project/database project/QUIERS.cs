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
    public partial class QUIERS : Form
    {
        public QUIERS()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-OPHR8RM;Initial Catalog=FRMORCOUS;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = " SELECT dbo.CLIENT.FIRSRT_NAMEC, dbo.CLIENT.LAST_NAMEC, dbo.CLIENT.CLIENT_ID, dbo.RENT.RentDate FROM dbo.CLIENT LEFT OUTER JOIN dbo.RENT ON dbo.CLIENT.CLIENT_ID = dbo.RENT.client_id  WHERE(dbo.RENT.RentDate IS NULL)   or (RENT.RentDate <= DATEADD(month, datediff(month, 0, getdate()), 0)); ";
            sqlCommand.ExecuteNonQuery();
        }
    }
}
