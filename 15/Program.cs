using System;
using System.Collections.Generic;

namespace Homework15
{
    public class Dictionary15
    {

        Dictionary<int, string> dict = new Dictionary<int, string>(7);

        public int Length() => dict.Count;
        public void Add(int key, string value)
        {
            try
            {
                dict.Add(key, value);

            }
            catch (ArgumentException)
            {
                Console.WriteLine($"{key} is already exists!");
            }

        }

        public string GetValue(int key)
        {
            return dict.TryGetValue(key, out string value) ? value : "not exists!";
        }

        public void Remove(int key)
        {
            try
            {
                dict.Remove(key);

            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine($"{key} not found!");
            }
        }
        public void Print()
        {
            foreach (KeyValuePair<int, string> pair in dict)
            {
                Console.WriteLine($"{pair.Key} | {pair.Value}");
            }

        }


    }
}

