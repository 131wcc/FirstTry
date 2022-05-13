using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMessagement
{
    class Path
    {
        public string APpath = ".\\AP.txt";
        public string link = AppDomain.CurrentDomain.BaseDirectory;

        public Path()
        {
            AppDomain.CurrentDomain.SetData(" DataDirectory ", link);
            link += "Library.mdf";
            link = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + link + ";Integrated Security=True;Connect Timeout=30 ";
        }
    }
}
