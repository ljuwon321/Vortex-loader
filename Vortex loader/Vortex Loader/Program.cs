using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vortex_Loader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new updater());
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