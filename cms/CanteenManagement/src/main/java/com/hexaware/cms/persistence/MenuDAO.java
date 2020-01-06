package com.hexaware.cms.persistence;
import org.skife.jdbi.v2.sqlobject.SqlQuery;
import org.skife.jdbi.v2.sqlobject.customizers.Mapper;
import java.util.List;
import com.hexaware.cms.model.Menu;
import org.skife.jdbi.v2.sqlobject.SqlUpdate;
//import com.hexaware.FTP112.model.MenuDetails;

import org.skife.jdbi.v2.sqlobject.Bind;
/**
 * MenuDAO class used to fetch data from data base.
 * @author hexware
 */
public interface MenuDAO {
    /**
     * @return the all the Menu record.
     */
    @SqlQuery("SELECT M.MEN_ID,M.MEN_ITEM,M.MEN_CALORIES,M.MEN_PRICE,"
    + " M.MEN_SPECIALITY FROM MENU M ORDER BY M.Men_ID;")
    @Mapper(MenuMapper.class)
    List<Menu> show();

    /**
     * @return Menu record for MenuId.
     */
    @SqlQuery("SELECT M.MEN_ID,M.MEN_ITEM,M.MEN_CALORIES,M.MEN_PRICE,"
    + " M.MEN_SPECIALITY FROM MENU M WHERE M.MEN_ID=:menuId;")
    @Mapper(MenuMapper.class)
    List<Menu> showByMenuId(@Bind("menuId")int menuId);

}