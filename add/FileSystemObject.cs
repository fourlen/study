using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    interface FileSystemObject
    {
        public string name { get; set; }
        public abstract FileSystemObject Copy();
        public abstract void Show();
    }
}
