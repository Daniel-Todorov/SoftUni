
package java_loops_method_classes_homework;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

/**
 * Problem 8.	Sum Numbers from a Text File
 * Write a program to read a text file "Input.txt" holding a sequence of integer numbers, each at a separate line. 
 * Print the sum of the numbers at the console. 
 * Ensure you close correctly the file in case of exception or in case of normal execution. 
 * In case of exception (e.g. the file is missing), print "Error" as a result. 
 * 
 */
public class Sum_Numbers_From_Text_File {

    public static void main(String[] args) throws IOException {

        try {
            BufferedReader input = new BufferedReader(new FileReader("Input.txt"));
            String line;
            int sum = 0;
            
            while ((line = input.readLine()) != null) {
                    sum += Integer.parseInt(line);
            }
            
            System.out.println(sum);
            input.close();
            
        } catch (java.io.FileNotFoundException myException) {
            System.out.println("Error");
        }
    }
}
