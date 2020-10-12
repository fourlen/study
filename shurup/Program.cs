using System;
using System.Collections.Generic;
using System.IO;


namespace shurup
{
    class program
    {
        static void Main(string[] args)
        {
            Cow cow = new Cow();
            cow.Say();
            Dog dog = new Dog();
            dog.Say();
            Cat cat = new Cat();
            cat.Say();
        }
    }
}