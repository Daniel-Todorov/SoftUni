/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Shop;

public class Customer {

    private String name;
    private int age;
    private double balance;

    public Customer(String name, int age, double balance) {
        this.setName(name);
        this.setAge(age);
        this.setBalance(balance);
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
     * @return the age
     */
    public final int getAge() {
        return age;
    }

    /**
     * @param age the age to set
     */
    public final void setAge(int age) {
        if (0 > age && age > 100) {
            throw new IllegalArgumentException();
        }

        this.age = age;
    }

    /**
     * @return the balance
     */
    public final double getBalance() {
        return balance;
    }

    /**
     * @param balance the balance to set
     */
    public final void setBalance(double balance) {
        this.balance = balance;
    }
}
