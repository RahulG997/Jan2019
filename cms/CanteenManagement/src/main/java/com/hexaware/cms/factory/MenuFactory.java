package com.hexaware.cms.factory;

import com.hexaware.cms.persistence.MenuDAO;
import com.hexaware.cms.persistence.DbConnection;
import java.util.List;
import com.hexaware.cms.model.Menu;

/**
 * MenuFactory class used to fetch menu data from database.
 * @author hexware
 */
public class MenuFactory {
    /**
     *  Protected constructor.
     */
    protected MenuFactory() {
  
    }
    /**
     * Call the data base connection.
     * @return the connection object.
     */
    private static MenuDAO dao() {
      DbConnection db = new DbConnection();
      return db.getConnect().onDemand(MenuDAO.class);
    }

      /**
   * Call the data base connection.
   * @return the array of menu object.
   */
  public static List<Menu> showMenu() {
    List<Menu> menu = dao().show();
    return menu;
  }

}  