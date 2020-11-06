using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            var nums = Enumerable.Range(0, 7).ToArray();
            var rnd = new Random();

            // Shuffle the array
            for (int i = 0; i < nums.Length; ++i)
            {
                int randomIndex = rnd.Next(nums.Length);
                int temp = nums[randomIndex];
                nums[randomIndex] = nums[i];
                nums[i] = temp;
            }

            // Now your array is randomized and you can simply print them in order
            for (int i = 0; i < nums.Length; ++i)
                Console.WriteLine(nums[i]);





            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("dddd" + "-" + "dd" + "-" + "M" + "-" + "yyyy"));


            Console.WriteLine("\r");
            Console.WriteLine("1-uge");
            Console.WriteLine("LYN-LOTTO");
            Console.WriteLine("\r");

            // Instantiate random number generator using system-supplied value as seed.
            var rand = new Random();


            for (int i = 0; i < 10; i++)
            {
                Console.Write("Value of i: {0}", i);
                for (int ctr = 0; ctr <= 4; ctr++)
                    Console.Write("{0,8:N0}", rand.Next(0, 10));
                Console.WriteLine();
            }












            //// Random random = new Random();
            //// char[] ch = "0123456789".ToCharArray();
            //// 
            //// for (int j = 0; j < 10; j++)
            //// {
            ////     string random_number_string = "";
            ////     for (int i = 0; random_number_string.Length != 2; i++)
            ////     {
            ////         int x = random.Next(0, ch.Length);
            ////         random_number_string += ch.GetValue(x).ToString();
            //// 
            ////     }
            ////     Console.WriteLine(random_number_string);
            //// 
            //// }


            Random ran = new Random();

            String b = "0123456789";

            int length = 2;

            String random = "";

            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(b.Length); //string.Lenght gets the size of string
                random = random + b.ElementAt(a);
            }

            Console.WriteLine("The random alphabet generated is: {0}", random);



            UniqueRandom u = new UniqueRandom(Enumerable.Range(1, 99));
            for (int j = 0; j < 10; j++)
            {
                Console.Write("{0} ", u.Next().ToString("D2"));
                Console.Write("{0} ", u.Next().ToString("D2"));
                Console.Write("{0} ", u.Next().ToString("D2"));
                Console.Write("{0} ", u.Next().ToString("D2"));
                Console.Write("{0} ", u.Next().ToString("D2"));
                Console.Write("{0} ", u.Next().ToString("D2"));
                Console.Write("{0} ", u.Next().ToString("D2"));
                Console.WriteLine();
            }
        }
    }





    class UniqueRandom
    {
        private readonly List<int> _currentList;
        private readonly Random _random = new Random();

        public UniqueRandom(IEnumerable<int> seed)
        {
            _currentList = new List<int>(seed);
        }

        public int Next()
        {
            if (_currentList.Count == 0)
            {
                throw new ApplicationException("No more numbers");
            }

            int j = _random.Next(_currentList.Count);
            int result = _currentList[j];
            _currentList.RemoveAt(j);
            return result;
        }
    }
}