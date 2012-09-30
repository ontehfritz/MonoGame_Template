using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

namespace maker
{
    public class MacGame : Game {
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;

        public MacGame() {
            graphics = new GraphicsDeviceManager (this);
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 600;
            Content.RootDirectory = "Content";
            graphics.IsFullScreen = false;   

        }

        protected override void Initialize () {
            base.Initialize();
            spriteBatch = new SpriteBatch(graphics.GraphicsDevice);
        }

        //protected override void Draw(GameTime gameTime) {
        //    graphics.GraphicsDevice.Clear(Color.CornflowerBlue);
        //}

        protected override void Update (GameTime gameTime){

            if(Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Escape)){
                Exit ();    
            }

            // TODO: Add your update logic here 
            //screenManager.Update(gameTime);
            base.Update (gameTime);
        }
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw (GameTime gameTime){
            graphics.GraphicsDevice.Clear (Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.End();

            base.Draw (gameTime);
        }
    }
}
