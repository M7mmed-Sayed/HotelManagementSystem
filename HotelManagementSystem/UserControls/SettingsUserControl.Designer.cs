﻿namespace HotelManagementSystem.UserControls
{
    partial class SettingsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.birthOfDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchBtn = new System.Windows.Forms.Button();
            this.getUsersBtn_deleteUser = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.ssnUpdateDeleteTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1077, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1069, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add User";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.addressTextBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.birthOfDateDateTimePicker);
            this.groupBox2.Controls.Add(this.firstNameTextBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.userTypeComboBox);
            this.groupBox2.Controls.Add(this.registerBtn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lastNameTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.genderComboBox);
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Controls.Add(this.usernameTextBox);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(this.mobileNumberTextBox);
            this.groupBox2.Controls.Add(this.ssnTextBox);
            this.groupBox2.Location = new System.Drawing.Point(133, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 525);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(495, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 22);
            this.label16.TabIndex = 39;
            this.label16.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.Location = new System.Drawing.Point(495, 51);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PlaceholderText = "Enter your address";
            this.addressTextBox.Size = new System.Drawing.Size(278, 27);
            this.addressTextBox.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(17, 388);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 22);
            this.label15.TabIndex = 37;
            this.label15.Text = "Birthdate";
            // 
            // birthOfDateDateTimePicker
            // 
            this.birthOfDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthOfDateDateTimePicker.Location = new System.Drawing.Point(17, 411);
            this.birthOfDateDateTimePicker.Name = "birthOfDateDateTimePicker";
            this.birthOfDateDateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.birthOfDateDateTimePicker.TabIndex = 36;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTextBox.Location = new System.Drawing.Point(17, 135);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PlaceholderText = "Enter your first name";
            this.firstNameTextBox.Size = new System.Drawing.Size(278, 27);
            this.firstNameTextBox.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(17, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 22);
            this.label14.TabIndex = 34;
            this.label14.Text = "First Name";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(495, 371);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 22);
            this.label13.TabIndex = 33;
            this.label13.Text = "Acount Type";
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.userTypeComboBox.Location = new System.Drawing.Point(495, 395);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(278, 28);
            this.userTypeComboBox.TabIndex = 32;
            // 
            // registerBtn
            // 
            this.registerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.registerBtn.Location = new System.Drawing.Point(241, 469);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(278, 51);
            this.registerBtn.TabIndex = 31;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(17, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTextBox.Location = new System.Drawing.Point(17, 211);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = "Enter your second name";
            this.lastNameTextBox.Size = new System.Drawing.Size(278, 27);
            this.lastNameTextBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(495, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(495, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(495, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mobile Number";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "SSN";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(17, 343);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(278, 28);
            this.genderComboBox.TabIndex = 22;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(495, 317);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PlaceholderText = "Enter your password";
            this.passwordTextBox.Size = new System.Drawing.Size(278, 27);
            this.passwordTextBox.TabIndex = 21;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Location = new System.Drawing.Point(495, 228);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Enter your username";
            this.usernameTextBox.Size = new System.Drawing.Size(278, 27);
            this.usernameTextBox.TabIndex = 20;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Location = new System.Drawing.Point(495, 135);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PlaceholderText = "Enter your email address";
            this.emailTextBox.Size = new System.Drawing.Size(278, 27);
            this.emailTextBox.TabIndex = 19;
            // 
            // mobileNumberTextBox
            // 
            this.mobileNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mobileNumberTextBox.Location = new System.Drawing.Point(17, 281);
            this.mobileNumberTextBox.Name = "mobileNumberTextBox";
            this.mobileNumberTextBox.PlaceholderText = "Enter your phone number";
            this.mobileNumberTextBox.Size = new System.Drawing.Size(278, 27);
            this.mobileNumberTextBox.TabIndex = 18;
            this.mobileNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mobileNumberTextBox_KeyPress);
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ssnTextBox.Location = new System.Drawing.Point(17, 51);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.PlaceholderText = "Enter your SSN";
            this.ssnTextBox.Size = new System.Drawing.Size(278, 27);
            this.ssnTextBox.TabIndex = 17;
            this.ssnTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ssnTextBox_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.searchBtn);
            this.tabPage2.Controls.Add(this.getUsersBtn_deleteUser);
            this.tabPage2.Controls.Add(this.deleteBtn);
            this.tabPage2.Controls.Add(this.ssnUpdateDeleteTextBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1069, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search/Delete User";
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBtn.BackColor = System.Drawing.Color.Gray;
            this.searchBtn.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.Location = new System.Drawing.Point(754, 25);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(94, 33);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // getUsersBtn_deleteUser
            // 
            this.getUsersBtn_deleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getUsersBtn_deleteUser.BackColor = System.Drawing.Color.SlateGray;
            this.getUsersBtn_deleteUser.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getUsersBtn_deleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getUsersBtn_deleteUser.Location = new System.Drawing.Point(870, 20);
            this.getUsersBtn_deleteUser.Name = "getUsersBtn_deleteUser";
            this.getUsersBtn_deleteUser.Size = new System.Drawing.Size(123, 43);
            this.getUsersBtn_deleteUser.TabIndex = 4;
            this.getUsersBtn_deleteUser.Text = "Get Users";
            this.getUsersBtn_deleteUser.UseVisualStyleBackColor = false;
            this.getUsersBtn_deleteUser.Click += new System.EventHandler(this.getUsersBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteBtn.BackColor = System.Drawing.Color.Gray;
            this.deleteBtn.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Location = new System.Drawing.Point(640, 25);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 33);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ssnUpdateDeleteTextBox
            // 
            this.ssnUpdateDeleteTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ssnUpdateDeleteTextBox.Location = new System.Drawing.Point(288, 25);
            this.ssnUpdateDeleteTextBox.Name = "ssnUpdateDeleteTextBox";
            this.ssnUpdateDeleteTextBox.PlaceholderText = "Enter your SSN";
            this.ssnUpdateDeleteTextBox.Size = new System.Drawing.Size(326, 27);
            this.ssnUpdateDeleteTextBox.TabIndex = 2;
            this.ssnUpdateDeleteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ssnUpdateDeleteTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(232, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "SSN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 459);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Teal;
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1069, 535);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Change Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.confirmNewPasswordTextBox);
            this.groupBox1.Controls.Add(this.changePasswordBtn);
            this.groupBox1.Controls.Add(this.usernameLabel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.newPasswordTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.oldPasswordTextBox);
            this.groupBox1.Location = new System.Drawing.Point(291, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 383);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // confirmNewPasswordTextBox
            // 
            this.confirmNewPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(225, 235);
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            this.confirmNewPasswordTextBox.PlaceholderText = "Confirm your  new password";
            this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(326, 27);
            this.confirmNewPasswordTextBox.TabIndex = 9;
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changePasswordBtn.BackColor = System.Drawing.Color.DimGray;
            this.changePasswordBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changePasswordBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changePasswordBtn.Location = new System.Drawing.Point(194, 295);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(158, 59);
            this.changePasswordBtn.TabIndex = 13;
            this.changePasswordBtn.Text = "Change";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLabel.Location = new System.Drawing.Point(107, 37);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(206, 24);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "Your Loged in with  ?";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(39, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 22);
            this.label11.TabIndex = 11;
            this.label11.Text = "Confirm new password:";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTextBox.Location = new System.Drawing.Point(225, 163);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PlaceholderText = "Enter the new password again";
            this.newPasswordTextBox.Size = new System.Drawing.Size(326, 27);
            this.newPasswordTextBox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(39, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Old Password:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(39, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "New Password:";
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPasswordTextBox.Location = new System.Drawing.Point(225, 100);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.PlaceholderText = "Enter your old password";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(326, 27);
            this.oldPasswordTextBox.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(1077, 568);
            this.Load += new System.EventHandler(this.SettingsUserControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button deleteBtn;
        private TextBox ssnUpdateDeleteTextBox;
        private Label label8;
        private DataGridView dataGridView1;
        private Button searchBtn;
        private TextBox ssn_SearchTextBox;
        private Label label9;
        private DataGridView dataGridView2;
        private Button changePasswordBtn;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox confirmNewPasswordTextBox;
        private TextBox newPasswordTextBox;
        private TextBox oldPasswordTextBox;
        private ErrorProvider errorProvider1;
        private Button getUsersBtn_deleteUser;
        private Button getUsersBtn_userDetails;
        private Label usernameLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label13;
        private ComboBox userTypeComboBox;
        private Button registerBtn;
        private Label label7;
        private TextBox lastNameTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox genderComboBox;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private TextBox emailTextBox;
        private TextBox mobileNumberTextBox;
        private TextBox ssnTextBox;
        private TextBox firstNameTextBox;
        private Label label14;
        private Label label15;
        private DateTimePicker birthOfDateDateTimePicker;
        private Label label16;
        private TextBox addressTextBox;
    }
}
