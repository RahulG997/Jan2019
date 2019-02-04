package com.hexaware.ftp114.util;
import java.util.Scanner;

import com.hexaware.ftp114.model.Employee;
import java.text.SimpleDateFormat;
import java.text.ParseException;

public class DeptUpdateLoc{

    public static void main(final String[] ar){
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter Department no. whose location is to be updated ");
        int deptno = Integer.parseInt(sc.nextLine());
        System.out.println("Enter Department location: ");
        String loc  = sc.nextLine();
        Department.updateNameLocMain(deptno, loc);
        System.out.println("Location updated...");
    }

}