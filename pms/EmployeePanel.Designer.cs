namespace pms
{
    partial class EmployeePanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filterDataGridView = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskEstimatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TNlabel = new System.Windows.Forms.Label();
            this.TDlabel = new System.Windows.Forms.Label();
            this.TPlabel = new System.Windows.Forms.Label();
            this.TSlabel = new System.Windows.Forms.Label();
            this.TUbutton = new System.Windows.Forms.Button();
            this.TCbutton = new System.Windows.Forms.Button();
            this.TDtextBox = new System.Windows.Forms.TextBox();
            this.TPcomboBox = new System.Windows.Forms.ComboBox();
            this.TScomboBox = new System.Windows.Forms.ComboBox();
            this.TNcomboBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ProfileNlabel = new System.Windows.Forms.Label();
            this.ProfilePlabel = new System.Windows.Forms.Label();
            this.ProfileClabel = new System.Windows.Forms.Label();
            this.ProfileNtextBox = new System.Windows.Forms.TextBox();
            this.ProfilePtextBox = new System.Windows.Forms.TextBox();
            this.ProfileCtextBox = new System.Windows.Forms.TextBox();
            this.ProfileUpdateBTN = new System.Windows.Forms.Button();
            this.ProfileCancelBTN = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 322);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControlindexCh);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.filterDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.86207F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // filterDataGridView
            // 
            this.filterDataGridView.AllowUserToAddRows = false;
            this.filterDataGridView.AllowUserToDeleteRows = false;
            this.filterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.TaskDesc,
            this.ManagerName,
            this.ProjectName,
            this.TaskStatus,
            this.TaskProgress,
            this.TaskEstimatedTime});
            this.filterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterDataGridView.Location = new System.Drawing.Point(3, 3);
            this.filterDataGridView.Name = "filterDataGridView";
            this.filterDataGridView.ReadOnly = true;
            this.filterDataGridView.Size = new System.Drawing.Size(747, 284);
            this.filterDataGridView.TabIndex = 1;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // TaskDesc
            // 
            this.TaskDesc.HeaderText = "Task Description";
            this.TaskDesc.Name = "TaskDesc";
            this.TaskDesc.ReadOnly = true;
            // 
            // ManagerName
            // 
            this.ManagerName.HeaderText = "Manager ";
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // TaskStatus
            // 
            this.TaskStatus.HeaderText = "Task Status";
            this.TaskStatus.Name = "TaskStatus";
            this.TaskStatus.ReadOnly = true;
            // 
            // TaskProgress
            // 
            this.TaskProgress.HeaderText = "Task Progress";
            this.TaskProgress.Name = "TaskProgress";
            this.TaskProgress.ReadOnly = true;
            // 
            // TaskEstimatedTime
            // 
            this.TaskEstimatedTime.HeaderText = "Task Estimate Time";
            this.TaskEstimatedTime.Name = "TaskEstimatedTime";
            this.TaskEstimatedTime.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TNlabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TDlabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TPlabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TSlabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TUbutton, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TCbutton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TDtextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TPcomboBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TScomboBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TNcomboBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(753, 290);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // TNlabel
            // 
            this.TNlabel.AutoSize = true;
            this.TNlabel.Location = new System.Drawing.Point(3, 0);
            this.TNlabel.Name = "TNlabel";
            this.TNlabel.Size = new System.Drawing.Size(27, 13);
            this.TNlabel.TabIndex = 0;
            this.TNlabel.Text = "Title";
            // 
            // TDlabel
            // 
            this.TDlabel.AutoSize = true;
            this.TDlabel.Location = new System.Drawing.Point(3, 47);
            this.TDlabel.Name = "TDlabel";
            this.TDlabel.Size = new System.Drawing.Size(60, 13);
            this.TDlabel.TabIndex = 0;
            this.TDlabel.Text = "Description";
            // 
            // TPlabel
            // 
            this.TPlabel.AutoSize = true;
            this.TPlabel.Location = new System.Drawing.Point(3, 94);
            this.TPlabel.Name = "TPlabel";
            this.TPlabel.Size = new System.Drawing.Size(48, 13);
            this.TPlabel.TabIndex = 0;
            this.TPlabel.Text = "Progress";
            // 
            // TSlabel
            // 
            this.TSlabel.AutoSize = true;
            this.TSlabel.Location = new System.Drawing.Point(3, 148);
            this.TSlabel.Name = "TSlabel";
            this.TSlabel.Size = new System.Drawing.Size(37, 13);
            this.TSlabel.TabIndex = 0;
            this.TSlabel.Text = "Status";
            // 
            // TUbutton
            // 
            this.TUbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TUbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TUbutton.Location = new System.Drawing.Point(3, 212);
            this.TUbutton.Name = "TUbutton";
            this.TUbutton.Size = new System.Drawing.Size(370, 75);
            this.TUbutton.TabIndex = 1;
            this.TUbutton.Text = "Update";
            this.TUbutton.UseVisualStyleBackColor = true;
            this.TUbutton.Click += new System.EventHandler(this.TUbutton_Click);
            // 
            // TCbutton
            // 
            this.TCbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TCbutton.Location = new System.Drawing.Point(379, 212);
            this.TCbutton.Name = "TCbutton";
            this.TCbutton.Size = new System.Drawing.Size(371, 75);
            this.TCbutton.TabIndex = 1;
            this.TCbutton.Text = "Cancel";
            this.TCbutton.UseVisualStyleBackColor = true;
            this.TCbutton.Click += new System.EventHandler(this.TCbutton_Click);
            // 
            // TDtextBox
            // 
            this.TDtextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TDtextBox.Enabled = false;
            this.TDtextBox.Location = new System.Drawing.Point(379, 50);
            this.TDtextBox.MaxLength = 50;
            this.TDtextBox.Multiline = true;
            this.TDtextBox.Name = "TDtextBox";
            this.TDtextBox.Size = new System.Drawing.Size(371, 41);
            this.TDtextBox.TabIndex = 2;
            // 
            // TPcomboBox
            // 
            this.TPcomboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TPcomboBox.FormattingEnabled = true;
            this.TPcomboBox.Items.AddRange(new object[] {
            "00%",
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.TPcomboBox.Location = new System.Drawing.Point(379, 97);
            this.TPcomboBox.Name = "TPcomboBox";
            this.TPcomboBox.Size = new System.Drawing.Size(371, 21);
            this.TPcomboBox.TabIndex = 3;
            // 
            // TScomboBox
            // 
            this.TScomboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TScomboBox.FormattingEnabled = true;
            this.TScomboBox.Items.AddRange(new object[] {
            "Active",
            "Unactive"});
            this.TScomboBox.Location = new System.Drawing.Point(379, 151);
            this.TScomboBox.Name = "TScomboBox";
            this.TScomboBox.Size = new System.Drawing.Size(371, 21);
            this.TScomboBox.TabIndex = 3;
            // 
            // TNcomboBox
            // 
            this.TNcomboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TNcomboBox.FormattingEnabled = true;
            this.TNcomboBox.Location = new System.Drawing.Point(379, 3);
            this.TNcomboBox.Name = "TNcomboBox";
            this.TNcomboBox.Size = new System.Drawing.Size(371, 21);
            this.TNcomboBox.TabIndex = 4;
            this.TNcomboBox.SelectedIndexChanged += new System.EventHandler(this.TNcomboBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(759, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.86533F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.13467F));
            this.tableLayoutPanel3.Controls.Add(this.ProfileNlabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ProfilePlabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ProfileClabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ProfileNtextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ProfilePtextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.ProfileCtextBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.ProfileUpdateBTN, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.ProfileCancelBTN, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(759, 296);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // ProfileNlabel
            // 
            this.ProfileNlabel.AutoSize = true;
            this.ProfileNlabel.Location = new System.Drawing.Point(3, 0);
            this.ProfileNlabel.Name = "ProfileNlabel";
            this.ProfileNlabel.Size = new System.Drawing.Size(35, 13);
            this.ProfileNlabel.TabIndex = 0;
            this.ProfileNlabel.Text = "Name";
            // 
            // ProfilePlabel
            // 
            this.ProfilePlabel.AutoSize = true;
            this.ProfilePlabel.Location = new System.Drawing.Point(3, 74);
            this.ProfilePlabel.Name = "ProfilePlabel";
            this.ProfilePlabel.Size = new System.Drawing.Size(53, 13);
            this.ProfilePlabel.TabIndex = 0;
            this.ProfilePlabel.Text = "Password";
            // 
            // ProfileClabel
            // 
            this.ProfileClabel.AutoSize = true;
            this.ProfileClabel.Location = new System.Drawing.Point(3, 148);
            this.ProfileClabel.Name = "ProfileClabel";
            this.ProfileClabel.Size = new System.Drawing.Size(44, 13);
            this.ProfileClabel.TabIndex = 0;
            this.ProfileClabel.Text = "Contact";
            // 
            // ProfileNtextBox
            // 
            this.ProfileNtextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileNtextBox.Location = new System.Drawing.Point(404, 3);
            this.ProfileNtextBox.Name = "ProfileNtextBox";
            this.ProfileNtextBox.Size = new System.Drawing.Size(352, 20);
            this.ProfileNtextBox.TabIndex = 1;
            // 
            // ProfilePtextBox
            // 
            this.ProfilePtextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfilePtextBox.Location = new System.Drawing.Point(404, 77);
            this.ProfilePtextBox.Name = "ProfilePtextBox";
            this.ProfilePtextBox.Size = new System.Drawing.Size(352, 20);
            this.ProfilePtextBox.TabIndex = 1;
            // 
            // ProfileCtextBox
            // 
            this.ProfileCtextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileCtextBox.Location = new System.Drawing.Point(404, 151);
            this.ProfileCtextBox.Name = "ProfileCtextBox";
            this.ProfileCtextBox.Size = new System.Drawing.Size(352, 20);
            this.ProfileCtextBox.TabIndex = 1;
            this.ProfileCtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProfileCtextBoxKey);
            // 
            // ProfileUpdateBTN
            // 
            this.ProfileUpdateBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileUpdateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileUpdateBTN.Location = new System.Drawing.Point(3, 231);
            this.ProfileUpdateBTN.Name = "ProfileUpdateBTN";
            this.ProfileUpdateBTN.Size = new System.Drawing.Size(395, 62);
            this.ProfileUpdateBTN.TabIndex = 2;
            this.ProfileUpdateBTN.Text = "Update Profile";
            this.ProfileUpdateBTN.UseVisualStyleBackColor = true;
            this.ProfileUpdateBTN.Click += new System.EventHandler(this.ProfileUpdateBTN_Click);
            // 
            // ProfileCancelBTN
            // 
            this.ProfileCancelBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileCancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileCancelBTN.Location = new System.Drawing.Point(404, 231);
            this.ProfileCancelBTN.Name = "ProfileCancelBTN";
            this.ProfileCancelBTN.Size = new System.Drawing.Size(352, 62);
            this.ProfileCancelBTN.TabIndex = 2;
            this.ProfileCancelBTN.Text = "Cancel";
            this.ProfileCancelBTN.UseVisualStyleBackColor = true;
            this.ProfileCancelBTN.Click += new System.EventHandler(this.ProfileCancelBTN_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(759, 296);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 322);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePanel";
            this.Load += new System.EventHandler(this.EmployeePanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView filterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskEstimatedTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label TNlabel;
        private System.Windows.Forms.Label TDlabel;
        private System.Windows.Forms.Label TPlabel;
        private System.Windows.Forms.Label TSlabel;
        private System.Windows.Forms.Button TUbutton;
        private System.Windows.Forms.Button TCbutton;
        private System.Windows.Forms.TextBox TDtextBox;
        private System.Windows.Forms.ComboBox TPcomboBox;
        private System.Windows.Forms.ComboBox TScomboBox;
        private System.Windows.Forms.ComboBox TNcomboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label ProfileNlabel;
        private System.Windows.Forms.Label ProfilePlabel;
        private System.Windows.Forms.Label ProfileClabel;
        private System.Windows.Forms.TextBox ProfileNtextBox;
        private System.Windows.Forms.TextBox ProfilePtextBox;
        private System.Windows.Forms.TextBox ProfileCtextBox;
        private System.Windows.Forms.Button ProfileUpdateBTN;
        private System.Windows.Forms.Button ProfileCancelBTN;
    }
}