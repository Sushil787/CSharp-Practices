
using System;
using DelegateNameSpace;

using PartialNameSpace;
namespace MainProgram
{
    public class PublicClass
    {
        public static void Main(string[] args)
        {
            // ReadData.ReadSelaedSpaceData();
            // ReadData.ReadUserInput();
            // ReadData.ReadAnimalData();
            // ReadData.ReadIndexerClass();
            // Tiger tiger = new Tiger("sushil", "69");
            // tiger.sayWeight();
            // tiger.eat();
            
            DelegateClass delegateClass = new DelegateClass();
            add sum = new add(delegateClass.sum());
            num(1,2);
        }
    }
}
