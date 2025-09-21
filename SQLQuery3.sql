use companytask;

create table departments (
    DNumber int primary key,              
    DName nvarchar(100) not null,          
    ManagerId int null,                   
    HiringDate date not null              
)

create table employees (
    Id int primary key,                    
    FirstName nvarchar(50) not null,       
    LastName nvarchar(50) not null,        
    Address nvarchar(200),                  
    Gender char(1) check (Gender in ('M','F')),
    BirthDate date not null,                
    SupervisorId int foreign key(SupervisorId) references employees(Id) null,                  
    DepartmentNumber int foreign key(DepartmentNumber) references departments(DNumber) not null         
)

alter table departments
add constraint fk_department_manager foreign key (ManagerId) references employees(Id);

create table projects (
    PNumber int primary key,               
    PName nvarchar(100) not null,           
    Location nvarchar(100),                 
    City nvarchar(100),                     
    DeptNum int foreign key (DeptNum) references departments(DNumber) not null                   
)

create table employee_projects (
    EId int not null,                       
    PNum int not null,                      
    WorkingHours int check (WorkingHours >= 0), 
    primary key (EId, PNum),
    constraint FK_EP_Employee foreign key (EId) references employees(Id),
    constraint FK_EP_Project foreign key (PNum) references projects(PNumber)
)


-- ********************************************** --

insert into Departments (DNumber, DName, ManagerId, HiringDate)
values
(1, 'HR', NULL, '2020-01-15'),
(2, 'IT', NULL, '2021-03-10'),
(3, 'Finance', NULL, '2019-06-01')

insert into Employees (Id, FirstName, LastName, Address, Gender, BirthDate, SupervisorId, DepartmentNumber)
values
(101, 'Ahmed', 'Hassan', 'Cairo, Egypt', 'M', '1990-05-10', NULL, 1),
(102, 'Mona', 'Ali', 'Giza, Egypt', 'F', '1992-08-20', 101, 1),
(103, 'Omar', 'Mahmoud', 'Alex, Egypt', 'M', '1988-11-15', 101, 2),
(104, 'Sara', 'Ibrahim', 'Cairo, Egypt', 'F', '1995-02-05', 103, 2),
(105, 'Youssef', 'Adel', 'Mansoura, Egypt', 'M', '1993-07-25', 101, 3)


insert into Projects (PNumber, PName, Location, City, DeptNum)
values
(201, 'Website Development', 'Smart Village', 'Cairo', 2),   
(202, 'Recruitment Campaign', 'Office', 'Cairo', 1),    
(203, 'Budget Analysis', 'ITI', 'Alex', 3)

insert into Employee_Projects (EId, PNum, WorkingHours)
values
(101, 201, 120),
(103, 201, 100),
(105, 203, 60)

-- *********************************************** --
select * 
from employees

select * 
from departments

select * 
from employee_projects

select * 
from projects

select * 
from employees
where DepartmentNumber = 1 

select FirstName , LastName as 'Full Name'
from employees
where Address  like '%Cairo%'

select *
from employees
where BirthDate between '1991-01-01' and '2002-12-31';

select p.PName
from Projects p
join Employee_Projects ep on p.PNumber = ep.PNum
where ep.EId = 105;

select *
from employees
order by LastName desc;

select *
from employees
where SupervisorId is null;


update employees
set Address = 'Alex'
where Id = 3;

select * 
from employees

-- *********************************************--

select *
from employees
where FirstName like 'M%';

select distinct Address
from employees;

select *
from employees
order by FirstName asc, LastName desc;

select *
from employees
where FirstName like '____'; -- or len(FirstName) = 4

select *
from employees
where FirstName like 'A_m%';

select *
from employees
where FirstName like '[A-M]%' 

select *
from employees
where Address not like 'C%';

-- the end ,Thanks --
