/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Asus
 */
public class Complex {
  private double realPart;
  private double imaginaryPart;
  
  public Complex() {
    this.realPart = 0;
    this.imaginaryPart = 0;
  }
  
  public Complex(double realPart, double imaginaryPart) {
    this.realPart = realPart;
    this.imaginaryPart = imaginaryPart;
  }
  
  public Complex add(Complex otherNumber) {
    double real = this.realPart + otherNumber.realPart;
    double imag = this.imaginaryPart + otherNumber.imaginaryPart;
    return new Complex(real, imag);
  }
  
  public Complex subtract(Complex otherNumber) {
    double real = this.realPart - otherNumber.realPart;
    double imag = this.imaginaryPart - otherNumber.imaginaryPart;
    return new Complex(real, imag);
  }
  
  public Complex multiply(Complex otherNumber) {
    double real = (this.realPart * otherNumber.realPart) - (this.imaginaryPart * otherNumber.imaginaryPart);
    double imag = (this.realPart * otherNumber.imaginaryPart) + (this.imaginaryPart * otherNumber.realPart);
    return new Complex(real, imag);
  }
  
  public Complex divide(Complex otherNumber) {
    double denominator = Math.pow(otherNumber.realPart, 2) + Math.pow(otherNumber.imaginaryPart, 2);
    double real = ((this.realPart * otherNumber.realPart) + (this.imaginaryPart * otherNumber.imaginaryPart)) / denominator;
    double imag = ((this.imaginaryPart * otherNumber.realPart) - (this.realPart * otherNumber.imaginaryPart)) / denominator;
    return new Complex(real, imag);
  }
  
  public void setRealPart(double realPart) {
    this.realPart = realPart;
  }
  
  public void setImaginaryPart(double imaginaryPart) {
    this.imaginaryPart = imaginaryPart;
  }
  
  public double getRealPart() {
    return this.realPart;
  }
  
  public double getImaginaryPart() {
    return this.imaginaryPart;
  }
  
  public String asString() {
    return this.realPart + " + " + this.imaginaryPart + "i";
  }
}

