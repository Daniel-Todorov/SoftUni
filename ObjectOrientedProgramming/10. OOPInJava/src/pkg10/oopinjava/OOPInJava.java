/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg10.oopinjava;

import Shop.AgeRestriction;
import Shop.Customer;
import Shop.FoodProduct;
import Shop.PurchaseManager;
import java.text.SimpleDateFormat;
import java.util.Arrays;
import java.util.List;
import pkg10.oopinjava.geometry.Circle;
import pkg10.oopinjava.geometry.Cuboid;
import pkg10.oopinjava.geometry.PlaneShape;
import pkg10.oopinjava.geometry.Rectangle;
import pkg10.oopinjava.geometry.Shape;
import pkg10.oopinjava.geometry.Sphere;
import pkg10.oopinjava.geometry.SquarePyramid;
import pkg10.oopinjava.geometry.Triangle;
import pkg10.oopinjava.geometry.Vertix2D;
import pkg10.oopinjava.geometry.Vertix3D;
import pkg10.oopinjava.geometry.VolumeMeasurable;

public class OOPInJava {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        //Geometry testing
        Vertix2D firstVertix = new Vertix2D(15, 15);
        Vertix2D secondVertix = new Vertix2D(15, 30);
        Vertix2D thirdVertix = new Vertix2D(30, 30);
        Triangle triangle = new Triangle(firstVertix, secondVertix, thirdVertix);
        Rectangle rectangle = new Rectangle(firstVertix, 10, 5);
        Circle circle = new Circle(secondVertix, 5);
        Cuboid cuboid = new Cuboid(new Vertix3D(1, 2, 3), 2, 3, 1);
        SquarePyramid pyramid = new SquarePyramid(new Vertix3D(4, 4, 4), 10, 5);
        Sphere sphere = new Sphere(new Vertix3D(10, 10, 10), 7.5);

        Shape[] shapes = new Shape[]{triangle, rectangle, circle, cuboid, pyramid, sphere};

        for (Shape shape : shapes) {
            System.out.println(shape.toString());
        }

        List<Shape> listedShapes = Arrays.asList(triangle, rectangle, circle, cuboid, pyramid, sphere);

        System.out.println("VolumeMeasurable shapes with volum > 40 :");
        listedShapes.stream()
                .filter(shape -> shape instanceof VolumeMeasurable)
                .filter(shape -> ((VolumeMeasurable) shape).getVolume() > 40)
                .forEach(shape -> System.out.println(shape.toString()));

        System.out.println("Plane shapes in ascending order by perimeter:");
        listedShapes.stream()
                .filter(shape -> shape instanceof PlaneShape)
                .sorted((s1, s2) -> (int) ((PlaneShape) s1).getPerimeter() - (int) ((PlaneShape) s2).getPerimeter())
                .forEach(shape -> System.out.println(shape.toString()));

        //Shop testing
        FoodProduct cigars = null;

        try {
            cigars = new FoodProduct("420 Blaze it fgt", 6.90, 1400, AgeRestriction.Adult, new SimpleDateFormat("yyyy-MM-dd").parse("2015-01-01"));
            
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        Customer pecata = new Customer("Pecata", 17, 30.00);
        Customer gopeto = new Customer("Gopeto", 18, 0.44);

        try {
            PurchaseManager.processPurchase(cigars, pecata);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        try {
            PurchaseManager.processPurchase(cigars, gopeto);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}
