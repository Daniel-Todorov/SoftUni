
package java_syntax_homework;

import java.util.Scanner;

/**
 * Problem 5.	Decimal to Hexadecimal
 * Write a program that enters a positive integer number num and converts and prints it in hexadecimal form. 
 * You may use some built-in method from the standard Java libraries
 *
 */
public class Decimal_To_Hexadecimal {
    
    public static void main(String[] args) {
        
        System.out.print("Please, type a positive integer number to be converted and press Enter: ");
        Scanner input = new Scanner(System.in);
        int num = input.nextInt();
        
        System.out.println("The hexadecimal representation of this number is " + Integer.toHexString(num).toUpperCase());
        
    }
    
}
