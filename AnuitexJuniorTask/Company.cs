// <copyright file="Company.cs" company="MikeSharapov">
// Copyright (c) MikeSharapov. All rights reserved.
// </copyright>

namespace AnuitexJuniorTask
{
    using System.Collections.Generic;

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
            return null;
        }

        public static Company operator -(Company company, Employee ee)
        {
            company.Employees.Remove(ee);
            return null;
        }
    }
}
