/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package danhba;

/**
 *
 * @author Admin
 */
public class Phone {
    private String name;
    private String phoneNumber;
    private String email;

    public Phone() {
    }

    public Phone(String name, String phoneNumber, String email) {
        this.name = name;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    @Override
    public String toString() {
        return name + " - " + phoneNumber + " - " + email;
    }
    
    public static boolean phoneNumberRegex(String phoneRgx) {
        String rgx = "0\\d{9}";
        if (phoneRgx.matches(rgx)) {
            return true;
        }
        return false;
    }
    
    public static boolean emailRegex(String emailRgx) {
        String rgx = "[A-z0-9]{1,20}@[A-z0-9]{1,20}\\.[A-z0-9]{1,20}";
        if (emailRgx.matches(rgx)) {
            return true;
        }
        return false;
    }
}
