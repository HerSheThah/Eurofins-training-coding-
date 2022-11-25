﻿create database company
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

-- 3. Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.

-- 5. Write an SQL query to print the FIRST_NAME from Worker table after replacing „a‟ with „A‟.
-- should separate them.
-- 8. Write an SQL query to print details of workers excluding first names, “Vipul” and “Satish” from Worker table.
select * from worker where fname not in ('Vipul', 'Sathish')

-- 9. Write an SQL query to print details of the Workers whose FIRST_NAME ends with „h‟ and contains six alphabets.


