using System;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string usingQuoted = @"The ""use"" of quotations causes difficulties.";
            string notUsingQuoted = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine("Quoted: {0}\nNon-quoted: {1}",usingQuoted,notUsingQuoted);
        }
    }
}
