show tables
DESC emp
select * from emp
SELECT
empno,
name,
basic
FROM EMP
select * from emp
where basic > 50000
select * from emp
where dept='java'
SELECT * FROM EMP
WHERE BASIC BETWEEN 20000 AND 50000
SELECT * FROM EMP
WHERE BASIC NOT BETWEEN 20000 AND 50000
SELECT * FROM EMP
WHERE DEPT IN ('JAVA','DOTNET')
SELECT * FROM EMP
WHERE DEPT NOT IN ('JAVA')
SELECT * FROM EMP
WHERE NAME LIKE 'K%'
SELECT * FROM EMP
WHERE NAME LIKE '%M'
SELECT * FROM EMP
ORDER BY NAME
SELECT * FROM EMP
ORDER BY DEPT
SELECT * FROM EMP
ORDER BY DEPT,NAME
SELECT DISTINCT DEPT FROM EMP
SELECT INSTR('BHUVI','I')
SELECT NAME
INSTR('KIRAN','K') FROM EMP
SELECT LENGTH ('BHUVI')
SELECT REVERSE ('BHUVI')
SELECT LEFT ('BHUVI',2)
SELECT NAME,
LOWER (NAME) FROM EMP
SELECT SUBSTRING('BHUVI SATCHIN',3,5)
SELECT REPLACE('BHUVI SATCHIN','BHUVI','MANO')
SELECT * FROM EMP
WHERE DEPT='JAVA'
SELECT
NAME,
CASE NAME
WHEN ' ' THEN '2'

END "CT"
FROM EMP
SELECT
EMPNO,
DEPT,
CASE DEPT
WHEN 'JAVA' THEN 'PUNE'
WHEN 'DOTNET' THEN 'CHENNAI'
END "CITY"
FROM EMP
SELECT ABS(-12)
SELECT SQRT(29)
SELECT POWER(2,5)
SELECT CEILING(12.0000000001)
SELECT ROUND(7868.2778,0)






SELECT INSTR('SANJANA','A')

SELECT * FROM EMP
WHERE NAME LIKE '%V' 'V%'


SELECT LENGTH('SANJANA')-INSTR((REVERSE('SANJANA')),'K')+1
CASE SANJANA



SELECT CURDATE()

SELECT ADDDATE(CURDATE(),INTERVAL 1 DAY)

SELECT LAST_DAY(ADDDATE(CURDATE(),INTERVAL 1 MONTH))

SELECT ADDDATE(LAST_DAY(SUBDATE(CURDATE(),INTERVAL 2 MONTH)),INTERVAL 1 DAY)
SELECT ADDDATE(CURDATE(), INTERVAL 

select adddate(last_day(subdate(curdate(),interval 1 month)),interval 1 year)

select last_day(subdate(curdate(),interval 1 month))








