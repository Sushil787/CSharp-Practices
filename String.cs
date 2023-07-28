
using System;
using System.Collections.Generic;
using System.Linq;
using oop;
using AnimalSpace;

namespace HumanSpace
{

    public class Human : IHuman
    {


        public Human(string age, string name, double height)
        {
            this.age = age;
            this.name = name;
            this.height = height;
        }

        string age { get; set; }
        string name { get; set; }
        double height { get; set; }
        public void Talk()
        {
            Console.WriteLine($"my name is {name}");
        }
        public void Walk()
        {
            Console.WriteLine("I am waking");
        }
        public void Sleep()
        {
            Console.WriteLine("I am sleeping");

        }

    }

    public class ReadData
    {
        public static void ReadUserInput()
        {
            Console.WriteLine("Enter Your Detail\n");
            Console.WriteLine("Enter Your name:");

            string name = Console.ReadLine();
            Console.WriteLine("Enter Your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Enter Your height:");
            string height = Console.ReadLine();
            Human sushil = new Human(age, name, Convert.ToDouble(height));
            sushil.Talk();
        }

        public static void ReadAnimalData()
        {
            Dog baga = new Dog();
            baga.Init();
        }
        public static void ReadSelaedSpaceData(){
            Doge dog =new  Doge();
            Cow co = new Cow();
            Cat ca = new Cat();

        }
    }


}