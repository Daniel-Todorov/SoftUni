/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg10.oopinjava.geometry;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable, AreaMeasurable {

    protected PlaneShape(Vertix2D[] vertices2D) {
        super(vertices2D);
    }

    @Override
    public String toString() {
        String result = super.toString();

        result += "Perimeter: " + this.getPerimeter() + System.getProperty("line.separator");
        result += "Area: " + this.getArea() + System.getProperty("line.separator");
        result += "----------";

        return result;
    }
}
