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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmemberid.Text = "";
            txtfirstname.Text = "";
            txtsurname.Text = "";
            txtamount.Text = "";
            txtpaymenttype.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Mainmenu ob = new Mainmenu();
            this.Hide();
            ob.Show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String connectionString, commandString;
            connectionString = "Data Source=LAPTOP-G9COF22H//SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "INSERT INTO Payments (ID,firstname,surname,amount,payment type) Values ('" + txtmemberid.Text + "','" + txtfirstname.Text + "','" + txtsurname.Text + "','" + txtamount.Text + "','" + txtpaymenttype.Text + "')";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Paid Succesfully!...");
           
        }
    }
}
