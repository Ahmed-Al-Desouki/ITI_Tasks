# ITI_Tasks
# C# ITI Tasks

This repository contains a collection of C# projects implemented as part of the **Information Technology Institute (ITI)** training program.  
Each project demonstrates a specific set of **Object-Oriented Programming (OOP)** concepts and gradually builds towards a complete system simulation.

---

## 📌 Projects

### 🔹 Program 1
- Create a **Company** class containing multiple **Departments**.
- Each department contains a list of **Employees**.
- Demonstrates **Aggregation**.

### 🔹 Program 2
- Link **Employees** with multiple **Courses** (**Association**).
- Implement **Composition** (e.g., Car contains an Engine).
- Print employees’ names, departments, and the courses they are enrolled in.

### 🔹 Program 3
- Create an **abstract class `Shape`** with an abstract method `Area()`.
- Implement **Circle** and **Rectangle** classes inheriting from `Shape`.
- Create an **interface `IDrawable`** with a method `Draw()`.
- Demonstrates **Polymorphism** by calling `Area()` and `Draw()` for different shapes.

### 🔹 Program 4
- Create a **static class `IdGenerator`** to auto-generate IDs for each new `Student` or `Instructor`.
- Create a **Grade class** with:
  - Overloaded `+` operator to calculate total grades.
  - Overloaded `==` and `!=` operators to compare grades.
- Create an **enum `CourseLevel { Beginner, Intermediate, Advanced }`**.
- When a student registers for a course, display a message based on its level:
  - Beginner → *"Good luck starting out!"*
  - Intermediate → *"Keep it up!"*
  - Advanced → *"This will be challenging!"*

### 🔹 Final System Simulation
- Combine all previous programs into a complete system:
  - A company has departments → each with employees and instructors.
  - Instructors teach different courses with levels.
  - Students register for courses and receive grades.
- Generate a **report** that displays:
  - Each student’s name + enrolled courses + total grades.
  - Each instructor’s name + the courses they teach.
  - Each department’s name + number of employees.

---

## 🎯 Learning Objectives
- Practical application of **OOP concepts** in C#:
  - Inheritance, Polymorphism, Abstraction, Encapsulation
  - Aggregation, Composition, Association
  - Operator Overloading
- Step-by-step practice on building structured systems.
- Strengthening problem-solving and design skills.

---

## 🛠️ Technologies Used
- **Language:** C#  
- **IDE:** Visual Studio  

---

## 📢 Notes
- These projects are part of the **tasks** required during the **ITI training program**.  
- Each program builds on the previous one, leading to a final integrated system simulation.  
