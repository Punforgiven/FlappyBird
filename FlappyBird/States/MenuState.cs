using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace FlappyBird.States
{
    public class MenuState : State
    {
        private Texture2D background;
        private Texture2D playButton;

        public MenuState(GameStateManager gameStateManager, IServiceProvider serviceProvider) : base(gameStateManager)
        {
            content = new ContentManager(serviceProvider, "Content");
            background = content.Load<Texture2D>("Sprites/bg");
            playButton = content.Load<Texture2D>("Sprites/playbtn");
        }

        public ContentManager Content
        {
            get { return content; }
        }
        ContentManager content;

        public override void Draw(SpriteBatch spriteBatch)
        {   
            Vector2 vector2 = new Vector2(0, 0);
            Rectangle backgroundRectangle = new Rectangle(0, 0, Game1.WIDTH, Game1.HEIGHT);
            Rectangle playRectangle = new Rectangle((Game1.WIDTH/2) - (playButton.Width / 2), (Game1.HEIGHT / 2) - (playButton.Height), playButton.Width, playButton.Height);

            spriteBatch.Draw(background, backgroundRectangle, Color.White);
            spriteBatch.Draw(playButton, playRectangle, Color.White);
        }

        public override void Update(float dt)
        {
            //throw new NotImplementedException();
        }

        protected override void HandleInput()
        {
            //throw new NotImplementedException();
        }

        public override void Dispose()
        {
            background.Dispose();
            playButton.Dispose();
        }
    }
}
