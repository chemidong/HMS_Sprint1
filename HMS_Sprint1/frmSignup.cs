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
    public partial class frmSignup : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd = new SQLiteCommand();
        private SQLiteDataAdapter DB;
        private String dbPath;
        public frmSignup()
        {
            InitializeComponent();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            dbPath = System.IO.Directory.GetCurrentDirectory() + @"\DB\DB.db";
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            String Query;
            //SQLiteConnection.CreateFile(System.IO.Directory.GetCurrentDirectory() + @"\DB\DB.db");
            sql_con = new SQLiteConnection("Data Source=" + dbPath);
            sql_cmd.Connection = sql_con;
            sql_cmd.Connection.Open();
            Query = "Insert into user (id, pwd, name, email, count, coupon) VALUES ('" + txtID.Text + "','" + txtPassword.Text + "','" + txtName.Text + "','" + txtEmail.Text + "',0, 0);";
            sql_cmd.CommandText = Query;
            sql_cmd.ExecuteNonQuery();
            sql_cmd.Connection.Clone();
        }
    }
}
