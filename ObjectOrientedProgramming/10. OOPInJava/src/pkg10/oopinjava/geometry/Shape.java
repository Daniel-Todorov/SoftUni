/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg10.oopinjava.geometry;

public abstract class Shape {

    private Vertix[] vertices;

    protected Shape(Vertix[] vertices) {
        this.setVertices(vertices);
    }

    @Override
    public String toString() {
        String result = "Type: " + this.getClass().getSimpleName() + System.getProperty("line.separator");

        for (int i = 0; i < this.getVertices().length; i++) {
            result += "vertix " + (i + 1) + ": " + this.getVertices()[i].toString() + System.getProperty("line.separator");
        }

        return result;
    }

    /**
     * @return the vertices
     */
    public Vertix[] getVertices() {
        return vertices;
    }

    /**
     * @param vertices the vertices to set
     */
    protected final void setVertices(Vertix[] vertices) {
        this.vertices = vertices;
    }
}
