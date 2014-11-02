/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg10.oopinjava.geometry;

public class Rectangle extends PlaneShape {

    private double width;
    private double height;

    public Rectangle(Vertix2D vertix, double width, double height) {
        super(new Vertix2D[]{vertix});

        this.setWidth(width);
        this.setHeight(height);
    }

    /**
     * @return the width
     */
    public final double getWidth() {
        return width;
    }

    /**
     * @param width the width to set
     */
    public final void setWidth(double width) {
        this.width = width;
    }

    /**
     * @return the height
     */
    public final double getHeight() {
        return height;
    }

    /**
     * @param height the height to set
     */
    public final void setHeight(double height) {
        this.height = height;
    }

    @Override
    public double getPerimeter() {
        double perimeter = 2 * this.getWidth() + 2 * this.getHeight();

        return perimeter;
    }

    @Override
    public double getArea() {
        double area = this.getWidth() * this.getHeight();

        return area;
    }
}
