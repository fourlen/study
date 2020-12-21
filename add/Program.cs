using System;
using System.Collections.Generic;
using System.IO;


namespace add
{

    class program
    {
        static void Main(string[] args)
        {
            FileSystem fs = new FileSystem();
            CareTaker cr = new CareTaker();
            FileSystemObject file1 = new File("Файл 1");
            fs.folder.files.Add(file1);
            Folder papka2 = new Folder("Подпапка");
            File file2 = new File("Файл 2");
            papka2.files.Add(file2);
            fs.folder.files.Add(papka2);
            fs.folder.Show();
            cr.Save(fs.CreateMemento());
            File file3 = new File("Файл 3");
            File file4 = new File("Файл 4");
            fs.folder.files.Add(file3);
            papka2.files.Add(file4);
            fs.folder.Show();
            fs.Restore(cr.Load(0));
            fs.folder.Show();
        }
    }
}