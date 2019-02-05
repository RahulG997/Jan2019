select * from agent


select 
MaritalStatus,
case MaritalStatus
when '0' then 'unmarried'
when '1' then 'married'
end "mm"
from agent

select distinct country, 
case Country
when 'INDIA' then 'bhaskar'
when 'USA' then 'george'
end "manager"
from agent

(select 
agentid,
firstname,
lastname,
city,
state,
ssn
from agent
where agentid between 1 and 10)
union all
(select 
agentid,
firstname,
lastname,
city,
state,
ssn
from agent
where agentid between 4 and 12)

select * from agent

select dob,

select floor(datediff(curdate(),dob)/365.25),floor((datediff(curdate(),dob)/365.25-floor(datediff(curdate(),dob)/365.25))*12) as "months"
from agent



select dayofmonth(curdate())


