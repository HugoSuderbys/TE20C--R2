using System;
using Raylib_cs;
namespace Bilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starta grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);


            Texture2D lincoln = Raylib.LoadTexture(@"./resurser/lincoln.png");
            Texture2D dandelion = Raylib.LoadTexture(@"./resurser/dandelion.png");


            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                //Rita ut en bild
                Raylib.DrawTexture(lincoln, 100, 100, Color.WHITE);
                Raylib.DrawTexture(dandelion, 200, 100, Color.WHITE);

                // Ritat ut på fönstret
                Raylib.EndDrawing();
            }
        }
    }
}
