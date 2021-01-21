// <copyright file="Worker.cs" company="MikeSharapov">
// Copyright (c) MikeSharapov. All rights reserved.
// </copyright>

namespace AnuitexJuniorTask
{
    /// <summary>
    /// Worker class.
    /// </summary>
    public class Manager : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        /// <param name="fullName">Full Name of worker.</param>
        /// <param name="expierence">Expirience in years.</param>
        public Manager(string fullName, int expierence)
            : base(fullName, expierence)
        {
        }

        /// <summary>
        /// Some work of manager.
        /// </summary>
        /// <returns>Result of work.</returns>
        public override string Work()
        {
            return "Order collecting";
        }

        /// <summary>
        /// Task giving to someone.
        /// </summary>
        /// <returns>some verbal task.</returns>
        public string GiveTask()
        {
            return "Giving a task.";
        }
    }
}
