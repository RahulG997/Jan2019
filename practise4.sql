select PaymentModeID,
case PaymentModeID
when '1' then 'yearly'
when '2' then 'half-yearly'
when '3' then 'quart-yearly'
end "year"
from policy

select date_format(appdate,'%Y')
from policy


select year(appdate), sum(annualpremium)
from policy


select year(appdate), sum(annualpremium)
from policy
where year(appdate) in('2009','2010')
group by year(appdate)
having  sum(annualpremium)>100000
order by sum(annualpremium)

select city,count(*)
from agent
group by city



select fullname,
case 
when fullname is null then 'enter the details'
else fullname
end "update"
from agent




select * from policy

