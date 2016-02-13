using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emma.abs
{
    public abstract class BaseSetMultimap<TKey, TValue> : BaseMultimap<TKey, ISet<TValue>>
    {
        public abstract void Add(TKey key, TValue value);
    }
}
