using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnloging_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            if (username == "senura" && password == "081205")
            {
                Mainmenu ob = new Mainmenu();
                ob.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login!");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            this.Hide();
            ob.Show();
        }
    }
}
