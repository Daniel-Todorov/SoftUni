/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Shop;

import java.util.Calendar;
import java.util.Date;

public class FoodProduct extends Product implements Expirable {
    
    private Date expirationDate;
    
    public FoodProduct(String name, double price, int quantity, AgeRestriction ageRestriction, Date expirationDate) {
        super(name, price, quantity, ageRestriction);
        
        this.setExpirationDate(expirationDate);
    }
    
    @Override
    public double getPrice() {
        Date currentDate = new Date();
        Calendar calendar = Calendar.getInstance();
        calendar.setTime(currentDate);
        calendar.add(Calendar.DAY_OF_MONTH, 15);
        Date dateAfter15Days = calendar.getTime();
        
        if (this.getExpirationDate().compareTo(currentDate) < 0) {
            throw new IllegalArgumentException();
        }
        
        if (this.getExpirationDate().compareTo(dateAfter15Days) < 0) {
            double reducedPrice = super.getPrice() * 0.7;
            
            return reducedPrice;
        }
        
        return super.getPrice();
    }
    
    @Override
    public final Date getExpirationDate() {
        return this.expirationDate;
    }

    /**
     * @param expirationDate the expirationDate to set
     */
    public final void setExpirationDate(Date expirationDate) {
        
        if (expirationDate.compareTo(new Date()) <= 0) {
            throw new IllegalArgumentException();
        }
        
        this.expirationDate = expirationDate;
    }
}
