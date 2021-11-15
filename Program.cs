using System;
using ImGuiNET;
using Raylib_cs;
using R = Raylib_cs.Raylib;

namespace LevelEditor2D {
    class Program {
        static ImguiController Controller = new ImguiController();
        static void Main(string[] args) {
            const int screenWidth = 1024;
            const int screenHeight = 576;
            R.SetConfigFlags(ConfigFlags.FLAG_WINDOW_RESIZABLE);
            R.InitWindow(screenWidth, screenHeight, "Level Editor 2D");
            Controller.Load(screenWidth, screenHeight);
            while (!R.WindowShouldClose()) {
                Controller.Update(R.GetFrameTime());
                ImGui.ShowDemoWindow();
                R.BeginDrawing();
                R.ClearBackground(Color.BLACK);
                R.DrawText("Hello World!", 12, 12, 17, Color.RAYWHITE);
                Controller.Draw();
                R.EndDrawing();
            }
            Controller.Dispose();
            R.CloseWindow();
        }
    }
}
