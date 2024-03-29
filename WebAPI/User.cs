﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class User
    {
        public int Id { get ; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }
        public string Phone { get; set; }
        public int Role { get; set; }
        public string Email { get; internal set; }
    }
}