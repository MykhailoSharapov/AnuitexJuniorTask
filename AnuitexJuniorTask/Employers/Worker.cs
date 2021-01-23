// <copyright file="Worker.cs" company="MikeSharapov">
// Copyright (c) MikeSharapov. All rights reserved.
// </copyright>

using System;

namespace AnuitexJuniorTask
{
    /// <summary>
    /// Worker class.
    /// </summary>
    public class Worker : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Worker"/> class.
        /// </summary>
        /// <param name="firstName">First Name of worker.</param>
        /// <param name="lastName">Last Name of worker.</param>
        /// <param name="expierence">Expirience in company.</param>
        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        /// <summary>
        /// Some work of worker.
        /// </summary>
        public override void Work()
        {
            // "Product release";
        }
    }
}
