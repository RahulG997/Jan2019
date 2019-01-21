Create Table Emp
(
    Empno int AUTO_INCREMENT,
    Name varchar(50), 
    Dept varchar(30),
    Desig varchar(30),
    Basic INT,
    primary key(Empno)
)
;


Insert into Emp(Name,Dept,Desig,Basic) values
('kiran kumar kailasam','java','developer',42233),
('Vishnu Vardhan Reddy','dotnet','programmer',42133),
('Ram Kishan','java','developer',82233),
('Kareem','dotnet','programmer',52234),
('Sheik Sulthan Mohammad','dotnet','developer',42555)

select * from emp
select empno, name, dept, desig, basic from emp where name = substring(name,1,'')
select left(name, INSTR(name, ' ')) from emp

SELECT LEFT(Name, LEFT( ' ',Name ) - 1) AS FirstName
FROM EMP


select name from Emp where instr(Name,' ')=0

select name from Emp where instr(Name,' ')=2



SELECT name from emp where length(name)-length(replace(name,' ',''))=0
SELECT name from emp where length(name)-length(replace(name,' ',''))=1
SELECT name from emp where length(name)-length(replace(name,' ',''))=2

SELECT name from emp where left(length(name)-length(replace(name,' ',''))=0,1)=left(length(name)-length(replace(name,' ',''))=1,1)

SELECT name from emp where left(length(name)-length(replace(name,' ',''))=0,1)=left(length(name)-length(replace(name,' ',''))=1,1)=left(length(name)-length(replace(name,' ',''))=2,1)

select name from emp
