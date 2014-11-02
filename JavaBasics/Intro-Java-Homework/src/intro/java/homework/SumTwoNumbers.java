package intro.java.homework;

import java.util.Scanner;

/**
 * Problem 6. Sum Two Numbers Write a program SumTwoNumbers.java that enters two
 * integers from the console, calculates and prints their sum. Search in
 * Internet to learn how to read numbers from the console.  *
 * @author Daniel Todorov
 */
public class SumTwoNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Please, enter the first number and press Enter: ");
        int first = scanner.nextInt();
        System.out.print("Please, enter the second number and press Enter: ");
        int second = scanner.nextInt();
        System.out.println("The sum of the numbers is " + (first + second));
    }
}
