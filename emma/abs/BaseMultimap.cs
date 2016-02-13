using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emma.abs
{
    public abstract class BaseMultimap<TKey, TValue> : IMultimap<TKey, TValue>
    {
        protected IDictionary<TKey,TValue> Data
        {
            get;
            private set;
        }

        public int Count
        {
            get
            {
                return Data.Count;
            }
        }

        public ICollection<TKey> Keys { get { return Data.Keys; } }
        public ICollection<TValue> Values { get { return Data.Values; } }

        public BaseMultimap()
        {
            Data = new Dictionary<TKey, TValue>();
        }

        public TValue Get(TKey key)
        {
            return Data[key];
        }

        public bool Remove(TKey key)
        {
            return Data.Remove(key);
        }

        public bool ContainsKey(TKey key)
        {
            return Data.ContainsKey(key);
        }
    }
}
