using System;
using System.Collections.Generic;
using System.Text;

namespace DBStructure.Data.Exceptions
{
    class DataIsAlreadyExistsException:Exception
    {
        public DataIsAlreadyExistsException(string message):base(message)
        {

        }
    }
}
