using KSmara.DataStructures.HashMap;
using KSmara.DataStructures.ListMap;

namespace KSmara.DataStructures
{
    public class ProgramTestbed
    {
        public static void Main(string[] args)
        {
            //int[] ints = new int[4];

            //ints[0] = 0;
            //ints[1] = 1;
            //ints[2] = 2;
            //ints[3] = 3;
            //InstertAt(ints, 1, 3);


            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}

            //ArrayList.ArrayList<string> list = new ArrayList.ArrayList<string>(5);

            //string name1 = "bobo";
            //string name2 = "Aristotle";
            //string name3 = "Platon";
            //string name4 = "Socrates";
            //string name5 = "Beggar Of Scorn";

            //list.Add(name1);
            //list.Add(name2);
            //list.Insert(name5, 1);
            //list.Add(name5);
            //list.Remove(1);

            //for (int i = 0; i < list.Size(); i++)
            //{
            //    Console.WriteLine(list.Get(i));
            //}

            LinkedList.LinkedList<int> ints = new DataStructures.LinkedList.LinkedList<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);
            ints.Add(6);
            ints.ShowAllNodes();

            IMap<string,int> ageDictionary = new ListMap<string,int>();

            ageDictionary.Set("Koko", 10); //SUCC
            ageDictionary.Set("Despo", 5); //SUCC
            Console.WriteLine(ageDictionary.Contains("Koko")); //SUCC
            Console.WriteLine(ageDictionary.Get("Koko")); //SUCC

            IMap<string,string> EnglishDicitonary = new HashMap<string,string>();
            string resilience = "Resilience";
            string ephemeral = "Ephemeral";
            string resilienceDescription = "The ability to adapt well to adversity, trauma, tragedy, threats, or significant stress";
            string ephemeralDescription = "Lasting for a short time";
            string catharsis = "Catharsis";
            string catharsisDescription = "The release of strong emotions through art or experience";
            EnglishDicitonary.Set(resilience,resilienceDescription);
            EnglishDicitonary.Set(ephemeral,ephemeralDescription);
            EnglishDicitonary.Set(catharsis,catharsisDescription);
            Console.WriteLine(EnglishDicitonary.Get(resilience));
            Console.WriteLine(EnglishDicitonary.Get(ephemeral));
            Console.WriteLine(EnglishDicitonary.Get(catharsis));
        }

        //public static void InstertAt(int[] array, int index,int elementToAdd) //TESTER
        //{
        //    for(int i = array.Length -1; i > index; i--)
        //    {
        //        array[i] = array[i - 1];
        //    }
        //    array[index] = elementToAdd;
        //}
    }
}
