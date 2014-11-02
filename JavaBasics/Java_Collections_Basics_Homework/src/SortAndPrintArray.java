import java.util.Arrays;
import java.util.Scanner;

/**
 * Problem 1.	Sort Array of Numbers
 * Write a program to enter a number n and n integer numbers and sort and print them. 
 * Keep the numbers in array of integers: int[].
 * 
 * NOTE: All input should be on a single line.
 */

public class SortAndPrintArray {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Please type a line of integers. The first integer should be the number of the following integers and press Enter: ");
        Integer[] arrayOfInt = new Integer[scanner.nextInt()];
        for (int i = 0; i < arrayOfInt.length; i++) {
            arrayOfInt[i] = scanner.nextInt();
        }
        Arrays.sort(arrayOfInt);
        for (int i = 0; i < arrayOfInt.length; i++) {
            System.out.print(arrayOfInt[i] + " ");
        }
    }
    
}
