using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HotdogDefender
{
    enum DroneType
    {
        /*Drone Types:
            Sentry is a standard gun turret
            Barricade creates an imapassable area
            MedStation heals the player inside a small radius, breaks after charge is depleted
         */
        Sentry,
        Barricade,
        MedStation
    }

    interface IDrone : GameObject
    {
        Vector2 Position { get; set; }

        void Update();

    }
}
