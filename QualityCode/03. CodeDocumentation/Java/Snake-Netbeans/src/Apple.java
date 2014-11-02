
import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;

/**
* Represents the apple object in the game.
* @author Anonymous
*/
public class Apple {

    /**
     * An instance of the random class used for generating random numbers when required.
     */
    public static Random randomGenerator;

    /**
     * The body of the apple.
     */
    private Point appleBody;
    /**
     * The color of the apple.
     */
    private Color color;

    /**
     * Apple's default constructor.
     * @param snake An instance of the class Snake, used to create the apple body.
     */
    public Apple(Snake snake) {
        appleBody = createApple(snake);
        color = Color.RED;
    }

    /**
     * Create a body of the apple.
     * @param snake A instance of class Snake used to calculate the right position of the newly created apple. 
     * @return The body of the apple represented by a single instance of class Point.
     */
    private Point createApple(Snake snake) {
        randomGenerator = new Random();
        int x = randomGenerator.nextInt(30) * 20;
        int y = randomGenerator.nextInt(30) * 20;

        for (Point snakePoint : snake.snakeBody) {
            if (x == snakePoint.getX() || y == snakePoint.getY()) {
                return createApple(snake);
            }
        }

        return new Point(x, y);
    }

    /**
    * The apple draws its body using the graphic adapter provided.
    * @param graphics A graphic adapter used to draw the body of the apple.
    */
    public void drawApple(Graphics graphics) {
        appleBody.drawPoint(graphics, color);
    }

    /**
    * Gets the body of the apple.
    * @return Returns the body of the apple represented by a single instance of class Point.
    */
    public Point getAppleBody() {
        return appleBody;
    }
}
