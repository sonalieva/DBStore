﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DBStructure.Data.Exceptions
{
    class NotFoundException:Exception 
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
