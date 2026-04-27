using KSmara.DataStructures;

namespace KSmara.DataStructures.HashMap
{
    public class HashMap<TKey, TValue> : IMap<TKey, TValue>
    {
        private static int MAX_BUCKETS = 1009;
        private List<KVPair<TKey, TValue>>[] _buckets = new List<KVPair<TKey, TValue>>[MAX_BUCKETS];
        private bool hasFoundSlot = false;

        public class KVPair<TKey, TValue>
        {
            public TKey key;
            public TValue value;
        }

        public void Clear()
        {
            foreach (List<KVPair<TKey, TValue>> bucket in _buckets)
            {
                bucket?.Clear();
            }
        }

        public bool Contains(TKey key)
        {
            if (key == null)
            {
                throw new NullReferenceException();
            }

            uint hashCode = (uint)key.GetHashCode();

            uint index = hashCode % (uint)_buckets.Length;

            if (_buckets[index] == null)
            {
                return false;
            }

            foreach (KVPair<TKey, TValue> pair in _buckets[index])
            {
                if (pair.key.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }

        public TValue Get(TKey key)
        {
            if (key == null)
            {
                throw new NullReferenceException();
            }

            uint hashCode = (uint)key.GetHashCode();

            uint index = hashCode % (uint)_buckets.Length;

            if (_buckets[index] == null)
            {
                _buckets[index] = new List<KVPair<TKey, TValue>>();
            }

            List<KVPair<TKey, TValue>> newBucket = _buckets[index];

            foreach (KVPair<TKey, TValue> k in newBucket)
            {
                if (k.key.Equals(key))
                {
                    return k.value;
                }
            }
            throw new KeyNotFoundException();
        }

        public void Set(TKey key, TValue value)
        {
            if (key == null)
            {
                throw new NullReferenceException();
            }
            uint hashCode = (uint)key.GetHashCode(); //Get hash

            uint index = hashCode % (uint)_buckets.Length; //Get index

            if (_buckets[index] == null)
            {
                _buckets[index] = new List<KVPair<TKey, TValue>>();
            }

            List<KVPair<TKey, TValue>> refBucket = _buckets[index];  //Checks currentBucket 

            foreach (KVPair<TKey, TValue> k in refBucket)
            {
                if (k.key.Equals(key))
                {
                    k.value = value;
                    return;
                }
            }
            refBucket.Add(new KVPair<TKey, TValue> { key = key, value = value });
        }

        public int Size()
        {
            return _buckets.Length;
        }
    }
}