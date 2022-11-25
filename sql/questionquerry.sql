use company

-- department names without any employees

create table departmentTable (deptid bigint primary key, deptname varchar(20))



create table EmployeeTable (empid int primary key not null, empname varchar(30), 
deptid bigint foreign key references departmentTable(deptid))

select * from EmployeeTable

select * from departmentTable

select d.deptid, d.deptname from departmentTable d except( select d.deptid, d.deptname from departmentTable d join EmployeeTable e
on d.deptid=e.deptid)

select * from departmentTable d left outer join EmployeeTable e
on d.deptid=e.deptid where empid is null