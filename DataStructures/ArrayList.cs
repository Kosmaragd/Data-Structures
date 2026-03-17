namespace DataStructures.ArrayList
{
    public class ArrayList<T> : IList<T>
    {
        #region Array Initialization
        private T[] array;
        private const int expansionMultiplier = 2;
        private int count;
        private readonly int startingSize;
        #endregion

        public ArrayList(int sizeAllocation)
        {
            array = new T[sizeAllocation];
            count = sizeAllocation;
            startingSize = sizeAllocation;
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
            if (array.Length <= count + 1)
            {
                Resize();
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
            if (index < 0 || index > array.Length)
            {
                throw new IndexOutOfRangeException("The current index is outside the bounds of the list");
            }
            T[] tempArray = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    array[i] = tempArray[i - 1];
                    break;
                }
            }
            count--;
        }

        public void Clear()
        {
            T[] tempArray = new T[startingSize];
            array = tempArray; //TODO MAKE THE CLEAR 
        }

        public int Find(T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    return i;
                }
            }
            throw new NullReferenceException();
        }

        public int Find(T element, int startAt)
        {
            for (int i = startAt; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    return i;
                }
            }
            throw new NullReferenceException();

        }

        public void Insert(T element, int index)
        {
            if (array.Length <= count + 1)
            {
                Resize();
            }

            if (index < 0 || index > array.Length)
            {
                throw new ArgumentOutOfRangeException("The Index is outside the bounds of the array");
            }

            for (int i = index; i < array.Length; i++)
            {
                array[i] = array[i + 1];
            }
            array[index] = element;
            
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
            T[] copyArray = new T[array.Length + expansionMultiplier];  //Resize method only concerns usage outside of main utilies 
            for (int i = 0; i < array.Length; i++)                      //of a List which is dynamically expanding size
            {                                                           //thus remaining out of the interface
                copyArray[i] = array[i];
            }
            array = copyArray;
        }
    }
}
