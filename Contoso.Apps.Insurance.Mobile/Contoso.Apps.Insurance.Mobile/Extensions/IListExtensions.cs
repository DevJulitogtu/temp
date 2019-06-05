
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CIMobile
{
    public static class IListExtensions
    {
        public static void AddRange<T>(this IList<T> collection, IEnumerable<T> items)
        {
            foreach (var i in items)
            {
                collection.Add(i);
            }
        }
        
    }
}

