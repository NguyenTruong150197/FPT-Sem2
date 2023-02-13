/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Demo_MangDong;

import java.util.ArrayList;

/**
 *
 * @author Asus
 */
public class Demo_ArrayList02 {
    public static void main(String[] args) {
        ArrayList<SinhVien1> arr = new ArrayList();
        arr.add(new SinhVien1("SV01", "Sinh Viên 1", 9));
        arr.add(new SinhVien1("SV02", "Sinh Viên 2", 10));
        arr.add(new SinhVien1("SV03", "Sinh Viên 3", 8));
        //Hiển thị các sinh viên
        for(int i = 0; i < arr.size(); i++){
            arr.get(i).Hienthi();
        }
        System.out.println("Sử dụng for...each ");
        for(SinhVien1 sv : arr){
            sv.Hienthi();
        }
    }
}
