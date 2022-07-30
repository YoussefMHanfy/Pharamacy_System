using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Pharamacy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (admin_txt.Text == "youssef" && pass_txt.Text == "0000")
            {
                this.Hide();

                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                label4.Text = "Your admin or password is wrong ";
            }
        }
    }
}
