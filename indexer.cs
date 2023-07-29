namespace oop
{
    public class IndexerClass {
        public string[] val = new string[3];

        public string this[int index]{
            get{
                return val[index];
            }
            set{
                val[index] = value;
            }
        }

    }
}