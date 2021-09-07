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

namespace WindowsFormsApplication2
{
    public partial class labbooking : Form
    {
        public labbooking()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Mainmenu ob = new Mainmenu();
            this.Hide();
            ob.Show();
        }

        private void btnbook_Click(object sender, EventArgs e)
        {
            String connectionString, commandString;
            connectionString ="Data Source=LAPTOP-G9COF22H/SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "INSERT INTO practicalbooking (ID,fullname,booking_date,bookin_time) Values ('" + txtMember_ID.Text + "','" + txtFullname.Text + "'," + txtbooking_date.Text + "','" + txtbooking_time.Text + "')";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Added Succesfully!..");
        }
    }
}
