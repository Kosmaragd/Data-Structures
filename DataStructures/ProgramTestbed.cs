namespace DataStructures
{
    public class ProgramTestbed
    {
        public static void Main(string[] args)
        {
            ArrayList.ArrayList<string> list = new ArrayList.ArrayList<string>(10);

            string name = "Kostas";
            string name2 = "Kostaras";
            list.Add(name);
            list.Add(name2);

            Console.WriteLine(list.Get(0));
            Console.WriteLine(list.Get(11));
        }
    }
}
