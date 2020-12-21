﻿using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class FileSystem
    {
        public Folder folder = new Folder("Корневая папка");
        private class MementoReal : Memento
        {
            public Folder root { get; set; }
            public MementoReal(FileSystemObject _root)
            {
                root = (Folder)_root.Copy();
            }
        }
        public Memento CreateMemento()
        {
            Folder foldercopy = (Folder)folder.Copy();
            return new MementoReal(foldercopy);
        }
        public void Restore(Memento memento)
        {
            MementoReal mr = (MementoReal)memento;
            folder = (Folder)mr.root.Copy();
        }
    }
}
