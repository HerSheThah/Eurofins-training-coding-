--Insert record

create table department(dept_id int , dept_name varchar(10), dept_block_no int)
insert into department values(1, 'CSE', 3),
(2, 'IT', 3),
(3, 'SE', 3)

-- dept name based on blk
select dept_name from department where dept_block_no=3 order by dept_name

-- delivery partner
create table delivery_partner(partner_id  varchar(10), parter_name varchar(20), phoneno bigint, rating int)

insert into delivery_partner values('abc', 'ramesh', 9878036780, 3),
('dfr', 'karthi', 9846790368, 4),
('rtu', 'keerthi', 4556778899, 4),
('cde', 'reetha', 94574580468, 5),
('sdt', 'shankar', 803533930, 2),
('gim', 'ragav', 63839393843, 1)
	
select * from delivery_partner
select partner_id, parter_name, phoneno from delivery_partner where rating between 3 and 5 order by partner_id

-- car and owner details
create table cars(carid varchar(10), carname varchar(20), cartype varchar(20), ownerid varchar(10), ownername varchar(20))

insert into cars values('123', 'tataharrier', 'convertible','err', 'gaby'),
('566', 'maruthi swift', 'hatchback','fty', 'mary'),
('i54', 'maruthi swift', 'hatchback','jmf', 'ibezha'),
('458', 'audi', 'suv','sdf', 'john'),
('sd5', 'tataharrier', 'sedan','sfc', 'time'),
('35f', 'alto', 'suv','kjy', 'paul'),
('43f', 'maruthi swift', 'hatchback','swf', 'reeta'),
('56u', 'tesla', 'sedan','run', 'jesi')

select * from cars

select carid, carname, ownerid from cars where cartype in ('suv', 'hatchback')

--car details on type and name 
select carid, carname, cartype from cars where cartype='sedan' and carname='maruthi swift'
order by carid
