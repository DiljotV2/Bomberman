using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;
using System.IO;

namespace Bomberman
{
    public static class MapReader
    {
        public static string Readmapcoords(this StreamReader reader)
        {
            return Convert.ToString(reader.ReadToEnd());
        }
    }
}
