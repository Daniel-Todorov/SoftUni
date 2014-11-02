package java_syntax_homework;

import java.util.Locale;
import java.util.Scanner;

/**
 * Problem 2.	Triangle Area
 * Write a program that enters 3 points in the plane (as integer x and y coordinates), 
 * calculates and prints the area of the triangle composed by these 3 points. 
 * Round the result to a whole number. 
 * In case the three points do not form a triangle, print "0" as result. 
 */
public class Triangle_Area {
    
    public static void main(String[] args) {
        
        Locale.setDefault(Locale.ROOT);
        System.out.print("Please, type two integers (x and y) as coordinates for the first point A: ");
        Scanner input = new Scanner(System.in);
        int aX = input.nextInt();
        int aY = input.nextInt();
        
        System.out.print("Please, type two integers (x and y) as coordinates for the first point B: ");
        input = new Scanner(System.in);
        int bX = input.nextInt();
        int bY = input.nextInt();
        
        System.out.print("Please, type two integers (x and y) as coordinates for the first point C: ");
        input = new Scanner(System.in);
        int cX = input.nextInt();
        int cY = input.nextInt();
        
        double area = ((double) (aX * (bY - cY) + bX * (cY - aY)  + cX * (aY - bY))) / 2;
        
        if (area < 0) {
            area = area * (-1);
        }
         
        System.out.println("The area of the triangle is " + area);
    }
    
}
