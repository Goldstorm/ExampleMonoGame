using System;
using System.ComponentModel.Design.Serialization;
using Microsoft.Xna.Framework;

namespace MonoGameDesktopGLGame
{
    public class GlobalGameWindow
    {
        public static GraphicsDeviceManager Window => instance.graphicsDeviceManager;
        private static GlobalGameWindow instance;

        public static void Init(Game game)
        {
            if (instance == null)
            {
                instance = new GlobalGameWindow {graphicsDeviceManager = new GraphicsDeviceManager(game)};
            }
            else
            {
                throw new Exception("Instance already created.");
            }
        }

        private GlobalGameWindow()
        {
            //Nobody can make me, except me!
        }
        private GraphicsDeviceManager graphicsDeviceManager;
    }
}