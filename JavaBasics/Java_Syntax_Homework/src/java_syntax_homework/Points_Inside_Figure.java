
package java_syntax_homework;

import java.util.Locale;
import java.util.Scanner;

/**
 * Problem 3.	Points inside a Figure
 * Write a program to check whether a point is inside or outside of the figure below. 
 * The point is given as a pair of floating-point numbers, separated by a space. 
 * Your program should print "Inside" or "Outside". 
 */
public class Points_Inside_Figure {

    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        
        System.out.print("Please, type the X and Y coordinates of a point and press Enter: ");
        Scanner input = new Scanner(System.in);
        float x = input.nextFloat();
        float y = input.nextFloat();
        
        if ((12.5 <= x && x <= 22.5) && (6 <= y && y <= 8.5)) {
            System.out.println("Inside");
        } else if ((12.5 <= x && x <= 17.5) && (8.5 <= y && y <= 13.5)) {
            System.out.println("Inside");
        } else if ((20 <= x && x <= 22.5) && (8.5 <= y && y <= 13.5)) {
            System.out.println("Inside");
        } else {
            System.out.println("Outside");
        }
    }
    
}
