namespace MethodHiding
{
    
    public class A{
        public virtual void sayHi(){
            Console.WriteLine("Say Hi from A");
        }
    }
    public class B{
        public new void sayHi(){
            Console.WriteLine("Say Hi from B");
        } 
    }

    public static class C{
    // public static void Main(string[] args)
    //     {
    //         B b = new B();
    //         B.sayHi();  
    //     }
    // }
    }
}