using System;

namespace MonoGameDesktopGLGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new ExampleGame())
                game.Run();
        }
    }
}