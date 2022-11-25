create database company
use company

-- worker table
create table worker(worderid int primary key, fname varchar(20), lname varchar(20), salary int, joiningdate datetime, dept varchar(20))


insert into worker values(001, 'Monika', 'Arora', 100000, '2014-02-20 09:00:00', 'HR'),
(002, 'Niharika', 'Verma', 80000, '2014-06-11 09:00:00', 'Admin'),
(003, 'Vishal', 'Singhal', 300000, '2014-02-20 09:00:00', 'HR'),
(004, 'Amitabh', 'Sighn', 500000, '2014-02-20 09:00:00', 'Admin'),
(005, 'Vivek', 'Bathi', 500000, '2014-06-11 09:00:00', 'Admin'),
(006, 'Vipul', 'Diwan', 200000, '2014-06-11 09:00:00', 'Account'),
(007, 'Sathish', 'Kumar', 75000, '2014-01-20 09:00:00', 'Account'),
(008, 'Geetika', 'chandth', 90000, '2014-04-11 09:00:00', 'Admin')
select * from worker


-- 1. Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.
select UPPER(fname) from worker

-- 2. Write an SQL query to print the first three characters of FIRST_NAME from Worker table
select SUBSTRING(fname, 1, 3) from worker 

-- 3. Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.select RTRIM(fname) from worker-- 4. Write an SQL query to print the DEPARTMENT from Worker table after removing white spaces from the left side.select LTRIM(dept) from worker

-- 5. Write an SQL query to print the FIRST_NAME from Worker table after replacing „a‟ with „A‟.select REPLACE(fname, 'a', 'A') from worker-- 6. Write an SQL query to print the FIRST_NAME and LAST_NAME from Worker table into a single column COMPLETE_NAME. A space char
-- should separate them.select concat(fname, ' ',lname) as complete_name from worker-- 7. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending and DEPARTMENT Descending.select * from worker order by fname asc, dept desc
-- 8. Write an SQL query to print details of workers excluding first names, “Vipul” and “Satish” from Worker table.
select * from worker where fname not in ('Vipul', 'Sathish')

-- 9. Write an SQL query to print details of the Workers whose FIRST_NAME ends with „h‟ and contains six alphabets.select * from worker where fname like '_____h'-- 10. Write an SQL query to print details of the Workers who have joined in Feb‟2014.select * from worker where month(joiningdate)=2 and year(joiningdate)=2014-- 11. Write an SQL query to fetch worker names with salaries >= 50000 and <= 100000.select fname from worker where salary between 50000 and 100000-- 12. Write an SQL query to fetch the no. of workers for each department in the descending order.select dept, count(*) from worker group by dept order by count(dept) desc-- title tablecreate table title(workrefid int foreign key references worker(worderid), title varchar(20), affectedfrom datetime)insert into title values(1, 'Manager', '2016-02-20 00:00:00'),(2, 'Executive', '2016-06-11 00:00:00'),(8, 'Executive', '2016-06-11 00:00:00'),(5, 'Manager', '2016-06-11 00:00:00'),(4, 'Asst.Manager', '2016-06-11 00:00:00'),(7, 'Executive', '2016-06-11 00:00:00'),(6, 'Lead', '2016-06-11 00:00:00'),(3, 'Lead', '2016-06-11 00:00:00')select * from title-- 13. Write an SQL query to print details of the Workers who are also Managers.select * from worker w join title t on w.worderid = t.workrefidwhere t.title='Manager'-- creating bonus table create table bonus(workid int , bonusamt int )insert into bonus values(1, 5000),(2, 3000),(3, 4000),(1, 4500),(2, 3500)insert into bonus values(1, 5000),(2, 3000),(3, 4000),(1, 4500),(2, 3500)-- 14. Write an SQL query to fetch duplicate records having matching data in some fields of a table.select workid,bonusamt, count(*) from bonus group by workid, bonusamt having count(*)>1-- 15. Write an SQL query to show only odd rows from a table.select * from ( select *, ROW_NUMBER() OVER(order by worderid) as rownum from worker)t where rownum%2 <>0-- 16. Write an SQL query to show the top n (say 10) records of a table.select top 5 * from worker-- 17. Write an SQL query to determine the 5th highest salary without using TOP or limit method.-- using top select top 1 salary from worker where salary in (select distinct top 5 salary as top5 from worker order by salary desc) order by salary SELECT salary FROM worker e1 WHERE 4 = (SELECT COUNT(DISTINCT salary) FROM worker e2 WHERE e2.salary > e1.salary)
SELECT * FROM ( SELECT e.*, ROW_NUMBER() OVER (ORDER BY salary DESC) rn FROM worker e ) WHERE rn = 2;

