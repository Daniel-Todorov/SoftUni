
package java_loops_method_classes_homework;

import java.util.Scanner;

/**
 * Problem 2.	Generate 3-Letter Words
 * Write a program to generate and print all 3-letter words consisting of given set of characters. 
 * For example if we have the characters 'a' and 'b', all possible words will be 
 * "aaa", "aab", "aba", "abb", "baa", "bab", "bba" and "bbb". 
 * The input characters are given as string at the first line of the input. 
 * Input characters are unique (there are no repeating characters).
 *
 */
public class Create_Three_Letter_Word {
 
    public static void main(String[] args) {
        
        System.out.println("Please, type the letters to be used and press Enter: ");
        Scanner input = new Scanner(System.in);
        char[] letters = input.next().toCharArray();

        if(letters.length > 0){
            PrintString(letters.length, letters);
        } else{
                System.out.printf("%s%s%s",letters[0],letters[0],letters[0]);
        }
        System.out.println();
    }
    
    private static void PrintString(int numberOfSymbols, char[] letters) {
        
        for(int a = 0; a < numberOfSymbols; a++){
            
                for(int b = 0; b < numberOfSymbols; b++){
                    
                        for(int c = 0;c < numberOfSymbols; c++){
                            System.out.printf("%s%s%s ",letters[a],letters[b],letters[c]);
                        }
                }
        }
    }
}
