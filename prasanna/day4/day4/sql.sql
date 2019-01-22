create database satish
use master
create table emp
(
    empno int primary key,
    nam varchar(15), basic int
)

drop database satish

create database satish

sp_renamedb satish,madhuri

drop database madhuri

sp_help emp

sp_unbindrule 'emp.dept'

select * from emp

insert into emp values(1,'swarna','web','programmer',18555)
insert into emp values(2,'narasimha','asp','developer',19000)

create rule crule1 as @dule in('asp','vb','csh')

sp_bindrule 'crule1','emp.dept'

insert into emp values(3,'sowjanya','java','developer',24999)

sp_unbindrule 'emp.dept'

create rule cdm1 as @cd2 in('java','sas')

sp_bindrule 'cdm1','emp.dept'

sp_help emp

sp_addtype 'test','varchar(15)'

create table x
(
   empno int,
   nam test
)
drop table x
sp_droptype 'test'

create default tdf1 as 'newyork'

select * from emp

create table x
(
   empno int,
   city varchar(15)
)

sp_bindefault 'tdf1','x.city'

insert into x(empno) values(1)

select * from x

sp_unbindefault 'x.city'

insert into x(empno) values(2)

sp_rename x,y

select * from emptest

select * from leavetest

sp_rename emptest,etest

sp_rename etest,emptest

alter table leavetest add foreign key(empno)
references emptest(empno)

drop table x

insert into x values(9,'detroit')

select * from x

create clustered index idx1 on x(empno)

select * from emptest

drop table x



insert into emptest values(6,'satish','asp','programmer',19344,3)

sp_help emptest

drop index x.idx1

select * from x

create clustered index idx1 on x(city)

create clustered index idx2 on x(empno)

sp_help emptest

select emptest.empno,nam,basic,lop from emptest left outer join
leavetest on emptest.empno=leavetest.empno

drop table x1
create table x1
(
   empno int,
   basic int
)

insert into x1 values(83,29553)

select * from x1

create table l1
(
  empno int,
  lop int
)

insert into l1 values(8,284)

select * from l1

select x1.empno,basic,lop from x1 join l1 on 
x1.empno=l1.empno

create clustered index id1 on x1(empno)

sp_help emptest



sp_help leavetest

create nonclustered index idx1 on leavetest(empno)

create index idx2 on leavetest(lop)

create index idx3 on leavetest(ltaken)

sp_help leavetest

select * from leavetest

create index idx4 on emptest(dept)

create index idx5 on emptest(basic)

sp_help emptest

sp_help leavetest

select emptest.empno,nam,basic,lop,ltaken from 
emptest left outer join leavetest on
emptest.empno=leavetest.empno

drop index emptest.idx5

select * from leavetest

insert into leavetest values(15,2,4,5000)

insert into leavetest values(3,3,3,0)

insert into leavetest values(12,2,2,0)

create view tv1 
as
   select empno,nam,basic from emptest

select * from tv1

update emptest set basic=basic+2000 where nam='satish'

select * from emptest

select empno,basic from tv1

create view two 
as
  select emptest.empno,nam,basic,lop from emptest join
leavetest on emptest.empno=leavetest.empno

select * from two

update two set lop=3000 where nam='Nithya'

update two set empno=7 where nam='Nithya'


drop view two

alter view tv1 
as
  select basic from emptest

drop view v1

create view v1
as
select iroon_no,vfname,vlnam,vcit,vcourse,fee from dotnet

declare @n int
set @n=15
print 'N values is '
print @n

