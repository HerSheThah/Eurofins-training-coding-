-- creating one table 
create table students(regno int, name varchar(30), age int, city varchar(20))

-- creating another table 
create table studentfee(regno int , dept varchar(20), amountpaid int)

insert into students values(12, 'peetha', 18, 'chennai'),
(15, 'jan', 17, 'chennai'),
(17, 'hari', 18, 'banglore'),
(10, 'jesi', 17, 'banglore'),
(19, 'mohan', 19, 'chennai')

insert into studentfee values(15, 'cs', 18000),
(10, 'bio', 15000),
(20, 'acc', 10000),
(17, 'cs', 12000)



-- inner join
select s.regno, name, dept, amountpaid from students s join studentfee f on s.regno=f.regno


-- left outer join
select s.regno, name, dept, amountpaid from students s left outer join studentfee f on s.regno=f.regno


select * from students
select * from studentfee
-- right outer join
select f.regno, name, dept, amountpaid from students s right outer join studentfee f on s.regno=f.regno


-- full outer join
select f.regno, name, dept, amountpaid from students s full join studentfee f on s.regno=f.regno

-- primary key
create table course(cid int primary key, cname varchar(20))
drop table course
insert into course values(123, 'python'),
(345, 'java'),
(868, 'web dev')

select * from course

-- adding foreign key element 
alter table students add cid int  foreign key references course(cid)
select * from students