using System;

namespace Lab_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var singleton = (string x) => new List<string>().Add(x);

            var _null = (List<string> x) => x.Count == 0;
            
            var snoc = (List<string> x, string y) => x.Add(y);

            var lenght = (List<string> x) =>
            {
                var len = 0;
                foreach (var elem in x)
                    len++;
                return len;
            };
        }
    }
}