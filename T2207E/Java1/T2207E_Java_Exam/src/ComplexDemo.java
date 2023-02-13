/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Asus
 */
public class ComplexDemo {
  public static void main(String[] args) {
    Complex cpl1 = new Complex(3, 4);
    Complex cpl2 = new Complex(5, 6);
    
    System.out.println("Complex number 1: " + cpl1);
    System.out.println("Complex number 2: " + cpl2);
    
    Complex sum = cpl1.add(cpl2);
    System.out.println("Sum of complex numbers: " + sum);
    
    Complex difference = cpl1.subtract(cpl2);
    System.out.println("Difference of complex numbers: " + difference);
    
    Complex product = cpl1.multiply(cpl2);
    System.out.println("Product of complex numbers: " + product);
    
    Complex quotient = cpl1.divide(cpl2);
    System.out.println("Quotient of complex numbers: " + quotient);
    
    cpl1.setRealPart(10);
    cpl1.setImaginaryPart(20);
    System.out.println("Complex number 1 after modification: " + cpl1);
  }
}
