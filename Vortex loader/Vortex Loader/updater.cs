//Hello pasters :D
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vortex_Loader
{

    public partial class updater : MetroForm
    {
        public static bool IsConnectedToInternet
        {
            get
            {
                Uri url = new Uri(settings.ping);
                string pingurl = string.Format("{0}", url.Host);
                string host = pingurl;
                bool result = false;
                Ping p = new Ping();
                try
                {
                    PingReply reply = p.Send(host, 3000);
                    if (reply.Status == IPStatus.Success)
                        return true;
                }
                catch { }
                return result;
            }
        }

        public updater()
        {
            InitializeComponent();
        }

        private void updater_Load(object sender, EventArgs e)
        {
            if (!IsConnectedToInternet) //user is not connected to internet
            {
                MessageBox.Show("Not connected to internet!\n Please check your connection.", settings.cheatname);
            }
            else //user is connected to internet
            {
                WebClient client = new WebClient();
                var newversion = client.DownloadString(settings.versiontxt);
                var newversionparsed = int.Parse(newversion);
                if (settings.version < newversionparsed) //check if the version in the txt file is higher than the one in settings.cs
                {
                        progressBar1.Increment(1);
                        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                        var stringChars = new char[8];
                        var random = new Random();
                        for (int i = 0; i < stringChars.Length; i++)
                        {
                            stringChars[i] = chars[random.Next(chars.Length)];
                        }
                        var finalString = new String(stringChars);

                        // Downloading the new version
                        WebClient myWebClient = new WebClient();
                        myWebClient.DownloadFile(settings.loaderexe, Directory.GetCurrentDirectory() + "/" + finalString + ".exe");
                        System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "/" + finalString + ".exe");
                        Application.Exit();

                  
                } else
                {
                    this.Hide();
                    login form = new login(); //version in txt is not higher than the one in settings.cs so it will show the login form
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                }
            }
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
