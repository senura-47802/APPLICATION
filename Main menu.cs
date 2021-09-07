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
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            this.Hide();
            ob.Show();
        }

        private void btnpayments_Click(object sender, EventArgs e)
        {
            Payments ob = new Payments();
            ob.Show();
            this.Hide();
        }

        private void btnstudentregistration_Click(object sender, EventArgs e)
        {
            Sudent_regestration ob = new Sudent_regestration();
            ob.Show();
            this.Hide();
        }

        private void btncources_Click(object sender, EventArgs e)
        {
            Courses ob = new Courses();
            ob.Show();
            this.Hide();
        }

        private void btnlabbooking_Click(object sender, EventArgs e)
        {
            labbooking ob = new labbooking();
            ob.Show();
            this.Hide();
        }
    }
}
