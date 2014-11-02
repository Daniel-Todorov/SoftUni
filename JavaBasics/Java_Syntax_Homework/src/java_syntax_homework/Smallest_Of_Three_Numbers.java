
package java_syntax_homework;

import java.util.Locale;
import java.util.Scanner;

/**
 * Problem 4.	The Smallest of 3 Numbers
 * Write a program that finds the smallest of three numbers. 
 *
 */
public class Smallest_Of_Three_Numbers {

    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        
        System.out.print("Please, type type three numbers and press Enter: ");
        Scanner input = new Scanner(System.in);
        double firstNumber = input.nextDouble();
        double secondNumber = input.nextDouble();
        double thirdNumber = input.nextDouble();
        
        if (secondNumber >= firstNumber && firstNumber <= thirdNumber) {
            System.out.println("The smallest number is " + firstNumber);
        } else if (firstNumber >= secondNumber && secondNumber <= thirdNumber) {
            System.out.println("The smallest number is " + secondNumber);
        } else if (firstNumber >= thirdNumber && thirdNumber <= secondNumber) {
            System.out.println("The smallest number is " + thirdNumber);
        }
    }
    
}
