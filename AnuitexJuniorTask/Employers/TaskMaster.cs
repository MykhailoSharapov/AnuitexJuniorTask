// <copyright file="Worker.cs" company="MikeSharapov">
// Copyright (c) MikeSharapov. All rights reserved.
// </copyright>

namespace AnuitexJuniorTask
{
    /// <summary>
    /// Worker class.
    /// </summary>
    public class TaskMaster : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskMaster"/> class.
        /// </summary>
        /// <param name="fullName">Full Name of worker.</param>
        /// <param name="expierence">Expirience in years.</param>
        public TaskMaster(string fullName, int expierence)
            : base(fullName, expierence)
        {
        }

        /// <summary>
        /// Some work of task master.
        /// </summary>
        /// <returns>Result of work.</returns>
        public override string Work()
        {
            return "Material purchasing";
        }

        /// <summary>
        /// TaskMaster check Workers.
        /// </summary>
        /// <returns>Message of start checking.</returns>
        public string WorkersCheck()
        {
            return "Start checking workers.";
        }
    }
}
