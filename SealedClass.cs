namespace AnimalSpace
{
    public class AnimalClass
    {
        public AnimalClass()
        {

        }

        public void Hi(string name)
        {
            Console.WriteLine($"Hi i am {name}");
        }

    }

    public class Doge : AnimalClass
    {
        public Doge()
        {
            base.Hi("Dog");
        }

    }
    public class Cat : AnimalClass
    {
        public Cat()
        {
            base.Hi("cat");
        }

    }

    public class Cow : AnimalClass
    {
        public Cow()
        {
            base.Hi("Dog");
        }
    }


}