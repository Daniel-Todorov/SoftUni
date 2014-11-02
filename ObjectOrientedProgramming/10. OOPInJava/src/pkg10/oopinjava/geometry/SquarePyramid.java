/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg10.oopinjava.geometry;

public class SquarePyramid extends SpaceShape {

    private double width;
    private double height;

    public SquarePyramid(Vertix3D vertix, double width, double height) {
        super(new Vertix3D[]{vertix});

        this.setWidth(width);
        this.setHeight(height);
    }

    @Override
    public double getArea() {
        double baseArea = this.getWidth() * this.getWidth();
        double baseParameter = 4 * this.getWidth();
        double slantLength = Math.sqrt(this.getHeight() * this.getHeight() + (this.getWidth() / 2) * (this.getWidth() / 2));

        double area = baseArea + (baseParameter * slantLength) / 2;

        return area;
    }

    @Override
    public double getVolume() {
        double volume = (this.getWidth() * this.getWidth() * this.getHeight()) / 3;

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
}
