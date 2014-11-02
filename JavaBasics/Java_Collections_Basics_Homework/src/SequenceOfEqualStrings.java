
import java.util.Arrays;
import java.util.Scanner;


/**
 * Problem 2.	Sequences of Equal Strings
 * 
 * Write a program that enters an array of strings and finds in it all sequences of equal elements. 
 * The input strings are given as a single line, separated by a space. 
 * 
 */
public class SequenceOfEqualStrings {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Please type a line of strings, separated by a space, and press Enter: ");
        String input = scanner.nextLine();
        String[] arrayOfStrings = input.split(" ");
        Arrays.sort(arrayOfStrings);
        for (int i = 0; i < arrayOfStrings.length - 1; i++) {
            if (arrayOfStrings[i].equals(arrayOfStrings[i + 1])) {
                System.out.print(arrayOfStrings[i] + " ");
            } else {
                System.out.println(arrayOfStrings[i]);
            }
        }
        if (arrayOfStrings[arrayOfStrings.length - 1].equals(arrayOfStrings[arrayOfStrings.length - 2])) {
            System.out.print(arrayOfStrings[arrayOfStrings.length - 1]);
        } else {
            System.out.println(arrayOfStrings[arrayOfStrings.length - 1]);
        }
        
    }
    
}
