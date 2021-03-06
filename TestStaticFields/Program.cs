using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStaticFields
{
    class Config
    {
        public static string Token;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Repeat("Hello", 5)
                .Select(q =>
                {
                    return new Task(() =>
                    {
                        for (int i = 0; i < 10000; i++)
                        {
                            Config.Token = q;
                            Console.WriteLine(i);
                            Console.WriteLine(Config.Token);
                        }
                    },TaskCreationOptions.LongRunning);
                })
                .ToList()
                .ForEach(h => h.Start());
            Console.ReadKey();

        }
    }
}
