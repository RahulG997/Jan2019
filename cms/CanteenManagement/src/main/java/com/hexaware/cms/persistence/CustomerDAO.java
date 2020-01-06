package com.hexaware.cms.persistence;
import org.skife.jdbi.v2.sqlobject.SqlQuery;
import org.skife.jdbi.v2.sqlobject.customizers.Mapper;
import java.util.List;
import com.hexaware.cms.model.Customer;
import org.skife.jdbi.v2.sqlobject.Bind;
/**
 * CustomerDAO class used to fetch data from data base.
 * @author hexware
 */
public interface CustomerDAO {

    /**
     * @return the all the Customer record.
     * @param cusId to initializing customer Id.
     */
  @SqlQuery("select C.CUS_ID, C.CUS_NAME,C.CUS_PHN_NO, C.CUS_USERNAME, CUS_PASSWORD, CUS_EMAIL "
  + " FROM CUSTOMER C where C.CUS_USERNAME = :username;")
    @Mapper(CustomerMapper.class)
    Customer showCustomer(@Bind("username")String username);
    /**
     * @return the all the Customer record.
     * @param cusId to initializing customer Id.
     */
  @SqlQuery("select C.CUS_ID, C.CUS_NAME,C.CUS_PHN_NO, C.CUS_USERNAME, CUS_PASSWORD, CUS_EMAIL "
  + "FROM CUSTOMER C where C.cus_id = :cusId;")
    @Mapper(CustomerMapper.class)
    Customer show(@Bind("cusId")int cusId);
    /**
     * @return the all the cus_id.
     * @param cusId to initializing customer Id.
     * @param password to initializing password.
     */
  @SqlQuery("select count(*) from customer where CUS_USERNAME = :username and CUS_PASSWORD = :password;")
    int authenticate(@Bind("username") String username, @Bind("password")String password);
    /**
     * @return the all the cus_id.
     * @param cusId to initializing customer Id.
     */
  @SqlQuery("select count(*) from customer where cus_id = :cusId;")
    int fetchCusId(@Bind("cusId")int cusId);
}


