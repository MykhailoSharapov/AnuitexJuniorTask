using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuitexJuniorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker("Mike", 1);
            var workerone = new Worker("Sharapov", 1000);
            Console.WriteLine(worker.FullName);
            Console.WriteLine(worker.Expierence);

            Console.WriteLine("------------");
            var company = new Company();
            _ = company + worker;
            _ = company + worker;
            _ = company + worker;
            _ = company + worker;
            _ = company + worker;
            _ = company + worker;
            _ = company - workerone;
            _ = company - worker;
            _ = company + new TaskMaster("Qwew", 1000);
            _ = company + new TaskMaster("Qwea", 1000);
            _ = company + new TaskMaster("Qweb", 1000);
            Console.WriteLine(company.Employees.Count);
            Console.WriteLine(company.Contains(workerone));
            var resultlist = company.GetEmployersByType<Manager>();
            foreach (Employee employee in resultlist)
            {
                Console.WriteLine(employee.FullName);
            }

            var count = company.GetEmployersCountByType<TaskMaster>();
            Console.WriteLine(count);

            company.PrintEmployersList();
            Console.ReadKey();
        }
    }
}
