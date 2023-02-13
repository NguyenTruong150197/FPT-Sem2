/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Baitap_QuanLySinhVien01;

/**
 *
 * @author Asus
 */
public class Demo3_Khoitao_Mangdoituong {
    public static void main(String[] args) {
        // Khai báo mảng chứa 3 sinh viên
        SinhVien[] SVarr = new SinhVien[3];
        //khởi tạo 3 sinh viên gán cho 3 phần tử của mảng
        for(int i = 0; i < SVarr.length; i++){
            SVarr[i] = new SinhVien();
        }
        // nhập 3 sinh viên
        for (SinhVien SVarr1 : SVarr) {
            System.out.println("Nhập sinh viên:");
            SVarr1.Nhap();
        }
        
        System.out.println("Hiển thị sinh viên 0");
        SVarr[0].Hienthi();
    }
}
