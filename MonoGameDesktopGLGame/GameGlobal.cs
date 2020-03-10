using System;
using System.ComponentModel.Design.Serialization;
using Microsoft.Xna.Framework;

namespace MonoGameDesktopGLGame
{
    public class GameGlobal
    {
        public static GraphicsDeviceManager Window => instance.graphicsDeviceManager;
        private static GameGlobal instance;

        public static void Init(Game game)
        {
            if (instance == null)
            {
                instance = new GameGlobal {graphicsDeviceManager = new GraphicsDeviceManager(game)};
            }
            else
            {
                throw new Exception("Instance already created.");
            }
        }

        private GameGlobal()
        {
            //Nobody can make me, except me!
        }
        private GraphicsDeviceManager graphicsDeviceManager;
    }
}