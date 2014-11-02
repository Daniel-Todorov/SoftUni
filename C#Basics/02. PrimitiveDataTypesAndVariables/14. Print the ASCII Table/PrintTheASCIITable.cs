//Find online more information about ASCII (American Standard Code for Information Interchange) and 
//write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255). 
//Note that some characters have a special purpose and will not be displayed as expected. 
//You may skip them or display them differently. 
//You may need to use for-loops (learn in Internet how).

using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.ASCII;
        //This is a very retarded encoding for this... on UTF-8 or the default one, it shows way more fancy characters!

        for (int i = 0; i < 255; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}
