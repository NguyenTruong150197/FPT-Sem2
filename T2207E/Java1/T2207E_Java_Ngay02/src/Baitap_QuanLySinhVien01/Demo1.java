/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Baitap_QuanLySinhVien01;

/**
 *
 * @author Asus
 */
public class Demo1 {
    public static void main(String[] args) {
        // Primitive data type
        int x;
        x = 10;
        // Reference data type
        SinhVien sv; // sv = null (chưa tham chiếu tới sinh viên nào)
        // lệnh sv.MaSV = "SV01" lỗi do chưa tạo đối tượng gán cho SV
        // sv.MaSV = "SV01";
        sv = new SinhVien();
        // new để gọi Constructor của lớp SinhVien
        // để tạo đối tượng (Object/Instance) SinhVien gán cho sv
        sv.MaSV = "SV01";
        sv.setHoTen("Nguyễn Trọng Trường");
        sv.setDiem(9.5);
        // tạo đối tượng moiwsgawns cho SV tham chiếu tới
        sv = new SinhVien("SV02", "Lê Thị Hoa", 8.5);
        sv.Hienthi(); // Hiện thị sinh viên mới
        // thông thường khai báo và khởi tạo đối tượng cùng 1 dòng
        SinhVien sv2 = new SinhVien();
        System.out.print("Nhập SV2: ");
        sv2.Nhap();
        SinhVien sv3 = sv2; // gán đối tượng của SV2 đang tham chiếu cho SV3
        System.out.println("Thông tin SV2:");
        sv3.Hienthi(); // tương đương sv2.Hienthi()
    }
}
