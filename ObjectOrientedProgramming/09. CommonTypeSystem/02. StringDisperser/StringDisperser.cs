//Define a class StringDisperser. 
//•	The constructor should take several strings as arguments. 
//•	Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//•	Implement the ICloneable interface. The Clone() method should make a deep copy of all object fields into a new object of type StringDisperser.
//•	Implement the IComparable<StringDisperser> interface to compare string dispersers by their total string value lexicographically.
//•	Implement the IEnumerable interface to allow foreach on objects of type StringDisperser. The items returned should be the characters of each string.

namespace _02.StringDisperser
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        public StringDisperser(params string[] arguments)
        {
            this.Strings = arguments;
        }

        public string[] Strings { get; set; }

        public override bool Equals(object obj)
        {
            var otherStringDisperser = obj as StringDisperser;

            if (this.Strings.Length != otherStringDisperser.Strings.Length)
            {
                return false;
            }

            for (int i = 0; i < this.Strings.Length; i++)
            {
                if (!this.Strings[i].Equals(otherStringDisperser.Strings[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var result = new StringBuilder();

            foreach (var str in this.Strings)
            {
                result.Append(str);
            }

            return result.ToString().GetHashCode();
        }

        public override string ToString()
        {
            var wholeText = new StringBuilder();

            foreach (var str in this.Strings)
            {
                wholeText.Append(str);
            }

            var splitedText = wholeText.ToString().ToCharArray();

            return string.Join(" ", splitedText);
        }

        public static bool operator ==(StringDisperser first, StringDisperser second){
            if (first.Equals(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(StringDisperser first, StringDisperser second)
        {
            if (first.Equals(second))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Clone()
        {
            var strings = new string[this.Strings.Length];

            for (int i = 0; i < this.Strings.Length; i++)
            {
                strings[i] = this.Strings[i];
            }

            return new StringDisperser(strings);
        }

        public int CompareTo(StringDisperser other)
        {
            var initialStringTotalValue = string.Join("", this.Strings);
            var otherStringTotalValue = string.Join("", other.Strings);

            return initialStringTotalValue.CompareTo(otherStringTotalValue);
        }

        public IEnumerator GetEnumerator()
        {
            var totalStringValue = string.Join("", this.Strings);
            var splitedStringValue = totalStringValue.ToCharArray();

            foreach (var character in splitedStringValue)
            {
                yield return character.ToString();
            }
        }
    }
}
