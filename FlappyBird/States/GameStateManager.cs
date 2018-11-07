using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.States
{
    public class GameStateManager
    {
        private readonly Stack<State> States;

        public GameStateManager()
        {
            States = new Stack<State>();
        }

        public void Push(State state)
        {
            States.Push(state);
        }

        public void Pop()
        {
            States.Pop();
        }

        public void Set(State state)
        {
            States.Pop();
            States.Push(state);
        }

        public void Update(float dt)
        {
            States.Peek().Update(dt);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            States.Peek().Draw(spriteBatch);
        }
    }
}
