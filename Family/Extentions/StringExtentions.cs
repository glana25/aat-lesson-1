using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyStats.Extentions
{
   public static  class StringExtentions
    {
        public static string SayHello(this string name)
        {
            return $"Hello{name}.";
        }
        public static bool CheckZip(this string zip)
        {
            //return zip.Length == 5 || zip.Length == 9;
            var isValid = zip.Length == 5 || zip.Length == 9;
            if (isValid)
            {
                if(!Int32.TryParse(zip,out int n))
                {
                    isValid = false;
                }
            }
            return isValid;
            
        }
    }

}
