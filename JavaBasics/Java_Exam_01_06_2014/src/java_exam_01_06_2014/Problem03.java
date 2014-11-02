
package java_exam_01_06_2014;

import java.math.BigDecimal;
import java.text.DecimalFormat;
import java.util.Scanner;

public class Problem03 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String rawInput = scanner.nextLine();
        int expressionLength = rawInput.length();
        String[] input = rawInput.split("[-+]");
        BigDecimal sum = new BigDecimal(input[0].trim());
        int currentNumber = 1;
        BigDecimal current;
        
        for (int i = 0; i < expressionLength; i++) {
            if (rawInput.charAt(i) == '+') {
                current=new BigDecimal(input[currentNumber].trim());
                sum = sum.add(current);
                currentNumber++;
            } else if (rawInput.charAt(i) == '-') {
                current=new BigDecimal(input[currentNumber].trim());
                sum = sum.subtract(current);
                currentNumber++;
            }
        }

        System.out.print(sum);
    }
    
}