// <copyright file="Worker.cs" company="MikeSharapov">
// Copyright (c) MikeSharapov. All rights reserved.
// </copyright>

using System;

namespace AnuitexJuniorTask
{
    /// <summary>
    /// Worker class.
    /// </summary>
    public class Taskmaster : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Taskmaster"/> class.
        /// </summary>
        /// <param name="firstName">First Name of taskmater.</param>
        /// <param name="lastName">Last Name of taskmaster.</param>
        public Taskmaster(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        /// <summary>
        /// Some work of task master.
        /// </summary>
        public override void Work()
        {
            //"Material purchasing";
        }

        /// <summary>
        /// TaskMaster check Workers.
        /// </summary>
        /// <returns>Message of start checking.</returns>
        public bool WorkersCheck()
        {
            Program.PrintLog("Start checking workers.");
            return false;
        }
    }
}
