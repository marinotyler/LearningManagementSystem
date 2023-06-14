using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherLMSApp
{
    public partial class Form1 : Form
    {
        string user = "teacher";
        string pass = "admin";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.ToLower() == user && txtPass.Text.ToLower() == pass)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect user/pass.\nPlease try again.");
                txtPass.Clear();
                txtUser.Clear();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if (txtUser.Text.ToLower() == user && txtPass.Text.ToLower() == pass)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrect user/pass.\nPlease try again.");
                    txtPass.Clear();
                    txtUser.Clear();
                }
            }
        }
    }
}
