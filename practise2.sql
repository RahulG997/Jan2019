select * from emp

update emp set name=upper(name)

update emp set basic=basic+5000 where empno=5

update emp set basic=basic+5000 where dept='java'

select name from emp

select * from agent

update agent set fullname=concat(firstname,' ',mi,' ',lastname)

update emp set name=concat(upper(left(name,1)),lower(right(name,Length(name)-1)))

start transaction;

delete from emp where empno=1

rollback




