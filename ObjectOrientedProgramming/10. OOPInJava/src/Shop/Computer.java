/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Shop;

public class Computer extends ElectronicProduct {

    public Computer(String name, double price, int quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction, 24);
    }
    
    @Override
    public double getPrice(){
        if (super.getQuantity() > 1000) {
            double reducedPrice = super.getPrice() * 0.95;
            return reducedPrice;
        }
        
        return super.getPrice();
    }
}
