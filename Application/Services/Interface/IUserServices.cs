﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interface
{
    public interface IUserServices
    {
        public Guid? getUserId();
        public string? getUserName();
    }
}
