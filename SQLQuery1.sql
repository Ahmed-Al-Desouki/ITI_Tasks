
select d.Dname,d.Dnum
from Departments d , Employee e 
where d.Dnum = e.Dno and e.SSN = ( 
	select min(ssn) from Employee ) 

SELECT d.Dname,
MAX(e.Salary) AS [Max Salary],
MIN(e.Salary) AS [Min Salary],
AVG(e.salary) AS [MAX SALARY]
FROM Departments d
JOIN Employee e ON d.Dnum = e.Dno
GROUP BY d.Dname;

select e.fname + ' ' + e.lname as [full name]
from employee e
join departments dd on dd.mgrssn = e.ssn
left join dependent d on e.ssn = d.essn
where d.essn is null;

select d.dnum, d.dname, count(e.ssn) as employee_count
from departments d
join employee e on d.dnum = e.dno
group by d.dnum, d.dname
having avg(e.salary) < (select avg(salary) from employee)

select e.fname, e.lname, p.pname
from employee e
join Works_for w on e.ssn = w.essn
join project p on w.pno = p.pnumber
order by e.dno, e.lname, e.fname;

insert into departments (dnum, dname, mgrssn, [MGRStart Date])
values (100, 'dept it', 112233, '2006-11-01')

select * from Departments

update departments
set mgrssn = 968574
where dnum = 100;

insert into employee (ssn, fname, lname, dno, superssn, salary)
values (102672, 'ahmed', 'al desouki', 100, null, 20000);

update departments
set mgrssn = 102672
where dnum = 20;

update employee
set superssn = 102672
where ssn = 102660;

select d.Dnum,d.Dname,d.MGRSSN,e.Fname + e.Lname as [MName]
from Departments d join
Employee e on d.Dnum = e.Dno

select d.Dname,p.Pname
from Departments d join 
Project p on d.Dnum = p.Dnum

select d.Dependent_name,d.Bdate,d.Sex,e.Fname + ' ' + e.Lname [employee full name]
from Employee e join 
Dependent d on e.SSN = d.ESSN

select Pnumber,Pname,Plocation
from Project
where Plocation in ('Cairo','Alex')

select *
from Project
where Pname like 'A%'

select e.* 
from Employee e
where e.Dno= 30 and e.Salary between 1000 and 2000

select e.fname
from employee e
join Works_for w on e.ssn = w.essn
join project p on w.pno = p.pnumber
where e.dno = 10
and p.pname = 'al rabwah'
and w.hours >= 10;

select e.fname
from employee e
join employee s on e.superssn = s.ssn
where s.fname = 'kamel'

select e.fname, p.pname
from employee e
join Works_for w on e.ssn = w.essn
join project p on w.pno = p.pnumber
order by p.pname;

select p.pnumber, p.pname, d.dname, m.lname, m.address
from project p
join departments d on p.dnum = d.dnum
join employee m on d.mgrssn = m.ssn;




