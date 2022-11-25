create database BankDB

use BankDB

select * from SBAccount
select * from SBtransactions


--create table SBAccount(
--AccountNumber bigint primary key, 
--CustomerName varchar(20), 
--CustomerAddress varchar(40), 
--CurrentBalance decimal(20, 2))


--create table SBtransactions(
--TransactionId bigint primary key, 
--TransactionDate datetime, 
--AccountNumber bigint foreign key(AccountNumber) references SBAccount(AccountNumber),
--Amount decimal(20, 2),
--TransactionType varchar(20))

--select CurrentBalance from SBAccount where AccountNumber=5421241956;

--select count(*) from SBtransactions where AccountNumber=5421241956;


-- **********************************************************************************************************************
create proc spinsertacc(
@AccountNumber bigint, 
@CustomerName varchar(20),
@CustomerAddress varchar(40), 
@CurrentBalance decimal(20, 2))
as
insert into SBAccount values(@AccountNumber, @CustomerName, @CustomerAddress, @CurrentBalance)


-- **********************************************************************************************************************
create proc spaccountdetail 
@AccountNumber bigint
as
select * from SBAccount where AccountNumber=@AccountNumber;

-- **********************************************************************************************************************
create proc spallaccounts
as
select * from SBAccount

-- **********************************************************************************************************************
create proc spcurrentbalance
@AccountNumber decimal(20, 2)
as
select CurrentBalance from SBAccount where AccountNumber=@AccountNumber;


-- **********************************************************************************************************************
create proc spupdateamount
(@CurrentBalance decimal(20, 2), 
@AccountNumber bigint)
as
update SBAccount set CurrentBalance=@CurrentBalance where AccountNumber=@AccountNumber;

select * from SBAccount where AccountNumber=5333117949
select * from SBtransactions where AccountNumber=5333117949

-- **********************************************************************************************************************
create proc spinserttransac(
@TransactionId bigint, 
@Transactiondate datetime,
@AccountNumber bigint, 
@Amount decimal(20, 2),
@TransactionType varchar(20))
as
insert into SBtransactions values(@TransactionId, @Transactiondate, @AccountNumber, @Amount, @TransactionType);

-- **********************************************************************************************************************
create proc sptranscount 
@AccountNumber bigint
as
select count(*) from SBtransactions where AccountNumber=@AccountNumber;

-- **********************************************************************************************************************
create proc spaccounttrans 
@AccountNumber bigint
as
select * from SBtransactions where AccountNumber=@AccountNumber;
