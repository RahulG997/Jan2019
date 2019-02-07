package com.hexaware.ftp114.util;
import java.util.Scanner;

import com.hexaware.ftp114.model.Employee;
import java.text.SimpleDateFormat;
import java.text.ParseException;

public class DeptMainDel{

    public static void main(final String[] ar){
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter Department no. ");
        int deptno = Integer.parseInt(sc.nextLine());
        Department.delDept(deptno);
        System.out.println("Record Inserted...");
    }

}