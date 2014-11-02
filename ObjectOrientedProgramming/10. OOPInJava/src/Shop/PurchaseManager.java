/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Shop;

import java.util.Date;

public class PurchaseManager {

    private PurchaseManager() {

    }

    public static void processPurchase(Product product, Customer customer) {
        if (product.getQuantity() <= 0) {
            throw new UnsupportedOperationException(product.getName() + " is out of stock. Please, come again later!");
        }

        if (product instanceof Expirable && ((Expirable) product).getExpirationDate().compareTo(new Date()) < 0) {
            throw new UnsupportedOperationException("The product has expired. Please, come back when we restock!");
        }

        if (customer.getBalance() < product.getPrice()) {
            throw new UnsupportedOperationException("You do not have enough money to buy this product!");
        }

        if ((product.getAgeRestriction() == AgeRestriction.Teenager && 12 > customer.getAge() && customer.getAge() > 19)
                || (product.getAgeRestriction() == AgeRestriction.Adult && (19 > customer.getAge() || customer.getAge() > 100))) {
            throw new UnsupportedOperationException("You don't match the age requirements to buy this product!");
        }

        product.setQuantity(product.getQuantity() - 1);
        customer.setBalance(customer.getBalance() - product.getPrice());
    }
}
