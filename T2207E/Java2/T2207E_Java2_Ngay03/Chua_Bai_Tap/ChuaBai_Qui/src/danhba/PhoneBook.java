/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package danhba;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Admin
 */
public class PhoneBook {

    private ArrayList<Phone> listPhone;
    private ArrayList<Phone> listResult;

    public PhoneBook() {
        listPhone = new ArrayList<Phone>();
        listResult = new ArrayList<Phone>();
        listPhone.add(new Phone("Quy", "0925251325", "quy@gmail.com"));
        listPhone.add(new Phone("Anh", "0918273645", "anh@gmail.com"));
        listPhone.add(new Phone("Dung", "0707225588", "dung@gmail.com"));
        listPhone.add(new Phone("Mai", "0986295956", "mai@gmail.com"));
        listPhone.add(new Phone("Trang", "0923456789", "thuy@gmail.com"));
    }

    public ArrayList<Phone> getListPhone() {
        return listPhone;
    }

    public void setListPhone(ArrayList<Phone> listPhone) {
        this.listPhone = listPhone;
    }

    public void addPhone(Phone phone) {
        listPhone.add(phone);
    }

    public boolean phoneNumberIsExist(String phoneNumber) {
        for (Phone phone : listPhone) {
            if (phone.getPhoneNumber().equals(phoneNumber)) {
                return true;
            }
        }
        return false;
    }

    public boolean phoneNumberIsExist2(String phoneNumberIn, String phoneNumberOut) {
        for (Phone phone : listPhone) {
            if (phone.getPhoneNumber().equals(phoneNumberOut) && !phoneNumberIn.equals(phoneNumberOut)) {
                return true;
            }
        }
        return false;
    }

    public ArrayList<Phone> setListResult(String key) {
        key = key.toLowerCase();
        System.out.println("Key ---" + key);
        if (!listResult.isEmpty()) {
            listResult.clear();
        }
        for (Phone phone : listPhone) {
            String phoneName = phone.getName().toLowerCase();
            String phonePhoneNumber = phone.getPhoneNumber().toLowerCase();
            System.out.println(phoneName.indexOf(key) + "Test name");
            if (phoneName.indexOf(key) >= 0 || phonePhoneNumber.indexOf(key) >= 0) {
                listResult.add(phone);
            }
        }
        return listResult;
    }
    
    public ArrayList<Phone> getListResult() {
        return listResult;
    }
    
    public Phone getPhoneByPhoneNumber(String phoneNumber){
        for (Phone phone : listPhone) {
            if (phone.getPhoneNumber().equals(phoneNumber)) {
                return phone;
            }
        }
        return null;
    } 
}
