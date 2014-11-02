
package jave.teamwork.project;

import java.util.Random;

class Computer extends Player{
    
    public Computer(int player){
        super(player);
        System.out.println("Player 'Computer' created");
    }
    
    @Override
    public void play(Board board){
        Try(board);
        board.setPosition(attempt, player);
    }
    
    @Override
    public void Try(Board board){
        
        Random rand = new Random();
        do{
            attempt[0] = rand.nextInt(3) + 1;
            attempt[1] = rand.nextInt(3) + 1;
            
            attempt[0]--; 
            attempt[1]--;
            
        }while( !checkTry(attempt, board) );
    }
}