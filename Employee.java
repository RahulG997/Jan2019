package com.hexaware.ftp04.model;

import com.hexaware.ftp04.persistence.DbConnection;
import com.hexaware.ftp04.persistence.EmployeeDAO;

import java.text.SimpleDateFormat;

import java.util.Objects;
import java.util.List;
import java.util.Date;
import java.text.ParseException;

/**
 * Employee class to store employee personal details.
 * @author hexware
 */
public class Employee {

  /**
   * empId to store employee id.
   */
  private int empId;
   /**
   * empName to store employee name.
   */
  private String empName;
   /**
   * empDepartment to store employee department.
   */
  private String empDepartment;
   /**
   * empPhone to store employee phone.
   */
  private long empPhone;
   /**
   * empEmail to store employee email.
   */
  private String empEmail;
   /**
   * empDateOfJoin to store employee date of Join.
   */
  private Date empDateOfJoin;
   /**
   * empLeaveBalance to store employee Leave balance.
   */
  private int empLeaveBalance;
   /**
   * empManagerId to store employee manager id.
   */
  private int empManagerId;

  @Override
  public final boolean equals(final Object obj) {
    if (obj == null) {
      return false;
    }
    if (getClass() != obj.getClass()) {
      return false;
    }
    Employee emp = (Employee) obj;
    if (Objects.equals(empId, emp.empId) && Objects.equals(empName, emp.empName)
        && Objects.equals(empDepartment, emp.empDepartment) && Objects.equals(empPhone, emp.empPhone)
        && Objects.equals(empEmail, emp.empEmail) && Objects.equals(empDateOfJoin, emp.empDateOfJoin)
        && Objects.equals(empLeaveBalance, emp.empLeaveBalance) && Objects.equals(empManagerId, emp.empManagerId)) {
      return true;
    }
    return false;
  }

  @Override
  public final int hashCode() {
    return Objects.hash(empId, empName, empDepartment, empPhone,
                      empEmail, empDateOfJoin, empLeaveBalance, empManagerId);
  }

  /**
   * @param argEmpId to initialize employee id.
   */
  public Employee(final int argEmpId) {
    this.empId = argEmpId;
  }

  /**
   * @param argEmpId to initialize employee id.
   * @param argEmpName to initialize employee name.
   * @param argEmpDepartment to initialize employee department.
   * @param argEmpPhone to initialize employee Phone.
   * @param argEmpEmail to initialize employee Email.
   * @param argEmpDateOfJoin to initialize employee date of join.
   * @param argEmpLeaveBalance to initialize employee Leave balance.
   * @param argEmpManagerId to initialize employee manager id.
   */
  public Employee(final int argEmpId, final String argEmpName, final String argEmpDepartment, final long argEmpPhone,
                  final String argEmpEmail, final Date argEmpDateOfJoin, final int argEmpLeaveBalance,
                  final int argEmpManagerId) {
    this.empId = argEmpId;
    this.empName = argEmpName;
    this.empDepartment = argEmpDepartment;
    this.empPhone = argEmpPhone;
    this.empEmail = argEmpEmail;
    this.empDateOfJoin = argEmpDateOfJoin;
    this.empLeaveBalance = argEmpLeaveBalance;
    this.empManagerId = argEmpManagerId;
  }

   /**
   * Gets the EmployeeId.
   * @return this Employee's ID.
   */
  public final int getEmpId() {
    return empId;
  }

  /**
   *
   * @param argEmpId to set employee id.
   */
  public final void setEmpId(final int argEmpId) {
    this.empId = argEmpId;
  }


  /**
   * Gets the EmployeeName.
   * @return this Employee's Name.
   */
  public final String getEmpName() {
    return empName;
  }

  /**
   *
   * @param argEmpName to set employee name.
   */
  public final void setEmpName(final String argEmpName) {
    this.empName = argEmpName;
  }


  /**
   * Gets the EmployeeDepartment.
   * @return this Employee's Department.
   */
  public final String getEmpDepartment() {
    return empDepartment;
  }

  /**
   *
   * @param argEmpDepartment to set employee Department.
   */
  public final void setEmpDepartment(final String argEmpDepartment) {
    this.empDepartment = argEmpDepartment;
  }


  /**
   * Gets the EmployeePhone.
   * @return this Employee's Phone.
   */
  public final long getEmpPhone() {
    return empPhone;
  }

  /**
   *
   * @param argEmpPhone to set employee Phone.
   */
  public final void setEmpPhone(final long argEmpPhone) {
    this.empPhone = argEmpPhone;
  }



  /**
   * Gets the EmployeeEmail.
   * @return this Employee's Email.
   */
  public final String getEmpEmail() {
    return empEmail;
  }

  /**
   *
   * @param argEmpEmail to set employee Email.
   */
  public final void setEmpEmail(final String argEmpEmail) {
    this.empEmail = argEmpEmail;
  }



  /**
   * Gets the EmployeeDateOfJoin.
   * @return this Employee's date of join.
   */
  public final Date getEmpDateOfJoin() {
    return empDateOfJoin;
  }

  /**
   *
   * @param argEmpDateOfJoin to set employee date of join.
   */
  public final void setEmpDateOfJoin(final Date argEmpDateOfJoin) {
    this.empDateOfJoin = argEmpDateOfJoin;
  }



  /**
   * Gets the EmployeeLeaveBalance.
   * @return this Employee's leave balance.
   */
  public final int getEmpLeaveBalance() {
    return empLeaveBalance;
  }

  /**
   *
   * @param argEmpLeaveBalance to set employee leave balance.
   */
  public final void setEmpLeaveBalance(final int argEmpLeaveBalance) {
    this.empLeaveBalance = argEmpLeaveBalance;
  }

  /**
   * Gets the EmployeeManagerId.
   * @return this Employee's Manager ID.
   */
  public final int getEmpManagerId() {
    return empManagerId;
  }

  /**
   *
   * @param argEmpManagerId to set employee Manager id.
   */
  public final void setEmpManagerId(final int argEmpManagerId) {
    this.empManagerId = argEmpManagerId;
  }

  /**
   * The dao for employee.
   */
  private static EmployeeDAO dao() {
    DbConnection db = new DbConnection();
    return db.getConnect().onDemand(EmployeeDAO.class);
  }

  /**
   * list all employee details.
   * @return all employees' details
   */
  public static Employee[] listAll() {
    List<Employee> es = dao().list();
    return es.toArray(new Employee[es.size()]);
  }

  /**
   * list employee details by id.
   * @param empID id to get employee details.
   * @return Employee
   */
  public static Employee listById(final int empID) {
    return dao().find(empID);
  }
  /**
   * Insert employee leave details.
   * @param argsEmpId  to get employee id.
   * @param argsLevNoOfDays to get number of days of leave.
   * @param argsLevStartDate  to get start date.
   * @param argsLevEndDate  to get end date.
   * @param argsLevType  to get leave Type.
   * @param argsLevReason  to get leave reason.
   * @throws ParseException throws Parse Exception.
   * @throws IllegalArgumentException throws Parse Exception.
   * @return s
   */
  public final String applyForLeave(final int argsLevNoOfDays, final Date argsLevStartDate,
                                  final Date argsLevEndDate, final LevType argsLevType,
                                  final String argsLevReason, final int argsEmpId)throws IllegalArgumentException,
                                  ParseException {
    String s = null;
    SimpleDateFormat myFormat = new SimpleDateFormat("yyyy/MM/dd");
    String startDate = myFormat.format(argsLevStartDate);
    String endDate = myFormat.format(argsLevEndDate);
    int diffInDays = (int) ((argsLevEndDate.getTime() - argsLevStartDate.getTime()) / (1000 * 60 * 60 * 24));
    long epochstartDate = myFormat.parse(startDate).getTime() / 1000;
    long epochendDate = myFormat.parse(endDate).getTime() / 1000;
    if ((epochendDate - epochstartDate) < 0) {
      s = "Sorry, end date is before start date";
      throw new IllegalArgumentException("Sorry, end date is before start date");
    }
    if (argsLevNoOfDays <=  0) {
      s = "Number of Days cannot be negative or zero";
      throw new IllegalArgumentException("Number of Days cannot be negative or zero");
    }
    if ((diffInDays + 1) < argsLevNoOfDays) {
      s = "Sorry, days cannot be more than the limit";
      throw new IllegalArgumentException("Sorry, days cannot be more than the limit");
    }
    empLeaveBalance =  empLeaveBalance - argsLevNoOfDays;
    if (empLeaveBalance < 0) {
      s = "Leave balance not sufficient";
      throw new IllegalArgumentException("Leave balance not sufficient");
    } else {
      System.out.println("Updated Leave balance " + empLeaveBalance);
      Date argsLevAppliedDate = new Date();
      LevStatus lv;
      if (empManagerId == 0) {
        lv = LevStatus.APPROVED;
        s = "Your Leave is approved";
      } else {
        lv = LevStatus.PENDING;
        s = "Your Leave is Pending";
      }
      Leavehistory.dao().insert(argsLevNoOfDays, argsLevStartDate, argsLevEndDate, argsLevAppliedDate,
                                argsLevType, lv, argsLevReason, argsEmpId);
      dao().updateLeaveBalance(empLeaveBalance, empId);
    }
    return s;
  }
}
