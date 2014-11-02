//Create your own LINQ extension methods:
//•	public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate) { … }
//– works just like Where(predicate) but filters the non-matching items from the collection.
//•	public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count) { … } – repeats the collection count times.
//•	public static IEnumerable<string> WhereEndsWith<string>(this IEnumerable<string> collection, IEnumerable<string> suffixes) { … } 
//– filters all items from the collection that ends with some of the specified suffixes.

namespace _02.CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomLINQExtensionMethods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var whereNotCollection = collection.Where(item => predicate(item) == false);

            return whereNotCollection;
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            var listedCollection = collection.ToList();

            for (int i = 0; i < count; i++)
            {
                listedCollection.AddRange(collection);
            }

            return listedCollection.AsEnumerable();
        }

        public static IEnumerable<string> WhereEndsWith<string>(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            var result = collection.Where((item) =>
            {
                foreach (var suffix in suffixes)
                {
                    if (item.EndsWith(suffix))
                    {
                        return true;
                    }
                }

                return false;
            });

            return result;
        }
    }
}
