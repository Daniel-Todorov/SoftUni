
package java_loops_method_classes_homework;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.Writer;
import java.util.ArrayList;
import java.util.Collections;

/**
 * 
 * @author Daniel Todorov
 */
public class List_Of_Products {
    
    public static void main(String[] args) {
        
        ArrayList<Product> products = new ArrayList<Product>();
        BufferedReader reader;
        Writer writer = null;
        
        try {
            reader = new BufferedReader(new FileReader("Products.txt"));
            String line = null;
            
            while ((line = reader.readLine()) != null) {
               String[] splittedLine = line.split(" ");
               products.add(new Product(splittedLine[0], Double.parseDouble(splittedLine[1])));
            }
            
            Collections.sort(products);
            writer = new BufferedWriter(new FileWriter("Output.txt"));
            
            for(Product product : products){
                writer.write(product.getPrice() + " " + product.getName() + "\r\n" );
            }
        } catch (Exception e) {
            System.out.println("Error");
        } finally {
            try {
                writer.close();
            } catch (Exception ex) {
                System.out.println("Error while closing resource");
            }
        }

    } 
}

class Product implements Comparable<Product>{
    
    private String name;
    private double price;

    public Product(String name, double price){
        this.name = name;
        this.price = price;
    }

    public String getName(){
        return name;
    }

    public double getPrice(){
        return price;
    }

    public int compareTo(Product compareFruit) {

        double otherPrice = ((Product) compareFruit).getPrice();

        if(this.price>otherPrice) {
            return 1;
        } else if(this.price==otherPrice) {
            return 0;
        }
        
        return -1;
    }      
}