
package java_exam_01_06_2014;

import java.util.Scanner;

public class Problem01 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.nextLine();
        String[] numbers = scanner.nextLine().split(" ");
        
        String currentSet;
        String matchingSet;
        int count = 0;
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (j != i) {
                currentSet = numbers[i] + numbers[j];
                
                    for (int k = 0; k < n; k++) {
                        for (int l = 0; l < n; l++) {
                            if (k != i && k != j && l != i&& l != j && k != l) {
                                matchingSet = numbers[k] + numbers[l];

                                if (currentSet.equals(matchingSet)) {
                                    count++;
                                    System.out.println(numbers[i] + "|" + numbers[j] + "==" + numbers[k] + "|" + numbers[l]);
                                }
                            }


                        }
                    }
                } 


                
            }
        }
        
        if (count == 0) {
            System.out.println("No");
        }
    }
    
}
