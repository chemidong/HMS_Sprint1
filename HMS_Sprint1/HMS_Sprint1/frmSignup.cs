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
        private SQLiteDataReader DB;
        private String dbPath;
        public frmSignup()
        {
            InitializeComponent();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            String Query;
            dbPath = System.IO.Directory.GetCurrentDirectory() + @"\DB\DB.db";
            sql_con = new SQLiteConnection("Data Source=" + dbPath);
            sql_cmd.Connection = sql_con;
            sql_cmd.Connection.Open();
            Query = "DROP TABLE reservation";
            sql_cmd.CommandText = Query;
            sql_cmd.ExecuteNonQuery();
            Query = "CREATE TABLE reservation (id INTEGER, roomID INTEGER, sdate TEXT, edate TEXT, userID TEXT)";
            sql_cmd.CommandText = Query;
            sql_cmd.ExecuteNonQuery();
            sql_cmd.Connection.Close();
            //sql_con = new SQLiteConnection("Data Source=" + dbPath);
            //sql_cmd.Connection = sql_con;
            //sql_cmd.Connection.Open();
            //Query = "Insert into room (id, type, cost, state) VALUES (0,0,50000,0)";
            //sql_cmd.CommandText = Query;
            //sql_cmd.ExecuteNonQuery();
            //Query = "Insert into room (id, type, cost, state) VALUES (1,0,50000,0)";
            //sql_cmd.CommandText = Query;
            //sql_cmd.ExecuteNonQuery();
            //Query = "Insert into room (id, type, cost, state) VALUES (2,1,100000,0)";
            //sql_cmd.CommandText = Query;
            //sql_cmd.ExecuteNonQuery();
            //Query = "Insert into room (id, type, cost, state) VALUES (3,1,100000,0)";
            //sql_cmd.CommandText = Query;
            //sql_cmd.ExecuteNonQuery();
            //sql_cmd.Connection.Close();
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Trim() == "" || txtEmail.Text.Trim()=="" || txtName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please Input All Information.");
            }
            else
            {
                String Query;
                //SQLiteConnection.CreateFile(System.IO.Directory.GetCurrentDirectory() + @"\DB\DB.db");
                sql_con = new SQLiteConnection("Data Source=" + dbPath);
                sql_cmd = new SQLiteCommand("select * from user", sql_con);
                sql_cmd.Connection.Open();
                bool d = false;
                try
                {
                    DB = sql_cmd.ExecuteReader();
                    while (DB.Read())
                    {
                        string id = (string)DB["id"];
                        if (txtID.Text.Trim() == id)
                        {
                            d = true;
                            break;
                        }
                    }
                }
                finally
                {
                    DB.Close();
                }
                if (d)
                {
                    MessageBox.Show("Your ID already exists");
                }
                else
                {
                    Query = "Insert into user (id, pwd, name, email, count, coupon) VALUES ('" + txtID.Text.Trim() + "','" + txtPassword.Text.Trim() + "','" + txtName.Text.Trim() + "','" + txtEmail.Text.Trim() + "',0, 0);";
                    sql_cmd.CommandText = Query;
                    sql_cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Registered!");
                    this.Close();
                }
                sql_cmd.Connection.Close();
            }
        }
    }
}
