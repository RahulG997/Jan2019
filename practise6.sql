use sqlpractice

select
agentid,firstname,lastname
PolicyID,AnnualPremium,ModalPremium

(select agentid,firstname,lastname,city,ssn,from agent)
AD,
(select PolicyID,AppNumber,AppDate,AnnualPremium,ModalPremium from policy)
PD
select *from policy

select d.deptno,dname,empno,ename,sal,job
from dept d left join emp e 
on d.deptno=e.deptno

select
agentid,firstname,lastname,
PolicyID,AnnualPremium,ModalPremium,
issplitagent
from agent a left join agentpolicy ap
on a.agentid=ap.agentid
left join policy p 
on p.policyid=ap.policyid


employee