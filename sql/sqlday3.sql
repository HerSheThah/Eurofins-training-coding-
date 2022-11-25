use Northwind
-- self join 
select * from employees

select employeeid, firstname, reportsto from employees

select e1.employeeid, e1.firstname + ' reports to ' + e2.firstname as manager from employees e1 join employees e2 on e1.reportsto=e2.employeeid

-- Constraints not null,prim and foreign key

use company
alter table student alter column stuid int not null
alter table student add constraint pkid primary key(stuid)
alter table student drop constraint pkid

create table depart(did int primary key identity(200, 2), 
dname varchar(30)
)
alter table student drop column depid
-- referential integrity/ foreign key
alter table student add depid int references depart(did)

alter table student add constraint fkdepid foreign key(depid) references depart(did)
alter table student drop constraint fknewdepid


-- changing name of foreign key constraint
sp_rename 'fkdepid','fknewdepid'

select * from student

alter table student drop column depid
-- check constraint 
alter table student add constraint ckdep check(deptid>10)

insert into student values(8, 'harshi', 'patti', 'banglore', 19)
insert into student values(8, 'jesi', 'patti', default, 90)


-- default constraint 
alter table student add constraint defcity default 'chennai' for city

-- stored procedure
create procedure spselect
as 
select * from student

execute spselect

create proc selecttitem(@stuid int)
as
select * from student where stuid=@stuid
exec selecttitem 8

-- to drop the procedure
drop proc selecttitem

create proc insertingitem(@stuid int, @stuname varchar(30), @address varchar(40), @city varchar(30), @deptid int)
as 
insert into student values(@stuid, @stuname, @address, 'banglore', @deptid)

alter proc insertingitem(@stuid int, @stuname varchar(30), @address varchar(40), @deptid int)
as 
insert into student values(@stuid, @stuname, @address,default, @deptid)

exec insertingitem 1, 'steve', 'richi',  11


