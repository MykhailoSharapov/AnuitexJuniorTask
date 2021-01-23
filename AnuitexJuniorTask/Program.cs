// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;

namespace AnuitexJuniorTask
{
    /// <summary>
    /// Progrram class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// EntryPoint of program.
        /// </summary>
        /// <param name="args">some args.</param>
        public static void Main(string[] args)
        {
            var company = FillCompanyList(5);
            company.PrintEmployersList();
            company = RemoveEmployers(company, 3);

            PrintLog("Removed 3 employers from company. \r\n Company list:");
            company.PrintEmployersList();

            PrintLog("Get employers by generic type manager:");
            GetWorkers<Manager>(company);

            PrintLog("Get employers by generic type task master:");
            GetWorkers<Taskmaster>(company);

            PrintLog("Get employers by generic type worker:");
            GetWorkers<Worker>(company);

            PrintLog("Get employers count by generic type TaskMaster:");
            GetWorkersCount<Taskmaster>(company);

            PrintLog("Get employers count by generic type Managers:");
            GetWorkersCount<Manager>(company);

            PrintLog("Get employers count by generic type Workers:");
            GetWorkersCount<Worker>(company);

            PrintLog("functionality succsesfull done work.");
            Console.ReadKey();
        }

        /// <summary>
        /// Printing Messages to user.
        /// </summary>
        /// <param name="message">message.</param>
        public static void PrintLog(string message)
        {
            Console.WriteLine(message);
        }

        private static Company FillCompanyList(int countemployers)
        {
            var company = new Company();
            for (var i = 0; i < countemployers; i++)
            {
                _ = company + new Worker("Test Worker Num", i.ToString());
                _ = company + new Manager("Test Manager Num", i.ToString());
                _ = company + new Taskmaster("Test TaskMaster Num", i.ToString());
            }

            PrintLog($"Add {countemployers * 3} employers:");
            return company;
        }

        private static Company RemoveEmployers(Company company, int count)
        {
            for (var i = 0; i < count; i++)
            {
                _ = company - company.Employees[company.Employees.Count-1];
            }

            return company;
        }

        private static void GetWorkers<T>(Company company)
            where T : Employee
        {
            var resultList = company.GetEmployersByType<T>();
            foreach (Employee employee in resultList)
            {
                PrintLog(employee.FullName);
            }
        }

        private static void GetWorkersCount<T>(Company company)
            where T : Employee
        {
            var count = company.GetEmployersCountByType<T>();
            PrintLog(count.ToString());
        }
    }
}
