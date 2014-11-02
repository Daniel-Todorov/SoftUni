
import java.awt.Color;
import java.awt.Graphics;
import java.util.LinkedList;

/**
 * Represents a snake.
 * @author Anonimous
 */
public class Snake {
    /**
     * Represents the body of the snake consisted of points.
     */
    LinkedList<Point> snakeBody = new LinkedList<Point>();
    /**
     * Represents the color of the snake.
     */
    private Color color;
    /**
     * Represents the horizontal direction of the snake.
     */
    private int velocityX;
    /**
     * represents the vertical direction of the snake.
     */
    private int velocityY;

    /**
     * The default constructor.
     */
    public Snake() {
        color = Color.GREEN;
        snakeBody.add(new Point(300, 100));
        snakeBody.add(new Point(280, 100));
        snakeBody.add(new Point(260, 100));
        snakeBody.add(new Point(240, 100));
        snakeBody.add(new Point(220, 100));
        snakeBody.add(new Point(200, 100));
        snakeBody.add(new Point(180, 100));
        snakeBody.add(new Point(160, 100));
        snakeBody.add(new Point(140, 100));
        snakeBody.add(new Point(120, 100));

        velocityX = 20;
        velocityY = 0;
    }

    /**
     * Draws the snake on the screen.
     * @param graphics The default graphic adapter.
     */
    public void drawSnake(Graphics graphics) {
        for (Point point : this.snakeBody) {
            point.drawPoint(graphics, color);
        }
    }

    /**
     * Changes the position of the snake according to its horizontal and vertical directions.
     */
    public void move() {
        Point newPosition = new Point((snakeBody.get(0).getX() + velocityX), (snakeBody.get(0).getY() + velocityY));

        if (newPosition.getX() > Game.WIDTH - 20) {
            Game.gameRunning = false;
        } else if (newPosition.getX() < 0) {
            Game.gameRunning = false;
        } else if (newPosition.getY() < 0) {
            Game.gameRunning = false;
        } else if (newPosition.getY() > Game.HEIGHT - 20) {
            Game.gameRunning = false;
        } else if (Game.apple.getAppleBody().equals(newPosition)) {
            snakeBody.add(Game.apple.getAppleBody());
            Game.apple = new Apple(this);
            Game.points += 50;
        } else if (snakeBody.contains(newPosition)) {
            Game.gameRunning = false;
            System.out.println("You ate yourself");
        }

        for (int i = snakeBody.size() - 1; i > 0; i--) {
            snakeBody.set(i, new Point(snakeBody.get(i - 1)));
        }
        
        snakeBody.set(0, newPosition);
    }

    /**
     * Gets the horizontal direction of the snake.
     * @return Returns the horizontal direction of the snake.
     */
    public int getVelocityX() {
        return velocityX;
    }

    /**
     * Sets the horizontal direction of the snake.
     * @param velX The new horizontal direction of the snake.
     */
    public void setVelocityX(int velX) {
        this.velocityX = velX;
    }

    /**
     * gets the vertical direction of the snake.
     * @return Returns the vertical direction of the snake.
     */
    public int getVelocityY() {
        return velocityY;
    }

    /**
     * Sets the vertical direction of the snake.
     * @param velY The new vertical direction of the snake
     */
    public void setVelocityY(int velY) {
        this.velocityY = velY;
    }
}
