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
    public partial class Administrator_panel : Form
    {
        database db = new database();
        public Administrator_panel()
        {
            InitializeComponent();
        }

        private void Administrator_panel_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Administrator Panel";
            this.tabPage1.Text = "Add Manager";
            this.tabPage2.Text = "Show Manager ";
            this.tabPage3.Text = "Logout";
            this.tabPage4.Text = "Update Manager";
            this.tableLayoutPanel1.CellBorderStyle = this.tableLayoutPanel2.CellBorderStyle =
             this.tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            this.filterTextboxLabel.Enabled = this.filterTextBox.Enabled =
            this.filterButton.Enabled = this.UMEmail.Enabled = this.UMContact.Enabled = 
            this.UMRole.Enabled = false; // tab 2
            this.UMStatusCombobox.SelectedIndex = 0;

        }

        private void addManager_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "" && this.textBox2.Text != "" && this.textBox3.Text != "")
            {
                checkUserInDB();
            }
            else {
                MessageBox.Show("Please Fill ALL Fields First.");
            }
        }

        void addManagerInDB() {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("insert into [users] (name, email, password, role, contact) values"
                                            + "(@name, @email, @password, @role, @contact) ;", db.con);
            cmd.Parameters.AddWithValue("@name", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@email", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@password", this.textBox3.Text);
            cmd.Parameters.AddWithValue("@role", "Manager");
            cmd.Parameters.AddWithValue("@contact", "00000000000");
            cmd.ExecuteNonQuery();
            db.con.Close();
            MessageBox.Show("Data has been entered successfully!");
            clearTab1();
        }

        void checkUserInDB() {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from users where email='" + this.textBox2.Text + "';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) MessageBox.Show("This Email is already add.");
            else addManagerInDB();
            db.con.Close();
        }

        void clearTab1() {
            this.textBox1.Clear(); this.textBox2.Clear(); this.textBox3.Clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clearTab1();
        }

        string filterQuery = "";
        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filterTextBox.Clear(); this.filterStatusComboBox.Visible = false;
            if (this.filterComboBox.Text != "Show All")
            {
                this.filterTextBox.Enabled = this.filterTextboxLabel.Enabled =
                this.filterButton.Enabled = true;
            }

            if (this.filterComboBox.Text == "Show All") {
                filterQuery = "select * from users where role='Manager';";
                this.filterTextBox.Enabled = this.filterTextboxLabel.Enabled = false;
                this.filterButton.Enabled = true;
            }

            if(this.filterComboBox.Text == "Status")
            {
                this.filterStatusComboBox.Visible = true;
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (this.filterComboBox.Text == "Show All" || this.filterComboBox.Text == "Status" || this.filterTextBox.Text != "")
            {
                db.conString();
                db.con.Open();
                //MessageBox.Show(filterQuery);
                //MessageBox.Show(filterTextBox.Text);
                SqlCommand cmd = new SqlCommand(filterQuery, db.con);
                SqlDataReader dr = cmd.ExecuteReader();
                this.ManagerDataGridView.Rows.Clear();
                int count = 0;
                while (dr.Read())
                {
                    //Button btn = new Button();
                    //btn.Text = "Delete";
                    //btn.PerformClick();
                    //btn.Click += new EventHandler(this.button_Dynamic_Click);
                    this.ManagerDataGridView.Rows.Add(dr["name"].ToString(), dr["email"].ToString(), dr["contact"].ToString(), 
                        dr["role"].ToString(), dr["status"].ToString());

                    this.ManagerDataGridView.Columns["Status"].DefaultCellStyle.ForeColor = Color.White;
                    if (dr["status"].ToString() == "Active") this.ManagerDataGridView.Rows[count].Cells[4].Style.BackColor = Color.Green;
                    else this.ManagerDataGridView.Rows[count].Cells[4].Style.BackColor = Color.Red;

                    count++;
                }
                if (this.ManagerDataGridView.Rows.Count <= 0) MessageBox.Show("Manager is not exist.");
                db.con.Close();
            }
            else
            {
                MessageBox.Show("Please Fill Mondatory Field.");
            }
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.filterComboBox.Text == "Name")
            {
                filterQuery = "select * from users where name='" + this.filterTextBox.Text + "' AND role='Manager';";
            }
            else if (this.filterComboBox.Text == "E-mail")
            {
                filterQuery = "select * from users where email='" + this.filterTextBox.Text + "' AND role='Manager';";
            }
            else if (this.filterComboBox.Text == "Contact")
            {
                filterQuery = "select * from users where contact='" + this.filterTextBox.Text + "' AND role='Manager';";
            }
        }

        private void tabIndexChange(object sender, EventArgs e)
        {
            //MessageBox.Show(" " + this.tabControl1.SelectedIndex);
            if(this.tabControl1.SelectedIndex == 3)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else if(this.tabControl1.SelectedIndex == 2)
            {
                fetchAllManager("names");
            }
        }


        /*void PerformClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
            Button button = sender as Button;

            // identify which button was clicked and perform necessary actions
        }*/

        void fetchAllManager(string action) {
            db.conString();
            db.con.Open();
            string updateManagerQuery = "";
            if (action == "names") updateManagerQuery = "select * from users where role='Manager';";
            else updateManagerQuery = "select * from users where role='Manager' AND name='"+ this.UMCombobox.Text + "';";
            SqlCommand cmd = new SqlCommand(updateManagerQuery, db.con);
            //SqlCommand cmd = new SqlCommand("select * from users where role='Manager';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            this.ManagerDataGridView.Rows.Clear();
            if (action == "names") this.UMCombobox.Items.Clear();
            while (dr.Read())
            {
                if(action == "names")
                {
                    this.UMCombobox.Items.Add(dr["name"].ToString());
                }
                else
                {
                    this.UMEmail.Text = dr["email"].ToString();
                    this.UMContact.Text = dr["contact"].ToString();
                    this.UMRole.Text = dr["role"].ToString();
                    if(dr["status"].ToString() == "Active") this.UMStatusCombobox.SelectedIndex = 0;
                    else this.UMStatusCombobox.SelectedIndex = 1;
                }
            }
            db.con.Close();
        }

        private void UMCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchAllManager("all");
        }

        private void UMStatusBtn_Click(object sender, EventArgs e)
        {
            db.con.Open();
            SqlCommand cmd = new SqlCommand("Update users set status = '" + this.UMStatusCombobox.Text + "' where email='"+ this.UMEmail.Text +"';", db.con);
            cmd.ExecuteNonQuery();
            db.con.Close();
            MessageBox.Show("Manager Status is updated!");

            this.UMCombobox.Text = "";
            this.UMCombobox.SelectedIndex = -1;
            this.UMEmail.Clear(); this.UMRole.Clear(); this.UMContact.Clear();
            this.UMStatusCombobox.Text = "";
            this.UMStatusCombobox.SelectedIndex = -1;
        }

        private void UMCancelBtn_Click(object sender, EventArgs e)
        {
            this.UMCombobox.Text = "";
            this.UMCombobox.SelectedIndex = -1;
            this.UMEmail.Clear(); this.UMRole.Clear(); this.UMContact.Clear();
            this.UMStatusCombobox.Text = "";
            this.UMStatusCombobox.SelectedIndex = -1;
        }

        private void filterStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterQuery = "select * from users where status='"+ this.filterStatusComboBox.Text + "' AND role='Manager';";
        }
    }
}
