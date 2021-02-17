using System;
using System.Collections.Generic;
using System.Text;

namespace FILLWORDS
{
    class DrawingField
    {
        public void ParsingByLetters()
        {
            AllData.Bykvi = new List<string>();
            AllData.Field = new string[5, 5];
            for(int i = 0; i<AllData.Slova.Count; i++)
            {
                for(int j = 0; j<AllData.Slova[i].Length - 1; j++)
                {
                    AllData.Bykvi.Add(AllData.Slova[i][j].ToString());
                }
            }
            int IdOfList = 0;
            
            for(int i = 0; i<=4; i++)
            {
                if(i%2==0)
                    for(int j = 0; j<=4; j++)
                    {
                        AllData.Field[i, j] = AllData.Bykvi[IdOfList];
                        IdOfList++;
                    }
                else
                {
                    for(int j = 4; j>=0; j--)
                    {
                        AllData.Field[i, j] = AllData.Bykvi[IdOfList];
                        IdOfList++;
                    }
                }

            }
        }
        public void TheDrawingOfField()
        {
            Console.Write("┌─");
            for(int i = 0; i < 4; i++)
            {
                Console.Write("──┬─");
            }
            Console.WriteLine("──┐");
            
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write("│");
                    
                    if (i == AllData.y && j == AllData.x)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.Write($" {AllData.Field[i, j]} ");
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                Console.WriteLine("│");
                if (i<=3)
                {
                    Console.Write("├─");
                    for(int j = 0; j<4; j++)
                        Console.Write("──┼─");
                    Console.WriteLine("──┤");
                }
            }

            Console.Write("└─");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("──┴─");
            }
            Console.WriteLine("──┘");
        }
    }
    
}


