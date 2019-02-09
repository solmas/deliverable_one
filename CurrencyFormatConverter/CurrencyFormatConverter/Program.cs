using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyFormatConverter
{
    class CurrencyConverter

    {
        static void Main(string[] args)
        {
            // I know there is a much better way of doing this, but at least its working for now
            double convBaht = 0;
            double convYen = 0;
            double convKro = 0;
            double avgAmount = 0;
            double minAmount = 0;
            double maxAmount = 0;
            double sumAmount = 0;
            double[] usd = new double[3];

            Console.WriteLine("Enter dollar amount A :");
            usd[0] = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter dollar amount B :");
            usd[1] = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter dollar amount C :");
            usd[2] = Double.Parse(Console.ReadLine());

            sumAmount = usd[0] + usd[1] + usd[2];
            Console.WriteLine("\n" + "Total amount is ");
            Console.WriteLine(sumAmount);

            minAmount = usd.Min();
            Console.WriteLine("\n" + "The minimum amount is ");
            Console.WriteLine(minAmount);

            maxAmount = usd.Max();
            Console.WriteLine("\n" + "The maximum amount is ");
            Console.WriteLine(maxAmount);

            avgAmount = (usd[0] + usd[1] + usd[2]) / 3;
            Console.WriteLine("\n" + "The average amount is ");
            Console.WriteLine(Math.Round(avgAmount, 2));

            // all conversion rates obtained via Google convert tool

            convKro = sumAmount * 9.17;
            Console.WriteLine("\n" + "Converted to Swedish Krona:");
            Console.WriteLine(Math.Round(convKro, 2));

            convYen = sumAmount * 109.76;
            Console.WriteLine("\n" + "Converted to Japanese Yen:");
            Console.WriteLine(Math.Round(convYen));

            convBaht = sumAmount * 31.23;
            Console.WriteLine("\n" + "Converted to Thai Baht:");
            Console.WriteLine(Math.Round(convBaht, 2));
        }
    }
}

