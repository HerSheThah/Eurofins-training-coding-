create table student(stuid int, stuname varchar(30), address varchar(40), city varchar(30), deptid int)
go
select * from student
-- select concat(address, city order by desc) from student

-- qn 2
create table hoteldetails(hotelid varchar(10) primary key, hotelname varchar(20), hoteltype varchar(20), rating int)

create table orders(orderid varchar(10) primary key , custid varchar(10), hotelid varchar(10) foreign key references hoteldetails(hotelid), partnerid varchar(10), orderdate date, orderamt int)


select * from hoteldetails
select * from orders
select distinct h.hotelid, hotelname, rating from hoteldetails h join orders o on h.hotelid=o.hotelid where month(o.orderdate)=6 

-- qn 3 

create table rentals(rentalid varchar(10), custid varchar(10), carid varchar(10), pickupdate date, returndate date, kmdriven int, faramount decimal(10, 2))




drop table rentals 










create table rentals(rentalid varchar(10), custid varchar(10), carid varchar(10), pickupdate date, returndate date, kmdriven int)
select rentalid, carid, custid, kmdriven from rentals where month(pickupdate)=8 and year(pickupdate)=2019
order by rentalid

drop retals