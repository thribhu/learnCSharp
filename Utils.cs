using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public static class Utils
    {
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }
        
    }
}
