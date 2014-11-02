/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg10.oopinjava.geometry;

/**
 *
 * @author Daniel Todorov
 */
public class Circle extends PlaneShape {

    private double radius;

    public Circle(Vertix2D vertix, double radius) {
        super(new Vertix2D[]{vertix});
        
        this.setRadius(radius);
    }

    /**
     * @return the radius
     */
    public final double getRadius() {
        return radius;
    }

    /**
     * @param radius the radius to set
     */
    public final void setRadius(double radius) {
        this.radius = radius;
    }

    @Override
    public double getPerimeter() {
        double perimeter = 2 * Math.PI * this.getRadius();
        
        return perimeter;
    }

    @Override
    public double getArea() {
        double area = Math.PI * this.getRadius() * this.getRadius();
        
        return area;
    }
}
