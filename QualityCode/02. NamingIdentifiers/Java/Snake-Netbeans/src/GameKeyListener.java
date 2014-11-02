import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class GameKeyListener implements KeyListener{
	
	public GameKeyListener(Game game){
		game.addKeyListener(this);
	}
	
        @Override
	public void keyPressed(KeyEvent event) {
		int keyCode = event.getKeyCode();
		
		if (keyCode == KeyEvent.VK_W || keyCode == KeyEvent.VK_UP) {
			if(Game.snake.getVelocityY() != 20){
				Game.snake.setVelocityX(0);
				Game.snake.setVelocityY(-20);
			}
		}
		if (keyCode == KeyEvent.VK_S || keyCode == KeyEvent.VK_DOWN) {
			if(Game.snake.getVelocityY() != -20){
				Game.snake.setVelocityX(0);
				Game.snake.setVelocityY(20);
			}
		}
		if (keyCode == KeyEvent.VK_D || keyCode == KeyEvent.VK_RIGHT) {
			if(Game.snake.getVelocityX() != -20){
			Game.snake.setVelocityX(20);
			Game.snake.setVelocityY(0);
			}
		}
		if (keyCode == KeyEvent.VK_A || keyCode == KeyEvent.VK_LEFT) {
			if(Game.snake.getVelocityX() != 20){
				Game.snake.setVelocityX(-20);
				Game.snake.setVelocityY(0);
			}
		}
		//Other controls
		if (keyCode == KeyEvent.VK_ESCAPE) {
			System.exit(0);
		}
	}
	
        @Override
	public void keyReleased(KeyEvent event) {
	}
	
        @Override
	public void keyTyped(KeyEvent event) {
		
	}

}
