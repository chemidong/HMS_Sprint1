using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HMS_Sprint1
{
    public partial class frmMain : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd = new SQLiteCommand();
        private SQLiteDataReader DB;
        private String dbPath;
     
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dbPath = System.IO.Directory.GetCurrentDirectory() + @"\DB\DB.db";
            picLogin.Image =  Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\pic1.jpg");

            this.txtPassword.Enter += new EventHandler(txtPassword_Enter);
            this.txtPassword.Leave += new EventHandler(txtPassword_Leave);
            txtPassword_SetText();

            this.txtID.Enter += new EventHandler(txtID_Enter);
            this.txtID.Leave += new EventHandler(txtID_Leave);
            txtID_SetText();

            txtID.Select();

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

        private void butSignin_Click(object sender, EventArgs e)
        {
            sql_con = new SQLiteConnection("Data Source=" + dbPath);
            sql_cmd = new SQLiteCommand("select * from user", sql_con);
            bool login = false;
            try
            {
                sql_cmd.Connection.Open();
                DB = sql_cmd.ExecuteReader();
                while(DB.Read())
                {
                    string id = (string)DB["id"];
                    string passwd = (string)DB["pwd"];
                    if(txtID.Text.Trim() == id && txtPassword.Text.Trim() == passwd)
                    {
                        login = true;
                        break;
                    }
                }
            }
            finally
            {
                DB.Close();
                sql_cmd.Connection.Close();
            }
            if(login)
            {
                frmMain2 frmMain2 = new frmMain2();
                frmMain2.Passvalue = txtID.Text;
                frmMain2.Show();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
