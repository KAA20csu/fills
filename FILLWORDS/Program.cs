using System;

namespace FILLWORDS
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingMenu link = new DrawingMenu();
            link.DrawMenu();
            Selecting link2 = new Selecting();
            link2.SelectInMenu();
            NewGame linkNewGame = new NewGame();
            linkNewGame.Name();
            
        }
    }
}
