package ThemDocGhiTep;


import java.util.InputMismatchException;
import java.util.Scanner;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Asus
 */
public class Main {
    public static int intputInt() {
        Scanner sc = new Scanner(System.in);
        int n;
        while(true) {
            try {
                String str = sc.nextLine();
                n = Integer.parseInt(str);
                return n;
            }
            catch(NumberFormatException e) {
                System.out.println("Mời nhập số nguyên");
            }
        }
    }
    
    private static int Menu() {
        int choice;
        System.out.println("--------- Menu -----------");
        System.out.println("1. Add new Student");
        System.out.println("2. Save");
        System.out.println("3. Display all students");
        System.out.println("4. Exit");
        choice = intputInt();
        return choice;
    }
    
    public static void main(String[] args) {
        StudentManager stm = new StudentManager();
        int choice;
        do {
            choice = Menu();
            switch(choice) {
                case 1 -> {
                    System.out.println("Add new Student");
                    stm.InputList();
                    System.out.println("Input Completed");
                }
                case 2 -> System.out.println("Save to file Student.dat");
                case 3 -> {
                    System.out.println("Display all Students");
                    stm.DisplayList();
                }
                case 4 -> System.out.println("Good bye!");
                default -> System.out.println("Please, Input 1-4");
            }
        } while(choice != 4);
    }
}
