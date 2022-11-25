using System;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Cat cat = new Cat("кот", "мяу");
            Dog dog = new Dog("пёс", "гав");
            cat.ShowInfo( );
            dog.ShowInfo();

        }
    }
}
