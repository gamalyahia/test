use NewExpenseIt;

drop table if exists NewExpenseItTable 

create table NewExpenseItTable
(
	PersonID int primary key identity(1,1), 
	PersonName varchar(max),
	PersonDepartment varchar(max),
	PersonAmount int,
	PersonExpenseType varchar(max)
);

insert into NewExpenseItTable(PersonName,PersonDepartment,PersonAmount,PersonExpenseType)values
	('Gamal' , 'AI Automation' , 999999 , 'GiftGamal'),
	('Sara' , 'Software Engineer', 151167 , 'GiftSara'),
	('Abdullah'	, 'Mern stack devolper' ,12700,'GiftAbdullah'),
	('Jordan' , 'vollyball player' , 23232 , NULL);

select * from NewExpenseItTable;