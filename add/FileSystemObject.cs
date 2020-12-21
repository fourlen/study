using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    interface FileSystemObject
    {
        public abstract FileSystemObject Copy();
        public abstract void Show();
    }
}
