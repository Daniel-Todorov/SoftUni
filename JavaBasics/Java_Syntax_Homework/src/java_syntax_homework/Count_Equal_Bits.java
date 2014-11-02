
package java_syntax_homework;

import java.util.Scanner;

/**
 * Problem 8.	* Count of Equal Bit Pairs
 * Write a program to count how many sequences of two equal bits ("00" or "11") 
 * can be found in the binary representation of given integer number n (with overlapping). 
 *
 */
public class Count_Equal_Bits {
    
    public static void main(String[] args) {
        
        System.out.print("Please, type an integer number and press Enter: ");
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        String binaryN = Integer.toBinaryString(n);
        char[] charArrayN = binaryN.toCharArray();
        int counter = 0;
        for (int i = 0; i < charArrayN.length - 1; i++) {
            if (charArrayN[i] == charArrayN[i + 1]) {
                counter++;
            }
        }
        
        System.out.printf("There are " + counter + " number of equal bits in the binary representation of the number");
        
    }
    
}
