using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSmara.DataStructures
{
    public interface IMap<TKey, TValue>
    {
        public TValue Get(TKey key);

        public void Set(TKey key, TValue value);

        public int Size();

        public void Clear();

        public bool Contains(TKey key);
    }
}
