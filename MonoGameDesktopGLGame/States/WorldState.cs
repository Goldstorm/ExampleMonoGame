using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameDesktopGLGame.States
{
    public class WorldState : IGameState
    {
        public void Dispose()
        {
        }

        public void Update(GameTime gameTime, IGameStateContext gameStateContext)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.B))
            {
                gameStateContext.SwitchGameState<BattleState>();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.T))
            {
                gameStateContext.SwitchGameState<TitleScreenState>();
            }        
        }

        public void Draw(GameTime gameTime)
        {
            GlobalGameWindow.Window.GraphicsDevice.Clear(Color.Beige);
        }
        
        public void OnEvent(IGameEvent gameEvent)
        {
            
        }
    }
}