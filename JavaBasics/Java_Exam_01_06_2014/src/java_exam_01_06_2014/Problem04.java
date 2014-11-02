
package java_exam_01_06_2014;

import java.util.ArrayList;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class Problem04 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberOfLines = scanner.nextInt();
        scanner.nextLine();
        
        ArrayList<String[]> rawInput = new ArrayList<String[]>();
        Set<String> users = new TreeSet();
        
        String[] line;

        for (int i = 0; i < numberOfLines; i++) {
            line = scanner.nextLine().split(" ");
            rawInput.add(line);
            users.add(line[1]);
        }
        
        int visits = 0;
        Set<String> IPs = new TreeSet<String>();
        
        for (String userName : users) {
            
            for ( int i = 0; i < numberOfLines; i++) {
                if (rawInput.get(i)[1].equals(userName)) {
                    visits += Integer.parseInt(rawInput.get(i)[2]);
                }
            }
            
            for (int i = 0; i < numberOfLines; i++) {
                if (rawInput.get(i)[1].equals(userName)) {
                    IPs.add(rawInput.get(i)[0]);
                }
            }
            
            System.out.println(userName + ": " + visits + " " + IPs);
            visits = 0;
            IPs = new TreeSet<String>();
        }
    }
    
}