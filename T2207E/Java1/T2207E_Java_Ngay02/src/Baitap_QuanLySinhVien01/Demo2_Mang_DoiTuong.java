/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Baitap_QuanLySinhVien01;

/**
 *
 * @author Asus
 */
public class Demo2_Mang_DoiTuong {
    public static void main(String[] args) {
        int[] iarr = new int[3]; // khai báo mảng số nguyên
        iarr[0] = 10;
        System.out.println("iarr[0] = " + iarr[0]);
        // Khai báo mảng chứa 3 sinh viên
        SinhVien[] SVarr = new SinhVien[3];
        SVarr[0] = new SinhVien();
        System.out.println("Nhập sinh viên 0:");
        SVarr[0].Nhap();
        System.out.println("Hiển thị sinh viên 0");
        SVarr[0].Hienthi();
    }
}
