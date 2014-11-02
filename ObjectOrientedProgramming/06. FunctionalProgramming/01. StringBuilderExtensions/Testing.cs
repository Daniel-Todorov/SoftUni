//Implement the following extension methods for the class StringBuilder:

//•	Substring(int startIndex, int length) – returns a new String object, containing the elements in the given range. 
//Throw an exception when the range is invalid.
//•	RemoveText(string text) – removes all occurrences of the specified text (case-insensitive) from the StringBuilder. 
//The method should not create a new StringBuilder, but should modify the existing one and return it as a result.
//•	AppendAll<T>(IEnumerable<T> items) – appends the string representations of all items from the specified collection. 
//Use ToString() to convert from T to string.

//Write a program to demonstrate that your new extension methods work correctly.

namespace _01.StringBuilderExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Testing
    {
        public static void Main()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("SoftUni rulez!");
            Console.WriteLine(builder.Substring(0,7));

            builder.RemoveText(" rulez");
            Console.WriteLine(builder);

            List<int> items = new List<int>();
            items.Add(1);
            items.Add(2);
            items.Add(3);
            builder.AppendAll(items);
            Console.WriteLine(builder);
        }
    }
}
