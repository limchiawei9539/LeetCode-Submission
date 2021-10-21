using System;
using System.Collections.Generic;
using System.Linq;

namespace _380._Insert_Delete_GetRandom_O_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class RandomizedSet
        {

            public List<int> list;

            public RandomizedSet()
            {
                list = new List<int>();
            }

            public bool Insert(int val)
            {
                if (list.Any(x=>x == val))
                {
                    return false;
                }
                else
                {
                    list.Add(val);
                    return true; 
                }
            }

            public bool Remove(int val)
            {
                if (list.Any(x => x == val))
                {
                    list.Remove(val);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public int GetRandom()
            {
                var random = new Random();
                int index = random.Next(list.Count);
                return list[index];
            }
        }
    }
}
