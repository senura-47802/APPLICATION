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
    public partial class Sudent_regestration : Form
    {
        public Sudent_regestration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mainmenu ob = new Mainmenu();
            this.Hide();
            ob.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmemberid.Text = "";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtaddress.Text = "";
            txtcontactnumber.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString, commandString;
            connectionString = "Data Source=LAPTOP-G9COF22H/SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "INSERT INTO student (ID,firstname,lastname,address,contact_no) Values ('" + txtmemberid.Text + "','" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtaddress.Text + "','" + txtcontactnumber.Text + "')";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Added Succesfully");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
        String connectionString, commandString;
            connectionString = "Data Source=LAPTOP-G9COF22H/SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "Delete from student where ID= '" + txtmemberid.Text + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Deleted Succesfully");

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String connectionString, commandString;
            connectionString = "Data Source=LAPTOP-G9COF22H/SQLEXPRESS;Initial Catalog=Melody;Integrated Security=True";
            commandString = "Update student set contact_no= '" + txtcontactnumber.Text + "' where ID= '" + txtmemberid.Text + "'";
            commandString = "Update student set address= '" + txtaddress.Text + "' where ID= '" + txtmemberid.Text + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Updated Succesfully!");
        }
    }
}
