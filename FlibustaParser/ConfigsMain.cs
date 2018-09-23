using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlibustaParser
{
    public static class ConfigsMain
    {
        static public string GetDomen()
        {
            return "http://flibusta.is";
        }
        static public string GetImageDirectory()
        {
            var imagesDirectory=Environment.CurrentDirectory + @"\Images\";
            return imagesDirectory;

        }
        static public string GetMainDirrectory()
        {
            var currentDirectory = Environment.CurrentDirectory;
            return currentDirectory;
        }
        static public string GetBookDirectory()
        {
            var bookDirectory = Environment.CurrentDirectory + @"\Books\";
            return bookDirectory;
        }
    }
}
