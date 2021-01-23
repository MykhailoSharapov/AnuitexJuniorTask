// <copyright file="Company.cs" company="MikeSharapov">
// Copyright (c) MikeSharapov. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace AnuitexJuniorTask
{
    /// <summary>
    /// Company class with list of employers.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        public Company()
        {
            this.Employees = new List<Employee>();
        }

        /// <summary>
        /// Gets or sets emloyers List which can contains Workers, taskmaster etc. look in folder Employers.
        /// </summary>
        public List<Employee> Employees { get; set; }

        public static Company operator +(Company company, Employee ee)
        {
            company.Employees.Add(ee);
            return company;
        }

        public static Company operator -(Company company, Employee ee)
        {
            company.Employees.Remove(ee);
            return company;
        }

        /// <summary>
        /// Get emloyers list ordered by type of employee.
        /// </summary>
        /// <typeparam name="T">Type of worker manager, worker etc.</typeparam>
        /// <returns>List of result.</returns>
        public List<T> GetEmployersByType<T>()
            where T : Employee
        {
            var result = new List<T>();
            foreach (Employee employee in this.Employees)
            {
                if (employee is T)
                {
                    result.Add(employee as T);
                }
            }

            return result;
        }

        /// <summary>
        /// Get emloyers count ordered by type of employee.
        /// </summary>
        /// <typeparam name="T">Type of worker manager, worker etc.</typeparam>
        /// <returns>Count.</returns>
        public int GetEmployersCountByType<T>()
            where T : Employee
        {
            var result = 0;
            foreach (Employee employee in this.Employees)
            {
                if (employee is T)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
