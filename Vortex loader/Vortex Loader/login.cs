//Hello pasters :D
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vortex_Loader
{
    public partial class login : MetroForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            settings.hwid1 = hwid.GetMachineGuid(); //hwid
            metroLabel1.Text = "Welcome to " + settings.cheatname;

            if (Properties.Settings.Default.Checked == true)
            {
                metroTextBox1.Text = Properties.Settings.Default.Username;
                metroTextBox2.Text = Properties.Settings.Default.Password;
                metroCheckBox1.Checked = Properties.Settings.Default.Checked;
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.DocumentText.Contains("p1")) //password is correct
            {
                if (webBrowser1.DocumentText.Contains("g4") || webBrowser1.DocumentText.Contains("g8") || webBrowser1.DocumentText.Contains("g3")) //group is correct
                {
                    if (webBrowser1.DocumentText.Contains("h1")) //hwid is correct
                    {
                        this.Hide();
                        inject form = new inject();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                    }
                    else if (webBrowser1.DocumentText.Contains("h2")) //hwid incorrect
                    {
                        metroLabel4.Text = "HWID Incorrect";
                    }
                    else if (webBrowser1.DocumentText.Contains("h3")) //new hwid set
                    {
                        metroLabel4.Text = "New HWID Set";
                    }
                }
                else //group incorrect
                {
                    metroLabel4.Text = "Group Incorrect";
                }
            }
            else //password incorrect
            {
                metroLabel4.Text = "Password Incorrect";
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            Process.Start(settings.discord); //discord
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            Process.Start(settings.forum); //forum
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(settings.checkphp + metroTextBox1.Text + "&password=" + metroTextBox2.Text + "&hwid=" + settings.hwid1); //check if info is correct
            Properties.Settings.Default.Username = metroTextBox1.Text;
            Properties.Settings.Default.Password = metroTextBox2.Text;
            Properties.Settings.Default.Checked = metroCheckBox1.Checked;
            Properties.Settings.Default.Save();
        }

    }
}

//-----------------------------------------------------
// Coded by Kanepu! Vortex loader source
// https://github.com/Kanepu/Vortex-loader
// Note to the person using this, removing this
// text is in violation of the license you agreed
// to by downloading. Only you can see this so what
// does it matter anyways.
// Copyright © Kanepu 2018
// Licensed under a MIT license
// Read the terms of the license here
// https://github.com/Kanepu/Vortex-loader/blob/master/LICENSE
//-----------------------------------------------------