
import java.util.Scanner;
import java.util.regex.Pattern;

/**
 * Problem 5.	Count All Words
 * Write a program to count the number of words in given sentence. 
 * Use any non-letter character as word separator.
 * 
 */
public class CountAllWords {
    
    public static void main(String[] args) {
        
        Scanner scanner = new Scanner(System.in);
        System.out.print("Please type a sentence and press Enter: ");
        String input = scanner.nextLine();
        Pattern pattern = Pattern.compile("\\W+");
        String[] words = pattern.split(input);
        System.out.println(words.length);
        
    }
    
}
