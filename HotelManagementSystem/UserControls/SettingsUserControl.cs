﻿using HotelManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.UserControls
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.registerNewUser(ssnTextBox, firstNameTextBox, lastNameTextBox, addressTextBox, genderComboBox, mobileNumberTextBox, birthOfDateDateTimePicker, emailTextBox, usernameTextBox, passwordTextBox, userTypeComboBox, errorProvider1);
            updateGridView();
        }



        private void getUsersBtn_Click(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void updateGridView()
        {
            HotelDbContext.showAllUsers(dataGridView1);
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.deleteUser(ssnUpdateDeleteTextBox, errorProvider1);
            updateGridView();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.changePassword(oldPasswordTextBox, newPasswordTextBox, confirmNewPasswordTextBox, errorProvider1);
            updateGridView();
        }

        private void SettingsUserControl_Load(object sender, EventArgs e)
        {

            updateGridView();
            if (!LoginInfo._isAdmin)
            {
                tabControl1.TabPages.Remove(tabPage1);
               tabControl1.TabPages.Remove(tabPage2);
            }
           usernameLabel.Text = usernameLabel.Text.Replace("?", LoginInfo._username);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.showUserWithSSN(ssnUpdateDeleteTextBox, dataGridView1, errorProvider1);
        }

        private void ssnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void mobileNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '+')
                e.Handled = true;
        }

        private void ssnUpdateDeleteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }




        //     MessageBox.Show("username " + LoginInfo._username + "\n" + "password " + LoginInfo._password + "\n" + "isAdmin " + LoginInfo._isAdmin + "\n");

    }
}
