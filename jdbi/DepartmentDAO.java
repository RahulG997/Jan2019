package com.hexaware.ftp114.persistence;
import com.hexaware.ftp114.model.Department;
import org.skife.jdbi.v2.sqlobject.Bind;
import org.skife.jdbi.v2.sqlobject.SqlQuery;
import org.skife.jdbi.v2.sqlobject.SqlUpdate;
import org.skife.jdbi.v2.sqlobject.customizers.Mapper;
import java.util.List;

public interface DepartmentDAO  {

  @SqlQuery("SELECT * FROM DEPT")
  @Mapper(DepartmentMapper.class)
  List<Department> list();
  
  /**
   * delete the record of the selected department.
   * @param deptID the id of the department
   * @return deletes the dept object
   */
  @SqlUpdate("DELETE FROM DEPT WHERE DEPTNO = :deptno")
  void finddel(@Bind("deptno") int deptno);

  /**
  * close with no args is used to close the connection.
  */
  
  @SqlUpdate("INSERT INTO DEPT(DEPTNO, DNAME, LOC)" +
   "VALUES(:deptno, :dname, :loc) ")
  void insert(@Bind("deptno") int deptno,
        @Bind("dname") String dname,
        @Bind("loc") String loc);
		
  @SqlUpdate("UPDATE DEPT SET DNAME=:dname,LOC=:loc WHERE DEPTNO = :deptno")
  void updateNameloc(@Bind("deptno") int deptno,
        @Bind("dname") String dname,
        @Bind("loc") String loc);
		
  @SqlUpdate("UPDATE DEPT SET DNAME=:dname WHERE DEPTNO = :deptno")
  void updateName(@Bind("deptno") int deptno,
        @Bind("dname") String dname);
		
  @SqlUpdate("UPDATE DEPT SET DNAME=:dname,LOC=:loc WHERE DEPTNO = :deptno")
  void updateLoc(@Bind("deptno") int deptno,
        @Bind("loc") String loc);		
		
		
		
		
        
  void close();
}