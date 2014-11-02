/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Shop;

public abstract class ElectronicProduct extends Product {

    private int guaranteePeriod;

    protected ElectronicProduct(String name, double price, int quantity, AgeRestriction ageRestriction, int guaranteePeriod) {
        super(name, price, quantity, ageRestriction);

        this.setGuaranteePeriod(guaranteePeriod);
    }

    /**
     * @return the guaranteePeriod
     */
    public final int getGuaranteePeriod() {
        return guaranteePeriod;
    }

    /**
     * @param guaranteePeriod the guaranteePeriod to set
     */
    public final void setGuaranteePeriod(int guaranteePeriod) {
        if (guaranteePeriod < 0) {
            throw new IllegalArgumentException();
        }

        this.guaranteePeriod = guaranteePeriod;
    }

}
