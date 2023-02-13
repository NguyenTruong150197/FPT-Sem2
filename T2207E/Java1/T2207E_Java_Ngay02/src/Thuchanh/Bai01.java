/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Thuchanh;

import java.util.Scanner;

/**
 *
 * @author Admin
 */
public class Bai01 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int[] arr = new int[100];
        int n, tongle;
        do{
            System.out.print("Nhập số phần tử (1-100): ");
            n = sc.nextInt();
        }while(n < 1 || n > 100);
        System.out.println("Mời nhập " + n + " phần tử");
        for(int i = 0; i < n; i++){
            System.out.print("Phần tử thứ " + (i + 1) + ": ");
            arr[i] = sc.nextInt();
        }
        
        System.out.println("Các phần tử đã nhập: ");
        for(int i = 0; i < n; i++){
            System.out.print(arr[i] + "\t");
        }
        
        tongle = 0;
        for(int i = 0; i < n; i++){
            if(arr[i] % 2 != 0)
                tongle += arr[i];
        }
        System.out.println("\nTổng các số lẻ: " + tongle);
    }
}
