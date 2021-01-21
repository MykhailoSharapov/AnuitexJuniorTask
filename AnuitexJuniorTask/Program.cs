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
            _ = company + workerone;
            _ = company - worker;
            Console.WriteLine(company.Employees.Count);
            Console.ReadKey();
        }
    }
}
