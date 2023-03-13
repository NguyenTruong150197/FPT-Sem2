
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
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        AddressBookManager mng = new AddressBookManager();
        System.out.println("Address Book");
        System.out.println("1. Add new contact");
        System.out.println("2. Find a contact by name");
        System.out.println("3. Display contacts");
        System.out.println("4. Exit");
        
        while (true) {
            System.out.print("Enter your choice: ");
            int choice = sc.nextInt();

            // Use a switch statement to handle different options
            switch (choice) {
              case 1 -> mng.addContact();
              case 2 -> mng.findContactbyName();
              case 3 -> mng.displayContacts();
              case 4 -> {
                  System.out.println("Thank you for using this program.");
                  System.exit(0);
                }
              default -> System.out.println("Invalid choice. Please try again.");
            }
        }
    }
}
