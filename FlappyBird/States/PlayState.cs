using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace FlappyBird.States
{
    class PlayState : State
    {
        private Texture2D bird;

        protected PlayState(GameStateManager gameStateManager) : base(gameStateManager)
        {
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        public override void Update(float dt)
        {
            throw new NotImplementedException();
        }

        protected override void HandleInput()
        {
            throw new NotImplementedException();
        }
    }
}
