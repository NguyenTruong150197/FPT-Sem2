/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Baitap_QuanLySinhVien02;

import java.util.Scanner;

/**
 *
 * @author Asus
 */
public class SinhVien1 {
    public String MaSV;
    public String Hoten;
    public double Diem;

    public SinhVien1() {
        this.MaSV = "";
        this.Hoten = "";
        this.Diem = 0;
    }
    
    public SinhVien1(String MaSV, String Hoten, double Diem) {
        this.MaSV = MaSV;
        this.Hoten = Hoten;
        this.Diem = Diem;
    }

    public String getMaSV() {
        return MaSV;
    }

    public void setMaSV(String MaSV) {
        this.MaSV = MaSV;
    }

    public String getHoten() {
        return Hoten;
    }

    public void setHoten(String Hoten) {
        this.Hoten = Hoten;
    }

    public double getDiem() {
        return Diem;
    }

    public void setDiem(double Diem) {
        this.Diem = Diem;
    }
    
    public void Nhap()/* Nhập thông tin từ bàn phím */{
        Scanner sc = new Scanner(System.in);
        System.out.print("Mã SV: ");
        this.MaSV = sc.nextLine();
        System.out.print("Họ tên: ");
        this.Hoten = sc.nextLine();
        System.out.print("Điểm: ");
        this.Diem = sc.nextDouble();
    }
    
    public void Hienthi(){
        System.out.println("Mã SV: " + this.MaSV + ", Họ tên: " + this.Hoten + ", Điểm: " + this.Diem);
    }
}
