
package java_loops_method_classes_homework;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

/**
 * Problem 6.	Random Hands of 5 Cards
 * Write a program to generate n random hands of 5 different cards form a standard suit of 52 cards.
 * 
 */
public class Random_Hands_Of_Five_Cards {

    public static void main(String[] args) {

        String clubs = "♣";
        String diamonds = "♦";
        String hearts = "♥";
        String spades = "♠";
        
        System.out.println("Please, type the number of hands you want to be printed and press Enter: ");
        Scanner input = new Scanner(System.in);
        int count = input.nextInt();
        String rank[] = new String[52];
        int counter = 0;
        
        for (int i = 1; i <= 13; i++) {
            String currentCard = "";
            
            if(i==1) {
                currentCard = "A";
            } else if (i <= 10) {
                currentCard = currentCard + i;
            } else{
                switch(i){
                    case 11: 
                        currentCard = "J"; 
                        break;
                    case 12: 
                        currentCard = "Q"; 
                        break;
                    case 13: 
                        currentCard = "K"; 
                        break;
                }
            }
            
            rank[counter] = "" + currentCard + clubs;
            rank[counter+1] = "" + currentCard + diamonds;
            rank[counter+2] = "" + currentCard + hearts;
            rank[counter+3]= "" + currentCard + spades;
            counter+=4;
        }
        
        List<String> cards = Arrays.asList(rank);
        
        for(int i=0; i<count;i++){
            Collections.shuffle(cards);
            List<String> selectedCards = cards.subList(0, 5);
            System.out.println(selectedCards.toString());
        }
    }    
}
