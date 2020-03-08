using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameDesktopGLGame
{
    public interface IGameState : IDisposable
    {
        void Update(GameTime gameTime, IGameStateContext gameStateContext);
        void Draw(GameTime gameTime, GraphicsDevice graphicsDevice);
        void OnEvent(IGameEvent gameEvent);
    }

    public interface IGameStateContext
    {
        // Your generic type T must implement the GameState Interface
        void SwitchGameState<T>() where T : IGameState;
        void PublishGameEvent(IGameEvent gameEvent);
    }
}