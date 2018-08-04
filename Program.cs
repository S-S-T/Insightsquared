    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;

namespace Palindrome
{// Devise a routine to handle an incoming pallindrome string value
    class Program
    {
        public static List<string> lstFinal = new List<string>();

        static public bool isPallindrome = false;
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter some text...");
            //string inputString = Console.ReadLine();            
            //handlePallindrome(inputString);
            List<string> last_month = new List<string>();
            List<string> this_month = new List<string>();
            last_month.Add("Connor");
            last_month.Add("Rose");
            last_month.Add("Stephen");
            this_month.Add("Stephen");
            this_month.Add("Rose");
            this_month.Add("Giovanna");
            handleLists(last_month, this_month);
        }
        // analyze the differences of the 2 lists; a SAME NAME = renewal, a MISSING NAME = cancellation, NEW NAME = new subscription
        public static void NameAndStatus(string matchname, string status)
        {
            var tuple2 = new Tuple<string, string>(matchname, status);
            // Console.WriteLine("{0}: {1}", tuple2.Item1, tuple2.Item2);  
            lstFinal.Add(tuple2.Item1 + ", " + tuple2.Item2);
            // return new Tuple<string, string>(matchname, status);
            // return lstFinal;
        }
        public static List<string> handleLists(List<string> _lastMonth, List<string> _thisMonth)
        {
            _lastMonth.Sort();
            _thisMonth.Sort();
            int counterThisMonth = 0;
            string strStatus = "";
            foreach (string name in _lastMonth)
            {
                string itemName = name;
                if (itemName == _thisMonth[counterThisMonth])
                {
                    strStatus = "Renewal";
                    NameAndStatus(itemName, strStatus);                  
                }
                counterThisMonth++;
            }
            counterThisMonth = 0;
            foreach (string name in _lastMonth)
            {
                string itemName = name;
                if (itemName != _thisMonth[counterThisMonth])
                {
                    strStatus = "Cancellation";
                    NameAndStatus(itemName, strStatus);
                }
                counterThisMonth++;
            }
            counterThisMonth = 0;
            foreach (string name in _thisMonth)
            {
                string itemName = name;
                if (itemName != _lastMonth[counterThisMonth])
                {
                    strStatus = "New Subscription";
                    NameAndStatus(itemName, strStatus);
                }
                counterThisMonth++;
            }
            //foreach (string status in lstFinal)
            //{
            //    if()
            //}

            return lstFinal;
            //return Tuple.Create("1", "2");
        }

        public static bool handlePallindrome(string _inputString)
        {// function to return true if input string is pallindromic
            string first = _inputString.Substring(0, _inputString.Length / 2);
            char[] arr = _inputString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            if (first.Equals(second))
            {
                Console.WriteLine("YES, a pallindrome!");
                Console.ReadKey(true);
                return true;
            }
            else
            {
                Console.WriteLine("NOT a pallindrome!");
                Console.ReadKey(true);
                return false;
            }
        }
    }
}
