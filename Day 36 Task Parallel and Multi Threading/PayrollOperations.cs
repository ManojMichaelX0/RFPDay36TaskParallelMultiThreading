using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_36_Task_Parallel_and_Multi_Threading
{
    public class PayrollOperations
    {
        public List<PayrollDetails> PayrollDetailList = new List<PayrollDetails>();

        //UC 5 without Thread
        public void addPayrollWithoutThread(List<PayrollDetails> payrollDataList)
        {
            payrollDataList.ForEach(payrollData =>
            {
                Stopwatch Time = new Stopwatch();
                Time.Start();
                Console.WriteLine("Payment Being Added  :" + payrollData.BasicPay);
                this.addToPayroll(payrollData);
                Time.Stop();
                Console.WriteLine("Payment added : " + payrollData.BasicPay + " ( Duration  : " + Time.Elapsed + ")");
            });
            Console.WriteLine(this.PayrollDetailList.ToString());
        }
        //UC 5, With Thread
        public void addPayrolllWithThread(List<PayrollDetails> payrollDataList)
        {
            payrollDataList.ForEach(payrollData =>
            {
                Task thread = new Task(() =>
                {
                    Stopwatch Time = new Stopwatch();
                    Time.Start();

                    Console.WriteLine("Payment Being Added  :" + payrollData.BasicPay);
                    this.addToPayroll(payrollData);
                    Time.Stop();
                    Console.WriteLine("Payment added : " + payrollData.BasicPay + " ( Duration : " + Time.Elapsed + ")");
                });
                thread.Start();
            });
            Console.WriteLine(this.PayrollDetailList.Count);
        }
        //UC 6 update Basic Pay Without Thread
        public void UpdatePayRollWithThread(List<PayrollDetails> payrollDataList)
        {

        }
        public void addToPayroll(PayrollDetails pay)
        {
            PayrollDetailList.Add(pay);

        }

    }
}
