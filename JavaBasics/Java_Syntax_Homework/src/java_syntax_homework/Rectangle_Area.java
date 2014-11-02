package java_syntax_homework;
import java.util.Scanner;
/**
 * Problem 1.	Rectangle Area
Write a program that enters the sides of a rectangle (two integers a and b) 
and calculates and prints the rectangle's area. 
 * 
 */
public class Rectangle_Area {

    public static void main(String[] args) {
        System.out.print("Please, type two integers separated by a space and press Enter: ");
        Scanner input = new Scanner(System.in);
        int a = input.nextInt();
        int b = input.nextInt();
        int area = a * b;
        System.out.println("The area of the rectangle is " + area);
    }
    
}
