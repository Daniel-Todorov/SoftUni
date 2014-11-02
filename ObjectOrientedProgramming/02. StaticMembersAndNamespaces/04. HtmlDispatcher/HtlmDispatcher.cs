//Write a static class HTMLDispatcher that holds 3 static methods: 
//CreateImage(), CreateURL(), CreateInput(), which takes a set of arguments 
//and return the HTML element as string. 
//Use the ElementBuilder class.

//•	CreateImage() takes image source, alt and title.
//•	CreateURL() tekes url, title and text.
//•	CreateInput() takes input type, name and value.

namespace _04.HtmlDispatcher
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class HtlmDispatcher
    {
        public static string CreateImage(string imageSource, string alt, string title)
        {
            ElementBuilder element = new ElementBuilder("img");

            element.AddAttribute("src", imageSource);
            element.AddAttribute("alt", alt);
            element.AddAttribute("title", title);

            return element.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder element = new ElementBuilder("a");

            element.AddAttribute("href", url);
            element.AddAttribute("title", title);
            element.AddContent(text);

            return element.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder element = new ElementBuilder("input");

            element.AddAttribute("type", type);
            element.AddAttribute("name", name);
            element.AddAttribute("value", value);

            return element.ToString();
        }
    }
}
