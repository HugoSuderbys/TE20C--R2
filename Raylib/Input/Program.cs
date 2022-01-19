using System;
using Raylib_cs;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starta grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

            Rectangle spelare = new Rectangle(100, 100, 50, 50);
            Rectangle fiende = new Rectangle(100, 100, 50, 50);
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                Raylib.DrawRectangleRec(spelare, Color.RED);
                Raylib.DrawRectangleRec(fiende, Color.GREEN);
                // Ritat ut på fönstret
                Raylib.EndDrawing();

                //Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    spelare.y -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    spelare.y += 5;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    fiende.x += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    fiende.x -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    fiende.y -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    fiende.y += 5;
                }
            }
        }
    }
}
