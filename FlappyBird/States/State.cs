using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.States
{
    public abstract class State
    {
        protected Matrix matrix;
        protected Vector2 mouse;
        protected GameStateManager gameStateManager;

        protected State(GameStateManager gameStateManager)
        {
            this.gameStateManager = gameStateManager;
            matrix = new Matrix();
            mouse = new Vector2();
        }

        protected abstract void HandleInput();
        public abstract void Update(float dt);
        public abstract void Draw(SpriteBatch spriteBatch);
        public abstract void Dispose();
    }
}
