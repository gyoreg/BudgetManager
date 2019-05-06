using System;

using budget.model;

namespace budget.cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = HVBTransactionImporter.Import(@"d:\Downloads\13451311_Umsatzliste.csv");

        }
    }
}
