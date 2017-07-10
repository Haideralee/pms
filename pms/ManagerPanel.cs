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
    public partial class ManagerPanel : Form
    {
        database db = new database();
        string storeEmployeeID = ""; string storeProjectID = "";
        string storeManagerID = Login.storeManagerID; string storeTaskID = "";
        string todayDate = DateTime.Now.ToString("MM/dd/yyyy");

        public ManagerPanel()
        {
            InitializeComponent();
        }

        //Form Load Event
        //////////////////////////////////////////////
        private void ManagerPanel_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Manager Panel";
            this.ProfilePtextBox.PasswordChar = 'X';

            this.tabPage1.Text = "Add Employee";
            this.tabPage2.Text = "Show Employee";
            this.tabPage3.Text = "Update Employee";
            this.tabPage4.Text = "Add Project";
            this.tabPage5.Text = "Update & Show Project";
            this.tabPage6.Text = "Add & Update Task";
            this.tabPage7.Text = "Update Profile";
            this.tabPage8.Text = "Logout";

            this.tableLayoutPanel1.CellBorderStyle = this.tableLayoutPanel2.CellBorderStyle =
            this.tableLayoutPanel3.CellBorderStyle = this.tableLayoutPanel4.CellBorderStyle =
            this.tableLayoutPanel5.CellBorderStyle = this.tableLayoutPanel6.CellBorderStyle =
            this.tableLayoutPanel7.CellBorderStyle = this.tableLayoutPanel8.CellBorderStyle =
            this.tableLayoutPanel9.CellBorderStyle = this.tableLayoutPanel10.CellBorderStyle =
            this.tableLayoutPanel11.CellBorderStyle = this.tableLayoutPanel12.CellBorderStyle =
            this.tableLayoutPanel13.CellBorderStyle = this.tableLayoutPanel14.CellBorderStyle =
            this.tableLayoutPanel15.CellBorderStyle = this.tableLayoutPanel16.CellBorderStyle =
            this.tableLayoutPanel17.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            this.filterTextboxLabel.Enabled = this.filterTextBox.Enabled =
            this.filterBtn.Enabled = this.UEEmail.Enabled = this.UEContact.Enabled =
            this.UERole.Enabled = false; // tab 2
            this.UEStatusCombobox.SelectedIndex = this.PSCombobox.SelectedIndex = 0;

        }
        //////////////////////////////////////////////

        //tab1 panel start from here
        //////////////////////////////////////////////
        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (this.NENameTextbox.Text != "" && this.NEEmailTextbox.Text != "" && this.NEPasswordTextbox.Text != "")
            {
                checkUserInDB();
            }
            else
            {
                MessageBox.Show("Please Fill All Mandatory Fields.");
            }
        }

        void checkUserInDB()
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from users where email='" + this.NEEmailTextbox.Text + "';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) MessageBox.Show("This Email is already add.");
            else addEmployee();
            db.con.Close();
        }

        void addEmployee()
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("insert into [users] (name, email, password, role, contact) values"
                                            + "(@name, @email, @password, @role, @contact) ;", db.con);
            cmd.Parameters.AddWithValue("@name", this.NENameTextbox.Text);
            cmd.Parameters.AddWithValue("@email", this.NEEmailTextbox.Text);
            cmd.Parameters.AddWithValue("@password", this.NEPasswordTextbox.Text);
            cmd.Parameters.AddWithValue("@role", "Employee");
            cmd.Parameters.AddWithValue("@contact", "00000000000");
            cmd.ExecuteNonQuery();
            db.con.Close();
            MessageBox.Show("Data has been entered successfully!");
            clearTab1();
        }

        void clearTab1()
        {
            this.NENameTextbox.Clear(); this.NEEmailTextbox.Clear(); this.NEPasswordTextbox.Clear();
        }

        private void NEmployeeCancelBtn_Click(object sender, EventArgs e)
        {
            clearTab1();
        }
        //////////////////////////////////////////////
        //tab1 panel finish here

        //tab2 panel start from here
        //////////////////////////////////////////////
        string filterQuery = "";
        private void filterOptionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filterTextBox.Clear(); this.filterCombobox.Visible = false;
            if (this.filterOptionCombobox.Text != "Show All")
            {
                this.filterTextBox.Enabled = this.filterTextboxLabel.Enabled =
                this.filterBtn.Enabled = true;
            }

            if (this.filterOptionCombobox.Text == "Show All")
            {
                filterQuery = "select * from users where role='Employee';";
                this.filterTextBox.Enabled = this.filterTextboxLabel.Enabled = false;
                this.filterBtn.Enabled = true;
            }

            if (this.filterOptionCombobox.Text == "Status")
            {
                this.filterCombobox.Visible = true;
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            if (this.filterOptionCombobox.Text == "Show All" || this.filterOptionCombobox.Text == "Status" || this.filterTextBox.Text != "")
            {
                db.conString();
                db.con.Open();
                //MessageBox.Show(filterQuery);
                //MessageBox.Show(filterTextBox.Text);
                SqlCommand cmd = new SqlCommand(filterQuery, db.con);
                SqlDataReader dr = cmd.ExecuteReader();
                this.EMPdataGridView.Rows.Clear();
                int count = 0;
                while (dr.Read())
                {
                    //Button btn = new Button();
                    //btn.Text = "Delete";
                    //btn.PerformClick();
                    //btn.Click += new EventHandler(this.button_Dynamic_Click);
                    this.EMPdataGridView.Rows.Add(dr["name"].ToString(), dr["email"].ToString(), dr["contact"].ToString(),
                        dr["role"].ToString(), dr["status"].ToString());

                    this.EMPdataGridView.Columns["EStatus"].DefaultCellStyle.ForeColor = Color.White;
                    if (dr["status"].ToString() == "Active") this.EMPdataGridView.Rows[count].Cells[4].Style.BackColor = Color.Green;
                    else this.EMPdataGridView.Rows[count].Cells[4].Style.BackColor = Color.Red;

                    count++;
                }
                if (this.EMPdataGridView.Rows.Count <= 0) MessageBox.Show("Employee is not exist.");
                db.con.Close();
            }
            else MessageBox.Show("Please Fill Mondatory Field.");
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.filterOptionCombobox.Text == "Name")
            {
                filterQuery = "select * from users where name='" + this.filterTextBox.Text + "' AND role='Employee';";
            }
            else if (this.filterOptionCombobox.Text == "E-mail")
            {
                filterQuery = "select * from users where email='" + this.filterTextBox.Text + "' AND role='Employee';";
            }
            else if (this.filterOptionCombobox.Text == "Contact")
            {
                filterQuery = "select * from users where contact='" + this.filterTextBox.Text + "' AND role='Employee';";
            }
        }

        private void filterCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterQuery = "select * from users where status='" + this.filterCombobox.Text + "' AND role='Employee';";
        }
        //////////////////////////////////////////////
        //tab2 panel finish here

        //tab change event
        //////////////////////////////////////////////
        private void tabIndexChange(object sender, EventArgs e)
        {
            //MessageBox.Show(" " + this.tabControl1.SelectedIndex);
            if (this.tabControl1.SelectedIndex == 7)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else if (this.tabControl1.SelectedIndex == 2)
            {
                fetchAllEmployee("names");
            }
            else if(this.tabControl1.SelectedIndex == 3)
            {
                this.PCDTextbox.Text = todayDate;
                this.PCDTextbox.Enabled = false;
                //MessageBox.Show(a);
            }
            else if(this.tabControl1.SelectedIndex == 4)
            {
                fetchAllProject("names");
                this.textBox1.Enabled = this.textBox2.Enabled = false;
            }
            else if (this.tabControl1.SelectedIndex == 5)
            {
                fetchAllEmployee("names");
                fetchAllProject("names");
                this.NTPcomboBox.SelectedIndex = 0;
                this.NTScomboBox.SelectedIndex = 0;
            }
            else if (this.tabControl1.SelectedIndex == 6)
            {
                getProfileDate();
            }
        }
        //////////////////////////////////////////////

        //tab3 panel start from here
        //////////////////////////////////////////////
        void fetchAllEmployee(string action)
        {
            db.conString();
            db.con.Open();

            string updateEmployeeQuery = "";
            if (action == "names")
            {
                this.UECombobox.Items.Clear();
                this.NTENcomboBox.Items.Clear();
                this.UTENcomboBox.Items.Clear();
                updateEmployeeQuery = "select * from users where role='Employee';";

            }
            else if (action == "all")
            {
                updateEmployeeQuery = "select * from users where role='Employee' AND name='" + this.UECombobox.Text + "';";
            }
            else
            {
                updateEmployeeQuery = "select * from users where role='Employee' AND name='" + this.NTENcomboBox.Text + "';";
            }

            SqlCommand cmd = new SqlCommand(updateEmployeeQuery, db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            this.EMPdataGridView.Rows.Clear();
            if (action == "names") this.UECombobox.Items.Clear();
            while (dr.Read())
            {
                if (action == "names")
                {
                    this.UECombobox.Items.Add(dr["name"].ToString());
                    this.NTENcomboBox.Items.Add(dr["name"].ToString());
                    this.UTENcomboBox.Items.Add(dr["name"].ToString());
                }
                else
                {
                    if (action == "all")
                    {
                        this.UEEmail.Text = dr["email"].ToString();
                        this.UEContact.Text = dr["contact"].ToString();
                        this.UERole.Text = dr["role"].ToString();
                        if (dr["status"].ToString() == "Active") this.UEStatusCombobox.SelectedIndex = 0;
                        else this.UEStatusCombobox.SelectedIndex = 1;
                    }
                    else
                    {
                        storeEmployeeID = dr["id"].ToString();
                        this.NTEEtextBox.Text = dr["email"].ToString();
                        this.NTECtextBox.Text = dr["contact"].ToString();
                    }

                    
                }
            }
            db.con.Close();
        }

        private void UECombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchAllEmployee("all");
        }

        private void UEStatusBtn_Click(object sender, EventArgs e)
        {
            db.con.Open();
            SqlCommand cmd = new SqlCommand("Update users set status = '" + this.UEStatusCombobox.Text + "' where email='" + this.UEEmail.Text + "';", db.con);
            cmd.ExecuteNonQuery();
            db.con.Close();
            MessageBox.Show("Employee Status is updated!");

            clearUEControl();
        }

        private void UECancelBtn_Click(object sender, EventArgs e)
        {
            clearUEControl();
        }

        void clearUEControl()
        {
            this.UECombobox.Text = "";
            this.UECombobox.SelectedIndex = -1;
            this.UEEmail.Clear(); this.UERole.Clear(); this.UEContact.Clear();
            this.UEStatusCombobox.Text = "";
            this.UEStatusCombobox.SelectedIndex = -1;
        }
        //////////////////////////////////////////////
        //tab3 panel finish here

        //tab4 panel start from here
        //////////////////////////////////////////////
        private void PCBtn_Click(object sender, EventArgs e)
        {
            if (this.PNTextbox.Text != "" && this.PDTextbox.Text != "" && this.PCDTextbox.Text != "" && this.PSCombobox.Text != "")
            {
                checkProjectInDB();
            }
            else
            {
                MessageBox.Show("Please Fill All Mandatory Fields.");
            }
        }

        void checkProjectInDB()
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from projects where name='" + this.PNTextbox.Text + "';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) MessageBox.Show("Project is already Exist.");
            else createProject();
            db.con.Close();
        }

        void createProject()
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("insert into projects (name, des, status, createDate) values"
                                            + "(@name, @des, @status, @createDate) ;", db.con);
            cmd.Parameters.AddWithValue("@name", this.PNTextbox.Text);
            cmd.Parameters.AddWithValue("@des", this.PDTextbox.Text);
            cmd.Parameters.AddWithValue("@status", this.PSCombobox.Text);
            cmd.Parameters.AddWithValue("@createDate", this.PCDTextbox.Text);
            cmd.ExecuteNonQuery();
            db.con.Close();
            MessageBox.Show("Data has been entered successfully!");
            clearTab4();
        }

        void clearTab4()
        {
            this.PNTextbox.Clear(); this.PDTextbox.Clear();
            this.PSCombobox.Text = ""; this.PSCombobox.SelectedIndex = -1;
        }
        //////////////////////////////////////////////
        //tab4 panel finish here 

        //tab5 panel start from here
        ////////////////////////////////////////////// 
        string UPfilterQuery = "";
        private void UPfilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UPfilterTextBox.Clear(); this.UPfilterStatusComboBox.Visible = false;
            if (this.UPfilterComboBox.Text != "Show All")
            {
                this.UPfilterTextBox.Enabled = this.UPfilterTextboxLabel.Enabled =
                this.UPfilterButton.Enabled = true;
            }

            if (this.UPfilterComboBox.Text == "Show All")
            {
                UPfilterQuery = "select * from projects;";
                this.UPfilterTextBox.Enabled = this.UPfilterTextboxLabel.Enabled = false;
                this.UPfilterButton.Enabled = true;
            }

            if (this.UPfilterComboBox.Text == "Status")
            {
                this.UPfilterStatusComboBox.Visible = true;
            }
        }

        private void UPfilterButton_Click(object sender, EventArgs e)
        {
            if (this.UPfilterComboBox.Text == "Show All" || this.UPfilterComboBox.Text == "Status" || this.UPfilterTextBox.Text != "")
            {
                db.conString();
                db.con.Open();
                //MessageBox.Show(UPfilterQuery);
                //MessageBox.Show(filterTextBox.Text);
                SqlCommand cmd = new SqlCommand(UPfilterQuery, db.con);
                SqlDataReader dr = cmd.ExecuteReader();
                this.UPdataGridView.Rows.Clear();
                int count = 0;
                while (dr.Read())
                {
                    //Button btn = new Button();
                    //btn.Text = "Delete";
                    //btn.PerformClick();
                    //btn.Click += new EventHandler(this.button_Dynamic_Click);
                    this.UPdataGridView.Rows.Add(dr["name"].ToString(), dr["des"].ToString(), dr["createDate"].ToString(), dr["status"].ToString());

                    this.UPdataGridView.Columns["UPStatus"].DefaultCellStyle.ForeColor = Color.White;
                    if (dr["status"].ToString() == "Active") this.UPdataGridView.Rows[count].Cells[3].Style.BackColor = Color.Green;
                    else this.UPdataGridView.Rows[count].Cells[3].Style.BackColor = Color.Red;

                    count++;
                }
                if (this.UPdataGridView.Rows.Count <= 0) MessageBox.Show("Project is not exist.");
                db.con.Close();
            }
            else MessageBox.Show("Please Fill Mondatory Field.");
        }

        private void UPfilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.UPfilterComboBox.Text == "Name")
            {
                UPfilterQuery = "select * from projects where name='" + this.UPfilterTextBox.Text + "';";
            }
           
        }
        
        private void UPfilterStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UPfilterQuery = "select * from projects where status='" + this.UPfilterStatusComboBox.Text + "';";

        }

        private void gotoUPBtn_Click(object sender, EventArgs e)
        {
            this.FPPanel.Hide();
            this.UPPanel.Show();
        }

        /////////////////////////////////////////////////
        void fetchAllProject(string action)
        {
            db.conString();
            db.con.Open();

            string getProjectQuery = "";
            if (action == "names")
            {
                getProjectQuery = "select * from projects;";
                this.comboBox1.Items.Clear();
                this.NTPNcomboBox.Items.Clear();
                this.UTPNcomboBox.Items.Clear();
            }
            else if (action == "all")
            {
                getProjectQuery = "select * from projects where name='" + this.comboBox1.Text + "';";
            }
            else
            {
                getProjectQuery = "select * from projects where name='" + this.NTPNcomboBox.Text + "';";
            }

            SqlCommand cmd = new SqlCommand(getProjectQuery, db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            this.EMPdataGridView.Rows.Clear();
            if (action == "names") this.UECombobox.Items.Clear();
            while (dr.Read())
            {
                if (action == "names")
                {
                    this.comboBox1.Items.Add(dr["name"].ToString());
                    this.NTPNcomboBox.Items.Add(dr["name"].ToString());
                    this.UTPNcomboBox.Items.Add(dr["name"].ToString());
                }
                else
                {
                    if (action == "all")
                    {
                        this.textBox1.Text = dr["des"].ToString();
                        this.textBox2.Text = dr["createDate"].ToString();
                        if (dr["status"].ToString() == "Active") this.comboBox2.SelectedIndex = 0;
                        else this.comboBox2.SelectedIndex = 1;
                    }
                    else
                    {
                        this.NTPDtextBox.Text = dr["des"].ToString();
                        storeProjectID = dr["id"].ToString();
                    }
                }
            }
            db.con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchAllProject("all");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.con.Open();
            SqlCommand cmd = new SqlCommand("Update projects set status = '" + this.comboBox2.Text + "' where name='" + this.comboBox1.Text + "';", db.con);
            cmd.ExecuteNonQuery();
            db.con.Close();
            MessageBox.Show("project Status is updated!");

            clearUEControl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearUPControl();
        }

        void clearUPControl()
        {
            this.comboBox1.Text = "";
            this.comboBox1.SelectedIndex = -1;
            this.textBox1.Clear(); this.textBox1.Clear();
            this.comboBox2.Text = "";
            this.comboBox2.SelectedIndex = -1;
        }

        private void goToPSBtn_Click(object sender, EventArgs e)
        {
            this.FPPanel.Show();
            this.UPPanel.Hide();
        }

        //////////////////////////////////////////////
        //tab5 panel finish here 

        //tab6 panel start from here
        //////////////////////////////////////////////
        private void NTPNcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchAllProject("New Task for Project");
        }

        private void NTENcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchAllEmployee("New Task for Employee");
        }

        private void NTAddBtn_Click(object sender, EventArgs e)
        {

            if (this.NTNtextBox.Text != "" && this.NTDtextBox.Text != "" && this.NTPcomboBox.Text != ""
               && this.NTScomboBox.Text != "" && this.NTPNcomboBox.Text != "" && this.NTENcomboBox.Text != "")
            {
                checkTaskInDB();
            }
            else
            {
                MessageBox.Show("Please Fill All Mandatory Fields.");
            }
        }

        void checkTaskInDB()
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from activity where title='" + this.NTNtextBox.Text + "';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) MessageBox.Show("Task is already add.");
            else addActivity();
            db.con.Close();
        }

        void addActivity()
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("insert into activity (title, des, progress, status) values"
                                            + "(@title, @des, @progress, @status) ;", db.con);
            cmd.Parameters.AddWithValue("@title", this.NTNtextBox.Text);
            cmd.Parameters.AddWithValue("@des", this.NTDtextBox.Text);
            cmd.Parameters.AddWithValue("@progress", this.NTPcomboBox.Text);
            cmd.Parameters.AddWithValue("@status", this.NTScomboBox.Text);
            cmd.ExecuteNonQuery();
            db.con.Close();
            //
            getTaskID();
        }

        void getTaskID()
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from activity where title='" + this.NTNtextBox.Text + "';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                storeTaskID = dr["id"].ToString();
            }
            db.con.Close();
            addNewTask();
        }

        void addNewTask()
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("insert into tasks (employeeID, projectID, managerID, activityID, createdDate, estimatedDate) values"
                                            + "(@employeeID, @projectID, @managerID, @activityID, @createdDate, @estimatedDate) ;", db.con);
            cmd.Parameters.AddWithValue("@employeeID", storeEmployeeID);
            cmd.Parameters.AddWithValue("@projectID", storeProjectID);
            cmd.Parameters.AddWithValue("@managerID", storeManagerID);
            cmd.Parameters.AddWithValue("@activityID", storeTaskID);
            cmd.Parameters.AddWithValue("@createdDate", todayDate);
            cmd.Parameters.AddWithValue("@estimatedDate", this.NTETdateTimePicker.Value.Date);
            //MessageBox.Show(this.NTETdateTimePicker.Value.Date.ToString("d"));
            //MessageBox.Show(this.NTETdateTimePicker.Value.Date + " ");
            //MessageBox.Show(this.NTETdateTimePicker.Text);
            //cmd.Parameters.AddWithValue("@finishedDate", null);
            cmd.ExecuteNonQuery();
            db.con.Close();
            MessageBox.Show("Data has been entered successfully!");
            clearANTControls();
        }

        private void NTCancelBtn_Click(object sender, EventArgs e)
        {
            clearANTControls();
        }

        void clearANTControls()
        {
            this.NTNtextBox.Clear(); this.NTDtextBox.Clear(); this.NTPDtextBox.Clear(); this.NTEEtextBox.Clear();
            this.NTECtextBox.Clear();
            this.NTPcomboBox.SelectedIndex = this.NTScomboBox.SelectedIndex = 0; 
            this.NTPNcomboBox.SelectedIndex = this.NTENcomboBox.SelectedIndex = -1;
            this.NTETdateTimePicker.Value = DateTime.Now.AddDays(0);
            this.NTPcomboBox.Text = this.NTScomboBox.Text = this.NTPNcomboBox.Text = this.NTENcomboBox.Text = "";
            this.NTNtextBox.Text = this.NTDtextBox.Text = this.NTPDtextBox.Text = this.NTEEtextBox.Text = "";
        }

        private void GTUTBtn_Click(object sender, EventArgs e)
        {
            this.ANTPanel.Hide();
            this.UTPanel.Show();
            getTasks("get title only");

        }

        string storeUpdateTaskID = "";
        void getTasks(string action)
        {
            if (action == "get title only") this.UTNcomboBox.Items.Clear();
            db.conString();
            db.con.Open();

            string getTaskQuery = "";
            if (action == "get title only") getTaskQuery = "select * from activity ;";
            else if(action == "get all detail") getTaskQuery = "select * from activity where title='" + this.UTNcomboBox.Text + "';";

            SqlCommand cmd = new SqlCommand(getTaskQuery, db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (action == "get title only") this.UTNcomboBox.Items.Add(dr["title"].ToString());
                else {
                    storeUpdateTaskID = dr["id"].ToString();
                    this.UTDtextBox.Text = dr["des"].ToString();
                    this.UTPcomboBox.Text = dr["progress"].ToString();
                    setProgress(this.UTPcomboBox.Text);
                    this.UTScomboBox.Text = dr["status"].ToString();
                    if (this.UTScomboBox.Text == "Active") this.UTScomboBox.SelectedIndex = 0;
                    else this.UTScomboBox.SelectedIndex = 1;
                }
            }
            db.con.Close();
            if (action != "get title only") getTaskDetail();
        }

        string storeUpdateTaskEmployeeID = "";
        string storeUpdateTaskManagerID = "";
        string storeUpdateTaskProjectID = "";

        void getTaskDetail() {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from tasks where activityID='" + storeUpdateTaskID + "';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                storeUpdateTaskEmployeeID = dr["employeeID"].ToString();
                storeUpdateTaskManagerID = dr["managerID"].ToString();
                storeUpdateTaskProjectID = dr["projectID"].ToString();

                //int Date = Convert.ToDateTime(dr["status"].ToString()).Date;
                //int year = Convert.ToDateTime(dateTimePicker1.Text).Year;
                //int month = Convert.ToDateTime(dateTimePicker1.Text).Month;

                this.UTdateTimePicker.Text = dr["estimatedDate"].ToString();

            }
            db.con.Close();
            
            getUTUser();
        }

        void getUTUser()
        {
            string employeeName = "";
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from users;", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            //MessageBox.Show(dr.Read() + "");
            while (dr.Read())
            {
                
                if (storeUpdateTaskEmployeeID == dr["id"].ToString()) {
                    employeeName = dr["name"].ToString();
                }

            }
            db.con.Close();
            this.UTENcomboBox.SelectedIndex = this.UTENcomboBox.Items.IndexOf(employeeName);
            getUProjects();

        }

        void getUProjects()
        {
            string projectname = "";
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from projects;", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (storeUpdateTaskProjectID == dr["id"].ToString())
                {
                    projectname = dr["name"].ToString();
                }

            }
            db.con.Close();
            this.UTPNcomboBox.SelectedIndex = this.UTPNcomboBox.Items.IndexOf(projectname);
        }

        void setProgress(string progress)
        {
            if (progress == "00%") this.UTPcomboBox.SelectedIndex = 0;
            else if (progress == "10%") this.UTPcomboBox.SelectedIndex = 1;
            else if (progress == "20%") this.UTPcomboBox.SelectedIndex = 2;
            else if (progress == "30%") this.UTPcomboBox.SelectedIndex = 3;
            else if (progress == "40%") this.UTPcomboBox.SelectedIndex = 4;
            else if (progress == "50%") this.UTPcomboBox.SelectedIndex = 5;
            else if (progress == "60%") this.UTPcomboBox.SelectedIndex = 6;
            else if (progress == "70%") this.UTPcomboBox.SelectedIndex = 7;
            else if (progress == "80%") this.UTPcomboBox.SelectedIndex = 8;
            else if (progress == "90%") this.UTPcomboBox.SelectedIndex = 9;
            else if (progress == "100%") this.UTPcomboBox.SelectedIndex = 10;

        }

        private void UTNcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTasks("get all detail");
        }

        string storeUpdateProjectID = "";
        private void UTPNcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from projects where name='" + this.UTPNcomboBox.Text + "';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                storeUpdateProjectID = dr["id"].ToString();
                this.UTPDtextBox.Text = dr["des"].ToString();
            }
            db.con.Close();
        }

        string storeUpdateEmployeeID = "";
        private void UTENcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from users where name='" + this.UTENcomboBox.Text + "' AND role='Employee';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                storeUpdateEmployeeID = dr["id"].ToString();
                this.UTEEtextBox.Text = dr["email"].ToString();
                this.UTECtextBox.Text = dr["contact"].ToString();
            }
            db.con.Close();

        }

        private void GTATBtn_Click(object sender, EventArgs e)
        {
            this.ANTPanel.Show();
            this.UTPanel.Hide();
        }

        private void UTCBtn_Click(object sender, EventArgs e)
        {
            clearUTControls();
        }

        void clearUTControls()
        {
            this.UTDtextBox.Clear(); this.UTPDtextBox.Clear(); this.UTEEtextBox.Clear(); this.UTECtextBox.Clear();
            this.UTPcomboBox.SelectedIndex = this.UTScomboBox.SelectedIndex = 0;
            this.UTNcomboBox.SelectedIndex = this.UTPNcomboBox.SelectedIndex = this.UTENcomboBox .SelectedIndex = -1;
            this.UTdateTimePicker.Value = DateTime.Now.AddDays(0);
            this.UTNcomboBox.Text = this.UTPcomboBox.Text = this.UTScomboBox.Text = this.UTPNcomboBox.Text = this.UTENcomboBox.Text = "";
            this.UTDtextBox.Text = this.UTPDtextBox.Text = this.UTEEtextBox.Text = this.UTECtextBox.Text = "";
        }

        private void UTBtn_Click(object sender, EventArgs e)
        {
            //UPDATE Student SET Address = @add, City = @cit Where FirstName = @fn and LastName = @add"

            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("update activity SET des = @des, progress = @progress, status = @status Where title = @title ;", db.con);
            cmd.Parameters.AddWithValue("@title", this.UTNcomboBox.Text);
            cmd.Parameters.AddWithValue("@des", this.UTDtextBox.Text);
            cmd.Parameters.AddWithValue("@progress", this.UTPcomboBox.Text);
            cmd.Parameters.AddWithValue("@status", this.UTScomboBox.Text);
            cmd.ExecuteNonQuery();
            db.con.Close();
            //MessageBox.Show("Data has been entered successfully!");
            //storeUpdateTaskID
            updateTask();
        }

        void updateTask() {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("update tasks SET employeeID = @employeeID, projectID = @projectID, estimatedDate = @estimatedDate Where activityID = @activityID ;", db.con);
            cmd.Parameters.AddWithValue("@activityID", storeUpdateTaskID);
            cmd.Parameters.AddWithValue("@employeeID", storeUpdateEmployeeID);
            cmd.Parameters.AddWithValue("@projectID", storeUpdateProjectID);
            cmd.Parameters.AddWithValue("@estimatedDate", this.UTdateTimePicker.Value.Date);
            MessageBox.Show("Data has been updated successfully!");
            cmd.ExecuteNonQuery();
            db.con.Close();
            clearUTControls();
        }

        //////////////////////////////////////////////
        //tab6 panel finish here 

        //tab7 panel start from here
        //////////////////////////////////////////////
        void getProfileDate()
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("select * from users where id='" + Login.storeManagerID + "' AND role='Manager';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.ProfileNtextBox.Text = dr["Name"].ToString();
                this.ProfilePtextBox.Text = dr["password"].ToString();
                this.ProfileCtextBox.Text = dr["contact"].ToString();
            }
            db.con.Close();
        }

        private void ProfileUpdateBTN_Click(object sender, EventArgs e)
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("update users SET name = @name, password = @password, contact = @contact Where id = @id ;", db.con);
            cmd.Parameters.AddWithValue("@id", Login.storeManagerID);
            cmd.Parameters.AddWithValue("@name", this.ProfileNtextBox.Text);
            cmd.Parameters.AddWithValue("@password", this.ProfilePtextBox.Text);
            cmd.Parameters.AddWithValue("@contact", this.ProfileCtextBox.Text);
            MessageBox.Show("Data has been updated successfully!");
            cmd.ExecuteNonQuery();
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

        private void ProfilePlabel_Click(object sender, EventArgs e)
        {

        }

        private void ProfileClabel_Click(object sender, EventArgs e)
        {

        }

        private void ProfileNlabel_Click(object sender, EventArgs e)
        {

        }

        private void ProfileCtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfilePtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfileNtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel17_Paint(object sender, PaintEventArgs e)
        {

        }
        //////////////////////////////////////////////
        //tab6 panel finish here 
    }
}
