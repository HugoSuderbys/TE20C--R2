using System;
using Raylib_cs;

namespace Fallande_objekt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------
            const int fönsterB = 800;
            const int fönsterH = 600;

            Raylib.InitWindow(fönsterB, fönsterH, "Snöflingor");
            Raylib.SetTargetFPS(60);

            // TODO: Infoga variabler och objekt här
            Random generator = new Random();

            Rectangle[] flingor = new Rectangle[100];

            int[] hastigheter = new int[100];

            for (int i = 0; i < flingor.Length; i++)
            {
                hastigheter[i] = generator.Next(1, 6);
            }

            for (int i = 0; i < flingor.Length; i++)
            {
                flingor[i] = new Rectangle(0, 0, 10, 10);
                flingor[i].x = generator.Next(0, fönsterB);
                flingor[i].y = generator.Next(0, fönsterH) - fönsterH;
            }
            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                for (int i = 0; i < flingor.Length; i++)
                {
                    flingor[i].y += hastigheter[i];
                    if (flingor[i].y > fönsterH)
                    {
                         flingor[i].y = 0;
                    }
                }

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);
                for (int i = 0; i < flingor.Length; i++)
                {
                    Raylib.DrawRectangleRec(flingor[i], Color.WHITE);
                    flingor[i].y += 1;
                }


                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}
