using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using MathLibrary;

namespace MathForGames
{
    class Goal : Actor
    {
        private Actor _player;

        public Goal(float x, float y, Actor player, Scene scene, char icon = ' ', ConsoleColor color = ConsoleColor.White)
            : base(x, y, scene, icon, color)
        {
            _player = player;
        }

        public Goal(float x, float y, Color rayColor, Actor player, Scene scene, char icon = ' ', ConsoleColor color = ConsoleColor.White)
            : base(x, y, scene, rayColor, icon, color)
        {
            _player = player;
        }

        private bool CheckPlayerDistance()
        {
            float distance = (_player.WorldPosition - WorldPosition).Magnitude;
            return distance <= 1;
        }

        public override void Update(float deltaTime)
        {
            if (CheckPlayerDistance())
                Engine.SetGameOver(true);

            base.Update(deltaTime);
        }
    }
}
