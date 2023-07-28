using System;
using System.Collections.Generic;
using System.Linq;

namespace oop
{

    public abstract class AbstractAnimal
    {


        public abstract void Init();
        public virtual void Poop()
        {
            Console.WriteLine("Animal pooped");
        }


    }

    public class Dog : AbstractAnimal
    {
        public override void Init()
        {
            Console.WriteLine("Dog Wake up");
            base.Poop();
        }


    }


}