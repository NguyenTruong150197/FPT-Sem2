/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Quest01_TamGiac;

/**
 *
 * @author Asus
 */
public class ETriangle extends Triangle {

    public ETriangle() {
        super();
    }

    public ETriangle(int a, int b, int c) {
        super(a, b, c);
    }
    
    
    @Override
    public void perimeter()  {
        P = a + b + c;
    }
    
    @Override
    public void area()  {
        S = Math.sqrt(P*(P - a)*(P - b)*(P - c));
    }
}
