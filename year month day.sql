use sqlpractice
select * from Agent;

select MaritalStatus,
case MaritalStatus
when '1' then 'Married'
else 'unmarried'
END "Mstatus"
from Agent


select distinct country,
case country
when 'india' then 'Bhaskar'
when 'usa' then 'george'
end "manager"
from agent

(select AgentID,
firstname,
city,
state,
ssn 
from agent 
where agentID between 1 and 10)
UNION
(select AgentID,
firstname,
city,
state,
ssn 
from agent 
where agentID between 4 and 12)

(select AgentID,
firstname,
city,
state,
ssn 
from agent 
where agentID between 1 and 10)
UNION ALL
(select AgentID,
firstname,
city,
state,
ssn 
from agent 
where agentID between 4 and 12)

select dob, year(dob) from Agent 


select dob, datediff(date(curdate()),date(dob)) from Agent

select date_format(curdate(),"%d");

select dob,floor(datediff(curdate(),dob)/365.25) as "years",
floor( (datediff(curdate(),dob)/365.25-floor(datediff(curdate(),dob)/365.25))*12 ) as "Months",
floor (((datediff(curdate(),dob)/365.25-floor(datediff(curdate(),dob)/365.25))*12 - floor( (datediff(curdate(),dob)/365.25-floor(datediff(curdate(),dob)/365.25))*12 ))*30.4375) as "Days"  
from agent;


/*select dob, datediff(year(dob),year(curdate())) from agent;*/





