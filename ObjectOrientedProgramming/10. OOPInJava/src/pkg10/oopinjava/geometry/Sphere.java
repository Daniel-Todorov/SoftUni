/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg10.oopinjava.geometry;

public class Sphere extends SpaceShape {

    private double radius;

    public Sphere(Vertix3D vertix, double radius) {
        super(new Vertix3D[]{vertix});
        
        this.setRadius(radius);
    }

    @Override
    public double getArea() {
        double area = 4 * Math.PI * this.getRadius() * this.getRadius();
        
        return area;
    }

    @Override
    public double getVolume() {
        double volume = (4 * Math.PI * Math.pow(this.getRadius(), 3)) / 3;
        
        return volume;
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
}
