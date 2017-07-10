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
    public partial class EmployeePanel : Form
    {
        database db = new database();

        public EmployeePanel()
        {
            InitializeComponent();
        }

        private void EmployeePanel_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Employee Panel";
            getTask();
            this.ProfilePtextBox.PasswordChar = 'X';

            this.tabPage1.Text = "Check Tasks";
            this.tabPage2.Text = "Update Task Status";
            this.tabPage3.Text = "Update Profile";
            this.tabPage4.Text = "Logout";

            this.tableLayoutPanel1.CellBorderStyle = this.tableLayoutPanel2.CellBorderStyle =
            this.tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
        }
        private void tabControlindexCh(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 3)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else if (this.tabControl1.SelectedIndex == 0)
            {
                getTask();
            }
            else if (this.tabControl1.SelectedIndex == 1)
            {
                getAllActivty();
            }
            else if (this.tabControl1.SelectedIndex == 2)
            {
                getProfileDate();
            }
        }

        void getTask()
        {

            int TRowIndex = 0;
            int ARowIndex = 0;
            int MRowIndex = 0;
            int PRowIndex = 0;
            this.filterDataGridView.Rows.Clear();

            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from tasks where employeeID='" + Login.storeEmployeeID + "';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SqlCommand mmd = new SqlCommand("select * from users where id='" + dr["managerID"].ToString() + "';", db.con);
                SqlDataReader mr = mmd.ExecuteReader();
                while (mr.Read())
                {
                    //this.dataGridView1.Rows[0].Cells[1].Value = "1";
                    //this.filterDataGridView.Rows[MRowIndex].Cells[2].Value = mr["name"].ToString();
                    this.filterDataGridView.Rows.Add("", "", mr["name"].ToString(), "", "", "", "");

                    MRowIndex++;
                }
                ///////////


                SqlCommand pmd = new SqlCommand("select * from projects where id='" + dr["projectID"].ToString() + "';", db.con);
                SqlDataReader pr = pmd.ExecuteReader();
                while (pr.Read())
                {
                    //this.dataGridView1.Rows[0].Cells[1].Value = "1";
                    this.filterDataGridView.Rows[PRowIndex].Cells[3].Value = pr["name"].ToString();
                    PRowIndex++;
                }
                ///////////


                SqlCommand amd = new SqlCommand("select * from activity where id='" + dr["activityID"].ToString() + "';", db.con);
                SqlDataReader ar = amd.ExecuteReader();
                while (ar.Read())
                {
                    //this.dataGridView1.Rows[0].Cells[1].Value = "1";
                    this.filterDataGridView.Rows[ARowIndex].Cells[0].Value = ar["title"].ToString();
                    this.filterDataGridView.Rows[ARowIndex].Cells[1].Value = ar["des"].ToString();
                    this.filterDataGridView.Rows[ARowIndex].Cells[4].Value = ar["status"].ToString();
                    this.filterDataGridView.Rows[ARowIndex].Cells[5].Value = ar["progress"].ToString();
                    ARowIndex++;
                }

                this.filterDataGridView.Rows[TRowIndex].Cells[6].Value = dr["estimatedDate"].ToString();
                TRowIndex++;
            }
            db.con.Close();
        }

        void getAllActivty()
        {
            this.TNcomboBox.Items.Clear();
            db.conString();
            db.con.Open();


            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from tasks where employeeID='" + Login.storeEmployeeID + "';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                SqlCommand cmdd = new SqlCommand("select * from activity where id='" + dr["activityID"].ToString() + "';", db.con);
                SqlDataReader drr = cmdd.ExecuteReader();
                while (drr.Read())
                {
                    this.TNcomboBox.Items.Add(drr["title"].ToString());
                }

            }
            
            db.con.Close();
        }

        private void TNcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from activity Where title='" + this.TNcomboBox.Text + "';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.TDtextBox.Text = dr["des"].ToString();
                setProgress(dr["progress"].ToString());
                if (dr["status"].ToString() == "Active") this.TScomboBox.SelectedIndex = 0;
                else this.TScomboBox.SelectedIndex = 1;
                this.TScomboBox.Text = dr["status"].ToString();
            }
            db.con.Close();
        }

        void setProgress(string progress)
        {
            if (progress == "00%") this.TPcomboBox.SelectedIndex = 0;
            else if (progress == "10%") this.TPcomboBox.SelectedIndex = 1;
            else if (progress == "20%") this.TPcomboBox.SelectedIndex = 2;
            else if (progress == "30%") this.TPcomboBox.SelectedIndex = 3;
            else if (progress == "40%") this.TPcomboBox.SelectedIndex = 4;
            else if (progress == "50%") this.TPcomboBox.SelectedIndex = 5;
            else if (progress == "60%") this.TPcomboBox.SelectedIndex = 6;
            else if (progress == "70%") this.TPcomboBox.SelectedIndex = 7;
            else if (progress == "80%") this.TPcomboBox.SelectedIndex = 8;
            else if (progress == "90%") this.TPcomboBox.SelectedIndex = 9;
            else if (progress == "100%") this.TPcomboBox.SelectedIndex = 10;

            this.TPcomboBox.Text = progress;
        }

        private void TUbutton_Click(object sender, EventArgs e)
        {
            if (this.TNcomboBox.SelectedIndex >= 0) {
                db.conString();
                db.con.Open();
                SqlCommand cmd = new SqlCommand("update activity SET progress = @progress, status = @status Where title = @title ;", db.con);
                cmd.Parameters.AddWithValue("@title", this.TNcomboBox.Text);
                cmd.Parameters.AddWithValue("@progress", this.TPcomboBox.Text);
                cmd.Parameters.AddWithValue("@status", this.TScomboBox.Text);
                cmd.ExecuteNonQuery();
                db.con.Close();
                MessageBox.Show("Data has been updated successfully!");
                clearCont();
            }
            
        }

        private void TCbutton_Click(object sender, EventArgs e)
        {
            clearCont();
        }

        void clearCont()
        {
            this.TDtextBox.Clear(); 
            this.TPcomboBox.SelectedIndex = this.TScomboBox.SelectedIndex = 0;
            this.TNcomboBox.SelectedIndex = -1;
            this.TPcomboBox.Text = this.TScomboBox.Text = this.TNcomboBox.Text = "";
            this.TDtextBox.Text = "";
        }

        private void ProfileUpdateBTN_Click(object sender, EventArgs e)
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("update users SET name = @name, password = @password, contact = @contact Where id = @id ;", db.con);
            cmd.Parameters.AddWithValue("@id", Login.storeEmployeeID);
            cmd.Parameters.AddWithValue("@name", this.ProfileNtextBox.Text);
            cmd.Parameters.AddWithValue("@password", this.ProfilePtextBox.Text);
            cmd.Parameters.AddWithValue("@contact", this.ProfileCtextBox.Text);
            MessageBox.Show("Data has been updated successfully!");
            cmd.ExecuteNonQuery();
            db.con.Close();
        }

        void getProfileDate()
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from users where id='" + Login.storeEmployeeID + "' AND role='Employee';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.ProfileNtextBox.Text = dr["Name"].ToString();
                this.ProfilePtextBox.Text = dr["password"].ToString();
                this.ProfileCtextBox.Text = dr["contact"].ToString();
            }
            db.con.Close();
        }

        private void ProfileCancelBTN_Click(object sender, EventArgs e)
        {
            getProfileDate();
        }

        private void ProfileCtextBoxKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }
    }
}
