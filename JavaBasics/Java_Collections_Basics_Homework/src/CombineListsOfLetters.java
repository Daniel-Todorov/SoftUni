
import java.util.ArrayList;
import java.util.Scanner;


/**
 * Problem 9.	Combine Lists of Letters
 * 
 * Write a program that reads two lists of letters l1 and l2 and combines them: 
 * appends all letters c from l2 to the end of l1, but only when c does not appear in l1. 
 * Print the obtained combined list. All lists are given as sequence of letters separated by a single space, each at a separate line. 
 * Use ArrayList<Character> of chars to keep the input and output lists. 
 * 
 */
public class CombineListsOfLetters {
    
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayList<Character> firstArray = new ArrayList<Character>();
        ArrayList<Character> secondArray = new ArrayList<Character>();
        ArrayList<Character> result = new ArrayList<Character>();

        for (char ch : scanner.nextLine().toCharArray()) {
                firstArray.add(ch);
        }
        for (char ch : scanner.nextLine().toCharArray()) {
                secondArray.add(ch);
        }
        result.addAll(firstArray);

        for (int i = 0; i < secondArray.size(); i++) {
                if (firstArray.contains(secondArray.get(i))) {
                        continue;
                } else {
                        result.add(' ');
                        result.add(secondArray.get(i));
                }
        }

        for (int i = 0; i < result.size(); i++) {
                System.out.print(result.get(i));
        }
    }
}
