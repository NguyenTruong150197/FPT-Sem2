
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Asus
 */
public class AddressBookManager {
    private HashMap<String, String> map_name;
    private Contact contact = new Contact();
    public AddressBookManager() {
        map_name = new HashMap();
    }
    
    public void addContact() {
        Scanner sc = new Scanner(System.in);
        String res;
        while(true) {
            contact.Input();
            map_name.put(contact.getName(), contact.getPhone());
            System.out.println("Continue add new contact? (y/n): ");
            res = sc.nextLine();
            if(res.equalsIgnoreCase("n"))
                break;
        }
    }
    
    public void findContactbyName() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter name: ");
        String name = sc.nextLine();
        if (map_name.containsKey(name)) {
            map_name.get(name);
            System.out.println("Phone: " + contact.getPhone());
        } 
        else
            System.out.println("Not found.");
    }

    public void displayContacts() {
        if (map_name.isEmpty())
            System.out.println("No contacts.");
        else
            System.out.println("Contact Name\tPhone Number");

        for(Map.Entry<String, String> entry : map_name.entrySet()) {
            String name = entry.getKey();
            entry.getValue();
            System.out.format("%-12s    %-12s\n", name, contact.getPhone());
        }
    }
}
