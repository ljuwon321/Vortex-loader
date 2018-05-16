using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vortex_Loader.ManualMap
{
    internal static class Helpers
    {
        internal static string ToStringAnsi(byte[] buffer)
        {
            var sb = new StringBuilder();
            foreach (var t in buffer)
            {
                if (t == 0)
                {
                    break;
                }

                sb.Append((char)t);
            }

            return sb.ToString();
        }

        internal static bool _stricmp(char[] str1, char[] str2)
        {
            var min = Math.Min(str1.Length, str2.Length);
            for (var i = 0; i < min; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }

                if (str1[i] == 0)
                {
                    break;
                }
            }

            return true;
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