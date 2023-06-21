﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;                  // ADD \\
using Microsoft.Win32;
using Application.IServices;

namespace MyApplication
{
    public partial class LoginForm : Usf.WinForms.Forms.Form
    {
        private readonly IUserService _userService;
        public LoginForm(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();

            #region Language

            ResourceManager resource = new ResourceManager
                ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

            UsernameLabel.Text =
                resource.GetString(name: nameof(UsernameLabel));

            PasswordLabel.Text =
                resource.GetString(name: nameof(PasswordLabel));

            EnterButton.Text =
                resource.GetString(name: nameof(EnterButton));

            ExitButton.Text =
                resource.GetString(name: nameof(ExitButton));

            LanguageLabel.Text =
                resource.GetString(name: nameof(LanguageLabel));

            SystemNameLabel.Text =
                resource.GetString(name: nameof(SystemNameLabel));

            this.Text =
                resource.GetString(name: nameof(LoginForm));

            #endregion / Language
        }

        // Loaded
        private void LoginForm_Load(object sender, EventArgs e)
        {
            RegistryUserName();

            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                PasswordLabel.Focus();
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
        }

        // Enter
        private async void EnterButton_Click(object sender, EventArgs e)
        {
            RegistryKey UserNameInRegistry = Registry.CurrentUser.CreateSubKey(@"Software\Inventory");

            if /*(await _userService.AuthenticateAsync(UsernameTextBox.Text, PasswordTextBox.Text, CancellationToken.None))*/(UsernameTextBox.Text == "1" && PasswordTextBox.Text == "1")
            {
                UserNameInRegistry.SetValue("UserNameKey", UsernameTextBox.Text.Trim());

                Program.CheckLogin = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه وارد شده است");

                return;
            }
        }

        // Registry
        private void RegistryUserName()
        {
            RegistryKey MasterKey = Registry.CurrentUser.CreateSubKey(@"Software\Inventory");

            UsernameTextBox.Text = (string?)MasterKey.GetValue("UserNameKey");
        }

        // Language
        private void LanguageLabel_Click(object sender, EventArgs e)
        {

            switch (ApplicationSettings.CurrentCulture)
            {
                case ApplicationSettings.Languages.English:
                    {
                        ApplicationSettings.CurrentCulture =
                            ApplicationSettings.Languages.Farsi;
                        break;
                    }
                case ApplicationSettings.Languages.Farsi:
                    {
                        ApplicationSettings.CurrentCulture =
                            ApplicationSettings.Languages.English;
                        break;
                    }
            }

            MyApp.Properties.Settings.Default.CurrentCulture =
                (int)ApplicationSettings.CurrentCulture;

            MyApp.Properties.Settings.Default.Save();

            System.Windows.Forms.Application.Restart();
        }

        // Exit
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


    }
}