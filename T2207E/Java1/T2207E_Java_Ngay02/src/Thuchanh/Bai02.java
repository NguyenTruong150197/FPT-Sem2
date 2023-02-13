/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Thuchanh;

import java.util.Scanner;

/**
 *
 * @author Asus
 */
public class Bai02 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double[] arr = new double[100];
        int n;
        do{
            System.out.print("Nhập số phần tử: ");
            n = sc.nextInt();
        }while(n < 1 || n > 100);
        System.out.println("Mời nhập " + n + " phần tử");
        for(int i = 0; i < n; i++){
            System.out.print("Phần tử thứ " + (i + 1) + ": ");
            arr[i] = sc.nextInt();
        }
        
        System.out.println("Các phần tử trong mảng: ");
        for(int i = 0; i < n; i++){
            System.out.print(arr[i] + "\t");
        }
        
        System.out.println("\nCác số âm trong mảng là:");
        for(int i = 0; i < n; i++){
            if(arr[i] < 0)
                System.out.print(arr[i] + "\t");
        }
    }
}
