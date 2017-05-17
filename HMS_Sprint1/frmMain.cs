using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Sprint1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            picLogin.Image =  Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\pic1.jpg");
            this.txtID.Enter += new EventHandler(txtID_Enter);
            this.txtID.Leave += new EventHandler(txtID_Leave);
            txtID_SetText();

            this.txtPassword.Enter += new EventHandler(txtPassword_Enter);
            this.txtPassword.Leave += new EventHandler(txtPassword_Leave);
            txtPassword_SetText();

            butSignin.Focus();
        }
        private void txtID_Enter(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtID.ForeColor = Color.Black;
        }
        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
                txtID_SetText();
        }
        private void txtID_SetText()
        {
            if (txtID.ForeColor == Color.Black)
                return;
            this.txtID.Text = "ID";
            txtID.ForeColor = Color.Gray;
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
                txtPassword_SetText();
        }
        private void txtPassword_SetText()
        {
            this.txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
        }
        private void butSignup_Click(object sender, EventArgs e)
        {
            frmSignup frmSign = new frmSignup();
            frmSign.Show();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
