
package java_exam_preparations;


import java.util.*;


public class Java_Exam_Preparations {

    public static void main(String[] args) {
        
        Scanner scanner = new Scanner(System.in);
        double x = scanner.nextDouble();
        scanner.nextLine();
        double y = scanner.nextDouble();
        
        if (x == 0 && y == 0) {
            System.out.print(0);
        } else if (x == 0) {
            System.out.print(5);
        } else if (y == 0) {
            System.out.print(6);
        } else if (x > 0 && y > 0) {
            System.out.print(1);
        } else if (x > 0 && 0 > y) {
            System.out.print(4);
        } else if (x < 0 && 0 > y) {
            System.out.print(3);
        } else if (x < 0 && 0 < y) {
            System.out.print(2);
        }
    }
    
}
