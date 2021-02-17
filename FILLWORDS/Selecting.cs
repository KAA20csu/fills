using System;
using System.Collections.Generic;
using System.Text;

namespace FILLWORDS
{
    class Selecting
    {
        public void SelectInMenu()
        {
            ConsoleKeyInfo key1;
            int y = 0;
            do
            {
                Console.SetCursorPosition(0, y);
                key1 = Console.ReadKey();
                if (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.W) y--;
                if (key1.Key == ConsoleKey.DownArrow || key1.Key == ConsoleKey.S) y++;
                if (y < 0) y = 3;
                if (y > 3) y = 0;
                if (y == 0) SelectedNewGame();
                if (y == 1) SelectedContinue();
                if (y == 2) SelectedRating();
                if (y == 3) SelectedExit();
                if (key1.Key == ConsoleKey.Enter)
                {
                    SelectedStep(y);
                    if (y == 0)
                        break;
                }
            }
            while(key1.Key != ConsoleKey.Escape);

        }
        private void SelectedNewGame()
        {
            Console.Clear();
            DrawingMenu i = new DrawingMenu();
            i.Title();
            Console.ForegroundColor = ConsoleColor.White;
            i.NewGame();
            Console.ForegroundColor = ConsoleColor.Red;
            i.Continue();
            i.Rating();
            i.Exit();
        }
        private void SelectedContinue()
        {
            Console.Clear();
            DrawingMenu i = new DrawingMenu();
            i.Title();
            i.NewGame();
            Console.ForegroundColor = ConsoleColor.White;
            i.Continue();
            Console.ForegroundColor = ConsoleColor.Red;
            i.Rating();
            i.Exit();
        }
        private void SelectedRating()
        {
            Console.Clear();
            DrawingMenu i = new DrawingMenu();
            i.Title();
            i.NewGame();
            i.Continue();
            Console.ForegroundColor = ConsoleColor.White;
            i.Rating();
            Console.ForegroundColor = ConsoleColor.Red;
            i.Exit();
        }
        private void SelectedExit()
        {
            Console.Clear();
            DrawingMenu i = new DrawingMenu();
            i.Title();
            i.NewGame();
            i.Continue();
            i.Rating();
            Console.ForegroundColor = ConsoleColor.White;
            i.Exit();
            Console.ForegroundColor = ConsoleColor.Red;
        }
        private static void SelectedStep(int y)
        {
            Dummy link4 = new Dummy();
            if (y == 1) link4.Continue();
            if (y == 2) link4.Rating();
            if (y == 3) link4.Exit();
        }
    }
}
