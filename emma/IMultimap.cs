using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Emma
{
    public interface IMultimap<K, V>
    {
        V Get(K key);
        bool Remove(K key);
        bool ContainsKey(K key);
        int Count { get; }
    }
}
