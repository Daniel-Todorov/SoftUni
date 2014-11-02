/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg10.oopinjava.geometry;

public class Triangle extends PlaneShape {

    public Triangle(Vertix2D firstVertix, Vertix2D secondVertix, Vertix2D thirdVertix) {
        super(new Vertix2D[]{firstVertix, secondVertix, thirdVertix});
    }

    @Override
    public double getPerimeter() {
        Vertix2D a = (Vertix2D) this.getVertices()[0];
        Vertix2D b = (Vertix2D) this.getVertices()[1];
        Vertix2D c = (Vertix2D) this.getVertices()[2];
        
        double ab = Math.sqrt((b.getX() - a.getX()) * (b.getX() - a.getX()) + (b.getY() - a.getY()) * (b.getY() - a.getY()));
        double bc = Math.sqrt((c.getX() - b.getX()) * (c.getX() - b.getX()) + (c.getY() - b.getY()) * (c.getY() - b.getY()));
        double ac = Math.sqrt((c.getX() - a.getX()) * (c.getX() - a.getX()) + (c.getY() - a.getY()) * (c.getY() - a.getY()));
        
        double perimeter = ab + bc + ac;
        
        return perimeter;
    }

    @Override
    public double getArea() {
        Vertix2D a = (Vertix2D) this.getVertices()[0];
        Vertix2D b = (Vertix2D) this.getVertices()[1];
        Vertix2D c = (Vertix2D) this.getVertices()[2];
        double area = Math.abs((a.getX() * (b.getY() - c.getY()) + b.getX() * (c.getY() - a.getY()) + c.getX() * (a.getY() - b.getY())) / 2);

        return area;
    }
}
