/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Shop;

public class Appliance extends ElectronicProduct {

    public Appliance(String name, double price, int quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction, 6);
    }
    
    @Override
    public double getPrice(){
        if (super.getQuantity() < 50) {
            double increasedPrice = super.getPrice() * 1.05;
            return increasedPrice;
        }
        
        return super.getPrice();
    }
}
