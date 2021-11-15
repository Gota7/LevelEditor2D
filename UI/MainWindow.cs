using System;
using ImGuiNET;
using Raylib_cs;
using R = Raylib_cs.Raylib;

namespace LevelEditor2D.UI {

    public static class MainWindow {
        public const int BaseWidth = 1024;
        public const int BaseHeight = 576;
        private static ImguiController Controller = new ImguiController();
        public static Color ClearColor = Color.BLACK;

        // Construct the main window.
        static MainWindow() {
            R.SetConfigFlags(ConfigFlags.FLAG_WINDOW_RESIZABLE);
            R.InitWindow(BaseWidth, BaseHeight, "Level Editor 2D");
            Controller.Load(BaseWidth, BaseHeight);
        }

        // Run the main window.
        public static void Run() {

            // Run until should close.
            while (!R.WindowShouldClose()) {

                // Update frame.
                Controller.Update(R.GetFrameTime());
                DrawUI();

                // Draw stuff.
                R.BeginDrawing();
                R.ClearBackground(ClearColor);
                DrawGraphics();
                Controller.Draw();
                R.EndDrawing();

                // Update.
                Update();

            }

            // Cleanup.
            R.CloseWindow();
            Controller.Dispose();

        }

        // Draw background graphics.
        private static void DrawGraphics() {
            R.DrawText("Hello World!", 12, 12, 17, Color.RAYWHITE);
        }

        // Draw the ImGUI interface.
        private static void DrawUI() {
            ImGui.ShowDemoWindow();
        }

        // Update raylib.
        private static void Update() {

            // Check for resize.
            if (R.IsWindowResized()) {
                Controller.Resize(R.GetScreenWidth(), R.GetScreenHeight());
            }

        }
        
    }

}