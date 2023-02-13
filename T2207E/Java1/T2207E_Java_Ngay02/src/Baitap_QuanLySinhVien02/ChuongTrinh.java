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
public class ChuongTrinh {
    public static int Menu(){
        int chon;
        Scanner sc = new Scanner(System.in);
        System.out.println("-----Menu-----");
        System.out.println("1. Nhập DSSV\n2. Hiển thị DSSV");
        System.out.println("3. Sáp xếp Điểm giảm dần");
        System.out.println("4. Thoát");
        System.out.println("Mời chọn (1-4):");
        chon = sc.nextInt();
        return chon;
    }
    
    public static void main(String[] args) {
        QuanliSV list = new QuanliSV();
        int chon;
        do{
            chon = Menu();
            
            switch(chon){
                case 1:
                    list.NhapDSSV();
                    break;
                case 2:
                    System.out.print("Danh sách sinh viên: ");
                    list.HienthiDSSV();
                    break;
                case 3:
                    System.out.print("Sắp xếp theo điểm giảm dần: ");
                    list.SapxepDiemGiamDan();
                    list.HienthiDSSV();
                    break;
                case 4:
                    System.out.println("Kết thúc!");
                    break;
                default:
                    
            }
        }while(chon != 4);
    }
}
