﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Course> Schedule { get; set; }
    }
}
