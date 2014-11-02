//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints it back on the console.

//program	            user
//Company name:	        Software University
//Company address:	    26 V. Kanchev, Sofia
//Phone number:       	+359 899 55 55 92
//Fax number:	
//Web site:	            http://softuni.bg
//Manager first name:	Svetlin
//Manager last name:	Nakov
//Manager age:	        25
//Manager phone:	    +359 2 981 981
//
//Software University
//Address: 26 V. Kanchev, Sofia
//Tel. +359 899 55 55 92
//Fax: (no fax)
//Web site: http://softuni.bg
//Manager: Svetlin Nakov (age: 25, tel. +359 2 981 981)	

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company adress: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("{1}{0}Adress: {2}{0}Tel. {3}{0}Fax: {4}{0}Web site: {5}{0}Manager: {6} {7} (age: {8}, tel. {9})", 
            Environment.NewLine, companyName, companyAdress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
