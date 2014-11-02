/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg10.oopinjava.geometry;

public abstract class Vertix {

    private double x;
    private double y;

    protected Vertix(double x, double y) {
        this.setX(x);
        this.setY(y);
    }
    
    @Override
    public String toString(){
        String result = "x=" + this.getX() + ", y=" + this.getY();
        
        return result;
    }

    /**
     * @return the x
     */
    public final double getX() {
        return x;
    }

    /**
     * @param x the x to set
     */
    public final void setX(double x) {
        this.x = x;
    }

    /**
     * @return the y
     */
    public final double getY() {
        return y;
    }

    /**
     * @param y the y to set
     */
    public final void setY(double y) {
        this.y = y;
    }

}
