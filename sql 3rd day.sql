SELECT * FROM EMP WHERE 
LEFT(NAME,1) = LEFT(right(Name,Length(Name)-Instr(Name,' ')),1) AND 
LEFT(NAME,1) = LEFT(REVERSE(LEFT(REVERSE(NAME),INSTR(REVERSE(NAME),' ')-1)),1)  AND INSTR(NAME,' ') !=0

Select
Name from
(select 
Name,
Length(Name)-Length(Replace(Name,' ','')) sp
from emp) Ed
where Ed.sp=2



SELECT * FROM EMP WHERE 
LEFT(NAME,1)=SUBSTRING(NAME,INSTR(NAME,' ')+1,1) 
FROM eMP



left(Reverse(name),8)

SELECT SUBSTRING(NAME,INSTR(NAME,' ')+1,1) FROM eMP

USE SQLPRACTICE
SELECT * FROM EMP WHERE 
LEFT(NAME,1) = LEFT(right(Name,Length(Name)-Instr(Name,' ')),1)= AND INSTR(NAME,' ') !=0


SELECT NAME,REVERSE(LEFT(REVERSE(NAME),INSTR(REVERSE(NAME),' ')-1)) FROM EMP

SELECT  NAME,INSTR(REVERSE(NAME),' ') FROM EMP

SELECT NAME, LEFT(REVERSE(LEFT(REVERSE(NAME),INSTR(REVERSE(NAME),' ')-1)),1) FROM EMP


select dob,floor(datediff(curdate(),dob)/365.25) as "years",floor( (datediff(curdate(),dob)/365.25-floor(datediff(curdate(),dob)/365.25))*12 ) as "Months",
floor (((datediff(curdate(),dob)/365.25-floor(datediff(curdate(),dob)/365.25))*12 - floor( (datediff(curdate(),dob)/365.25-floor(datediff(curdate(),dob)/365.25))*12 ))*30.4375) as "Days"  from agent;

SELECT 
AD.AGENTID,AD.FIRSTNAME,AD.LASTNAME,
PD.POLICYID,PD.MODALPREMIUM,PD.ANNUALPREMIUM
FROM
(SELECT AGENTID,FIRSTNAME,LASTNAME,CITY,SSN FROM AGENT) AD,
(SELECT POLICYID,APPNUMBER,MODALPREMIUM,ANNUALPREMIUM FROM POLICY) PD