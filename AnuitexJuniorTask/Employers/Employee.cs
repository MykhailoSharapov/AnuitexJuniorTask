// <copyright file="Employee.cs" company="MikeSharapov">
// Copyright (c) MikeSharapov. All rights reserved.
// </copyright>
using System;

namespace AnuitexJuniorTask
{
    /// <summary>
    /// Abstract class with base field and functionality.
    /// </summary>
    public abstract class Employee
    {
        private readonly DateTime startWorkDate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// Base initialization of new employe.
        /// </summary>
        /// <param name="firstName">First name of employee.</param>
        /// <param name="lastName">Last name of employee.</param>
        /// <param name="expierence">Expirience of work in company.</param>
        protected Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = string.Empty;
            this.startWorkDate = DateTime.UtcNow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// Base initialization of new employe.
        /// </summary>
        /// <param name="firstName">First name of employee.</param>
        /// <param name="lastName">Last name of employee.</param>
        /// <param name="middleName">Middle name of employee.</param>
        /// <param name="expierence">Expirience of work in company.</param>
        protected Employee(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.startWorkDate = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets Full Name of employee.
        /// </summary>
        public string FullName => !string.IsNullOrEmpty(this.MiddleName) ? $"{this.FirstName} {this.MiddleName} {this.LastName}" : $"{this.FirstName} {this.LastName}";

        /// <summary>
        /// Gets or sets Fisrt Name of employee.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets Middle Name of employee.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets Last Name of employee.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets eprierence in years.
        /// </summary>
        public TimeSpan Expierence => DateTime.UtcNow - this.startWorkDate;

        /// <summary>
        /// Some work.
        /// </summary>
        public abstract void Work();
    }
}
