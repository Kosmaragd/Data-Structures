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
            ints.Add(7);
            ints.Add(8);
            ints.Add(9);
            ints.Add(10);
            ints.Add(2);

            Console.WriteLine(ints.Find(2,8));
            Console.WriteLine(ints.Find(5));
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
