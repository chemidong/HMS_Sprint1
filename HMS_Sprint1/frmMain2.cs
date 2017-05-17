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
    public partial class frmMain2 : Form
    {
        private string form2_value;
        public string Passvalue
        {
            get { return this.form2_value; }
            set { this.form2_value = value;}
        }
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd = new SQLiteCommand();
        private SQLiteDataReader DB;
        private String dbPath;

        private int resN;
        private int resIndex;
        private String[][] arr_date = new String[100][];
        private int[] arr_room = new int[100];
        private int[] arr_resvID = new int[100];
        private String[] roomName = new String[4];
        public frmMain2()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            dbPath = System.IO.Directory.GetCurrentDirectory() + @"\DB\DB.db";
            this.AutoSize = false;
            this.Size = new Size(1270, 920);
            int i;
            for(i=0;i<100;i++)
            {
                arr_date[i] = new String[2];
            }
            roomName[0] = "다현방";
            roomName[1] = "쯔위방";
            roomName[2] = "사나방";
            roomName[3] = "나연방";
        }

        private void butReservation_Click(object sender, EventArgs e)
        {
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //예약 검색 
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button4.Text = "예약";
            button5.Text = "예약";
            button6.Text = "예약";
            button7.Text = "예약";
            DateTime sd = dateTimePicker1.Value.Date;
            DateTime ed = dateTimePicker2.Value.Date;
            String Query;
            //SQLiteConnection.CreateFile(System.IO.Directory.GetCurrentDirectory() + @"\DB\DB.db");
            sql_con = new SQLiteConnection("Data Source=" + dbPath);
            sql_cmd = new SQLiteCommand("select * from reservation", sql_con);
            sql_cmd.Connection.Open();
            try
            {
                DB = sql_cmd.ExecuteReader();
                while (DB.Read())
                {
                    String sdate_ = (String)DB["sdate"];
                    String edate_ = (String)DB["edate"];
                    DateTime sdate = Convert.ToDateTime(sdate_);
                    DateTime edate = Convert.ToDateTime(edate_);
                    int roomID = Convert.ToInt16(DB["roomID"]);
                    if(edate >= sd && sdate <= ed)
                    {
                        if(roomID == 0)
                        {
                            button4.Enabled = false;
                            button4.Text = "예약불가";
                        }   
                        else if(roomID == 1)
                        {
                            button5.Enabled = false;
                            button5.Text = "예약불가";
                        } 
                        else if(roomID == 2)
                        {
                            button6.Enabled = false;
                            button6.Text = "예약불가";
                        }
                        else
                        {
                            button7.Enabled = false;
                            button7.Text = "예약불가";
                        }
                    }
                }
            }
            finally
            {
                DB.Close();
            }
            sql_cmd.Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            pictureBox6.Visible = false;

            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int resvID=0;
            DialogResult dd = MessageBox.Show("결제 하시겠습니까?","트와이스 나연 호텔", MessageBoxButtons.YesNo);
            if(dd == DialogResult.Yes)
            {
                String Query;
                sql_con = new SQLiteConnection("Data Source=" + dbPath);
                sql_cmd.CommandText = "select * from reservation"; 
                sql_cmd.Connection = sql_con;
                sql_cmd.Connection.Open();
                DB = sql_cmd.ExecuteReader();
                while (DB.Read())
                {
                    resvID = Convert.ToInt16(DB["id"]);
                }
                resvID++;
                DB.Close();
                Query = "Insert into reservation (id, roomID, sdate, edate, userID) VALUES (" + resvID.ToString() + ",2,'" + dateTimePicker1.Value.Date.ToString() + "','" + dateTimePicker2.Value.Date.ToString() + "','" + Passvalue + "');";
                sql_cmd.CommandText = Query;
                sql_cmd.ExecuteNonQuery();
                sql_cmd.Connection.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int resvID = 0;
            DialogResult dd = MessageBox.Show("결제 하시겠습니까?", "트와이스 나연 호텔", MessageBoxButtons.YesNo);
            if (dd == DialogResult.Yes)
            {
                String Query;
                sql_con = new SQLiteConnection("Data Source=" + dbPath);
                sql_cmd.CommandText = "select * from reservation";
                sql_cmd.Connection = sql_con;
                sql_cmd.Connection.Open();
                DB = sql_cmd.ExecuteReader();
                while (DB.Read())
                {
                    resvID = Convert.ToInt16(DB["id"]);
                }
                resvID++;
                DB.Close();
                Query = "Insert into reservation (id, roomID, sdate, edate, userID) VALUES (" + resvID.ToString() + ",3,'" + dateTimePicker1.Value.Date.ToString() + "','" + dateTimePicker2.Value.Date.ToString() + "','" + Passvalue + "');";
                sql_cmd.CommandText = Query;
                sql_cmd.ExecuteNonQuery();
                sql_cmd.Connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int resvID = 0;
            DialogResult dd = MessageBox.Show("결제 하시겠습니까?", "트와이스 나연 호텔", MessageBoxButtons.YesNo);
            if (dd == DialogResult.Yes)
            {
                String Query;
                sql_con = new SQLiteConnection("Data Source=" + dbPath);
                sql_cmd.CommandText = "select * from reservation";
                sql_cmd.Connection = sql_con;
                sql_cmd.Connection.Open();
                DB = sql_cmd.ExecuteReader();
                while (DB.Read())
                {
                    resvID = Convert.ToInt16(DB["id"]);
                }
                resvID++;
                DB.Close();
                Query = "Insert into reservation (id, roomID, sdate, edate, userID) VALUES (" + resvID.ToString() + ",0,'" + dateTimePicker1.Value.Date.ToString() + "','" + dateTimePicker2.Value.Date.ToString() + "','" + Passvalue + "');";
                sql_cmd.CommandText = Query;
                sql_cmd.ExecuteNonQuery();
                sql_cmd.Connection.Close();
            }
        }
        private void setinfo(int index)
        {
            if(resN >0)
            {
                textBox10.Text = roomName[arr_room[index]];
                textBox11.Text = arr_date[index][0] + " ~ " + arr_date[index][1];
            }
            else
            {
                textBox10.Text = "예약된 방이";
                textBox11.Text = "없어요 ㅡㅡ";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int resvID = 0;
            DialogResult dd = MessageBox.Show("결제 하시겠습니까?", "트와이스 나연 호텔", MessageBoxButtons.YesNo);
            if (dd == DialogResult.Yes)
            {
                String Query;
                sql_con = new SQLiteConnection("Data Source=" + dbPath);
                sql_cmd.CommandText = "select * from reservation";
                sql_cmd.Connection = sql_con;
                sql_cmd.Connection.Open();
                DB = sql_cmd.ExecuteReader();
                while (DB.Read())
                {
                    resvID = Convert.ToInt16(DB["id"]);
                }
                resvID++;
                DB.Close();
                Query = "Insert into reservation (id, roomID, sdate, edate, userID) VALUES (" + resvID.ToString() + ",1,'" + dateTimePicker1.Value.Date.ToString() + "','" + dateTimePicker2.Value.Date.ToString() + "','" + Passvalue + "');";
                sql_cmd.CommandText = Query;
                sql_cmd.ExecuteNonQuery();
                sql_cmd.Connection.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
            resN = 0;
            sql_con = new SQLiteConnection("Data Source=" + dbPath);
            sql_cmd.CommandText = "select * from reservation where userID = '" + Passvalue + "'";
            sql_cmd.Connection = sql_con;
            sql_cmd.Connection.Open();
            DB = sql_cmd.ExecuteReader();
            while (DB.Read())
            {
                arr_date[resN][0] = (String)DB["sdate"];
                arr_date[resN][1] = (String)DB["edate"];
                arr_room[resN] = Convert.ToInt16(DB["roomID"]);
                arr_resvID[resN] = Convert.ToInt16(DB["id"]);
                resN++;
            }
            DB.Close();
            sql_cmd.Connection.Close();
            setinfo(0);
            resIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            pictureBox6.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
           if(resIndex>0)
                setinfo(--resIndex);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (resIndex < resN-1)
                setinfo(++resIndex);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sql_con = new SQLiteConnection("Data Source=" + dbPath);
            sql_cmd.Connection = sql_con;
            sql_cmd.Connection.Open();
            sql_cmd.CommandText = "delete from reservation where id = " + arr_resvID[resIndex].ToString();
            sql_cmd.ExecuteNonQuery();

            sql_cmd.CommandText = "select * from reservation where userID = '" + Passvalue + "'";
            DB = sql_cmd.ExecuteReader();
            resN = 0;
            while (DB.Read())
            {
                arr_date[resN][0] = (String)DB["sdate"];
                arr_date[resN][1] = (String)DB["edate"];
                arr_room[resN] = Convert.ToInt16(DB["roomID"]);
                arr_resvID[resN] = Convert.ToInt16(DB["id"]);
                resN++;
            }
            DB.Close();
            sql_cmd.Connection.Close();
            setinfo(0);
            resIndex = 0;
        }
    }
}
