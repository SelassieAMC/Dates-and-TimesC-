using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_and_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var contractDate = new DateTimeOffset(2020, 2, 29, 0, 0, 0, TimeSpan.Zero);

            Console.WriteLine(contractDate);

            contractDate = ExtendContract(contractDate, 1);
            Console.WriteLine(contractDate);
            Console.ReadLine();
        }

        private static DateTimeOffset ExtendContract(DateTimeOffset contractDate, int months)
        {
            var newContractDate = contractDate.AddMonths(months).AddTicks(-1);

            return new DateTimeOffset(newContractDate.Year,
                    newContractDate.Month,
                    DateTime.DaysInMonth(newContractDate.Year, newContractDate.Month),
                    23, 59, 59, contractDate.Offset
                );
        }
    }
}
