using Emma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Emma.abs;

namespace Emma.impl
{
    
    [Serializable]
    public class HashMultimap<K, V> : BaseSetMultimap<K, V>
    {        
        public override void Add(K key, V value)
        {
            ISet<V> set = null;
            if(!Data.TryGetValue(key, out set))
            {
                set = new HashSet<V>();
                Data[key] = set;
            }

            set.Add(value);
        }
        
    }
}
