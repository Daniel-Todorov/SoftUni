/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Shop;

public abstract class Product implements Buyable {

    private String name;
    private double price;
    private int quantity;
    private AgeRestriction ageRestriction;
    
    protected Product(String name, double price, int quantity, AgeRestriction ageRestriction){
        this.setName(name);
        this.setPrice(price);
        this.setQuantity(quantity);
        this.setAgeRestriction(ageRestriction);
    }

    /**
     * @return the name
     */
    public final String getName() {
        return name;
    }

    /**
     * @param name the name to set
     */
    public final void setName(String name) {
        if (name == null) {
            throw new NullPointerException();
        }

        this.name = name;
    }

    /**
     * @return the price
     */
    @Override
    public double getPrice() {
        return price;
    }

    /**
     * @param price the price to set
     */
    public final void setPrice(double price) {
        if (price <= 0) {
            throw new IllegalArgumentException();
        }
        
        this.price = price;
    }

    /**
     * @return the quantity
     */
    public final int getQuantity() {
        return quantity;
    }

    /**
     * @param quantity the quantity to set
     */
    public final void setQuantity(int quantity) {
        if (quantity < 0) {
            throw new IllegalArgumentException();
        }
        
        this.quantity = quantity;
    }

    /**
     * @return the ageRestriction
     */
    public final AgeRestriction getAgeRestriction() {
        return ageRestriction;
    }

    /**
     * @param ageRestriction the ageRestriction to set
     */
    public final void setAgeRestriction(AgeRestriction ageRestriction) {
        if (ageRestriction == null) {
            throw new NullPointerException();
        }
        
        this.ageRestriction = ageRestriction;
    }

}
