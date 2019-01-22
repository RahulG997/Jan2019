begin tran 
update emptest set basic=45900 where empno=2

--use master
--select * from emptest

rollback tran
sp_help emptest

drop trigger trgs1

sp_helptext trgupd2

drop trigger trgupd2

select * from emptest where dept='ASP'

select avg(basic) from emptest

begin tran
declare @n int
update emptest set basic=basic+5000 where dept='ASP'
select @n=avg(basic) from emptest where dept='ASP'
   if @n>=25000
   begin
   rollback tran
   print 'Transaction is rolled back'
end
else
begin
    commit tran
    print 'transaction is committed'
end

select avg(basic) from emptest where dept='Java'
select avg(basic) from emptest where dept='ASP'

select * from emptest

begin tran
update emptest set basic=basic+1000 where dept='ASP'
save tran t1
update emptest set basic=basic+3000 where dept='Java'
if (select avg(basic) from emptest where dept='Java') >= 25000
begin
     print 'Transaction 1 is committed but transaction 2 has not completed'
     rollback tran t1
end
else
begin
   print 'Both transactions are committed'
   commit tran
end

declare @na varchar(20),@n int 

--declaring cursor
declare c1 cursor for 
select nam,basic from emptest 
--open cursor
open c1
fetch c1 into @na,@n 

-- start the loop to display values 

while (@@fetch_status=0)
begin
--    if @na is null
  --  begin
   --  update emptest set city='Washington'
--    end
    if @na='satish'
    begin
    print 'Employ Name = ' +@na
    print 'Basic  = ' +convert(char(15),@n)
    end
    fetch c1 into @na,@n
end

close c1
deallocate c1