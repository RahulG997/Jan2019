package com.hexaware.ftp.persistence;
import com.hexaware.ftp.model.Employee;
import org.skife.jdbi.v2.sqlobject.Bind;
import org.skife.jdbi.v2.sqlobject.SqlQuery;
import org.skife.jdbi.v2.sqlobject.SqlUpdate;
import org.skife.jdbi.v2.sqlobject.customizers.Mapper;
import java.util.List;

public interface EmployeeDAO  {

  @SqlQuery("SELECT * FROM EMP")
  @Mapper(EmployeeMapper.class)
  List<Employee> list();
}