//A marketing company wants to keep record of its employees. 
//Each record would have the following characteristics:

//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)

//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//Use descriptive names. 
//Print the data at the console.


using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Daniel";
        string lastName = "Todorov";
        byte age = 27;
        char gender = 'm';
        ulong personalIDNumber = 8611068725;
        int employeeNumber = 27569999;

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID number: {0}", personalIDNumber);
        Console.WriteLine("Unique employee number: {0}", employeeNumber);
    }
}
