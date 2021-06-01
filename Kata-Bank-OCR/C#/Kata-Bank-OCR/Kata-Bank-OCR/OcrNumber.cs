using System.Linq;

namespace Kata_Bank_OCR
{
    public class OcrNumber
    {
        public char[,] Source { get; } = new char[4, 3];

        public int GetParsedNumber()
        {
            if (IsNumber(One)) return 1;
            if (IsNumber(Two)) return 2;
            if (IsNumber(Three)) return 3;
            if (IsNumber(Four)) return 4;
            if (IsNumber(Five)) return 5;
            if (IsNumber(Six)) return 6;
            if (IsNumber(Seven)) return 7;
            if (IsNumber(Eight)) return 8;
            if (IsNumber(Nine)) return 9;
            if (IsNumber(Zero)) return 0;

            return -1;
        }

        private bool IsNumber(char[,] number) => Source.Cast<char>().SequenceEqual(number.Cast<char>());

        private static readonly char[,] One = { { ' ', ' ', ' ' },
                                                { ' ', ' ', '|' },
                                                { ' ', ' ', '|' },
                                                { ' ', ' ', ' ' } };

        private static readonly char[,] Two = { { ' ', '_', ' ' },
                                                { ' ', '_', '|' },
                                                { '|', '_', ' ' },
                                                { ' ', ' ', ' ' } };

        private static readonly char[,] Three = { { ' ', '_', ' ' },
                                                  { ' ', '_', '|' },
                                                  { ' ', '_', '|' },
                                                  { ' ', ' ', ' ' } };

        private static readonly char[,] Four =  { { ' ', ' ', ' ' },
                                                  { '|', '_', '|' },
                                                  { ' ', ' ', '|' },
                                                  { ' ', ' ', ' ' } };

        private static readonly char[,] Five =  { { ' ', '_', ' ' },
                                                  { '|', '_', ' ' },
                                                  { ' ', '_', '|' },
                                                  { ' ', ' ', ' ' } };

        private static readonly char[,] Six = { { ' ', '_', ' ' },
                                                { '|', '_', ' ' },
                                                { '|', '_', '|' },
                                                { ' ', ' ', ' ' } };

        private static readonly char[,] Seven = { { ' ', '_', ' ' },
                                                  { ' ', ' ', '|' },
                                                  { ' ', ' ', '|' },
                                                  { ' ', ' ', ' ' } };

        private static readonly char[,] Eight = { { ' ', '_', ' ' },
                                                  { '|', '_', '|' },
                                                  { '|', '_', '|' },
                                                  { ' ', ' ', ' ' } };

        private static readonly char[,] Nine = { { ' ', '_', ' ' },
                                                 { '|', '_', '|' },
                                                 { ' ', '_', '|' },
                                                 { ' ', ' ', ' ' } };

        private static readonly char[,] Zero = { { ' ', '_', ' ' },
                                                 { '|', ' ', '|' },
                                                 { '|', '_', '|' },
                                                 { ' ', ' ', ' ' } };
    }
}
