/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package CSDL;

import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Asus
 */
public class Database {
    public static String user = "root";
    public static String pass = "";
    public static String url = "jdbc:mysql://localhost:3306/t2207e_java?useUnicode=true&characterEncoding=utf8";
    public static Connection KetnoiCSDL() throws SQLException{
        Connection cnn = null;
        try {
            Class.forName("com.mysql.jdbc.Driver");
                                                                                                                                                                                                                                                                                                                                                                cnn = DriverManager.getConnection(url, user, pass);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(Database.class.getName()).log(Level.SEVERE, null, ex);
        }
        return cnn;
    }
}
