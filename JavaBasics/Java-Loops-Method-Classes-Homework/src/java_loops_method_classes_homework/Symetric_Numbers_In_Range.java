
package java_loops_method_classes_homework;

import java.util.Scanner;
import java.lang.*;

/**
 * Problem 1.	Symmetric Numbers in Range
 * Write a program to generate and print all symmetric numbers in given range [start…end]. 
 * A number is symmetric if its digits are symmetric toward its middle. 
 * For example, the numbers 101, 33, 989 and 5 are symmetric, but 102, 34 and 997 are not symmetric.
 * 
 */
public class Symetric_Numbers_In_Range {

    public static void main(String[] args) {
        
        System.out.print("Please, enter two integer numbers to define the range and press Enter: ");
        Scanner input = new Scanner(System.in);
        int start = input.nextInt();
        int end = input.nextInt();
        String currentNumber = null;
        String reversedNumber = null;
        StringBuilder test = new StringBuilder();
        
        for (int i = start; i <= end; i++) {
            currentNumber = Integer.toString(i);
            reversedNumber = new StringBuilder(currentNumber).reverse().toString();
            
            if (i == Integer.parseInt(reversedNumber)) {
                System.out.print( i + " ");
            }
        }
        
        System.out.println();
    }
    
}
