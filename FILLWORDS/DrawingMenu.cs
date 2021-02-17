using System;
using System.Collections.Generic;
using System.Text;

namespace FILLWORDS
{
    class DrawingMenu
    {
        public void DrawMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Title();
            NewGame();
            Continue();
            Rating();
            Exit();
        }
        public void Title()
        {
            Console.WriteLine($"{new string(' ', 45)}______ _____ _      _     _    _  _________________  _____ \n"
                       + $"{new string(' ', 45)}|  ___|_   _| |    | |   | |  | ||  _  | ___ \\  _  \\/  ___|\n"
                        + $"{new string(' ', 45)}| |_    | | | |    | |   | |  | || | | | |_/ / | | |\\ `--. \n"
                        + $"{new string(' ', 45)}|  _|   | | | |    | |   | |/\\| || | | |    /| | | | `--. \\ \n"
                        + $"{new string(' ', 45)}| |    _| |_| |____| |___\\  /\\  /\\ \\_/ / |\\ \\| |/ / /\\__/ /\n"
                        + $"{new string(' ', 45)}\\_|    \\___/\\_____/\\_____/\\/  \\/  \\___/\\_| \\_|___/  \\____/ ");
        }
        public void NewGame()
        {
            Console.WriteLine($"{new string(' ', 53)} _____              _____\n"
                            + $"{new string(' ', 53)}|     |___  _ _ _   |  __|___ _____ ___\n"
                            + $"{new string(' ', 53)}| | | | -_ | | | |  |  | | .'|     | -_|\n"
                            + $"{new string(' ', 53)}|_|___| ___|_____|  |____|__,|_|_|_|___|\n");
        }
        public void Continue()
        {
            Console.WriteLine($"{ new string(' ', 57)} _____          _   _\n"
                            + $"{new string(' ', 57)}|     |___ ___ | |_|_|__ ___ ___\n"
                            + $"{new string(' ', 57)}|   --| . |   |  _| |   | | | -_|\n"
                            + $"{new string(' ', 57)}|_____|___|_|_|_| |_|_|_|___|___|\n");
        }
        public void Rating()
        {
            Console.WriteLine($"{ new string(' ', 59)}   _____     _   _\n"         
                            + $"{new string(' ', 59)}  | __  |___| |_|_|___ ___\n"
                            + $"{new string(' ', 59)}  |    -| .'|  _| |   | . |\n"
                            + $"{new string(' ', 59)}  |__|__|__,|_| |_|_|_|_  |\n"
                            + $"{new string(' ', 59)}                      |___|\n");
        }
        public void Exit()
        {
            Console.WriteLine($"{ new string(' ', 65)}  _____    _ _\n"   
                            + $"{new string(' ', 65)}  | __|_ _|_| |_\n"
                            + $"{new string(' ', 65)}  | __|_'_| |  _|\n"
                            + $"{new string(' ', 65)}  |___|_,_|_|_| \n");
        }
        

    }
}
