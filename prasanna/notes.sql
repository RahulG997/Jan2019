select * from emp

create table emptest
(
  empno int constraint cnt1 primary key,
  nam varchar(15) not null,
  dept varchar(15)
  constraint cnt3 check(dept in('sql','java','dotnet')),
  desig varchar(15)
  constraint cnt4 check(desig in('junior','senior','head')),
  basic float
  constraint cnt5 check(basic between 1000 and 50000)
)

insert emptest values(1,'sunitha','sql','senior',19545)

select * from emptest

sp_help emptest

drop table emptest

drop table emp

create table emp
(
   empno int primary key,
   nam varchar(15),
   dept varchar(15),
   desig varchar(15),
   basic float
)


create table leave
(
   empno int references emp(empno) on delete cascade,
   lavail int,ltaken int, lop int
)

insert into emp values(1,'sriharsha','sql','programmer',14432)
insert emp values(2,'kiran','sql','developer',16744)
insert emp values(3,'smitha','dotnet','developer',19553)
insert emp values(4,'amar','java','programmer',37443)
insert emp values(5,'noor','dotnet','teamlead',19563)

select * from emp

insert leave values(2,4,4,0)
insert leave values(3,4,7,2900)
select * from leave

select emp.empno,nam,basic,lop,basic-lop from 
emp left outer join leave on emp.empno=leave.empno

select nam,basic,lop from emp
join leave on emp.empno=leave.empno
where basic > 15000

select emp.empno,nam,basic,lop,basic-lop from
emp right outer join leave on emp.empno=leave.empno

create table leave1
(
  empno int,
  lavail int,ltaken int,lop int
)

insert leave1 values(2,12,15,4300)
insert leave1 values(8,12,44,9000)
insert leave1 values(9,2,5,900)

select emp.empno,nam,basic,lop,basic-lop from
emp full outer join leave on
emp.empno=leave.empno

select emp.empno,nam,basic,lop,basic-lop from
emp full outer join leave1 on
emp.empno=leave1.empno

select * from emp cross join leave

select e1.empno,e2.nam,e1.basic from emp e1 
join emp e2 on e1.empno=e2.empno

select * into emp2 from emp

alter table emp2 add dno int

select * from emp2

update emp2 set dno=2 where empno=5
select * from emp2

select e2.dno,e2.nam,e1.basic from emp2 e1
join emp2 e2 on e1.empno=e2.dno

select * from emp2

select max(basic) from emp

select nam from emp where basic
=(select max(basic) from emp)

select top 2 * from emp order by basic desc

select max(basic) from emp 
where basic < (select max(basic) from emp where 
basic < (select max(basic) from emp))

select * from emp

select * from leave

select nam from emp where empno <>
all(select empno from leave)

select empno,nam from emp where empno =
any(select empno from leave where empno <4)

select * into model..emp from emp
use model
select * from emp
use master

create table #x
(
   x int
)
