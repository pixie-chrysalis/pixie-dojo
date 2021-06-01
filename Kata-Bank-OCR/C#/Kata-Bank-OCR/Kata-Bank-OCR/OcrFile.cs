using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kata_Bank_OCR
{
    public class OcrFile
    {
        OcrLine[] Source { get; }

        public OcrFile(string path)
        {
            var lines = File.ReadAllLines(path);

            Source = new OcrLine[lines.Length % 4 == 0 ? lines.Length / 4 : lines.Length / 4 + 1];

            for(int i = 0; i < Source.Length; i++)
            {
                Source[i] = new OcrLine();
            }

            for(int i = 0; i < lines.Length; i++)
            {
                Source[i / 4].Source[i % 4] = lines[i];
            }
        }

        public int[][] GetParsedNumbers() => Source.Select(x => x.GetParsedLine()).ToArray();
    }
}
