# Emma multimaps

This project contains a set of Multimaps I use. These data structures are replacements for times when you have a Dictionary where the value type is not just one value, for example a list.

Usually, you'd instantiate a `IDicionary<string, IList<int>> = new Dictionary<string, IList<int>>();`.  With these data structures you can use something like `ListMultimap<string, int>`.

## 
* `ListMultimap<TKey, TValue>` gives you `IDicionary<TKey, IList<TValue>>`
* `SetMultimap<TKey, TValue>` gives you `IDictionary<TKey, ISet<TValue>>`
