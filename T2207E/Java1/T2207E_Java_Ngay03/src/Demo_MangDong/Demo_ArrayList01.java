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
public class Demo_ArrayList01 {
    public static void main(String[] args) {
        //Khai báo và khởi tạo đối tượng ArrayList
        //là đối tượng dùng để quản lí mảng động
        ArrayList arr = new ArrayList();
        Integer i = 10;
        Double d = 5.5;
        String str = "Java";
        SinhVien1 sv = new SinhVien1("SV01", "Sinh Viên 1", 9);
        //Thêm các đối tượng vào mảng arr
        //Không cần cùng kiểu , vì mảng sử dụng kiểu Object chung
        //Object là cha của mọi lớp trong Java
        arr.add(i);//Thêm 1 đối tượng Integer vào vị trí 0
        arr.add(d);// Thêm 1 đối tượng Double vào vị trí 1
        arr.add(str);//Thêm 1 chuỗi vào vị trí 2
        //Thêm đối tượng Sinh viên vào vị trí 2, đối tượng str sẽ lùi
        arr.add(2, sv);
        //Số phàn tử mảng
        int n = arr.size();
        System.out.println("Số phần tử: " + n);
        //Lấy phần tử ở vị trí số 3 (str)
        String s = (String)arr.get(3);//Phải ép kiểu về kiểu ban đầu khi 
        System.out.println("arr[3] = " + s);
        SinhVien1 sv2 = (SinhVien1)arr.get(2);
        sv2.Hienthi();
    }
}
