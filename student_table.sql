use sqlday3


select
a.agentid,firstname,lastname,city,ssn,
p.policyid,appnumber,modelpremium,annualpremium,
issplitagent
from agent a inner join agentpolicy ap
on a.agentid=ap.agentpolicy


select * from agentpolicy

select * from dept cross join emp

select * from agent cross join agentpolicy 

select * from policy cross join agentpolicy  

desc emp

select empno,mgr
from emp order by mgr

select e1.empno,e2.empno,e1.name,e2.name
from empmgr e1 inner join empmgr e2
on e1.empno=e2.mgrno
order by e1.empno

select * from empmgr


select * from policy
select * from agentpolicy
select * from agent

select max(sal)
from emp
where sal<(select max(sal) from emp)


select max(sal)
from emp
where sal<(select max(sal)
from emp
where sal<(select max(sal) from emp))

select ename
from emp
where sal=(select max(sal)
from emp
where sal<(select max(sal) from emp)
)

select distinct sal from emp e1
where 5-1=(select distinct count(*) from emp e2 where e2.sal > e1.sal)

select * from dept
where deptno <> all(select deptno from emp)

select * from agent
where agentid <> all(select agentid from agentpolicy)

select * from policy
where policyid <> all(select policyid from agentpolicy)


select * from emp

select sum(sal),job, min(sal),max(sal),avg(sal)
from emp 
group by job
having sum(sal)>5000 

select mgr,
case 
when mgr is null then 'no manager'
else mgr
end mnu
from emp

select * from emp
where (year(curdate())-(year(hiredate)))>35


select count(comm) from emp

select * ,adddate(hiredate,interval 58 year)
from emp


create table employ
(
empno int,
name varchar(30),
dob date,
gender varchar(10),
salary double
)

insert into employ values(1,'bhuvi','1997-03-24','female',66778),
(2,'jai','1997-06-14','male',66798),
(3,'hari','1998-03-21','male',66779),
(4,'maddy','1997-07-23','male',66770),
(5,'karthi','1997-09-2','male',66773)

create table student
(
sno int,
name varchar(30),
sub1 int,
sub2 int,
sub3 int,
total int,
avg double
)
insert into student(sno,name,sub1,sub2,sub3)
values(1,'bhuvi',56,57,88),
(2,'hari',55,66,85),
(1,'apu',96,88,98)

select * from student


drop table employ

create table employ
(
empno int,
name varchar(30) not null,
dob date,
gender enum('male','female'),
salary double,
constraint pk_employ_empno primary key(empno)
);

(1,'bhuvi','1997-03-24','female',66778),
(2,'jai','1997-06-14','male',66798),
(3,'hari','1998-03-21','male',66779),
(4,'maddy','1997-07-23','male',66770),
(5,'karthi','1997-09-2','male',66773)


drop table emp

drop table employ

drop table dept

create table dept(
deptno int,
dname varchar(14),
loc varchar(13),
constraint pk_dept_deptno primary key(deptno)
);

create table emp(
empno int,
ename varchar(10),
job varchar(9),
mrg int,
hiredate date,
sal int,
comm int,
deptno int,
constraint pk_emp_empno primary key(empno),
constraint pk_emp_deptno foreign key(deptno)
references dept(deptno)
);

insert into dept
values(10, 'ACCOUNTING', 'NEW YORK');
insert into dept
values(20, 'RESEARCH', 'DALLAS');
insert into dept
values(30, 'SALES', 'CHICAGO');
insert into dept
values(40, 'OPERATIONS', 'BOSTON');

insert into emp
values(
 7839, 'KING', 'PRESIDENT', null,
 '1981-11-17',
 5000, null, 10
);
insert into emp
values(
 7698, 'BLAKE', 'MANAGER', 7839,
 '1981-1-5',
 2850, null, 30
);
insert into emp
values(
 7782, 'CLARK', 'MANAGER', 7839,
 '1981-9-6',
 2450, null, 10
);
insert into emp
values(
 7566, 'JONES', 'MANAGER', 7839,
 '1981-2-4',
 2975, null, 20
);
insert into emp
values(
 7788, 'SCOTT', 'ANALYST', 7566,
 '1987-08-12',
 3000, null, 20
);
insert into emp
values(
 7902, 'FORD', 'ANALYST', 7566,
 '1981-3-12',
 3000, null, 20
);
insert into emp
values(
 7369, 'SMITH', 'CLERK', 7902,
 '1980-12-17',
 800, null, 20
);
insert into emp
values(
 7499, 'ALLEN', 'SALESMAN', 7698,
 '1981-02-20',
 1600, 300, 30
);
insert into emp
values(
 7521, 'WARD', 'SALESMAN', 7698,
 '1981-2-22',
 1250, 500, 50
);
insert into emp
values(
 7654, 'MARTIN', 'SALESMAN', 7698,
 '1981-8-29',
 1250, 1400, 30
);
insert into emp
values(
 7844, 'TURNER', 'SALESMAN', 7698,
 '1981-8-9',
 1500, 0, 30
);
insert into emp
values(
 7876, 'ADAMS', 'CLERK', 7788,
 '1987-07-09',
 1100, null, 20
);
insert into emp
values(
 7900, 'JAMES', 'CLERK', 7698,
 '1981-3-12',
 950, null, 30
);
insert into emp
values(
 7934, 'MILLER', 'CLERK', 7782,
 '1982-2-15',
 1300, null, 10
);

select * from dept

select * from emp

insert into emp
values(
 75251, 'WARD', 'SALESMAN', 7698,
 '1981-2-22',
 1250, 500, 50
 );

create table payroll
(
empno int,
name varchar(30),
gender varchar(30),
saldate date,
status enum('0','1'),
constraint pk_payroll primary key(empno,saldate)
)