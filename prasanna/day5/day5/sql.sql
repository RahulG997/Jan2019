declare @n int

set @n=56

print @n

select @@version
select @@servername
select @@spid

select * from emptest

select @@rowcount

declare @na varchar(15)
set @na='satish'
print 'Name is  ' +@na

declare @a int,@b int, @c int
set @a=5
set @b=6
set @c=@a+@b
print 'Sum is  ' +convert(char(10),@c)

select 'The no.of rows returned byh tghe query is ' 
+convert(char(10),@@rowcount)

select max(basic) from emptest

declare @n int
select @n=max(basic) from emptest 
if @n >=40000
 print 'Good Salary'
else
 print 'Increment Required'

declare @type varchar(15)
set @type='computers'
select category=
    case @type
      when 'computers' then 'computers department'
      when 'physics' then 'physics department'
      when 'maths' then 'maths department'
      else 'Not yet decided'
end

declare @n int,@i int
set @n=20
set @i=0
while @i < @n
begin
    set @i=@i+2
    print @i
end    


create procedure prcdisp 
as
begin
declare @na varchar(15),@bas int,@dpt varchar(15)
set @na='satish'
select @bas=basic,@dpt=dept from emptest where 
nam=@na
print 'Department is ' +@dpt
print 'Basic is ' +convert(char(10),@bas)
end

exec prcdisp

sp_help prcdisp

sp_helptext prcdisp

drop proc prc1

create proc prc1
as
begin
declare @bas int
select @bas=max(basic) from emptest 
print 'Max. salary is ' +convert(char(10),@bas)
end

prc1

select * from emptest

drop proc prc1
create proc prc1 @na varchar(15)
as
begin
declare @bas int,@dpt varchar(15)
   print 'List is '
   select @dpt=dept,@bas=basic from emptest
    where nam=@na
   print 'Department is ' +@dpt
   print 'Basic is ' +convert(char(10),@bas)
end

prc1 satish

drop proc prc1

create proc prc1 @n int,@m int=5
as
 print @n*@m

prc1 5,9

drop proc prc1

create proc prc1 @na varchar(15)=null
as
begin
if @na is null
begin
   print 'Usage : prc1 name'
   return
end
declare @bas int,@dpt varchar(15)
   print 'List is '
   select @dpt=dept,@bas=basic from emptest
    where nam=@na
   print 'Department is ' +@dpt
   print 'Basic is ' +convert(char(10),@bas)
end

prc1 Anil

drop proc prc1

create proc prc1 @na varchar(15)=null
as
begin
declare @bas int,@dpt varchar(15)
if @na is null
begin
   print 'Usage : prc1 name'
   return
end
if exists(select * from emptest where nam=@na)
begin
   print 'List is '
   select @dpt=dept,@bas=basic from emptest
    where nam=@na
   print 'Department is ' +@dpt
   print 'Basic is ' +convert(char(10),@bas)
   return 0
end
else
begin
   print 'No records found for the given name'    
   return 1
end
end

declare @ret int
exec @ret=prc1 'madhuri'
select @ret

drop proc prc2

select * from student

create proc prc2 @na varchar(15)
as
begin
   declare @no int,@tot int
   select @no=sno,@tot=tot from student where 
      nam=@na
   print 'Student No ' +convert(char(10),@no)
   print 'Total is  ' +convert(char(10),@tot)
end

drop proc exec2
create proc exec2 @na varchar(15)
as
begin
   exec prc1 @na
   exec prc2 @na
end

exec2 Nithya

select * from student

update student set nam='Nithya' where sno=2


drop proc prc1

drop proc prc2

create proc prc1 @eno int,@na varchar(15) output,@bas int output
as
begin
  if exists(select * from emptest where empno=@eno)
  begin
    select @na=nam,@bas=basic from emptest where empno=@eno
    return 0
  end
  else
   return 1
end

create proc prc2 @eno int 
as
begin
  declare @na varchar(15)
  declare @bas int,@retval int
  exec @retval=prc1 @eno,@na output,@bas output
  if (@retval=0)
  begin
    print 'Name is  ' + @na
    print 'Basic  ' +convert(char(10),@bas)
 end
  else 
    print 'Record Not found'
end

exec prc2 355

select max(basic) from emptest

sp_helptext facts

create function eveodd(@n int) returns varchar(15)
as
begin
   declare @s varchar(15)
   if @n%2=0
    set @s='Even No'
   else
    set @s='Odd No'
     return @s
end

select dbo.eveodd(14)

sp_helptext ncr

drop function fac

create function fac(@n int) returns int
as
begin
 declare @f int,@i int 
 set @f=1
 set @i=1
 while @i <= @n
 begin
   set @f=@f*@i
   set @i=@i+1
 end
 return @f
end

select dbo.fac(5)

sp_helptext ncr

drop function ncrs

create function ncrs(@n int,@r int) returns int
as
begin
 declare @r1 int,@r2 int,@r3 int,@res int
 select @r1=dbo.fac(@n)
 select @r2=dbo.fac(@r)
 select @r3=dbo.fact(@n-@r)
 set @res=(@r1)/(@r3 * @r2)
 return @res
end

select dbo.ncrs(6,2)

create table testemp
(
  empno int primary key,
  nam varchar(15),
  basic int,hra float,da float,ta float,tax float,
  pf float, gpay float,npay float
)

drop trigger trginsemp
create trigger trginsemp on testemp for insert
as
  update testemp set hra=basic*0.3,da=basic*0.12,ta=basic*0.15,
    tax=basic*0.2,pf=basic*0.19
  update testemp set gpay=basic+hra+da+ta
  update testemp set npay=gpay-tax-pf

insert into testemp(empno,nam,basic)
values(1,'swarna',18666)

insert into testemp(empno,nam,basic)
values(2,'narasimha',20000)

insert into testemp(empno,nam,basic)
values(3,'sowjanya',19033)
insert into testemp(empno,nam,basic)
values(4,'satish',29000)
select * from testemp

select * from emptest

drop trigger trgdel

create trigger trgdel 
on emptest for delete 
as
   print 'deleting records denied'
   rollback tran
return 

delete from emptest where empno=2

drop trigger 

create trigger trgupd1 on emptest for update
as
 if update(basic)
 begin
    print 'Update is not possible'
    rollback tran
 end

select * from emptest

update emptest set basic=basic+4500 where 
empno=1

drop trigger trgupd1

create trigger trgupd2 on emptest for update
as
begin
  print 'Updated the record successfully'
  commit tran
end

update emptest set basic=basic+1000 where empno=1

update emptest set nam='Chitra' where empno=1

sp_settriggerorder 'trgupd2','LAST','UPDATE'
sp_settriggerorder 'trgupd1','FIRST','update'

select * from emptest