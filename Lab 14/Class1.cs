using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_14
{
     abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void ToSay();


    public void ShowInfo()
        {
            Console.WriteLine(Name);
            ToSay();
        }   
    }

    class Cat:Animal
    {
        private string name;
        string say;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Cat(string name, string say):base (name)
        {
            this.say = say;
        }
        public override void ToSay()
        {
            Console.WriteLine(say);
        }
    }
    class Dog : Animal
    {
        private string name;
        string say;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name, string say) : base(name)
        {
            this.say = say;
        }
        public override void ToSay()
        {
            Console.WriteLine(say);
        }
    }
}
