/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg10.oopinjava.geometry;

public class Vertix3D extends Vertix {

    private double z;

    public Vertix3D(double x, double y, double z) {
        super(x, y);
        this.setZ(z);
    }

    @Override
    public String toString() {
        String result = super.toString() + ", z=" + this.getZ();

        return result;
    }

    /**
     * @return the z
     */
    public final double getZ() {
        return z;
    }

    /**
     * @param z the z to set
     */
    public final void setZ(double z) {
        this.z = z;
    }
}
