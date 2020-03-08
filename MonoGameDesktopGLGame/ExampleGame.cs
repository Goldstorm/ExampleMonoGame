﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameDesktopGLGame.States;

namespace MonoGameDesktopGLGame
{
    public class ExampleGame : Game, IGameStateContext
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private List<IGameState> gameStates = new List<IGameState>();
        private IGameState activeGameState;
        private IGameState nextGameState;

        public ExampleGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            this.graphics.PreferredBackBufferWidth = 1280;
            this.graphics.PreferredBackBufferHeight = 720;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            gameStates.Add(new TitleScreenState());
            gameStates.Add(new OverworldState());
            gameStates.Add(new BattleState());

            SwitchGameState<TitleScreenState>();
            base.Initialize();
        }

        protected override void LoadContent() 
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            activeGameState = nextGameState;
            activeGameState.Update(gameTime, this);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            activeGameState.Draw(gameTime, this.graphics.GraphicsDevice);
            base.Draw(gameTime);
        }

        public void SwitchGameState<T>() where T : IGameState
        {
            foreach (var givenState in gameStates)
            {
                if (givenState is T)
                {
                    nextGameState = givenState;
                }
            }
        }
        public void PublishGameEvent(IGameEvent gameEvent)
        {
            foreach (var state in gameStates)
            {
                state.OnEvent(gameEvent);
            }
        }
    }
}