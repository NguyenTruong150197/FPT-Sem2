/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Baitap_QuanLySinhVien01;

import java.util.Scanner;

/**
 *
 * @author Asus
 */
public class SinhVien {
    public String MaSV;
    public String HoTen;
    public double Diem;
    
    // Xây dựng cấc hàm tạo
    // Hàm tạo thì không có kiểu dữ liệu trả về (không dùng void)
    // Overload (nạp chồng) 2 hàm tạo 0 tham số và 3 tham số
    public SinhVien() {
        this.MaSV = "";
        this.HoTen = "";
        this.Diem = 0;
    }

    public SinhVien(String MaSV, String HoTen, double Diem) {
        this.MaSV = MaSV;
        this.HoTen = HoTen;
        this.Diem = Diem;
    }

    public String getMaSV() {
        return MaSV;
    }

    public void setMaSV(String MaSV) {
        this.MaSV = MaSV;
    }

    public String getHoTen() {
        return HoTen;
    }

    public void setHoTen(String HoTen) {
        this.HoTen = HoTen;
    }

    public double getDiem() {
        return Diem;
    }

    public void setDiem(double Diem) {
        this.Diem = Diem;
    }
    
    // Xây dựng các phương thức của lớp Sinh viên
    public void Nhap()/* Nhập thông tin từ bàn phím */{
        Scanner sc = new Scanner(System.in);
        System.out.print("Mã SV: ");
        this.MaSV = sc.nextLine();
        System.out.print("Họ tên: ");
        this.HoTen = sc.nextLine();
        System.out.print("Điểm: ");
        this.Diem = sc.nextDouble();
    }
    
    public void Hienthi(){
        System.out.println("Mã SV: " + this.MaSV + ", Họ tên: " + this.HoTen + ", Điểm: " + this.Diem);
    }
}
