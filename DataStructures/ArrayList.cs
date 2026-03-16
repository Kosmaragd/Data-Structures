namespace DataStructures.ArrayList
{
    public class ArrayList<T> : IList<T>
    {
        #region Array Initialization
        private T[] array;
        private const int expansionMultiplier = 2;
        private int count;
        #endregion

        public ArrayList(int sizeAllocation)
        {
            array = new T[sizeAllocation];
        }

        public T Get(int index)
        {
            if (index > array.Length)
            {
                throw new IndexOutOfRangeException("The selected index is out of range");
            }
            return array[index];
        }

        public int Add(T element)
        {
            if (array.Length == count)
            {
                Resize(); //TODO FIX THIS
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = element;
                    break;
                }
                count++;
            }
            return array.Length;
        }

        public void Remove(int index)
        {
            //TODO FIX REMOVING ITEMS
            T elementToRemove = array[index];
            if (array[index].Equals(elementToRemove))
            {
                for (int i = 0;i < array.Length; i++)
                {
                    array[index -1] = elementToRemove;
                    if(elementToRemove == null)
                    {
                        elementToRemove = array[index - 1];
                    }
                }
                count--;
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
            //for(int i = startAt; i< array.Length; i++)
            //{
            //    if (array[i] == )
            //    {

            //    }
            //}
            //return -1;
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
            for (int i = 0; i < array.Length; i++)                        //thus remaining out of the interface
            {
                array[i] = copyArray[i];
            }
            array = copyArray;
        }
    }
}
