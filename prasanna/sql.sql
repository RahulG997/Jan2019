select * from #x

create database rama

use rama

use master

drop database rama


create table e1
(
  empno int,
  nam varchar(15),
  dept varchar(15),
  desig varchar(15),
  basic float
)


--alter table e1 add constraint c1 primary key(empno)

alter table e1 alter column empno int not null

sp_help e1

alter table e1 alter column nam varchar(15) not null

alter table e1 
add constraint c2
 check(dept in('sql','java','dotnet'))


alter table e1
add constraint c3 check(basic between 1000 and 50000)

create database sunitha

sp_helpdb sunitha

sp_renamedb sunitha,smitha

drop database smitha

create rule r1 as @r in('java','dotnet','sql')
create rule r2 as @p in('sap,','hr','bw')


sp_help emp

sp_help emp2

select * from emp

insert emp values(6,'sunitha','sap','admin',16633)

sp_bindrule 'r1','emp.dept'
sp_bindrule 'r2','emp.dept'

insert emp values(7,'amar','asp','admin',19455)
sp_unbindrule 'emp.dept'

sp_addtype 'test','varchar(15)'

create table x
(
   empno int primary key,
   nam test
)
drop table x

sp_droptype 'test'

create table x
(
   empno int primary key,
   city varchar(15) default 'NewYork'
)


insert x(empno) values(1)

select * from x
insert x values(2,'Detroit')

drop table x

create table x
(
  empno int,
  nam varchar(15)
)

insert x(nam) values('sriharsha')
insert x(nam) values('kiran')
select * from x
truncate table x

create default def1 as 'harsha'

select * from x
drop table x
sp_bindefault 'def1','x.nam'

sp_unbindefault 'x.nam'
insert x(empno) values(1)

truncate table x

sp_help emp

select * from emp

update emp set empno=12 where nam='sunitha'

select * from emp

insert emp values(6,'chaitanya','dotnet','developer',15333)

create table x1
(
  empno int,nam varchar(15),bas float
)
insert x1 values(9,'kiran',18945)
insert x1 values(8,'sriram',19556)
insert x1 values(3,'amar',15533)
insert x1 values(7,'sunitha',15533)

select * from x1

create clustered index idx1 on x1(bas)

drop index x1.idx1

update x1 set empno=12 where nam='amar'

update x1 set nam='yogi' where empno=12