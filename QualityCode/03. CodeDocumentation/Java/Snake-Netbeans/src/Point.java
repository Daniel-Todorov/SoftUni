
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;

/**
 * Represents the building block of all game objects.
 *
 * @author Anonimous
 */
public class Point {

    /**
     * The width of a point.
     */
    private final int WIDTH = 20;
    /**
     * The height of a point.
     */
    private final int HEIGHT = 20;

    /**
     * The horizontal position of a point.
     */
    private int x;
    /**
     * The vertical position of a point.
     */
    private int y;

    /**
     * Constructor of class Point
     *
     * @param point An instance of class Point.
     */
    public Point(Point point) {
        this(point.x, point.y);
    }

    /**
     * Constructor of class Point
     *
     * @param x Horizontal position of the point.
     * @param y vertical position of the point.
     */
    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }

    /**
     * Gets the horizontal position of a point.
     *
     * @return Returns the horizontal position of a point.
     */
    public int getX() {
        return x;
    }

    /**
     * Sets the horizontal position of a point.
     *
     * @param x The new horizontal position of a point.
     */
    public void setX(int x) {
        this.x = x;
    }

    /**
     * Gets the vertical position of a point.
     *
     * @return Returns the vertical position of a point.
     */
    public int getY() {
        return y;
    }

    /**
     * Sets the vertical position of a point.
     *
     * @param y The new vertical position of a point.
     */
    public void setY(int y) {
        this.y = y;
    }

    /**
     * Draws the point on the screen.
     * @param graphics The default graphic adapter.
     * @param color The color of the point.
     */
    public void drawPoint(Graphics graphics, Color color) {
        graphics.setColor(Color.BLACK);
        graphics.fillRect(x, y, WIDTH, HEIGHT);
        graphics.setColor(color);
        graphics.fillRect(x + 1, y + 1, WIDTH - 2, HEIGHT - 2);
    }

    /**
     * Turns an instance of class Point into a string.
     * @return Returns a string in the format: "[x=?,y=?]"
     */
    @Override
    public String toString() {
        return "[x=" + x + ",y=" + y + "]";
    }

    /**
     * Defines when two points are equal.
     * @param object Object to compare with.
     * @return Returns true if the objects are equal and false otherwise.
     */
    @Override
    public boolean equals(Object object) {
        if (object instanceof Point) {
            Point point = (Point) object;
            return (x == point.x) && (y == point.y);
        }
        return false;
    }
}
