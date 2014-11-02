
import java.awt.Canvas;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.image.BufferedImage;

/**
 * Main class in the application, containing the game logic.
 * @author Anonimous
 */
@SuppressWarnings("serial")
public class Game extends Canvas implements Runnable {

    /**
     * Width of the game screen.
     */
    public static final int WIDTH = 600;
    /**
     * Height of the game screen.
     */
    public static final int HEIGHT = 600;
    /**
     * The graphic dimensions of the game screen.
     */
    private final Dimension DIMENTIONS = new Dimension(WIDTH, HEIGHT);
    
    /**
     * The points rank achieved by the user.
     */
    static int points;
    /**
     * A flag determining if the game is still in progress.
     */
    static boolean gameRunning = false;
    /**
     * Represents the snake.
     */
    public static Snake snake;
    /**
     * Represents the apple.
     */
    public static Apple apple;
    /**
     * Represents the graphic adapter.
     */
    private Graphics globalGraphics;
    /**
     * Represents the thread in which the game is running.
     */
    private Thread runThread;  

    /**
     * Add colors to the game components on the screen.
     * @param graphics The graphic adapter used to draw on the screen.
     */
    @Override
    public void paint(Graphics graphics) {
        this.setPreferredSize(DIMENTIONS);
        globalGraphics = graphics.create();
        points = 0;

        if (runThread == null) {
            runThread = new Thread(this);
            runThread.start();
            gameRunning = true;
        }
    }

    /**
     * Moves the snake in a direction.
     */
    @Override
    public void run() {
        while (gameRunning) {
            snake.move();
            render(globalGraphics);
            
            try {
                Thread.sleep(100);
            } catch (Exception e) {
                // TODO: Handle the exception.
            }
        }
    }

    /**
     * The default class constructor.
     */
    public Game() {
        snake = new Snake();
        apple = new Apple(snake);
    }

    /**
     * Draws all game objects on the screen.
     * @param graphics The default graphic adapter.
     */
    public void render(Graphics graphics) {
        graphics.clearRect(0, 0, WIDTH, HEIGHT + 25);

        graphics.drawRect(0, 0, WIDTH, HEIGHT);
        snake.drawSnake(graphics);
        apple.drawApple(graphics);
        graphics.drawString("score= " + points, 10, HEIGHT + 25);
    }
}
