
package java_loops_method_classes_homework;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;

/**
 * Problem 7.	Days between Two Dates
 * Write a program to calculate the difference between two dates in number of days. 
 * The dates are entered at two consecutive lines in format day-month-year. Days are in range [1…31]. 
 * Months are in range [1…12]. 
 * Years are in range [1900…2100]. 
 * 
 */
public class Days_Between_Two_Dates {

    public static void main(String args[]) throws ParseException  {

        System.out.println("Please, type a date and press Enter: ");
        Scanner input = new Scanner(System.in);
        String input1 = input.nextLine();
        System.out.println("Please, type a date and press Enter: ");
        String input2 = input.nextLine();

        SimpleDateFormat simpleDateFormat = new SimpleDateFormat("dd-MM-yyyy");
        Date date1 = simpleDateFormat.parse(input1);
        Date date2 = simpleDateFormat.parse(input2);

        System.out.println((int)computeDaysBetweenDates(date1, date2));
    }

    public static double computeDaysBetweenDates(Date d1, Date d2) {
        
        long diff;
        diff = d2.getTime() - d1.getTime();
        return ((double) diff) / (86400.0 * 1000.0);
    }
    
}
