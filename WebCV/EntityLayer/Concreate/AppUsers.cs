﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class AppUsers : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
