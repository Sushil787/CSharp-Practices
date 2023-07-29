namespace PartialNameSpace
{
    
    public partial class Tiger{
        string name {get;set;}
        string weight {get;set;}    
        public void eat(){
            Console.WriteLine("I can Eat");
        }
    } 
    public partial class Tiger{
        public Tiger(string name ,string weight){
            this.name = name;
            this.weight = weight;
        }

    }

    public partial class Tiger{
        public void sayWeight(){
            Console.WriteLine($"my weight is {this.weight}");
        }
    }
}