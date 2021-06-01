using System;

namespace Kata_Bank_OCR
{
    class Program
    {
        static void Main(string[] args)
        {
            var theFile = new OcrFile("Test Cases.txt");

            foreach (var line in theFile.GetParsedNumbers())
            {
                Console.WriteLine($"[{string.Concat(line, ", ")}]");
            }
        }
    }
}
