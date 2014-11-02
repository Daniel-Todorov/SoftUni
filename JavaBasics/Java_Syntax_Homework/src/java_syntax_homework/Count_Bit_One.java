
package java_syntax_homework;

import java.util.Scanner;

/**
 * Problem 7.	Count of Bits One
 * Write a program to calculate the count of bits 1 in the binary representation of given integer number n. 
 *
 */
public class Count_Bit_One {
    
    public static void main(String[] args) {
        
        System.out.print("Please, type an integer number and press Enter: ");
        Scanner input = new Scanner(System.in);
        int number = input.nextInt();
        String binaryNumber = Integer.toBinaryString(number);
        char[] charArrayNumber = binaryNumber.toCharArray();
        int counter = 0;
        for (int i = 0; i < charArrayNumber.length; i++) {
            if (charArrayNumber[i] == '1') {
                counter++;
            }
        }
        
        System.out.printf("There are " + counter + " number of bit 1 in the binary representation of the number");
        
    }
    
}
