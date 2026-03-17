namespace DataStructures
{
    public class ProgramTestbed
    {
        public static void Main(string[] args)
        {
            ArrayList.ArrayList<string> list = new ArrayList.ArrayList<string>(2);

            string name1 = "bobo";
            string name2 = "Aristotle";
            string name3 = "Platon";
            string name4 = "Socrates";
            string name5 = "Beggar Of Scorn";

            list.Add(name1);
            list.Add(name2);

            Console.WriteLine(list.Get(0));
            Console.WriteLine(list.Get(1));
            Console.WriteLine(list.Size());
        }
    }
}
