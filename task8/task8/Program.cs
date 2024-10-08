 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double task1 = QuantityBtnInterval(2, 27, 4);
            Console.WriteLine(task1);

            var task2 =  FindMatchNumber("AABBCC");
            Console.WriteLine(task2);

            var task3 = compareTwoStrings("some random text", "it is some random text");
            Console.WriteLine(task3);

            var listSTR = new List<string> { "list", "listtt1" };
            var listInts = new List<int> { 22, 2, 25, 3, 22 };
            genMethod(listSTR);
            genMethod(listInts);

            getDigitsRecursively("1234");
            Console.WriteLine();
            var hasdbl = FindDublicates(listInts);
            Console.WriteLine(hasdbl);
            
        }
        static int QuantityBtnInterval(int min, int max, int exponent)
        {
            var qnt = 0;
            
            var minBase = Math.Pow(min, 1.0 / exponent);
            
            while(Math.Pow(Math.Ceiling(minBase) + qnt, exponent) < max)
            {
                qnt++;
            }
            return qnt;
        }

        static int FindMatchNumber(string a)
        {
            var Arr = a.ToCharArray();
            Array.Sort(Arr);

            var countMatches = 0;
            var count = 1;
            while(count < Arr.Count())
            {
                if (Arr[count-1] == Arr[count])
                {
                    countMatches++;
                    count += 2;
                } else
                {
                    count++;
                }
            }
            return countMatches;
        }

        static string compareTwoStrings(string a, string b) 
        
        {
            var arr1 = a.ToCharArray().Reverse().ToArray();
            var arr2 = b.ToCharArray().Reverse().ToArray();

            var arr3 = new char[arr1.Count()];
            var n = 0;
            while(n < arr1.Count())
            {
                if (arr1[n] == arr2[n])
                {
                    arr3[n] = arr1[n];
                    n++;
                }
                else { break; }
            }
            var str = arr3.Length > 0 ? new string(arr3.Reverse().ToArray()) : "No common characters ...";
            return str;

        }

        static void genMethod<T>(List<T> list)
        {
            if(typeof(T) == typeof(string))
            {
                foreach(var t in list)
                {
                    
                    Console.WriteLine(t.ToString().ToUpper());
                }
            }

            if (typeof(T) == typeof(int))
                
            {
                var sum = 0;
                foreach(var i in list)
                {
                    sum += Convert.ToInt32(i);

                }
                Console.WriteLine(sum);
            }

            if (typeof(T) == typeof(Boolean))
            {
                var middle = (list.Count - 1) / 2;
                var last = list.Count - 1;
                Console.WriteLine($"first element is {list[0]}");
                Console.WriteLine($"middle element is {list[middle]}");
                Console.WriteLine($"middle element is {list[last]}");
            }

        }

        static void getDigitsRecursively(string num)
        {
            var length = num.Length;
            var count = 0;
            if (count == length) 
            {
                //Console.Write(num[count-1]);
                return ;
            }
            
            if(count == length -1)
            {
                Console.Write(num[count]);
            }
            else
            {
                Console.Write($"{num[count]} -");
            }
            count++;
            getDigitsRecursively(num.Substring(count, length - 1));

        }

        static bool FindDublicates(List<int> lst)
        {
            bool hasDubl = false;

            

            for (int i = 0; i < lst.Count() -1; i++) 
            {
                for (int j = 1; j < lst.Count(); j++ )
                {
                    if (lst[i] == lst[j] && i != j) { hasDubl = true; break; }
                }
                
            }

            return hasDubl;
        }
      
    }
}
