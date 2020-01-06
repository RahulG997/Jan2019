package com.hexaware.cms.model;

import java.util.Objects;
import java.util.Date;
import com.hexaware.cms.model.OrderStatus;

/**
 * Orders class used to display Orders information.
 * @author hexaware.
 */
public class Orders {
/**
 * orders to store order.
 */
  private int orderId;
  private int cusId;
  private int venId;
  private String walletSource;
  private int menuId;
  private Date orderDate;
  private int orderQuantity;
  private double orderBillAmount;
  private OrderStatus orderStatus;
  private String orderComments;
  /**
   * Default Constructor.
   */
  public Orders() {

  }
    /**
   * @param argCusId to initialize customer Id.
   * @param argVenId to initialize vendor Id.
   * @param argOrderBillAmount to initialize Total Order Price.
   * @param argWalId to initialize Wallet Id.
   * used to get details through constructor.
   */
  public Orders(final int argCusId, final int argVenId, final int argOrderId, 
                  final String argWalletSource, final int argMenuId,
                  final int argOrderQuantity,final String argComments,
                  final OrderStatus argOrderStatus, 
                  final double argOrderBillAmount,
                  final Date argOrderDate) {
    this.cusId = argCusId;
    this.venId = argVenId;
    this.orderId=argOrderId;
    this.orderQuantity=argOrderQuantity;
    this.orderComments=argComments;
    this.orderStatus=argOrderStatus;
    this.menuId=argMenuId;
    this.orderBillAmount = argOrderBillAmount;
    this.walletSource = argWalletSource;
    this.orderDate=argOrderDate;
  }

  /**
   * @param argOrderQuantity gets the Quantity Ordered.
   */
  public final void setOrderQuantity(final int argOrderQuantity) {
    this.orderQuantity=argOrderQuantity;
  }
  /**
     * @return this Menu Id.
     */
  public final int getOrderQuantity() {
    return this.orderQuantity;
  }
  /**
   * @param argMenuId gets the Menu Id.
   */
  public final void setMenuId(final int argMenuId) {
    this.menuId = argMenuId;
  }
  /**
     * @return this Menu Id.
     */
  public final int getMenuId() {
    return this.menuId;
  }
  
  /**
   * @param argCusId gets the customer Id.
   */
  public final void setCusId(final int argCusId) {
    this.cusId = argCusId;
  }
  /**
     * @return this customer Id.
     */
  public final int getCusId() {
    return this.cusId;
  }
      /**
     * @param argVenId gets the vendor Id.
     */
  public final void setVenId(final int argVenId) {
    this.venId = argVenId;
  }
 /**
     * @return this vendor Id.
     */
  public final int getVenId() {
    return this.venId;
  }
      /**
     * @param argTotalOrderPrice gets the order Price.
     */
  public final void setOrderBillAmount(final double argOrderBillAmount) {
    this.orderBillAmount = argOrderBillAmount;
  }
 /**
     * @return this order price.
     */
  public final double getOrderBillAmount() {
    return this.orderBillAmount;
  }
    /**
     * @param argOrderStatus gets the order comments.
     */
  public final void setOrderStatus(final OrderStatus argOrderStatus) {
    this.orderStatus = argOrderStatus;
  }
    /**
       * @return this order Comments.
       */
  public final OrderStatus getOrderStatus() {
    return this.orderStatus;
  }
/**
  * @param argOrderDate gets the order date.
  */
  public final void setOrderDate(final Date argOrderDate) {
    this.orderDate = argOrderDate;
  }
/**
  * @return this order Date.
  */
  public final Date getOrderDate() {
    return this.orderDate;
  }
/**
  * @param argOrderId gets the order Id.
  */
  public final void setOrderId(final int argOrderId) {
    this.orderId = argOrderId;
  }
/**
  * @return this order Id.
  */
  public final int getOrderId() {
    return this.orderId;
  }
/**
  * @param argOrderComments gets the order comments.
  */
  public final void setOrderComments(final String argOrderComments) {
    this.orderComments = argOrderComments;
  }
/**
  * @return this order Comments.
  */
  public final String getOrderComments() {
    return this.orderComments;
  }
/**
 * @param argWalId gets the wallet id.
 */
  public final void setWalletSource(final String argWalletSource) {
    this.walletSource = argWalletSource;
  }
/**
 * @return this order Comments.
 */
  public final String getWalletSource() {
    return this.walletSource;
  }

 
}
