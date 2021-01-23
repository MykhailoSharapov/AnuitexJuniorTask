// <copyright file="Worker.cs" company="MikeSharapov">
// Copyright (c) MikeSharapov. All rights reserved.
// </copyright>

using System;

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
        /// <param name="firstName">First Name of manager.</param>
        /// <param name="lastName">Last Name of manager.</param>
        public Manager(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        /// <summary>
        /// Some work of manager.
        /// </summary>
        public override void Work()
        {
            //Collecting order.
        }

        /// <summary>
        /// Task giving to someone.
        /// </summary>
        public void GiveTask()
        {
            Program.PrintLog("Task give");
        }
    }
}
