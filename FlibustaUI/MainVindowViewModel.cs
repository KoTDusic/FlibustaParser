using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlibustaUI
{
    class MainVindowViewModel
    {
        public string Assembly { get; set; }

        public bool IsLoaded { get; set; }
        public MainVindowViewModel()
        {
            IsLoaded = false;
        }
    }
}
