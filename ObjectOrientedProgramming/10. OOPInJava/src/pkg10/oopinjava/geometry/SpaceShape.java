/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg10.oopinjava.geometry;

public abstract class SpaceShape extends Shape implements AreaMeasurable, VolumeMeasurable {

    protected SpaceShape(Vertix3D[] vertices) {
        super(vertices);
    }

    @Override
    public String toString() {
        String result = super.toString();

        result += "Volume: " + this.getVolume() + System.getProperty("line.separator");
        result += "Area: " + this.getArea() + System.getProperty("line.separator");
        result += "----------";

        return result;
    }
}
