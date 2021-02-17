using System;
using System.Collections.Generic;
using System.Text;

namespace FILLWORDS
{
    class Interactionwithplayer
    {
        public void KeyBoardMoves()
        {

            DrawingField link2288 = new DrawingField();
            ConsoleKeyInfo key2;
            AllData.x = 0;
            AllData.y = 0;
            do
            {
                key2 = Console.ReadKey();

                MoveOnBoard(key2);
                Console.Clear();

                link2288.TheDrawingOfField();
                if (key2.Key == ConsoleKey.Enter)
                {
                    SelectedLetter();
                }
            }
            while (key2.Key != ConsoleKey.Escape);
        }
        private void SelectedLetter()
        {
            ConsoleKeyInfo key2;

            DrawingField link2288 = new DrawingField();

            do
            {
                key2 = Console.ReadKey();

                MoveOnBoard(key2);
                Console.Clear();
            

                link2288.TheDrawingOfField();
                //if (key2.Key == ConsoleKey.Enter) { }
                
            }
            while (key2.Key != ConsoleKey.Escape);
        }
        private void MoveOnBoard(ConsoleKeyInfo key2)
        {
            if (key2.Key == ConsoleKey.UpArrow || key2.Key == ConsoleKey.W) AllData.y--;
            if (key2.Key == ConsoleKey.DownArrow || key2.Key == ConsoleKey.S) AllData.y++;
            if (key2.Key == ConsoleKey.RightArrow || key2.Key == ConsoleKey.D) AllData.x++;
            if (key2.Key == ConsoleKey.LeftArrow || key2.Key == ConsoleKey.A) AllData.x--;

            if (AllData.y > 4) AllData.y = 0;
            if (AllData.y < 0) AllData.y = 4;
            if (AllData.x > 4) AllData.x = 0;
            if (AllData.x < 0) AllData.x = 4;
        }
    }
}
