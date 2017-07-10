namespace pms
{
    partial class Administrator_panel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addManager = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterStatusComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterTextboxLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filterComboboxLabel = new System.Windows.Forms.Label();
            this.ManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UMCombobox = new System.Windows.Forms.ComboBox();
            this.UMEmail = new System.Windows.Forms.TextBox();
            this.UMRole = new System.Windows.Forms.TextBox();
            this.UMContact = new System.Windows.Forms.TextBox();
            this.UMStatusBtn = new System.Windows.Forms.Button();
            this.UMCancelBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.UMStatusCombobox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 361);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabIndexChange);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cancel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addManager, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 329);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(357, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(348, 20);
            this.textBox2.TabIndex = 4;
            // 
            // cancel
            // 
            this.cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(357, 203);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(348, 123);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // addManager
            // 
            this.addManager.Dock = System.Windows.Forms.DockStyle.Left;
            this.addManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addManager.Location = new System.Drawing.Point(3, 203);
            this.addManager.Name = "addManager";
            this.addManager.Size = new System.Drawing.Size(348, 123);
            this.addManager.TabIndex = 7;
            this.addManager.Text = "Add Manager";
            this.addManager.UseVisualStyleBackColor = true;
            this.addManager.Click += new System.EventHandler(this.addManager_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(357, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(348, 20);
            this.textBox3.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ManagerDataGridView, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.93313F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.06687F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(708, 329);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterStatusComboBox);
            this.groupBox1.Controls.Add(this.filterButton);
            this.groupBox1.Controls.Add(this.filterTextBox);
            this.groupBox1.Controls.Add(this.filterTextboxLabel);
            this.groupBox1.Controls.Add(this.filterComboBox);
            this.groupBox1.Controls.Add(this.filterComboboxLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Panel";
            // 
            // filterStatusComboBox
            // 
            this.filterStatusComboBox.FormattingEnabled = true;
            this.filterStatusComboBox.Items.AddRange(new object[] {
            "Active",
            "Unactive"});
            this.filterStatusComboBox.Location = new System.Drawing.Point(382, 21);
            this.filterStatusComboBox.Name = "filterStatusComboBox";
            this.filterStatusComboBox.Size = new System.Drawing.Size(193, 21);
            this.filterStatusComboBox.TabIndex = 5;
            this.filterStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.filterStatusComboBox_SelectedIndexChanged);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(596, 21);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(100, 21);
            this.filterButton.TabIndex = 4;
            this.filterButton.Text = "Search";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(382, 22);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(193, 20);
            this.filterTextBox.TabIndex = 3;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // filterTextboxLabel
            // 
            this.filterTextboxLabel.AutoSize = true;
            this.filterTextboxLabel.Location = new System.Drawing.Point(259, 25);
            this.filterTextboxLabel.Name = "filterTextboxLabel";
            this.filterTextboxLabel.Size = new System.Drawing.Size(107, 13);
            this.filterTextboxLabel.TabIndex = 2;
            this.filterTextboxLabel.Text = "Search Manager By :";
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Show All",
            "Name",
            "E-mail",
            "Contact",
            "Status"});
            this.filterComboBox.Location = new System.Drawing.Point(65, 22);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(149, 21);
            this.filterComboBox.TabIndex = 1;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // filterComboboxLabel
            // 
            this.filterComboboxLabel.AutoSize = true;
            this.filterComboboxLabel.Location = new System.Drawing.Point(6, 25);
            this.filterComboboxLabel.Name = "filterComboboxLabel";
            this.filterComboboxLabel.Size = new System.Drawing.Size(53, 13);
            this.filterComboboxLabel.TabIndex = 0;
            this.filterComboboxLabel.Text = "Filter By : ";
            // 
            // ManagerDataGridView
            // 
            this.ManagerDataGridView.AllowUserToAddRows = false;
            this.ManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.Email,
            this.Contact,
            this.Role,
            this.Status});
            this.ManagerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagerDataGridView.Location = new System.Drawing.Point(3, 61);
            this.ManagerDataGridView.Name = "ManagerDataGridView";
            this.ManagerDataGridView.ReadOnly = true;
            this.ManagerDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManagerDataGridView.Size = new System.Drawing.Size(702, 265);
            this.ManagerDataGridView.TabIndex = 1;
            // 
            // userName
            // 
            this.userName.HeaderText = "Name";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(714, 335);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.UMCombobox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.UMEmail, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.UMRole, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.UMContact, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.UMStatusBtn, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.UMCancelBtn, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.UMStatusCombobox, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(714, 335);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Role";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Contact";
            // 
            // UMCombobox
            // 
            this.UMCombobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UMCombobox.FormattingEnabled = true;
            this.UMCombobox.Location = new System.Drawing.Point(360, 3);
            this.UMCombobox.Name = "UMCombobox";
            this.UMCombobox.Size = new System.Drawing.Size(351, 21);
            this.UMCombobox.TabIndex = 1;
            this.UMCombobox.SelectedIndexChanged += new System.EventHandler(this.UMCombobox_SelectedIndexChanged);
            // 
            // UMEmail
            // 
            this.UMEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UMEmail.Location = new System.Drawing.Point(360, 50);
            this.UMEmail.Name = "UMEmail";
            this.UMEmail.Size = new System.Drawing.Size(351, 20);
            this.UMEmail.TabIndex = 2;
            // 
            // UMRole
            // 
            this.UMRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UMRole.Location = new System.Drawing.Point(360, 97);
            this.UMRole.Name = "UMRole";
            this.UMRole.Size = new System.Drawing.Size(351, 20);
            this.UMRole.TabIndex = 3;
            // 
            // UMContact
            // 
            this.UMContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UMContact.Location = new System.Drawing.Point(360, 150);
            this.UMContact.Name = "UMContact";
            this.UMContact.Size = new System.Drawing.Size(351, 20);
            this.UMContact.TabIndex = 4;
            // 
            // UMStatusBtn
            // 
            this.UMStatusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UMStatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UMStatusBtn.Location = new System.Drawing.Point(3, 250);
            this.UMStatusBtn.Name = "UMStatusBtn";
            this.UMStatusBtn.Size = new System.Drawing.Size(351, 82);
            this.UMStatusBtn.TabIndex = 5;
            this.UMStatusBtn.Text = "Update Manager";
            this.UMStatusBtn.UseVisualStyleBackColor = true;
            this.UMStatusBtn.Click += new System.EventHandler(this.UMStatusBtn_Click);
            // 
            // UMCancelBtn
            // 
            this.UMCancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UMCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UMCancelBtn.Location = new System.Drawing.Point(360, 250);
            this.UMCancelBtn.Name = "UMCancelBtn";
            this.UMCancelBtn.Size = new System.Drawing.Size(351, 82);
            this.UMCancelBtn.TabIndex = 6;
            this.UMCancelBtn.Text = "Cancel";
            this.UMCancelBtn.UseVisualStyleBackColor = true;
            this.UMCancelBtn.Click += new System.EventHandler(this.UMCancelBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Status";
            // 
            // UMStatusCombobox
            // 
            this.UMStatusCombobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UMStatusCombobox.FormattingEnabled = true;
            this.UMStatusCombobox.Items.AddRange(new object[] {
            "Active",
            "Unactive"});
            this.UMStatusCombobox.Location = new System.Drawing.Point(360, 203);
            this.UMStatusCombobox.Name = "UMStatusCombobox";
            this.UMStatusCombobox.Size = new System.Drawing.Size(351, 21);
            this.UMStatusCombobox.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(714, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Administrator_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "Administrator_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator_panel";
            this.Load += new System.EventHandler(this.Administrator_panel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button addManager;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label filterComboboxLabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label filterTextboxLabel;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.DataGridView ManagerDataGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox UMCombobox;
        private System.Windows.Forms.TextBox UMEmail;
        private System.Windows.Forms.TextBox UMRole;
        private System.Windows.Forms.TextBox UMContact;
        private System.Windows.Forms.Button UMStatusBtn;
        private System.Windows.Forms.Button UMCancelBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox UMStatusCombobox;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox filterStatusComboBox;
    }
}