using System;
using System.Collections.Generic;
using System.Text;

namespace FILLWORDS
{
    class NewGame
    {   
        public void Name()
        {
            Console.Clear();
            Console.WriteLine("Введи своё имя:");
            string name = Console.ReadLine();
            Console.Clear();
            SearchingWords link666 = new SearchingWords();
            link666.SearchFile();
            link666.CreatingListOfWords();
            DrawingField linkDrawField = new DrawingField();
            linkDrawField.ParsingByLetters();
            linkDrawField.TheDrawingOfField();
            Interactionwithplayer link228 = new Interactionwithplayer();
            link228.KeyBoardMoves();




        }

    }
}
