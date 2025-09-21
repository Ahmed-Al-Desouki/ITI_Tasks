--1
select e.Dno, count(*) as number_of_employees
from employee e
group by e.Dno;
--2
select e.Dno, min(e.salary) as minimum_salary
from employee e
group by e.Dno;
--3
select e.Dno, avg(e.salary) as average_salary
from employee e
group by e.Dno;
--4
select e.Dno, count(*) as number_of_employees
from employee e
group by e.Dno
having count(*) > 3;
--5
select p.Pname
from Employee e inner join 
Works_for w on e.SSN = w.ESSn inner join 
Project p on p.Pnumber = w.Pno
group by p.Pname 
having count(e.ssn) > 2
--6
select e.Fname + ' ' + e.Lname
from Employee e 
where e.Salary = (select max(salary) from Employee) 
--7
select e.Fname + ' ' + e.Lname
from Employee e 
where e.Salary > (select avg(salary) from Employee) 

select * from Project -- to saw a data
--8
select distinct e.Fname + ' ' + e.Lname 
from Employee e inner join 
Works_for w on e.SSN = w.ESSn
where w.Pno in (
select w2.Pno
from Works_for w2 inner join 
Project p2 on w2.Pno = p2.Pnumber
where p2.Pname = 'Al Rabwah')

select * from Employee
--9
select distinct d.dname
from departments d
join project p on d.dnum = p.dnum
join works_for w on p.pnumber = w.pno
join employee e on w.essn = e.ssn
where e.fname = 'Ahmed';
--10
create view employee_department_salary as
select e.fname, e.lname, e.salary, d.dname
from employee e
join departments d on e.dno = d.dnum;
--11
select * from employee_department_salarye 
--12
create view project_department as 
select p.Pname , d.Dname
from Project p inner join 
Departments d on p.Dnum = d.Dnum

select * from project_department
--13
select Fname + ' ' + Lname ,Salary
from Employee 
order by Salary desc
--14
select Pname
from Project
order by Pname
--15
select top 3 fname+ ' ' + lname, salary
from employee
order by salary desc;
--16
select top 2 d.dname, count(e.ssn) as num_employees
from departments d
join employee e on e.dno = d.dnum
group by d.dname
order by count(e.ssn) desc;
--17
select p.Pname ,count(e.SSN) [Num_employee]
from Project p inner join 
Works_for w on p.Pnumber = w.Pno inner join
Employee e on e.SSN = w.ESSn
group by p.Pname
--18
create view proj as 
select p.Pnumber
from Project p

delete from proj
where Pnumber = 1
--19
create view employee_view as
select ssn, fname, lname, salary, dno
from employee;


update employee_view
set salary = salary * 1.10
where fname = 'john' and lname = 'smith';
--20
select e.fname+ ' ' + e.lname, e.salary, d.dname
from employee e
join departments d on e.dno = d.dnum
where e.salary > (
    select avg(e2.salary)
    from employee e2
    where e2.dno = e.dno)