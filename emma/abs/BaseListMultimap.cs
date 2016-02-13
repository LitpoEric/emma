using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emma.abs
{
    public abstract class BaseListMultimap<TKey, TValue> : BaseMultimap<TKey,IList<TValue>>
    {
        public abstract void Put(TKey key, TValue value);
    }
}
