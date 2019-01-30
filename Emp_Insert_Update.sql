use sqlpractice


insert into emp(name,dept,desig,Basic)
 values('bhaskar','java',
'programmer',58334),
('pavan','git','expert',56211),
('sanjana','sql','programmer',56222),
('sahil','sql','expert',99999),
('nikita','agile','master',98444),
('megha','git','expert',81455),
('priyanka','java','programmer',62112),
('krishna','SAP','Programmer',66222)

select * from emp


1)Sum:Used to generate sum on specified numeric column
select sum(BAsic) from emp

2) Avg:Used to generate average on specified numeric column
select avg(BAsic) from emp

3)Max: Displays MAx val
select Max(BAsic) from emp

4)Min:
select min(BAsic) from emp

5)Count(*):Displays total number of records
Select count(*) from emp 

6)GroupBy: used to generate aggregate reports.

Select f1,f2,AggF
From Table_Name Group by F1,F2

fields we specify inSELECT must be followed after GROUP BY Clause

select Dept,SUM(Basic) "TOTAL SAL"
FROM EMP
GROUP BY DEPT

sELECT DEPT,COUNT(*) "EMPCOUNT"
FROM EMP
GROUP BY DEPT

SELECT DEPT, MAX(baSIC) "maXsal"
FROM EMP
GROUP BY DEPT

SELECT DEPT, MIN(baSIC) "maXsal"
FROM EMP
GROUP BY DEPT

SELECT DEPT, AVG(baSIC) ,MAX(BASIC), MIN(BASIC), COUNT(*), SUM(BASIC)
FROM EMP
GROUP BY DEPT

SELECT DEPT, AVG(baSIC) ,MAX(BASIC), MIN(BASIC), COUNT(*), SUM(BASIC)
FROM EMP
GROUP BY DEPT
HAVING COUNT(*) >= 2

SELECT DEPT, AVG(baSIC) ,MAX(BASIC), MIN(BASIC), COUNT(*), SUM(BASIC)
FROM EMP
GROUP BY DEPT
HAVING COUNT(*) >= 2
ORDER BY DEPT DESC

SELECT DEPT, AVG(baSIC) ,MAX(BASIC), MIN(BASIC), COUNT(*), SUM(BASIC)
FROM EMP
WHERE DEPT IN('JAVA','SQL')
GROUP BY DEPT
HAVING COUNT(*) >= 2
ORDER BY DEPT

USE SQLPRACTICE

7)  ORDER BY- IT SORTS




