package com.hexaware.cms.factory;

import com.hexaware.cms.persistence.CustomerDAO;
import com.hexaware.cms.persistence.DbConnection;
import java.util.List;
import com.hexaware.cms.model.Customer;

/**
 * CustomerFactory class used to fetch menu data from database.
 * @author hexware
 */
public class CustomerFactory {
  /**
   *  Protected constructor.
   */
  protected CustomerFactory() {

  }
  /**
   * Call the data base connection.
   * @return the connection object.
   */
  private static CustomerDAO dao() {
    DbConnection db = new DbConnection();
    return db.getConnect().onDemand(CustomerDAO.class);
  }
  /**
   * Call the data base connection.
   * @return the array of menu object.
   * @param cusId to initialize customer Id.
   */
  public static Customer showCustomer(final int cusId) {
    Customer customer = dao().show(cusId);
    return customer;
  }

  /**
   * Call the data base connection.
   * @return the array of menu object.
   * @param cusId to initialize customer Id.
   */
  public static Customer findCustomerByUserName(final String username) {
    Customer customer = dao().showCustomer(username);
    return customer;
  }
  /**
   * Call the data base connection.
   * @return the customerId.
   * @param cusId to initialize customer Id.
   * @param password to initialize customer password.
   */
  public static int validateCustomer(final String user, final String password) {
    int count = dao().authenticate(user, password);
    return count;
  }
}