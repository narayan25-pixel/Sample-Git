create table branch_master(
branch_id varchar(6),
branch_name varchar(30),
branch_city varchar(30)
constraint pk_bid primary key(branch_id)
)

create table loan_details(
customer_number varchar(6),
branch_id varchar(6),
loan_amount int
)

create table customer_master(

customer_number varchar(6),
firstname varchar(30),
middlename varchar(30),
lastname varchar(30),
customer_city varchar(15),
customer_contact_no varchar(10),
occupation varchar(20),
customer_date_of_birth date
constraint pk_cnum primary key(customer_number)
)


create table account_master(
account_number varchar(6),
customer_number varchar(6),
branch_id varchar(6),
opening_balance int,
account_opening_date date,
account_type varchar(10),
account_status varchar(10)
constraint pk_anum primary key(account_number)
constraint fk_custnum foreign key(customer_number) references customer_master(customer_number),
constraint fk_branid foreign key(branch_id) references branch_master(branch_id)
)


create table transaction_details(
transaction_number varchar(6),
account_number varchar(6),
date_of_transaction date,
medium_of_transaction varchar(20),
transaction_type varchar(20),
transaction_amount int
constraint pk_tnum primary key(transaction_number)
constraint fk_accnum foreign key(account_number) references account_master(account_number)
)
select * from branch_master
select * from customer_master


insert into loan_details values ('C00001','B00001',100000)
insert into loan_details values ('C00002','B00002',200000)
insert into loan_details values ('C00009','B00008',400000)
insert into loan_details values ('C00010','B00009',500000)
insert into loan_details values ('C00001','B00003',600000)
insert into loan_details values ('C00002','B00001',600000)


select * from loan_details

delete from loan_details where loan_amount is null


insert into account_master values('A00001','C00001','B00001',1000,'2012-12-15','SAVING','ACTIVE')



insert into transaction_details values('T00001','A00001','2013-01-01','CHEQUE','DEPOSIT',2000)
insert into transaction_details values('T00002','A00001','2013-02-01','CASH','WITHDRAWL',2000)
insert into transaction_details values('T00004','A00002','2013-02-01','CASH','DEPOSIT',2000)
insert into transaction_details values('T00005','A00007','2013-01-11','CASH','DEPOSIT',2000)
insert into transaction_details values('T00006','A00007','2013-01-13','CASH','DEPOSIT',2000)
insert into transaction_details values('T00007','A00001','2013-03-13','CASH','DEPOSIT',2000)
insert into transaction_details values('T00008','A00001','2013-03-14','CHEQUE','DEPOSIT',2000)
insert into transaction_details values('T00009','A00001','2013-03-21','CASH','WITHDRAWL',2000)
insert into transaction_details values('T00010','A00001','2013-03-22','CASH','WITHDRAWL',2000)
insert into transaction_details values('T00011','A00002','2013-03-25','CASH','WITHDRAWL',2000)
insert into transaction_details values('T00012','A00007','2013-03-26','CASH','WITHDRAWL',2000)


SELECT * FROM transaction_details


insert into account_master values ('A00001','C00001','B00001',1000,'2012-12-15','SAVING','ACTIVE')
select * from account_master
delete from account_master where account_type is null

drop table transaction_details

insert into account_master values ('A00001','C00001','B00001',1000,'2012-12-15','SAVING','ACTIVE')

delete from account_master where account_type is null

select * from account_master


insert into account_master values ('A00001','C00001','B00001',1000,'2012-12-15','SAVING','ACTIVE')
insert into account_master values ('A00002','C00002','B00001',1000,'2012-06-12','SAVING','ACTIVE')
insert into account_master values ('A00003','C00003','B00002',1000,'2012-05-17','SAVING','ACTIVE')
insert into account_master values ('A00004','C00002','B00005',1000,'2013-01-27','SAVING','ACTIVE')
insert into account_master values ('A00005','C00006','B00006',1000,'2012-12-17','SAVING','ACTIVE')
insert into account_master values ('A00006','C00007','B00007',1000,'2010-08-12','SAVING','SUSPENDED')
insert into account_master values ('A00007','C00007','B00001',1000,'2012-10-02','SAVING','ACTIVE')
insert into account_master values ('A00008','C00001','B00003',1000,'2009-11-09','SAVING','TERMINATED')
insert into account_master values ('A00009','C00003','B00007',1000,'2008-11-30','SAVING','TERMINATED')
insert into account_master values ('A000010','C00004','B00002',1000,'2013-03-01','SAVING','ACTIVE')

SELECT * FROM customer_master
SELECT * FROM account_master



select account_number,customer_master.customer_number,firstname,lastname,account_opening_date from
account_master left join
customer_master
on account_master.customer_number=customer_master.customer_number



select count(customer_city) as 'Cust_Count' from customer_master where customer_city = 'DELHI'



select customer_master.customer_number,firstname,account_number from
account_master left join
customer_master
on account_master.customer_number=customer_master.customer_number
where date(customer_master.aod)>15
order by customer_master.customer_number,account_master.account_number




select customer_master.customer_number,firstname,account_number from
account_master left join
customer_master
on account_master.customer_number=customer_master.customer_number
where account_master.account_status='TERMINATED'



select transaction_details.transaction_type,count(transaction_details.transaction_number) as'Trans_count' from
transaction_details left join
account_master
on account_master.account_number=transaction_details.account_number
left join
customer_master
on customer_master.customer_number=account_master.customer_number
where customer_master.account_number like '001'
group by transaction_details.transaction_type
order by transaction_details.transaction_type



select count(*) as 'count_customer' from
customer_master left join
account_master
on account_master.customer_number=customer_master.customer_number
where account_master.account_status is null



select account_number,account_master.opening_balance+sum(transaction_details.transaction_amount) as 'Deposit_Amount' from
account_master left join
transaction_details
on account_master.account_number = transaction_details.account_number
where transaction_details.transaction_type='DEPOSIT'
order by account_master.customer_number,account_number










