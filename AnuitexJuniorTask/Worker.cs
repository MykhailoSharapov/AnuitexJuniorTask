// <copyright file="Worker.cs" company="MikeSharapov">
// Copyright (c) MikeSharapov. All rights reserved.
// </copyright>

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
        /// <param name="fullName">Full Name of worker.</param>
        /// <param name="expierence">Expirience in years.</param>
        public Worker(string fullName, int expierence)
            : base(fullName,expierence)
        {
        }

        /// <summary>
        /// Some work of worker.
        /// </summary>
        /// <returns>Result of work.</returns>
        public override string Work()
        {
            return "Product release";
        }
    }
}
