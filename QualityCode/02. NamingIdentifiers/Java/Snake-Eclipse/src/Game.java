
import java.awt.Canvas;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.image.BufferedImage;

@SuppressWarnings("serial")
public class Game extends Canvas implements Runnable {

    public static final int WIDTH = 600;
    public static final int HEIGHT = 600;
    private final Dimension DIMENTIONS = new Dimension(WIDTH, HEIGHT);
    
    static int points;
    static boolean gameRunning = false;

    public static Snake snake;
    public static Apple apple;
    private Graphics globalGraphics;
    private Thread runThread;  

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

    public Game() {
        snake = new Snake();
        apple = new Apple(snake);
    }

    public void render(Graphics graphics) {
        graphics.clearRect(0, 0, WIDTH, HEIGHT + 25);

        graphics.drawRect(0, 0, WIDTH, HEIGHT);
        snake.drawSnake(graphics);
        apple.drawApple(graphics);
        graphics.drawString("score= " + points, 10, HEIGHT + 25);
    }
}
