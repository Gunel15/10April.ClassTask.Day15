using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10April.ClassWork.Day15.Exceptions
{
    internal class WrongIdException(string message):Exception(message)
    {
    }
}
