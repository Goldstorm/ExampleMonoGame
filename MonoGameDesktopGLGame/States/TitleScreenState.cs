using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameDesktopGLGame.States
{
    public class TitleScreenState : IGameState
    {
        public void Dispose()
        {
        }

        public void Update(GameTime gameTime, IGameStateContext gameStateContext)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.H))
            {
                gameStateContext.SwitchGameState<OverworldState>();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.B))
            {
                gameStateContext.SwitchGameState<BattleState>();
            }
        }

        public void Draw(GameTime gameTime, GraphicsDevice graphicsDevice)
        {
            graphicsDevice.Clear(Color.CornflowerBlue);
        }

        public void OnEvent(IGameEvent gameEvent)
        {
            
        }
    }
}