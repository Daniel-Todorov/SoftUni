//Define a class Computer that holds name, several components and price. 
//The components (processor, graphics card, motherboard, etc.) 
//should be objects of class Component, which holds name, details (optional) and price. 
//•	Define several constructors that take different sets of arguments. 
//Use proper variable types. 
//Use properties to validate the data. 
//Throw exceptions when improper data is entered.
//•	Add a method in the Computer class that displays the name, each of the components' name and price and the total computer price. 
//The total price is the sum of all components' price. 
//Print the prices in BGN currency format.
//•	Create several Computer objects, sort them by price, and print them on the console using the created display method.

namespace _03.PcCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntryPoint
    {
        public static void Main()
        {
            Computer firstComputer = new Computer("First computer", new Component("AMD", 150.99M));
            Computer secondComputer = new Computer("Second computer");
            Computer thirdComputer = new Computer("Third computer", new Component("Intel", 180M, "Ultra nice processor"), new Component("nVidia", 500M), new Component("Some motherboard", 89.99M));

            List<Computer> list = new List<Computer>();
            list.Add(firstComputer);
            list.Add(secondComputer);
            list.Add(thirdComputer);
            list = list.OrderBy(computer => computer.Price).ToList();

            Console.OutputEncoding = Encoding.UTF8;

            foreach (var computer in list)
            {
                Console.WriteLine(computer);
            }
        }
    }
}
