using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_36_Task_Parallel_and_Multi_Threading;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.Linq;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        //Test UC 1
        public void Given10Employee_WhenAddToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employees = new List<EmployeeDetails>();
            employees.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Eren", PhoneNumber: "8106529025", Address: "Attack On Titan", Department: "Survey Corpes", Gender: 'M', City: "shinsengumi", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Levi", PhoneNumber: "8106523333", Address: "Attack On Titan", Department: "Captian", Gender: 'M', City: "Wall Maria", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "Mikasa", PhoneNumber: "61065629025", Address: "Attack On Titan", Department: "Survey Corpes", Gender: 'f', City: "shinsengumi", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "Naruto", PhoneNumber: "8123429025", Address: "Naruto", Department: "Hokage", Gender: 'M',  City: "Leaf Village", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "Sasuke", PhoneNumber: "9123429025", Address: "Naruto", Department: "Shadow Hokage", Gender: 'M', City: "Leaf Village", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 6, EmployeeName: "Madara", PhoneNumber: "8003429025", Address: "Naruto", Department: "Uchiha Head", Gender: 'M', City: "Uchiha Clan", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 7, EmployeeName: "Luffy", PhoneNumber: "8123429025", Address: "OnePiece", Department: "Pirate", Gender: 'M', City: "Grand Blue", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 8, EmployeeName: "Zorro", PhoneNumber: "9123459025", Address: "OnePiece", Department: "Pirate Hunter", Gender: 'M', City: "Grand Blue", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 9, EmployeeName: "Nami", PhoneNumber: "8123429025", Address: "OnePiece", Department: "Navigator", Gender: 'F',City: "Grand Blue", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 10, EmployeeName: "Naruto", PhoneNumber: "8123429025", Address: "Naruto", Department: "Hokage", Gender: 'M', City: "Leaf Village", Country: "Anime"));

            //Uc 1 without Thread
            EnployeePayrollOperations employeePayrollOperations = new EnployeePayrollOperations();
            
            employeePayrollOperations.addEmployeeToPayroll(employees);

            //Uc 2 With Thread
            employeePayrollOperations.addEmployeeToPayrollWithThread(employees);

            
        }
        [TestMethod]
        //Test Uc 5
        public void Given10employee_ShowDuration()
        {
            List<PayrollDetails> empPayRoll = new List<PayrollDetails>();
            empPayRoll.Add(new PayrollDetails(EmployeeID: 1, BasicPay: 25000, Deductions: 200, TaxablePay: 200, Tax: 100, NetPay: 24000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 2, BasicPay: 250000, Deductions: 2000, TaxablePay: 2000, Tax: 1000, NetPay: 240000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 3, BasicPay: 20000, Deductions: 200, TaxablePay: 200, Tax: 100, NetPay: 19000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 4, BasicPay: 550000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 540000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 5, BasicPay: 500000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 490000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 6, BasicPay: 650000, Deductions: 500, TaxablePay: 1000, Tax: 10000, NetPay: 640000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 7, BasicPay: 50000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 40000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 8, BasicPay: 40000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 40000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 9, BasicPay: 460000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 45000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 10, BasicPay: 550000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 540000));

            //Without Thread
            PayrollOperations payrollOperations = new PayrollOperations();
            payrollOperations.addPayrollWithoutThread(empPayRoll);

            //With Thread
            payrollOperations.addPayrolllWithThread(empPayRoll);

            //UC 6 Without thread
            payrollOperations.UpdatePayWithoutThread(empPayRoll);
            //UC 6 With Thread
            payrollOperations.UpdatePayWithThread(empPayRoll);
           
        }
        
    }
}
