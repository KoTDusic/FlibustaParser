using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlibustaParser
{
    public partial class GenreSelector : Form
    {
        string _genreListLocator = "//div[@id='main']/h3";
        public GenreSelector()
        {
            InitializeComponent();
        }
        string GetLocatorFromId(int id)
        {
            return "(//div[@id='main']/h3/following-sibling::ul)["+id+"]//a[not(@name)]";
        }
        /*string ParseGenreList()
        {
            
        }*/
    }
}
