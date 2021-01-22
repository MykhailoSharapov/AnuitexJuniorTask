// <copyright file="Company.cs" company="MikeSharapov">
// Copyright (c) MikeSharapov. All rights reserved.
// </copyright>

namespace AnuitexJuniorTask
{
    using System;

    /// <summary>
    /// Starter class for demonstrate functionality.
    /// </summary>
    public class Starter
    {
        /// <summary>
        /// Start demonstration functionality of task.
        /// </summary>
        public void StartDemonstration()
        {
            var worker = new Worker("worker 4", 4);
            var manager = new Manager("manager 4", 8);
            var taskMaster = new TaskMaster("TaskMaster 4", 12);
            Console.WriteLine("Add 12 employers:");
            var company = new Company();
            _ = company + new Worker("worker 1", 1);
            _ = company + new Worker("worker 2", 2);
            _ = company + new Worker("worker 3", 3);
            _ = company + worker;
            _ = company + new Manager("manager 1", 5);
            _ = company + new Manager("manager 2", 6);
            _ = company + new Manager("manager 3", 7);
            _ = company + manager;
            _ = company + new TaskMaster("TaskMaster 1", 9);
            _ = company + new TaskMaster("TaskMaster 2", 10);
            _ = company + new TaskMaster("TaskMaster 3", 11);
            _ = company + taskMaster;
            company.PrintEmployersList();
            Console.WriteLine($"Employers count : {company.Employees.Count}");
            _ = company - worker;
            _ = company - manager;
            _ = company - taskMaster;
            Console.WriteLine("Remove 3 employers from company. \r\n Company list:");
            company.PrintEmployersList();
            Console.WriteLine("Get employers by generic type manager:");
            var resultListManagers = company.GetEmployersByType<Manager>();
            foreach (Employee employee in resultListManagers)
            {
                Console.WriteLine(employee.FullName);
            }

            Console.WriteLine("Get employers by generic type task master:");
            var resultListTaskMasters = company.GetEmployersByType<TaskMaster>();
            foreach (Employee employee in resultListTaskMasters)
            {
                Console.WriteLine(employee.FullName);
            }

            Console.WriteLine("Get employers by generic type worker:");
            var resultlistWorkers = company.GetEmployersByType<Worker>();
            foreach (Employee employee in resultlistWorkers)
            {
                Console.WriteLine(employee.FullName);
            }

            Console.WriteLine("Get employers count by generic type TaskMaster:");
            var counttaskMasters = company.GetEmployersCountByType<TaskMaster>();
            Console.WriteLine(counttaskMasters);

            Console.WriteLine("Get employers count by generic type Managers:");
            var countManagers = company.GetEmployersCountByType<Manager>();
            Console.WriteLine(countManagers);

            Console.WriteLine("Get employers count by generic type Workers:");
            var countWorkers = company.GetEmployersCountByType<Worker>();
            Console.WriteLine(countWorkers);

            Console.WriteLine("functionality succsesfull done work.");
            Console.ReadKey();
        }
    }
}
