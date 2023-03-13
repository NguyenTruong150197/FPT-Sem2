package ThemDocGhiTep;


import java.io.FileOutputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import java.util.Scanner;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Asus
 */
public class StudentManager {
    private ArrayList<Student> list;

    public StudentManager() {
        list = new ArrayList();
    }
    
    public void InputList() {
        Scanner sc = new Scanner(System.in);
        String res;
        while(true){
            Student st = new Student();
            System.out.print("Nhập sinh viên mới: ");
            st.Input();
            list.add(st);
            System.out.print("Có tiếp tục thêm sinh viên? (c/k): ");
            res = sc.nextLine();
            if(res.equalsIgnoreCase("k"))
                break;
        }
    }
    
    public void DisplayList() {
        if(list.isEmpty()) {
            System.out.println("List is Empty");
            return;
        }
        System.out.format("%-11s       %-25s  %-7s",
        "  EnrolID", "Full Name", "Age");
        System.out.println("");
        System.out.println("-----------  ------------------------------  -------");
        for(Student st : list) {
            st.Display();
        }
    }
    
    public boolean SaveToFile(String filename) {
        FileOutputStream fos = null;
        ObjectOutputStream oos = null;
        try {
            fos = new FileOutputStream(filename);
            oos = new ObjectOutputStream(fos);
            if(list.isEmpty()) {
                System.out.println("Không có dữ liệu để ghi");
                return false;
            }
        }
        catch() {
            
        }
    }
}
