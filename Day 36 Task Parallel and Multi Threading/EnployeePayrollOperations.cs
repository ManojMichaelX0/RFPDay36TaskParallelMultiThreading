using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_36_Task_Parallel_and_Multi_Threading
{
    public class EnployeePayrollOperations
    {
        public List<EmployeeDetails> employeePolyeeDetailList = new List<EmployeeDetails>();

        //UC 1
        public void addEmployeeToPayroll(List<EmployeeDetails> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Console.WriteLine("Employee added : " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.employeePolyeeDetailList.ToString());
        }
        public void addEmployeeToPayroll(EmployeeDetails emp)
        {
            employeePolyeeDetailList.Add(emp);
        }

    }
}
