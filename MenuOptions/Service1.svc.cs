using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MenuOptions
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool PrimeNumber(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public string PrintHTMLTAGs(string tag, int data)
        {
            return $"<{tag}> {data} </{tag}>";
        }

        public string ReverseString(string str)
        {
            char[] reverse = str.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        public string SortNumbers(string sort, string data)
        {
            string str = "";
            List<string> numbers = data.Split(',').ToList();
            if (sort == "descending")
            {
                foreach (string digits in numbers)
                {
                    digits.OrderByDescending(i => i);
                    str = string.Join(",", digits);
                }
            }
            else
            {
                foreach (string digits in numbers)
                {
                    digits.OrderBy(i => i);
                    str = string.Join(",", digits);
                }
            }
            return str;
        }

        public int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
