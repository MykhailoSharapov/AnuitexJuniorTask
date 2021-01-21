// <copyright file="Employee.cs" company="MikeSharapov">
// Copyright (c) MikeSharapov. All rights reserved.
// </copyright>
namespace AnuitexJuniorTask
{
    /// <summary>
    /// Abstract class with base field and functionality.
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// Base initialization of new employe.
        /// </summary>
        /// <param name="fullName">Full name of employee.</param>
        /// <param name="expierence">Expirience of work in years.</param>
        public Employee(string fullName, int expierence)
        {
            this.FullName = fullName;
            this.Expierence = expierence;
        }

        /// <summary>
        /// Gets or sets Full Name of employee.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets eprierence in years.
        /// </summary>
        public int Expierence { get; set; }

        /// <summary>
        /// Some work.
        /// </summary>
        public abstract void Work();
    }
}
