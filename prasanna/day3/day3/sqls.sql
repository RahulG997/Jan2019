create table empt
(
    empno int constraint ckd1 primary key,
    nam varchar(15) not null,
    gender varchar(15) 
    constraint cg1 check(gender in('male','female')),
    dept varchar(15)
    constraint cd1 check(dept in('asp','vb','c#','sql')),
    desig varchar(15)
    constraint cds1 check(desig in('junior','senior','head')),
    basic int
    constraint cb1 check(basic between 1000 and 50000)
)

drop table empt

insert into empt values(1,'satish','male','c#','head',28900)

insert into empt values(2,'madhuri','female','vb','head',19000)


sp_help empt

create table studs
(
   sno int primary key,
   nam varchar(15) not null,
   sub1 int,sub2 int,sub3 int,
   tot int,aveg float
)

insert into studs(sno,nam,sub1,sub2,sub3) 
values(1,'sowjanya',67,88,55)

update studs set tot=sub1+sub2+sub3,aveg=(sub1+sub2+sub3)/3

select * from studs

select * from emp3

drop table emp3

select * from emp2

select * from emp7

truncate table emp7

select * from empc

delete from empc



create table empt
(
   empno int,
   nam varchar(15),
   dept varchar(15),
   desig varchar(15),
   basic int
)

alter table empt add constraint prk1 primary key(empno)

alter table empt alter column empno int not null

alter table empt alter column nam varchar(20) not null

sp_help empt

alter table empt add constraint cs1
check(dept in('asp','vb','c#','sql'))


alter table empt add constraint cd1
check(desig in('junior','senior','head'))

alter table empt add constraint csk1
check(basic between 1000 and 50000)

alter table empt add gender varchar(15)

alter table empt add city varchar(15)

alter table empt drop column city

select * from emptest

select * into duptab from emptest

select * from duptab

select * into model..cptab from master..emptest

use model
select * from cptab

sp_help duptab


create table testemp
(
    empno int primary key,
    deptno int unique,
    city varchar(15)
)

select * from testemp
insert into testemp values(1,2,'washington')

insert into testemp(empno,city) values(5,'Detroit')

select * from emptest

use master

select * from leavetest
create table leaves
(
   empno int references emptest(empno) on delete cascade,
   lavil int,ltaken int,lop int
)

insert into leaves values(110,3,4,1000)

select * from emptest

select * from leaves

delete from emptest where empno=1

drop table leaves

delete from emptest where empno=110


select * from emptest

select * from leavetest

sp_help emptest

sp_help leavetest

select * from leavetest

insert into leavetest values(829,5,8,4000)

select * from emptest

select * from leavetest

sp_help leavetest

alter table leavetest drop constraint FK__leavetest__empno__3C2ACFCE


select emptest.empno,nam,basic,lop from emptest
right outer join leavetest on emptest.empno=leavetest.empno

select nam,basic,lop,'Cash on hand'=basic-lop from emptest 
right outer join
leavetest on  emptest.empno=leavetest.empno

select emptest.empno,nam,basic,lop from 
emptest full outer join leavetest on 
emptest.empno=leavetest.empno


select * from emptest cross join leavetest

select e1.empno,e2.basic,e1.nam from emptest e1 join
emptest e2 on e1.empno=e2.empno

alter table emptest add deptno int

SELECT * FROM EMPtest
update emptest set deptno=10 where empno=2

select e1.empno,e2.basic,e1.nam from emptest e1 join
emptest e2 on e2.empno=e1.deptno

select * from emptest

select max(basic) from emptest

select nam from emptest where basic=max(basic)

select nam from emptest where 
basic=(select max(basic) from emptest)

select max(basic) from emptest where 
basic < (select max(basic) from emptest where 
basic < (select max(basic) from emptest  where 
basic < (select max(basic) from emptest)))

select top 5 * from emptest order by basic desc

select max(basic) from emptest where basic < 5000 -> 39022

select max(basic) from emptest where basic < 39002



select * from emptest

select * from leavetest

select nam from emptest where empno <> 
all(select empno from leavetest)

select empno,nam from emptest where empno =
any(select empno from leavetest where empno <10)

select * from emptest where empno > ALL(select empno
from leavetest)

select * from emptest where empno > ANY(select empno
from leavetest)

select * from emptest where empno <>ALL(select empno
from leavetest)

select * from emptest where empno <> ANY(select empno
from leavetest)

select * from leavetest

delete from leavetest where empno >=19

create table #x
(
   empno int,
   nam varchar(15),
   city varchar(15)
)
   

insert into #x values(3,'glory','alabama')

select * from #x
