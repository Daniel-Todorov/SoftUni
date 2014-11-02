
import java.util.Scanner;
import java.util.regex.Pattern;


/**
 * Problem 7.	Count Substring Occurrences
 * 
 * Write a program to find how many times given string appears in given text as substring. 
 * The text is given at the first input line. 
 * The search string is given at the second input line. 
 * The output is an integer number. 
 * Please ignore the character casing. 
 * 
 */
public class CountSubstringOccurrences {
    
    public static void main(String[] args) {
        
        Scanner scanner = new Scanner(System.in);
        System.out.print("Please type a text and press Enter: ");
        String text = scanner.nextLine().toLowerCase();
        System.out.print("Please type a subsstring and press Enter: ");
        String substring = scanner.nextLine();
        int count = 0;
        
        for (int i = 0; i < text.length(); i++) {
            
            if (text.indexOf(substring, i) >= 0) {
                i = text.indexOf(substring, i);
                count++;
            }
        }
        
        System.out.println(count);
        
    }
    
}
