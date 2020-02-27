using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockData
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lines = File.ReadAllLines(@"..\..\StockData.csv");

            //foreach (var line in lines.Skip(1))
            //{
            //    var segments = line.Split(',');

            //    var tradeDate = DateTime.Parse(segments[1], CultureInfo.GetCultureInfo("en-GB"));
            //    Console.WriteLine(tradeDate.ToLongDateString());
            //}

            var now = DateTime.Now;

            TimeZoneInfo sydneyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");
            var sydney = TimeZoneInfo.ConvertTime(now, sydneyTimeZone);

            Console.WriteLine(now);
            Console.WriteLine(sydney);
            Console.ReadLine();
        }
    }
}
