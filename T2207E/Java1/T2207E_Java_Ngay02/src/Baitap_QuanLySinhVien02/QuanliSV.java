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
public class QuanliSV {
//    public SinhVien1[] SV = new SinhVien1[30];
    public SinhVien1[] SV;
    public int n;
    
    public QuanliSV(){
        n = 0;
        SV = new SinhVien1[30];
    }
    
    public void NhapDSSV(){
        Scanner sc = new Scanner(System.in);
        do{
            System.out.print("Nhập số sinh viên cần nhập thông tin (1-30): ");
            n = sc.nextInt();
        }while(n < 1 || n > 30);
        
        System.out.println("Nhập " + n + " Sinh Viên");
        for(int i = 0; i < n; i++){
            System.out.println("Nhập sinh viên thứ " + (i + 1) + ":");
            SV[i] = new SinhVien1();
            SV[i].Nhap();
        }
    }
    
    public void HienthiDSSV(){
        for(int i = 0; i < 0; i++){
            SV[i].Hienthi();
        }
    }
    
    public void SapxepDiemGiamDan(){
        for(int i = 0; i < n - 1; i++){
            for(int j = i + 1; j < n; j++){
                SinhVien1 temp;
                if(SV[i].Diem < SV[j].Diem){
                    temp = SV[i];
                    SV[i] = SV[j];
                    SV[j] = temp;
                }
            }
        }
    }
    
}
