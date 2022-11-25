/*create database Eurofins
use eurofins

select name from master.sys.databases 

create table Employee(empid int, empname varchar(30), gender varchar(10), location varchar(20)	)

alter table Employee add dept varchar(30),salary decimal(8, 2)

alter table Employee drop column gender
select * from Employee
truncate table Employee

drop table Employee

delete Employee
insert into Employee values(16, 'teena', 'chennai', 'hr', 80000),
(17, 'reena', 'pune', 'testing', 50000),
(18, 'kumar', 'banglore', 'developer', 80000),
(19, 'jesi', 'banglore', 'engineer', 90000),
(20, 'gery', 'mumbai', 'designer', 75000),
insert into Employee values(20, 'tony', 'pune', 'developer', 85000),
(20, 'harshi', 'chennai', 'engineer', 90000),
insert into Employee values(22, 'janani', 'pune', 'engineer', 70000)


select * from Employee where dept in ('hr', 'engineer')

select empname, dept from Employee where empname like '%a' 
select * from Employee where location <>'chennai'

select max(salary ) as maxsalary from Employee
select avg(salary ) as avgsalary from Employee

select count(empname), dept from Employee group by dept
select dept, min(salary), max(salary) from Employee group by dept

select dept, count(salary) from employee group by dept having dept='engineer'

select distinct empid  from Employee */



-- DDL => create, Alter, truncate, drop

-- Creating new database
create database eurofinsemployee

--Renaming databse 
alter database eurofinsemployee modify name =eurofinsdetails

-- Creating table
create table employee(eid int, name varchar(30), dept varchar(20), location varchar(20), salary int)

-- alter table
alter table employee add gender varchar(20)
alter table employee drop column gender
alter table employee alter column salary decimal(8, 2)


-- truncate table 
truncate table employee

-- drop table 
drop table employee


-- DML commands => INSERT UPDATE DELETE

-- insert into table 
insert into employee values(1, 'john', 'hr', 'banglore', 80000),
(2, 'rakesh', 'manager', 'chennai', 100000),
(3, 'harshi', 'developer', 'banglore', 90000),
(4, 'deni', 'hr', 'pune', 85000),
(5, 'jesi', 'engineer', 'mumbai', 75000),
(6, 'sowmy', 'hr', 'banglore', 90000),
(7, 'kiran', 'engineer', 'chennai', 75000)

-- update value 
update employee set salary=80000 where eid=7

-- delete record 
delete employee where salary>90000

-- DQL => select(and, or, in , not in, like, betweeen), aggregate func and clause(mn, max, sum, avg, group by, having, order by)

-- select operator
select * from employee
select eid, name, dept from employee where salary>70000 and location='chennai'
select name, dept, location from employee where salary between 70000 and 80000

-- select with not 
select name, dept, location, salary from employee where location not in ('chennai', 'mumbai')


-- like operator 
select name, dept from employee where name not like '%i'
select name, dept from employee where name like '__hn'
select name, dept from employee where name like '_r%'

-- Aggregate sum, avg, min, max
select min(salary), max(salary), avg(salary) from employee

select location, count(*) from employee group by location
select count(*) as no_of_employee from employee

select dept, count(*) from employee group by dept 

select count(*), location, salary from employee where salary>80000 group by location 


-- collation for changing cases to lower and upper 
select SERVERPROPERTY('collation')

-- function for getting current date and time
select getdate(), CURRENT_TIMESTAMP, GETUTCDATE()

-- dates 
alter table employee add joining_date date
insert into employee values(8, 'tharani', 'developer', 'chennai', '80000', '12/06/2022')


select * from employee where year(joining_date)=2022
select name, DATEDIFF(year, joining_date, getdate()) from employee

-- string operations
select upper(concat('hello', 'world'))
select LTRIM('     hello   worl d   fru  ')
select RTRIM('     hello   worl d   fru  ')
select REPLICATE('harshi', 5)