//Test the HTML Dispatcher by creating various HTML elements, using the implemented static methods.

namespace _04.HtmlDispatcher
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Testing
    {
        public static void Main()
        {
            var img = HtlmDispatcher.CreateImage("http://hot-girls.com/cecilia", "A picture of the prettiest girl in the world", "Cecilia");
            var url = HtlmDispatcher.CreateURL("http://hot-girls.com/cecilia", "Cecilia", "Hottest girl ever!");
            var input = HtlmDispatcher.CreateInput("text", "your-girl-image", "http://hot-girls.com/cecilia");

            Console.WriteLine("Image:");
            Console.WriteLine(img);
            Console.WriteLine();
            Console.WriteLine("Url:");
            Console.WriteLine(url);
            Console.WriteLine();
            Console.WriteLine("Input:");
            Console.WriteLine(input);
            Console.WriteLine();
        }
    }
}
