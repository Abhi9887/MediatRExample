﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Blogs.Commands.CreateUser
{
    public class UserVM
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


    }
}
