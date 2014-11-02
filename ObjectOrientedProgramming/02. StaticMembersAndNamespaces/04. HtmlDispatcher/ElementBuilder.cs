//Write a class ElementBuilder that creates HTML elements:
//•	The class constructor should take the element's name as argument.
//•	Write a method AddAtribute(attribute, value) that adds an attribute and value to the element. 
//  For example, we create an element a and add the attributes href="www.softuni.bg" and class="links". 
//  The result is <a href="www.softuni.bg" class="links"><a/>.
//•	Write a method AddContent(string) that inserts content inside the current tag (e.g. <div>Text</div>).
//•	Overload the * operator for ElementBuilder objects. 
//  The operator should multiply the string value of the element n times and return the result as string. 
//  (e.g. <li></li> * 3 = <li></li><li></li><li></li>).

namespace _04.HtmlDispatcher
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class ElementBuilder
    {
        public ElementBuilder(string elementName)
        {
            this.ElementName = elementName;
            this.Attributes = new List<KeyValuePair<string, string>>();
        }

        public string ElementName { get; set; }

        public List<KeyValuePair<string, string>> Attributes { get; set; }

        public string Content { get; set; }

        public void AddAttribute(string attribute, string value)
        {
            KeyValuePair<string, string> attributePair = new KeyValuePair<string, string>(attribute, value);

            this.Attributes.Add(attributePair);
        }

        public void AddContent(string content)
        {
            this.Content = content;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("<");
            result.Append(this.ElementName);

            if (this.Attributes != null)
            {
                result.Append(" ");

                var attributes = this.Attributes.Select(attribute => string.Format("{0}=\"{1}\"", attribute.Key, attribute.Value)).ToArray();

                result.Append(string.Join(" ", attributes));
            }

            result.Append(">");

            if (this.Content != null)
            {
                result.Append(this.Content);
            }

            result.Append("</");
            result.Append(this.ElementName);
            result.Append(">");

            return result.ToString();
        }

        public static string operator *(ElementBuilder element, int multiplier)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Element can't be null.");
            }

            if (multiplier <= 0)
            {
                throw new ArgumentNullException("Multiplier can't have negative or zero value.");
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < multiplier; i++)
            {
                result.Append(element.ToString());
            }

            return result.ToString();
        }
    }
}
