using System;
using Raylib_cs;

namespace Scener
{
    class Program
    {
        static void Main(string[] args)
        {
                        // Initialisering
            //--------------------------------------------------------------------------------------
            const int fönsterB = 800;
            const int fönsterH = 450;

            Raylib.InitWindow(fönsterB, fönsterH, "raylib [cs]");
            Raylib.SetTargetFPS(60);

            // TODO: Infoga variabler och objekt här
            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------
                // TODO: Uppdatera variabler här
                //----------------------------------------------------------------------------------

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Raylib.Raywhite);

                Raylib.DrawText("Mitt första fönster!", 190, 200, 20, Raylib.Gray);

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
                
            }
        }
    }
}
