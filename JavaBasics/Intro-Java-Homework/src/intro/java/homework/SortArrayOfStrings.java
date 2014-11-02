package intro.java.homework;

import java.util.Scanner;
import java.util.Arrays;

/**
 * Problem 06. Sort Array of Strings Write a program that enters from the
 * console number n and n strings, then sorts them alphabetically and prints
 * them. Note: you might need to learn how to use loops and arrays in Java
 * (search in Internet).
 *
 * @author Daniel Todorov
 */
public class SortArrayOfStrings {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        System.out.print("Please, enter the number of strings and press Enter: ");
        int n = scan.nextInt();
        String[] inputs = new String[n];

        for (int i = 0; i < n; i++) {
            inputs[i] = scan.next();
        }

        Arrays.sort(inputs);

        for (int i = 0; i < n; i++) {
            System.out.println((i + 1) + " => " + inputs[i]);
        }
    }
}
