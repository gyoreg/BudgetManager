using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace budget.model
{
    public class HVBTransactionImporter
    {
        public static List<HVBTransaction> Import(string fileName)
        {
            var result = new List<HVBTransaction>();

            var fileData = File.ReadAllLines(fileName, Encoding.Unicode).ToList();
            var fileCultureInfo = new CultureInfo("de-DE");

            // remove header
            fileData.RemoveAt(0);

            foreach (var record in fileData)
            {
                var recordData = record.Split(';');
                var transaction = new HVBTransaction()
                {
                    //Kontonummer; Buchungsdatum; Valuta; Empfaenger 1; Empfaenger 2; Verwendungszweck; Betrag; Waehrung
                    AccountNumber = recordData[0],
                    BookingDate = DateTime.Parse(recordData[1],fileCultureInfo.DateTimeFormat),
                    Valuta = DateTime.Parse(recordData[2], fileCultureInfo.DateTimeFormat),
                    Receiver1 = recordData[3],
                    Receiver2 = recordData[4],
                    Note = recordData[5],
                    Amount = Double.Parse(recordData[6],fileCultureInfo.NumberFormat),
                    Currency = recordData[7]
                };
                result.Add(transaction);
            }

            return result;
        }
    }
}