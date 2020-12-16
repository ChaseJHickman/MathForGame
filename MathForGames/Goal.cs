using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using MathLibrary;

namespace MathForGames
{
    class Goal : Actor
    {
        private Sprite _sprite;

        public Goal(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.White)
            : base(x, y, icon, color)
        {
            _sprite = new Sprite("Images/goal.png");
        }

        public Goal(float x, float y, Color rayColor, char icon = ' ', ConsoleColor color = ConsoleColor.White)
            : base(x, y, rayColor, icon, color)
        {
            _sprite = new Sprite("Images/goal.png");
        }

        //private bool CheckPlayerDistance()
        //{
        //    float distance = (WorldPosition - WorldPosition).Magnitude;
        //    return distance <= 1;
        //}

        public override void Update(float deltaTime)
        {
            //if (CheckPlayerDistance())
            //    Game.SetGameOver(true);

            base.Update(deltaTime);
        }

        public override void Draw()
        {
            _sprite.Draw(_globalTransform);
            base.Draw();
        }
    }
}
