
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;


/**
 * Problem 11.	Most Frequent Word
 * 
 * Write a program to find the most frequent word in a text and print it, 
 * as well as how many times it appears in format "word -> count". 
 * Consider any non-letter character as a word separator. 
 * Ignore the character casing. 
 * If several words have the same maximal frequency, print all of them in alphabetical order. 
 * 
 */
public class MostFrequentWord {
    
    public static void main(String[] args) {
        
        Scanner scanner = new Scanner(System.in);
        String[] words =  scanner.nextLine().split("\\W+");
        TreeMap<String, Integer> wordOccurrences = new TreeMap<>();
        int maxWordCount = 0;
        
        for (String word : words) {
            word = word.toLowerCase();
            Integer wordCount = wordOccurrences.get(word);
            
            if (wordCount == null) {
                wordCount = 0;
            }
            
            if (wordCount + 1 > maxWordCount) {
                maxWordCount = wordCount + 1;
            }
            
            wordOccurrences.put(word, wordCount + 1);
        }

        for (Map.Entry<String, Integer> entry : wordOccurrences.entrySet()) {

            if (entry.getValue() == maxWordCount) {
                
                System.out.println(entry.getKey() + " -> " + maxWordCount + " times");
                
            }

        }
        
    }
    
}