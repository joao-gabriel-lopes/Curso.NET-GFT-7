using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace extension_method.Models
{
    public static class IntExtensions
    {
        public static bool EPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}