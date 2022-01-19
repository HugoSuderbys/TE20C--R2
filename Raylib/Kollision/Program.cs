using System;
using Raylib_cs;

namespace Kollision
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiera grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");
            Raylib.SetTargetFPS(60);

            // Skapa slumpgeneratorn
            Random generator = new Random();
            int poäng = 0;

            Texture2D bill = Raylib.LoadTexture(@"bill.png");
            Texture2D lincoln = Raylib.LoadTexture(@"alien.png");
            /* Skapa objekt */
            // Skapa en spelare och en alien
            Rectangle spelare = new Rectangle(generator.Next(1, 300), generator.Next(1, 550), 48, 40);
            Rectangle fiende = new Rectangle(generator.Next(300, 750), generator.Next(1, 550), 64, 64);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                /* Rita ut grafiken */
                // Börja rita
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita ut objekt
                Raylib.DrawTexture(bill, Color.DARKPURPLE);
                Raylib.DrawRectangleRec(fiende, Color.LIME);


                Raylib.DrawText($"poäng {poäng}", 500, 50, 50, Color.GOLD);
                // ...
                if (Raylib.CheckCollisionRecs(spelare, fiende))
                {
                    Raylib.DrawText("kollision", 100, 200, 50, Color.GOLD);
                    fiende.x = (generator.Next(300, 750));
                    fiende.y = (generator.Next(1, 550));
                    poäng++;
                }
                // Ritat ut på fönstret
                Raylib.EndDrawing();


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
