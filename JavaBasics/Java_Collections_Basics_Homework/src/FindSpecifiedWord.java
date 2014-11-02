
import java.util.Scanner;
import java.util.regex.Pattern;


/**
 * Problem 6.	Count Specified Word
 * 
 * Write a program to find how many times a word appears in given text. 
 * The text is given at the first input line. 
 * The target word is given at the second input line. 
 * The output is an integer number. 
 * Please ignore the character casing. 
 * Consider that any non-letter character is a word separator. 
 * 
 */
public class FindSpecifiedWord {
    
    public static void main(String[] args) {
        
        Scanner scanner = new Scanner(System.in);
        System.out.print("Please type a sentence and press Enter: ");
        String sentence = scanner.nextLine();
        String specifiedWord = scanner.nextLine();
        Pattern pattern = Pattern.compile("\\W+");
        String[] words = pattern.split(sentence);
        int count = 0;
        
        for (int i = 0; i < words.length; i++) {
            
            if (words[i].equalsIgnoreCase(specifiedWord)) {
                count++;
                
            }
        }
        
        System.out.println(count);
    }
}
