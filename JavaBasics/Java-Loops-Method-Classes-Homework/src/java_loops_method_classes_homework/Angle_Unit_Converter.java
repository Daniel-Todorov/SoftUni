
package java_loops_method_classes_homework;

import java.util.Scanner;
import java.util.regex.Pattern;

/**
 * Problem 5.	Angle Unit Converter (Degrees ↔ Radians)
 * Write a method to convert from degrees to radians. 
 * Write a method to convert from radians to degrees. 
 * You are given a number n and n queries for conversion. 
 * Each conversion query will consist of a number + space + measure. 
 * Measures are "deg" and "rad". 
 * Convert all radians to degrees and all degrees to radians. 
 * Print the results as n lines, each holding a number + space + measure. 
 * Format all numbers with 6 digit after the decimal point.
 * 
 */
public class Angle_Unit_Converter {

    public static void main(String[] args) {
        
        System.out.print("Please, enter a number n and press Enter: ");
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        double[] values = new double[n];
        String[] measures = new String[n];
        String line = null;
        
        for (int i = 0; i < n; i++) {
            System.out.print("Please, enter a new line of values and press Enter: ");
            values[i] = input.nextDouble();
            measures[i] = input.next(Pattern.compile("\\w+"));
        }
        
        for (int i = 0; i < n; i++) {
            if (measures[i].equals("rad")) {
                System.out.printf("%6f deg", ConvertToDegrees(values[i]));
            } else if (measures[i].equals("deg")) {
                System.out.printf("%6f rad", ConvertToRads(values[i]));
            }
            System.out.println();
        }
    }
    
    public static double ConvertToRads(double degrees){
        double result;
        
        result = (degrees * Math.PI) / 180;
        
        return result;
    }
    
    public static double ConvertToDegrees(double rads){
        double result;
        
        result = (rads * 180) / Math.PI;
        
        return result;
    }
}
