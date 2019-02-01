package com.hexaware.ftp114.util;
import java.util.Scanner;

import com.hexaware.ftp114.model.Employee;
import com.hexaware.ftp114.model.Department;
import java.text.SimpleDateFormat;
import java.text.ParseException;

public class DeptMainInsert{

    public static void main(final String[] ar){
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter Department no. ");
        int deptno = Integer.parseInt(sc.nextLine());
        System.out.println("Enter Department Name ");
        String dname  = sc.nextLine();
        System.out.println("Enter Department location ");
        String loc  = sc.nextLine();
        Department.insertDept(deptno, dname, loc);
        System.out.println("Record Inserted...");
    }

}