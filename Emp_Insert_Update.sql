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
select sum(basic) from emp
select avg(basic) from emp
select max(basic) from emp
select min(basic) from emp
select count(basic) from emp

select dept, sum(basic) "total"
from emp
group by dept

select dept, count(*) "no"
from emp
group by dept


select dept, max(basic) "high"
from emp
group by dept

select dept, sum(basic),max(basic),avg(basic),min(basic),count(*)
from emp
group by dept

select dept, sum(basic),max(basic),avg(basic),min(basic),count(*)
from emp
group by dept
having count(*) >=2

select dept, sum(basic),max(basic),avg(basic),min(basic),count(*)
from emp
group by dept
having count(*) >=2
order by dept

select dept, sum(basic),max(basic),avg(basic),min(basic),count(*)
from emp
where dept in('java','sql')
group by dept
having count(*) >=2
order by dept