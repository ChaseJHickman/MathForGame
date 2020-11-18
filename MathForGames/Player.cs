﻿using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using MathLibrary;

namespace MathForGames
{
    class Player : Actor
    {
        private float _speed = 1;
        private Sprite _sprite;

        public float Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }


        public Player(float x, float y, Scene scene, char icon = ' ', ConsoleColor color = ConsoleColor.White)
            : base(x, y, scene, icon, color)
        {
            _sprite = new Sprite("Images/player.png");
        }

        public Player(float x, float y, Scene scene, Color rayColor, char icon = ' ', ConsoleColor color = ConsoleColor.White)
            : base(x, y, scene, rayColor, icon, color)
        {
            _sprite = new Sprite("Images/player.png");
        }

        public override void Update(float deltaTime)
        {
            int xVelocity = -Convert.ToInt32(Engine.GetKeyDown((int)KeyboardKey.KEY_A))
                + Convert.ToInt32(Engine.GetKeyDown((int)KeyboardKey.KEY_D));

            int yVelocity = -Convert.ToInt32(Engine.GetKeyDown((int)KeyboardKey.KEY_W))
                + Convert.ToInt32(Engine.GetKeyDown((int)KeyboardKey.KEY_S));

            Velocity = new Vector2(xVelocity, yVelocity);
            Velocity = Velocity.Normalized * Speed;

            //if (xVelocity >= 1)
            //{
            //    SetRotation(0);
            //}
            //else if (xVelocity <= -1)
            //{
            //    SetRotation(-(float)Math.PI);
            //}

            //if (yVelocity <= -1)
            //{
            //    SetRotation((float)Math.PI / 2);
            //}
            //else if (yVelocity >= 1)
            //{
            //    SetRotation((float)(3 * Math.PI / 2));
            //}

            
            //float dotproda = Vector2.DotProduct(Velocity, new Vector2 (1, 0));
            //float dotprodb = Vector2.DotProduct(Velocity, new Vector2(0, -1));
            //float angle = (float)Math.Acos(dotproda);
            //if(dotprodb < 0)
            //{
            //    angle = -angle;
            //}
            //SetRotation(angle);


            base.Update(deltaTime);
        }

        public override void Draw()
        {
            _sprite.Draw(_globalTransform);
            base.Draw();
        }
    }
}
