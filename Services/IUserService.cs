﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Services
{
    public interface IUserService
    {
        List<User> GetAllUsers();
    }
}
