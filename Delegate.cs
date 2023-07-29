namespace DelegateNameSpace
{
    
    public class DelegateClass{
        public delegate void add(int a, int b);
        public delegate void mul(int a,int b);
    
    public  void sum(int a, int b){
        Console.WriteLine(a+b);
    }
    public  void multiply(int a, int b){
        Console.WriteLine(a*b);
    }
    }


}