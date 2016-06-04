﻿using System.Collections.Generic;

namespace eManager
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}