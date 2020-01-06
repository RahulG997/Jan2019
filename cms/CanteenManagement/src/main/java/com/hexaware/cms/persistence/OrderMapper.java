package com.hexaware.cms.persistence;

import java.sql.ResultSet;
import java.sql.SQLException;
import com.hexaware.cms.model.OrderStatus;

import com.hexaware.cms.model.Orders;

import org.skife.jdbi.v2.tweak.ResultSetMapper;
import org.skife.jdbi.v2.StatementContext;
/**
 * WalletMapper class used to fetch Wallet data from database.
 * @author hexware
 */
public class OrderMapper implements ResultSetMapper<Orders> {
    /**
     * @param idx the index
     * @param rs the resultset
     * @param ctx the context
     * @return the mapped customer object
     * @throws SQLException in case there is an error in fetching data from the resultset
     */
  public final Orders map(final int idx, final ResultSet rs, final StatementContext ctx) throws SQLException {
      /**
       * @return Wallet
       */
      String src = rs.getString("ORD_STATUS");
      OrderStatus ordStatus = OrderStatus.valueOf(src);
  
      return new Orders(rs.getInt("CUS_ID"), rs.getInt("VEN_ID"), rs.getInt("ORD_ID"), 
      rs.getString("WAL_SOURCE"), rs.getInt("MEN_ID"), rs.getInt("ORD_QUANTITY"), 
        rs.getString("ORD_COMMENTS"), ordStatus, rs.getDouble("ORD_BILLAMOUNT"),
        rs.getDate("ORD_DATE") );
  //  return new Orders(rs.getInt("cus"), rs.getDouble("wal_amount"),ws);
  }
}

