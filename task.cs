using System.Threading.Tasks;
namespace TaskNameSpace
{

    public class TaskClass
    {
        public static  async Task TaskMethod(){
            
            Console.WriteLine("hhelloi");

            await Task.Delay(3000);
            Console.WriteLine("hi");

        }
}
}