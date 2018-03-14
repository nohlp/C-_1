using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2_Task4
{
    class Auth
    {
        public Auth()
        {
        }

        public bool userCheck(string login,string password)
        {
            if (login=="root" && password == "GeekBrains") {
                return true;
            }
            return false;
        }
    }
}
