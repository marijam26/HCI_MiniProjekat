using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_MiniProjekat
{
    static class CsvReader
    {
        public static List<Currency> readCSVfile()
        {
            
            using (var reader = new StreamReader(@"./../../physical_currency_list.csv"))
            {
                List<Currency> currencies = new List<Currency>();
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    System.Console.WriteLine(values);
                    Currency currency = new Currency(values[0], values[1]);
                    currencies.Add(currency);
                }
                return currencies;

            }

        }
        



    }

    


}
