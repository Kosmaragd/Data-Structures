namespace DataStructures
{
    public class ProgramTestbed
    {
        public static void Main(string[] args)
        {
            ArrayList.ArrayList<string> list = new ArrayList.ArrayList<string>(5);

            string name1 = "bobo";
            string name2 = "Aristotle";
            string name3 = "Platon";
            string name4 = "Socrates";
            string name5 = "Beggar Of Scorn";

            list.Add(name1);
            list.Add(name2);
            list.Insert(name5, 1);

            for(int i = 0;i < list.Size(); i++)
            {
                Console.WriteLine(list.Get(i));
            }
            Console.WriteLine(list.Size());
        }
    }
}
