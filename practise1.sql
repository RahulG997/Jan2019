select * from dept
select * from emp
select count(*) from emp


select dept.deptno,dname,
empno,ename,sal
from dept,emp
where dept.deptno=emp.deptno

select dept.deptno,dname,
empno,ename,sal
from dept inner join emp
on dept.deptno=emp.deptno

select d.deptno,dname,
empno,ename,sal
from dept d inner join emp e
on d.deptno=e.deptno


select comm from emp

select * from
(select d.deptno,dname,
empno,ename,sal,comm,

case
when comm is null then 'sal'
else 'sal+comm'
end takehome
from dept d inner join emp e
on d.deptno=e.deptno)dt
where dt.cm=0




