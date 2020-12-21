using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class File : FileSystemObject
    {
        public string name { get; set; }
        public File(string _name)
        {
            name = _name;
        }
        public FileSystemObject Copy()
        {
            return new File(name);
        }
        public void Show()
        {
            Console.WriteLine(name);
        }
    }
}