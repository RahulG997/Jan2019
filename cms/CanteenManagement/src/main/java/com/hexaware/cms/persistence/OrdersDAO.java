package com.hexaware.cms.persistence;
import org.skife.jdbi.v2.sqlobject.SqlQuery;
import org.skife.jdbi.v2.sqlobject.SqlUpdate;

import org.skife.jdbi.v2.sqlobject.customizers.Mapper;
import java.util.List;
import org.skife.jdbi.v2.sqlobject.Bind;
import org.skife.jdbi.v2.sqlobject.BindBean;
import com.hexaware.cms.persistence.OrderMapper;
import com.hexaware.cms.model.Orders;
import com.hexaware.cms.model.OrderStatus;
import org.skife.jdbi.v2.sqlobject.GetGeneratedKeys;

/**
 * OrdersDAO class used to fetch data from data base.
 * @author hexware
 */
public interface OrdersDAO {
    /**
     * @return the all the Orders pending record.
     * @param vendorId to initialize vendor id.
     */

  @SqlQuery("SELECT  CUS_ID, VEN_ID, ORD_ID, ORD_QUANTITY, WAL_SOURCE, MEN_ID, " 
  + " ORD_QUANTITY, ORD_BILLAMOUNT, ORD_COMMENTS, ORD_STATUS, ORD_BILLAMOUNT,ORD_DATE " 
  +  "  FROM orders WHERE VEN_ID=:vendorId AND ORD_STATUS='PENDING'")
    @Mapper(OrderMapper.class)
    List<Orders> pendingOrders(@Bind("vendorId")int vendorId);

    /**
     * @return the all the Customers Order record.
     * @param customerId to initialize vendor id.
     */
  @SqlQuery("SELECT  CUS_ID, VEN_ID, ORD_ID, ORD_QUANTITY, WAL_SOURCE, MEN_ID, " 
  + " ORD_QUANTITY, ORD_BILLAMOUNT, ORD_COMMENTS, ORD_STATUS, ORD_BILLAMOUNT,ORD_DATE " 
  +  "  FROM orders WHERE CUS_ID=:customerId")
    @Mapper(OrderMapper.class)
    List<Orders> customerOrders(@Bind("customerId")int customerId);

    /**
     * @return the all the Vendors Order record.
     * @param vendorId to initialize vendor id.
     */
    @SqlQuery("SELECT  CUS_ID, VEN_ID, ORD_ID, ORD_QUANTITY, WAL_SOURCE, MEN_ID, " 
    + " ORD_QUANTITY, ORD_BILLAMOUNT, ORD_COMMENTS, ORD_STATUS, ORD_BILLAMOUNT,ORD_DATE " 
    +  "  FROM orders WHERE VEN_ID=:vendorId")
      @Mapper(OrderMapper.class)
      List<Orders> vendorOrders(@Bind("vendorId")int vendorId); 
/**
     *@param order to initialize order.
     *@return the showPrice.
     */

    @SqlUpdate("INSERT INTO orders(CUS_ID,VEN_ID,WAL_SOURCE,MEN_ID,ORD_DATE,ORD_QUANTITY,ORD_BILLAMOUNT,"
    + "ORD_STATUS,ORD_COMMENTS) values(:cusId,:venId,:walSource,:menId,:ordDate,"
    + ":ordQty,:ordBillAmount,:ordStatus,:ordComments);")
    int placeOrder(@BindBean Orders order);

}






