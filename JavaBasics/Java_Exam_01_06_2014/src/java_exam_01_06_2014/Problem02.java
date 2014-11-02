
package java_exam_01_06_2014;

import static java.lang.Integer.parseInt;
import java.util.Scanner;

public class Problem02 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] hand = scanner.nextLine().split(" ");
        int handLength = hand.length;
        long totalSum = 0;
        long currentSum = 0;
        long currentValue = 0;
        long nextValue = 0;
        int counter = 0;
        
//        2C 2H 2D AS 10H 10C 2S KD
        
        for (int i = 0; i < handLength; i++) {
            currentValue = getValue(hand[i]);
            currentSum += currentValue;
            counter++;
            
            if (i + 1 != handLength) {
                nextValue = getValue(hand[i + 1]);
            } else {
                nextValue = 0;
            }
            
            if (currentValue != nextValue) {
                if (counter >= 2) {
                    currentSum *= 2;
                }
                totalSum += currentSum;
                counter = 0;
                currentSum = 0;
            }
        }
        
        System.out.print(totalSum);
    }
    
    private static int getValue(String card){
        int value;
        
        switch(card.charAt(0)){
            case 'A': value = 15; break;
            case 'K': value = 14; break;
            case 'Q': value = 13; break;
            case 'J': value = 12; break;
            case '1': value = 10; break;
            default: value = parseInt(Character.toString(card.charAt(0))); break;
        }
        
        return value;
    }
    
}