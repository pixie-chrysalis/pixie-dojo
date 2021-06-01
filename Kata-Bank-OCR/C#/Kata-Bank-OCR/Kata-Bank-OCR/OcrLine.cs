using System.Linq;

namespace Kata_Bank_OCR
{
    public class OcrLine
    {
        public string[] Source { get; } = new string[4];

        public int[] GetParsedLine()
        {
            var numbers = new OcrNumber[9];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new OcrNumber();
            }

            for(int i = 0; i < Source.Length; i++)
            {
                var sourceLine = Source[i];
                for(int j = 0; j < sourceLine.Length; j++)
                {
                    numbers[j / 3].Source[i, j % 3] = sourceLine[j];
                }
            }

            return numbers.Select(x => x.GetParsedNumber()).ToArray();
        }
    }
}
