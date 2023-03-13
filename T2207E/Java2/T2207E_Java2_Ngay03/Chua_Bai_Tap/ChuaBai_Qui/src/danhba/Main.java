/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package danhba;

import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Admin
 */
public class Main {
    
    static Loading loading;
    static frmHome home;
    
    public static void main(String[] args) {
        loading = new Loading();
        showHome();  
    }

    public static void showHome() {
       try {
            Thread.sleep(1750);
        } catch (InterruptedException ex) {
            Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
        }
        frmHome home = new frmHome();
        home.setVisible(true);
    }
}
