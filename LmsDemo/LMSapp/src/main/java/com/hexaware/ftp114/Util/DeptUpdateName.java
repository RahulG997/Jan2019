package com.hexaware.ftp114.util;
import java.util.Scanner;

import com.hexaware.ftp114.model.Employee;
import com.hexaware.ftp114.model.Department;
import java.text.SimpleDateFormat;
import java.text.ParseException;

public class DeptUpdateName{

    public static void main(final String[] ar){
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter Department no. whose Name is to be updated ");
        int deptno = Integer.parseInt(sc.nextLine());
        System.out.println("Enter Department Name: ");
        String dname  = sc.nextLine();
        Department.updateNameMain(deptno, dname);
        System.out.println("dName updated...");
    }

}