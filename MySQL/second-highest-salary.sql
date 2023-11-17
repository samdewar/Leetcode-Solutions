-- https://leetcode.com/problems/second-highest-salary/ Completed
# Write your MySQL query statement below
SELECT
(SELECT max(Salary)
FROM Employee
WHERE Salary < (SELECT max(Salary) FROM Employee)
)
AS SecondHighestSalary 
FROM dual;
