// <copyright file="Company.cs" company="MikeSharapov">
// Copyright (c) MikeSharapov. All rights reserved.
// </copyright>

using System.Linq;

namespace AnuitexJuniorTask
{
    /// <summary>
    /// Extensions for work with emloyers list.
    /// </summary>
    public static class CompanyExtensions
    {
        /// <summary>
        /// Check is the current instance present employee in the company.
        /// </summary>
        /// <param name="company">Company class.</param>
        /// <param name="employee">Employee for check.</param>
        /// <returns>true or false result of linq contains method.</returns>
        public static bool Contains(this Company company, Employee employee)
        {
            return company.Employees.Contains<Employee>(employee);
        }

        /// <summary>
        /// Print employers list ro console.
        /// </summary>
        /// <param name="company">Company class.</param>
        public static void PrintEmployersList(this Company company)
        {
            foreach (Employee employee in company.Employees)
            {
                Program.PrintLog($"FullName: { employee.FullName}, Expirience: {employee.Expierence}");
            }
        }
    }
}
