using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vortex_Loader
{
    class settings
    {
        public static string ping = "http://yoursite.com"; //the site for the loader to ping
        public static string cheatname = "Vortex"; //your cheat's name
        public static int version = 0; //version
        public static string versiontxt = "http://yoursite.com/version.txt"; //location of version.txt on your site
        public static string loaderexe = "http://yoursite.com/loader.exe"; //location of the updated loader on your site
        public static string discord = "https://discord.gg/code"; //discord invite link
        public static string forum = "http://yoursite.com/forum"; //fprum link
        public static string checkphp = "http://yoursite.com/forum/check.php?username="; //check.php
        public static string hwid1; //hwid
        public static string dllonsite = "http://yoursite.com/cheat.dll"; //location of dll on your site
        public static string dllondevice = @"C:\cheat.dll"; //location of dll on device
        public static string unexpectedmsg = "Error: An unexpected error happened, loader will now restart"; //unexpected error
        public static string csgomsg = "Error: CS:GO is not open! Please start CS:GO then inject"; //csgo isnt running
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