package com.hexaware.FTP113.integration.test;

import java.util.Arrays;
import java.util.Date;
import java.util.List;
import java.util.Set;
import java.util.HashSet;
import java.net.URISyntaxException;
import java.text.SimpleDateFormat;
import java.text.ParseException;
import org.junit.Test;
import static org.junit.Assert.*;

import com.jayway.restassured.http.ContentType;
import com.jayway.restassured.path.json.JsonPath;
import static com.jayway.restassured.RestAssured.given;


public class LeaveDetailsRestTest {

    @Test 
    public void testLeaveHistory() throws AssertionError, URISyntaxException,ParseException { 
              
     SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        
          final String s1 = "2019-03-04";
    final Date s = sdf.parse(s1);
    final String s2 = "2019-03-05";
    final Date e = sdf.parse(s2);
    final String s3 = "2019-02-05";
    final Date l = sdf.parse(s3);
           LeaveDetails[] res = given().accept(ContentType.JSON).when()
				.get(CommonUtil.getURI("/api/leaveDetails/leaveHistory/1000")).getBody().as(LeaveDetails[].class);
           LeaveDetails l2 = new LeaveDetails(1, 1000, 2, s, e, LeaveType.EL, LeaveStatus.PENDING, "sick", l, "null");
           assertEquals(res[0].getLeaId(), l2.getLeaId());
    }

     @Test
	public void testPendingLeaves() throws AssertionError, URISyntaxException,ParseException { 
              
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        
          final String s1 = "2019-02-26";
    final Date s = sdf.parse(s1);
    final String s2 = "2019-02-26";
    final Date e = sdf.parse(s2);
    final String s3 = "2019-02-25";
    final Date l = sdf.parse(s3);
           LeaveDetails[] res = given().accept(ContentType.JSON).when()
				.get(CommonUtil.getURI("/api/leaveDetails/listPending/1000")).getBody().as(LeaveDetails[].class);
           LeaveDetails l2 = new LeaveDetails(34, 2000, 1, s, e, LeaveType.EL, LeaveStatus.PENDING, "home", l, "null");
           assertEquals(res[0].getLeaId(), l2.getLeaId());
    }

    @Test
	public void testLeaveDetailsById() throws AssertionError, URISyntaxException,ParseException { 
        LeaveDetails res = given().accept(ContentType.JSON).when()
				.get(CommonUtil.getURI("/api/leaveDetails/1")).getBody().as(LeaveDetails.class);
        
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        
          final String s1 = "2019-03-04";
    final Date s = sdf.parse(s1);
    final String s2 = "2019-03-05";
    final Date e = sdf.parse(s2);
    final String s3 = "2019-02-05";
    final Date l = sdf.parse(s3);

    LeaveDetails l1 = new LeaveDetails(1, 1000, 2, s, e, LeaveType.EL, LeaveStatus.PENDING, "sick", l, null);
    assertEquals(l1.getLeaId(), res.getLeaId());
     assertEquals(l1.getLeaEmpId(), res.getLeaEmpId());
      assertEquals(l1.getLeaNumberOfDays(), res.getLeaNumberOfDays());
         assertEquals(l1.getLeaLeaveType(), res.getLeaLeaveType());
          assertEquals(l1.getLeaStatus(), res.getLeaStatus());
           assertEquals(l1.getLeaReason(), res.getLeaReason());
             assertEquals(l1.getLeaManagerComment(), res.getLeaManagerComment());

    LeaveDetails res1 = given().accept(ContentType.JSON).when()
				.get(CommonUtil.getURI("/api/leaveDetails/2")).getBody().as(LeaveDetails.class);

    SimpleDateFormat sdf1 = new SimpleDateFormat("yyyy-MM-dd");
    final String s4 = "2019-08-12";
    final Date s11 = sdf1.parse(s4);
    final String s5 = "2019-08-13";
    final Date e11 = sdf1.parse(s5);
    final String s6 = "2019-02-05";
    final Date l11 = sdf1.parse(s6);
        
    LeaveDetails l2 = new LeaveDetails(2, 4000, 2, s11, e11, LeaveType.EL, LeaveStatus.APPROVED, "sick", l11, "BYE");
    assertEquals(l2.getLeaId(), res1.getLeaId());
     assertEquals(l2.getLeaEmpId(), res1.getLeaEmpId());
      assertEquals(l2.getLeaNumberOfDays(), res1.getLeaNumberOfDays());
         assertEquals(l2.getLeaLeaveType(), res1.getLeaLeaveType());
          assertEquals(l2.getLeaStatus(), res1.getLeaStatus());
           assertEquals(l2.getLeaReason(), res1.getLeaReason());
             assertEquals(l2.getLeaManagerComment(), res1.getLeaManagerComment());


    }
}