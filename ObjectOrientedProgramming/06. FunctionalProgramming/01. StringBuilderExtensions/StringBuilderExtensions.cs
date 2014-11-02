namespace _01.StringBuilderExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static string Substring(this StringBuilder builder, int startIndex, int length)
        {
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("startIndex", "Start index cannot have negative value.");
            }
            if (startIndex >= builder.Length)
            {
                throw new ArgumentOutOfRangeException("startIndex", "Start index cannot exceed the lengt of the string builder.");
            }
            if (length == 0)
            {
                throw new ArgumentOutOfRangeException("length", "Length of the substring cannot be zero.");
            }
            if (startIndex + length > builder.Length)
            {
                throw new ArgumentOutOfRangeException("length", "Length cannot exceed the length of the remaining part of the string builder.");
            }

            return builder.ToString().Substring(startIndex, length);
        }

        public static StringBuilder RemoveText( this StringBuilder builder, string text)
        {
            builder.Replace(text, "");

            return builder;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder builder, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                builder.Append(item.ToString());
            }

            return builder;
        }
    }
}
