package com.hexaware.cms.factory;

//import com.hexaware.cms.persistence.OrdersDAO;
import com.hexaware.cms.persistence.DbConnection;
import java.util.List;
import com.hexaware.cms.model.Orders;
import com.hexaware.cms.persistence.OrdersDAO;
import com.hexaware.cms.model.OrderStatus;


/**
 * OrderFactory class used to fetch Orders data from database.
 * @author hexware
 */
public class OrdersFactory {
  /**
   *  Protected constructor.
   */
  protected OrdersFactory() {

  }
  /**
   * Call the data base connection.
   * @return the connection object.
   */
  private static OrdersDAO dao() {
    DbConnection db = new DbConnection();
    return db.getConnect().onDemand(OrdersDAO.class);
  }
  /**
   * Call the data base connection.
   * @return the array of Orders object.
   * @param vendorId to initialize customer Id.
   */
  public static List<Orders> showPendingOrders(final int vendorId) {
    List<Orders> orders = dao().pendingOrders(vendorId);
    return orders;
  }

 /**
   * Call the data base connection.
   * @return the array of Orders object.
   * @param customerId to initialize customer Id.
   */
  public static List<Orders> showCustomerHistory(final int customerId) {
    List<Orders> orders = dao().customerOrders(customerId);
    return orders;
  }

 /**
   * Call the data base connection.
   * @return the array of Orders object.
   * @param vendorId to initialize customer Id.
   */
  public static List<Orders> showVendorHistory(final int vendorId) {
    List<Orders> orders = dao().vendorOrders(vendorId);
    return orders;
  }

   /**
   * Call the data base connection.
   * @param order to initialize oder object.
   * @return the result.
   */
  public static String setPlaceOrder(final Orders order) {
    
    int result = dao().placeOrder(order);
    return result;
  }
}