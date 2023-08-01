﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Helpers
{
    public static class ErrorMessages
    {
        public static string NameTaken(string name)
        {
            return $"Name- {name} is already taken!";
        }
        public static string NotFoundId(int id,string entityName)
        {
            return $"There is no {entityName} with {id} id!";
        }
    }
}
