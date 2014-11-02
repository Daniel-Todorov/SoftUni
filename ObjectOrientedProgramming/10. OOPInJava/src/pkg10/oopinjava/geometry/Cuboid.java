/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg10.oopinjava.geometry;

public class Cuboid extends SpaceShape {

    private double width;
    private double height;
    private double depth;

    public Cuboid(Vertix3D vertix, double width, double height, double depth) {
        super(new Vertix3D[]{vertix});
        
        this.setWidth(width);
        this.setHeight(height);
        this.setDepth(depth);
    }

    @Override
    public double getArea() {
        double area = 2 * this.getWidth() * this.getDepth() + 2 * this.getDepth() * this.getHeight() + 2 * this.getHeight() * this.getWidth();
        
        return area;
    }

    @Override
    public double getVolume() {
        double volume = this.getWidth() * this.getHeight() * this.getDepth();
        
        return volume;
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

    /**
     * @return the depth
     */
    public final double getDepth() {
        return depth;
    }

    /**
     * @param depth the depth to set
     */
    public final void setDepth(double depth) {
        this.depth = depth;
    }
}
