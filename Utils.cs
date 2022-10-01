using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    /*
     * common functions which are being used around the project
     * should be defined here
    */
    public static class Utils
    {
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
