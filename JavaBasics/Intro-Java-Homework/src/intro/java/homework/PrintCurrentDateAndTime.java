package intro.java.homework;

import java.util.Date;
import java.text.SimpleDateFormat;

/**
 * Problem 5. Print the Current Date and Time
 * * 
Create a simple Java program CurrentDateTime.java to print the current date
 * and time. Submit the Java class CurrentDateTime as part of your homework.
 *
 * @author Daniel Todorov
 */
public class PrintCurrentDateAndTime {

    public static void main(String[] args) {

        SimpleDateFormat currentDateAndTime = new SimpleDateFormat("dd.MM.YYYY  HH:mm:ss");;
        System.out.println(currentDateAndTime.format(new Date()));

    }

}
