//Hello pasters :D
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vortex_Loader.ManualMap;

namespace Vortex_Loader
{
    public partial class inject : MetroForm
    {
        public inject()
        {
            InitializeComponent();
        }

        private void inject_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("CSGO"); //0 you can add more if you want
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var name = "csgo";
            var target = Process.GetProcessesByName(name).FirstOrDefault();

            if (target != null) // if csgo is running 
            {
                WebClient download = new WebClient();
                download.DownloadFile(settings.dllonsite, settings.dllondevice); //download the dll

                if (!File.Exists(settings.dllondevice)) //check if the dll exists
                {
                    MessageBox.Show(settings.unexpectedmsg, settings.cheatname);
                    Application.Restart();
                }
                var dll = File.ReadAllBytes(settings.dllondevice);
                var injector = new ManualMapInjector(target) { AsyncInjection = true };
                metroLabel1.Text = $"hmodule = 0x{injector.Inject(dll).ToInt64():x8}"; //inject the dll into the target

                File.Delete(settings.dllondevice); //delete the dll
            }
            else
            {
                MessageBox.Show(settings.csgomsg, settings.cheatname); //csgo is not running
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