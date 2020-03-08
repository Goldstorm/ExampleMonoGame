using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameDesktopGLGame.States
{
    public class BattleState : IGameState
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
            else if (Keyboard.GetState().IsKeyDown(Keys.T))
            {
                gameStateContext.SwitchGameState<TitleScreenState>();
            }
        }

        public void Draw(GameTime gameTime, GraphicsDevice graphicsDevice)
        {
            graphicsDevice.Clear(Color.Red);
        }

        public void OnEvent(IGameEvent gameEvent)
        {
            
        }
    }
}