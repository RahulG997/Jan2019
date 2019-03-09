package com.hexaware.ftp113.util;

import javax.ws.rs.GET;
import javax.ws.rs.NotFoundException;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.Consumes;
import javax.ws.rs.POST;

import com.hexaware.ftp113.model.Employee;

@Path("/employees")
public class EmpRest {

    @GET
    @Produces(MediaType.APPLICATION_JSON)
    public final Employee[] employeesList() {
      System.out.println("Employees List");
      final Employee[] employees = Employee.listAll();
      return employees;
    }
  
    /**
     * Returns a specific employee's details.
     * @param id the id of the employee
     * @return the employee details
     */
    @GET
    @Path("{id}")
    @Produces(MediaType.APPLICATION_JSON)
    public final Employee employeeListById(@PathParam("id") final int id) {
      final Employee empl = Employee.listById(id);
      if (empl == null) {
        throw new NotFoundException("No such Employee ID: " + id);
      }
      return empl;
    }

	@POST
  @Path("/employInsert")
  @Consumes(MediaType.APPLICATION_JSON)
  @Produces(MediaType.APPLICATION_JSON)
  public String insertEmploy(final Employee e) {
    String s = Employee.insertEmp(e);
    System.out.println(s);
    return s;
  }
}