using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FILLWORDS
{
    public class SearchingWords
    {
        public void SearchFile()
        {
            AllData.Words.AddRange(File.ReadAllText("Dictionary.txt").Split('\n'));
        }
        public void CreatingListOfWords()
        {
            AllData.Slova = new List<string>();

            Random rnd = new Random();

            int randomslovo;
            int kolbykv = 0;
            do
            {

                randomslovo = rnd.Next(0, AllData.Words.Count);
                AllData.Slova.Add(AllData.Words[randomslovo]);
                kolbykv += AllData.Words[randomslovo].Length - 1;
                if(kolbykv > 25)
                {
                    kolbykv = 0;
                    AllData.Slova.Clear();

                }
                if(kolbykv == 25)
                {
                    foreach(string k in AllData.Slova)
                    {
                        AllData.Words.Remove(k);
                    }
                }

            }
            while (kolbykv != 25);
           
    
        }
    }
}
