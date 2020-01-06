package com.hexaware.cms.persistence;

import java.sql.ResultSet;
import java.sql.SQLException;
import com.hexaware.cms.model.WalletSource;

import com.hexaware.cms.model.Wallet;

import org.skife.jdbi.v2.tweak.ResultSetMapper;
import org.skife.jdbi.v2.StatementContext;
/**
 * WalletMapper class used to fetch Wallet data from database.
 * @author hexware
 */
public class WalletMapper implements ResultSetMapper<Wallet> {
    /**
     * @param idx the index
     * @param rs the resultset
     * @param ctx the context
     * @return the mapped customer object
     * @throws SQLException in case there is an error in fetching data from the resultset
     */
  public final Wallet map(final int idx, final ResultSet rs, final StatementContext ctx) throws SQLException {
      /**
       * @return Wallet
       */
      String src = rs.getString("WAL_SOURCE");
      WalletSource ws = WalletSource.valueOf(src);
  
    return new Wallet(rs.getInt("wal_id"), rs.getDouble("wal_amount"),ws);
  }
}

