
import java.util.Scanner;

/*
 * Problem 3.	Largest Sequence of Equal Strings
 *
 * Write a program that enters an array of strings and finds in it the largest sequence of equal elements. 
 * If several sequences have the same longest length, print the leftmost of them. 
 * The input strings are given as a single line, separated by a space. 
 */

public class LargestSequanceOfEqualStrings {
    
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Please type a line of strings, separated by a space, and press Enter: ");
        String input = scanner.nextLine();
        String[] arrayOfStrings = input.split(" ");
        int count = 0;
        int maxCount = 0;
        String elementValue = "";
        
        
        for (int i = 0; i < arrayOfStrings.length; i++) {
            
            count++;
            
            do {
                count++;
                
                if (count > maxCount) {
                    maxCount = count;
                    elementValue = arrayOfStrings[i];
                }
                
                i++;
                
                if (i + 1 >= arrayOfStrings.length - 1) {
                    break;
                }
                
            } while (arrayOfStrings[i].equals(arrayOfStrings[i + 1]));
            
            count = 0;
            
        }
        
        for (int i = 0; i < maxCount; i++) {
            System.out.print(elementValue + " ");
        }
        
    }
}
