using Emma;
using Emma.abs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emma.impl
{
    [Serializable]
    public class ListMultimap<K, V> : BaseListMultimap<K,V>
    {
        public override void Put(K key, V value)
        {
            IList<V> keyEntries = null;
            if(!(Data.TryGetValue(key, out keyEntries)))
            {
                keyEntries = new List<V>();
                Data[key] = keyEntries;
            }

            keyEntries.Add(value);
        }


    }
}
