package com.hexaware.ftp04.model;

import com.hexaware.ftp04.persistence.DbConnection;
import com.hexaware.ftp04.persistence.LeavehistoryDAO;

import java.util.Objects;
import java.util.Date;
import java.util.List;

/**
 * Leave history class to store leave details.
 * @author hexware
 */
public class Leavehistory {
  /**
   * levId to store leave id.
   */
  private int levId;
  /**
   * levNoOfDays to store no of days.
   */
  private int levNoOfDays;
  /**
   * levStartDate to store leave start date.
   */
  private Date levStartDate;
  /**
   * levEndDate to store leave end date.
   */
  private Date levEndDate;
  /**
   * levAppliedDate to store leave applied date.
   */
  private Date levAppliedDate;
  /**
   * levType to store leave type.
   */
  private LevType levType;
  /**
   * levStatus to store leave status.
   */
  private LevStatus levStatus;
  /**
   * levReason to store leave reason.
   */
  private String levReason;
  /**
   * levManagerComment to store manager's comment.
   */
  private String levManagerComment;
  /**
   * empId to store employee's id.
   */
  private int empId;

  @Override
  public final boolean equals(final Object obj) {
    if (obj == null) {
      return false;
    }
    if (getClass() != obj.getClass()) {
      return false;
    }
    Leavehistory lev = (Leavehistory) obj;
    if (Objects.equals(levId, lev.levId) && Objects.equals(levNoOfDays, lev.levNoOfDays)
        && Objects.equals(levStartDate, lev.levStartDate) && Objects.equals(levEndDate, lev.levEndDate)
        && Objects.equals(levAppliedDate, lev.levAppliedDate) && Objects.equals(levType, lev.levType)
        && Objects.equals(levStatus, lev.levStatus) && Objects.equals(levReason, lev.levReason)
        && Objects.equals(levManagerComment, lev.levManagerComment)
        && Objects.equals(empId, lev.empId)) {
      return true;
    }
    return false;
  }

  @Override
  public final int hashCode() {
    return Objects.hash(levId, levNoOfDays, levStartDate, levEndDate,
                        levAppliedDate, levType, levStatus, levReason,
                        levManagerComment, empId);
  }
  @Override
  public final String toString() {
    return "leave id :" + levId + "  " + "number of days :" +  levNoOfDays + "  "
           + "start date :" + levStartDate + "  " + "end date :" + levEndDate + "  "
           + "apply date :" + levAppliedDate + "  " + "leave type :" +  levType + "  "
           + "leave status :" + levStatus + "  " + "leave reason :" + levReason + "  "
           + "manager comment :" + levManagerComment + "  " + "employee id :" + empId;
  }

  /**
   * Leavehistory to initialize leave history constructor.
   */
  public Leavehistory() {
  }

  /**
   * @param argLevId to initialize leave id.
   */
  public Leavehistory(final int argLevId) {
    this.levId = argLevId;
  }

  /**
   * @param argLevId to initialize leave id.
   * @param argLevNoOfDays to initialize number of days.
   * @param argLevStartDate to initialize start date.
   * @param argLevEndDate to initialize end date.
   * @param argLevAppliedDate to initialize applied date.
   * @param argLevType to initialize leave type.
   * @param argLevStatus to initialize leave status.
   * @param argLevReason to initialize leave reason.
   * @param argLevManagerComment to initialize manager's comment.
   * @param argEmpId to initialize employee's id.
   */
  public Leavehistory(final int argLevId, final int argLevNoOfDays, final Date argLevStartDate,
                      final Date argLevEndDate, final Date argLevAppliedDate, final LevType argLevType,
                      final LevStatus argLevStatus, final String argLevReason, final String argLevManagerComment,
                      final int argEmpId) {
    this.levId = argLevId;
    this.levNoOfDays = argLevNoOfDays;
    this.levStartDate = argLevStartDate;
    this.levEndDate = argLevEndDate;
    this.levAppliedDate = argLevAppliedDate;
    this.levType = argLevType;
    this.levStatus = argLevStatus;
    this.levReason = argLevReason;
    this.levManagerComment = argLevManagerComment;
    this.empId = argEmpId;
  }

   /**
   * Gets the leave id.
   * @return this Leave Id.
   */
  public final int getLevId() {
    return levId;
  }

  /**
   *
   * @param argLevId to set employee id.
   */
  public final void setLevId(final int argLevId) {
    this.levId = argLevId;
  }

  /**
   * Gets the number of days of leave.
   * @return this number of days of leave.
   */
  public final int getLevNoOfDays() {
    return levNoOfDays;
  }

  /**
   *
   * @param argLevNoOfDays to set number of days of leave.
   */
  public final void setLevNoOfDays(final int argLevNoOfDays) {
    this.levNoOfDays = argLevNoOfDays;
  }


  /**
   * Gets the start date.
   * @return this start date.
   */
  public final Date getLevStartDate() {
    return levStartDate;
  }

  /**
   *
   * @param argLevStartDate to set start date.
   */
  public final void setLevStartDate(final Date argLevStartDate) {
    this.levStartDate = argLevStartDate;
  }


  /**
   * Gets the end date.
   * @return this end date.
   */
  public final Date getLevEndDate() {
    return levEndDate;
  }

  /**
   *
   * @param argLevEndDate to set end date.
   */
  public final void setLevEndDate(final Date argLevEndDate) {
    this.levEndDate = argLevEndDate;
  }

  /**
   * Gets the applied date.
   * @return this applied date.
   */
  public final Date getLevAppliedDate() {
    return levAppliedDate;
  }

  /**
   *
   * @param argLevAppliedDate to set applied date.
   */
  public final void setLevAppliedDate(final Date argLevAppliedDate) {
    this.levAppliedDate = argLevAppliedDate;
  }
  /**
   * Gets the type of leave.
   * @return this type of leave.
   */
  public final LevType getLevType() {
    return levType;
  }

  /**
   *
   * @param argLevType to set type of leave.
   */
  public final void setLevType(final LevType argLevType) {
    this.levType = argLevType;
  }

  /**
   * Gets the status of leave.
   * @return this status of leave.
   */
  public final LevStatus getLevStatus() {
    return levStatus;
  }

  /**
   *
   * @param argLevStatus to set status of leave.
   */
  public final void setLevStatus(final LevStatus argLevStatus) {
    this.levStatus = argLevStatus;
  }
  /**
   * Gets the reason of leave.
   * @return this reason of leave.
   */
  public final String getLevReason() {
    return levReason;
  }

  /**
   *
   * @param argLevReason to set reason of leave.
   */
  public final void setLevReason(final String argLevReason) {
    this.levReason = argLevReason;
  }


  /**
   * Gets the manager comment.
   * @return this manager comment.
   */
  public final String getLevManagerComment() {
    return levManagerComment;
  }

  /**
   *
   * @param argLevManagerComment to set manager comment.
   */
  public final void setLevManagerComment(final String argLevManagerComment) {
    this.levManagerComment = argLevManagerComment;
  }

  /**
   * Gets the employee's id.
   * @return this employee id.
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
   * The dao for leave history.
   *@return dbconnection.
   */
  public static LeavehistoryDAO dao() {
    DbConnection db = new DbConnection();
    return db.getConnect().onDemand(LeavehistoryDAO.class);
  }
  /**
   * list employee leave details by id.
   * @param empID id to get employee leave details.
   * @return Leavehistory
   */
  public static Leavehistory listById(final int empID) {
    return dao().find(empID);
  }
  /**
   * list employee details by id.
   * @param empID id to get employee details.
   * @return Employee leave Details
   */
  public static Leavehistory[] listLeaveDetails(final int empID) {
    List<Leavehistory> ls = dao().list(empID);
    return ls.toArray(new Leavehistory[ls.size()]);
  }
  /**
   * update leave status.
   * @param levStatus id to update leave status.
   * @param levId to update leave Id.
   * @param levManagerComment to update Manager Comments.
   */
  public static void status(final LevStatus levStatus, final int levId, final String levManagerComment) {
    dao().update(levStatus, levId, levManagerComment);
  }

  /**
   * update number of days after status is changed to deny.
   * @param levId to update leave Id.
   */
  public static void increment(final int levId) {
    dao().increase(levId);
  }

  /**
   * update number of days after status changed to approved or pending.
   * @param levId to update leave Id.
   */
  public static void decrement(final int levId) {
    dao().decrease(levId);
  }

  /**
   * Method to switch leave status.
   * @param selectStatus to select option.
   * @param argslevId to leave Id.
   * @param argslevManagerComment to manager comment.
   * @return s to print the string.
   */
  public final String approveDeny(final LevStatus selectStatus, final int argslevId,
                                 final String argslevManagerComment) {
    String s = null;
    Leavehistory statusObj = new Leavehistory(argslevId);
    if (levStatus == LevStatus.PENDING && selectStatus == LevStatus.DENIED) {
      statusObj.status(LevStatus.DENIED, argslevId, argslevManagerComment);
      statusObj.increment(argslevId);
      s = "Leave is Denied for employee" + " " + empId;
    } else if (levStatus == LevStatus.PENDING && selectStatus == LevStatus.APPROVED) {
      statusObj.status(LevStatus.APPROVED, argslevId, argslevManagerComment);
      s = "Leave is Approved for employee" + " " + empId;
    } else if (levStatus == LevStatus.APPROVED && selectStatus == LevStatus.DENIED) {
      statusObj.status(LevStatus.DENIED, argslevId, argslevManagerComment);
      statusObj.increment(argslevId);
      s = "Leave is Denied for employee" + " " + empId;
    } else if (levStatus == LevStatus.APPROVED && selectStatus == LevStatus.PENDING) {
      statusObj.status(LevStatus.PENDING, argslevId, argslevManagerComment);
      s = "Leave is Pending for employee" + " " + empId;
    } else if (levStatus == LevStatus.DENIED && selectStatus == LevStatus.APPROVED) {
      statusObj.status(LevStatus.APPROVED, argslevId, argslevManagerComment);
      statusObj.decrement(argslevId);
      s = "Leave is Approved for employee" + " " + empId;
    } else if (levStatus == LevStatus.DENIED && selectStatus == LevStatus.PENDING) {
      statusObj.status(LevStatus.PENDING, argslevId, argslevManagerComment);
      statusObj.decrement(argslevId);
      s = "Leave is Pending for employee" + " " + empId;
    } else {
      s = "Enter correct choice";
    }
    return s;
  }

  /**
   * list leave details by id.
   * @param levId id to get employee details.
   * @return Employee
   */
  public static Leavehistory listByLevId(final int levId) {
    return dao().fetch(levId);
  }
  /**
   * list employee history by id.
   * @param empId id to get employee history.
   * @return employee array.
   */
  public static Leavehistory[] listPendingApplication(final int empId) {
    List<Leavehistory> l = dao().finds(empId);
    return l.toArray(new Leavehistory[l.size()]);
  }
}


