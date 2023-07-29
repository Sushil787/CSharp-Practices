using System;
namespace MethodOverridingClass
{
    
    public class A{
        public void Hi(){
            Console.WriteLine("Hi Sushil");
        }

    }
    public class B:A{

        public new  void Hi()
        {
           Console.WriteLine("HI Ram");
        }
    }
}