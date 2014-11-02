
import java.util.ArrayList;
import java.util.Scanner;

/*
 * Problem 4.	Longest Increasing Sequence
 * 
 * Write a program to find all increasing sequences inside an array of integers. 
 * The integers are given in a single line, separated by a space. 
 * Print the sequences in the order of their appearance in the input array, each at a single line. 
 * Separate the sequence elements by a space. 
 * Find also the longest increasing sequence and print it at the last line. 
 * If several sequences have the same longest length, print the leftmost of them. 
 * 
 */

public class LongestIncreasingSequence {
    
        public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Please type a line of integers, separated by a space, and press Enter: ");
        String input = scanner.nextLine();
        String[] arrayOfStrings = input.split(" ");
        Integer[] arrayOfIntegers = new Integer[arrayOfStrings.length];
        
        for (int i = 0; i < arrayOfStrings.length; i++) {
            arrayOfIntegers[i] =  Integer.parseInt(arrayOfStrings[i]);
        }
        
        ArrayList<ArrayList<Integer>> sequences = new ArrayList<ArrayList<Integer>>();
        ArrayList<Integer> currentSequence = new ArrayList<Integer>();
        
        
        for (int i = 1; i < arrayOfIntegers.length; i++) {
            while (arrayOfIntegers[i] > arrayOfIntegers[i-1]) {
                currentSequence.add(arrayOfIntegers[i-1]);
                i++;
                if (i >= arrayOfIntegers.length) {
                    break;
                }
            }
            currentSequence.add(arrayOfIntegers[i-1]);
            sequences.add(currentSequence);
            currentSequence = new ArrayList<Integer>();
        }
        
        int maxLenght = 0;
        
        for (int i = 0; i < sequences.size(); i++) {
            if (maxLenght < sequences.get(i).size()) {
                maxLenght = i;
            }
            for (int j = 0; j < sequences.get(i).size(); j++) {
                System.out.print(sequences.get(i).get(j) + " ");
            }
            System.out.println();
        }
        
        System.out.print("Longest: ");
        for (int i = 0; i < sequences.get(maxLenght).size(); i++) {
            System.out.print(sequences.get(maxLenght).get(i) + " ");
        }
    }
}
