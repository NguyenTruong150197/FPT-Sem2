/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Quest01_TamGiac;

/**
 *
 * @author Asus
 */
public class Triangle {
    public int a;
    public int b;
    public int c;
    public int P;
    public double S;

    public Triangle() {
    }

    public Triangle(int a, int b, int c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public int getA() {
        return a;
    }

    public void setA(int a) {
        this.a = a;
    }

    public int getB() {
        return b;
    }

    public void setB(int b) {
        this.b = b;
    }

    public int getC() {
        return c;
    }

    public void setC(int c) {
        this.c = c;
    }
    
    public void perimeter()  {
        P = a + b + c;
    }
    
    public void area()  {
        S = Math.sqrt(P*(P - a)*(P - b)*(P - c));
    }
}
