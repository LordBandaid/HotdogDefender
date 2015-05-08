using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HotdogDefender
{
    enum Direction
    {
        Up = 0,
        UpRight = 1,
        Right = 2,
        DownRight = 3, 
        Down = 4,
        DownLeft = 5,
        Left = 6,
        UpLeft = 7
    }

    interface ICharacter : GameObject
    {
        int Health { get; set; }
        Vector2 Position { get; set; }
        Direction LookDirection { get; set; }
        Texture2D Sprite { get; set; }

        void Update(KeyboardState? kb);
        void Attack();
        void Draw(SpriteBatch sb);
    }
}
