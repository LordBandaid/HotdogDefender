using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class PlayerController : ICharacter
    {
        private int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        private Vector2 position;
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        private Direction direction;
        public Direction LookDirection
        {
            get { return direction; }
            set { direction = value; }
        }

        private Texture2D sprite;
        public Texture2D Sprite
        {
            get { return sprite; }
            set { sprite = value; }
        }

        public PlayerController()
        {
            Health = 100;
        }

        public void Update(KeyboardState? kb)
        {

        }

        public void Attack()
        {

        }

        public void Draw(SpriteBatch sb)
        {

        }

        //Dodge roll. Causes invulnerability during the action, but inability to shoot.
        private void Dodge()
        {

        }

        //Places a stationary drone, of type DroneType, at the player location
        private IDrone PlaceDrone(DroneType droneType)
        {
            //Replace with true return
            return null;
        }

        private void Equip()
        {

        }
    }
}
