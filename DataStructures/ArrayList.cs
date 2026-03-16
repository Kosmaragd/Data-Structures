namespace DataStructures.ArrayList
{
    public class ArrayList<T> : IList<T>
    {
        private T[] array;
        private const int sizeIncrement = 10;
        private readonly int expansionMultiplier = 2;
        private int count;
        public ArrayList(int sizeAllocation)
        {
            array = new T[sizeAllocation];
            count = sizeAllocation;
        }

        public T Get(int index)
        {
            if(index > array.Length)
            {
                throw new IndexOutOfRangeException("The selected index is out of range");
            }
            return array[index];
        }

        public int Add(T element)
        {
            if(array.Length > array.Length + 1) Resize(); //TODO FIX THIS
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = element;
            }
            return array.Length;
        }

        public void Remove(int offset)
        {
            for(int i = 0;i < array.Length; i++)
            {

            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int Find(T element)
        {
            throw new NotImplementedException();
        }

        public int Find(T element, int startAt)
        {
            throw new NotImplementedException();
        }

  
        public void Insert(T element, int index)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            return array.Length;
        }

        /// <summary>
        /// Expands the current size of the array 
        /// </summary>
        public void Resize() 
        {
            T[] copyArray = new T[array.Length * expansionMultiplier];  //Resize method only concerns usage outside of main utilies of a List
            for (int i = 0;i< array.Length; i++)                        //thus remaining out of the interface
            {
                array[i] = copyArray[i];
            }
            array = copyArray;
        }
    }
}
