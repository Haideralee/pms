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

namespace pms
{
    public partial class Login : Form
    {
        public database db = new database();
        public static string storeAdminstratorID = "";
        public static string storeManagerID = "";
        public static string storeEmployeeID = "";

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "PMS Login";
            this.textBox1.Focus();
            this.AcceptButton = this.button1;
            this.CancelButton = this.button2;
            this.textBox2.PasswordChar = 'X';
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            /*
            this.textBox1.Text = "admin@admin.com";
            this.textBox2.Text = "admin";
            this.comboBox1.SelectedIndex = 0;
            */

            /*
            this.textBox1.Text = "haider@gmail.com";
            this.textBox2.Text = "123";
            this.comboBox1.SelectedIndex = 1;
            */

            ///*
            this.textBox1.Text = "ali@gmail.com";
            this.textBox2.Text = "123";
            this.comboBox1.SelectedIndex = 1;
            //*/

            /*
            this.textBox1.Text = "saqib@gmail.com";
            this.textBox2.Text = "123";
            this.comboBox1.SelectedIndex = 2;
            */

            /*
            this.textBox1.Text = "ammar@gmail.com";
            this.textBox2.Text = "123";
            this.comboBox1.SelectedIndex = 2;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        void login() {

            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from users where email='" + this.textBox1.Text + "' AND password='" + this.textBox2.Text + "' AND role='" + this.comboBox1.Text + "';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (this.comboBox1.Text == "Administrator") {
                    storeAdminstratorID = dr["id"].ToString();
                    this.Hide();
                    Administrator_panel admin = new Administrator_panel();
                    admin.Show();
                }
                else if(this.comboBox1.Text == "Manager")
                {
                    storeManagerID = dr["id"].ToString();
                    //storeEmployeeID = dr["id"].ToString();
                    this.Hide();
                    ManagerPanel mp = new ManagerPanel();
                    mp.Show();
                }
                else if (this.comboBox1.Text == "Employee")
                {
                    storeEmployeeID = dr["id"].ToString();
                    //storeEmployeeID = dr["id"].ToString();
                    this.Hide();
                    EmployeePanel emp = new EmployeePanel();
                    emp.Show();
                }
            }
            else MessageBox.Show("Please make sure your are putting correct information.");
            db.con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
