using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class Folder : FileSystemObject
    {
        public string name { get; set; }
        public List<FileSystemObject> files { get; set; } = new List<FileSystemObject>();
        public Folder(string _name)
        {
            name = _name;
        }
        public FileSystemObject Copy()
        {
            Folder copyfolder = new Folder(name);
            for (int i = 0; i < files.Count; i++)
            {
                copyfolder.files.Add(files[i].Copy());
            }
            return copyfolder;
        }
        public void Show()
        {
            Console.WriteLine($"Папка: {name}");
            for (int i = 0; i < files.Count; i++)
            {
                Console.Write($"    ");
                files[i].Show();
            }
        }
    }
}
