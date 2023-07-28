
using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanSpace
{

    public class Human
    {   


        public Human(string age, string name, double height){
            this.age = age;
            this.name = name;
            this.height = height;
        }
        
        string age {get;set;}
        string name {get;set;}
        double height {get;set;}
        public void Talk (){
            Console.WriteLine($"my name is {name}");
        }

    }

    public class ReadData{
        public static void ReadUserInput(){
            Console.WriteLine("Enter Your Detail\n");
            Console.WriteLine("Enter Your name:");
            
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Enter Your height:");
            string height = Console.ReadLine();


            Human sushil = new Human(age,name,Convert.ToDouble(height));
            sushil.Talk();
        }
    }


}