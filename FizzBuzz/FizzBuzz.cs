using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    public class Kata
    {
        public string FizzBuzz(int num)
        {
            string result = "";
            if (num % 3 == 0) result += "fizz";
            if (num % 5 == 0) result += "buzz";
            if (result == "") return num.ToString(); else return result;
        }
    }
}
