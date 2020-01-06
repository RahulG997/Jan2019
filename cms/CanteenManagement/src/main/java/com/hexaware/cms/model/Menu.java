package com.hexaware.cms.model;

/**
 * Menu class used to display menu information.
 * @author hexaware
 */
public class Menu {

    private int menuId;
    private String menItem;
    private double menCalories;
    private double menuPrice;
    private String menuSpeciality;

    public final int getMenuId() {
		return menuId;
	}
	public final void setMenuId(final int argMenId) {
		this.menuId = argMenId;
	}
	public final String getMenItem() {
		return menItem;
	}
	public final void setMenItem(final String argMenItem) {
		this.menItem = argMenItem;
	}
	public final double getMenCalories() {
		return menCalories;
	}
	public final void setMenCalories(final double argMenCalories) {
		this.menCalories = argMenCalories;
	}
	public final double getMenuPrice() {
		return menuPrice;
	}
	public final void setMenuPrice(final double argMenuPrice) {
		this.menuPrice = argMenuPrice;
	}
	public final String getMenuSpeciality() {
		return menuSpeciality;
	}
	public final void setMenuSpeciality(final String argMenuSpeciality) {
		this.menuSpeciality = argMenuSpeciality;
	}
	
	
	public Menu() {
    }
/**
 * @param argMenuId to initialize menu id.
 * @param argMenItem to initialize menu item.
 * @param argMenPrice to initialize menu price.
 * @param argMenCalories to initialize calories.
 * @param argMenuSpeciality to initialize calories.
 * used to get details through constructor.
 */

    public Menu(final int argMenuId, final String argMenItem, final double argMenCalories, 
                                final double argMenPrice, final String argMenuSpeciality) {
		this.menuId = argMenuId;
		this.menItem = argMenItem;
		this.menCalories = argMenCalories;
		this.menuPrice = argMenPrice;
		this.menuSpeciality = argMenuSpeciality;
	}
    

}
