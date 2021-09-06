using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskItAcademy
{
    public class LineWrireSweets : SweetsInTheShop
    {

        public List<string> sweetLine;
        public List<string> sweetLine2;
        public string SweetLine { get; set; }

        
        public LineWrireSweets()
        {

        }

        public void ReadLineSweet()
        {
            sweetLine = new List<string>();
            using (StreamReader sweetWord = new StreamReader(FileRead, System.Text.Encoding.Default))
            {

                while (!sweetWord.EndOfStream)
                {
                    sweetLine.Add(sweetWord.ReadLine());
                }
            }

            foreach (var value in sweetLine)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(value);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        
    }
}
