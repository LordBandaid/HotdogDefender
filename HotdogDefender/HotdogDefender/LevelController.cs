using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class LevelController
    {
        public List<ICharacter> actorList;

        public LevelController()
        {
            actorList = new List<ICharacter>();

            actorList.Add(new PlayerController());
        }

        public void Update(KeyboardState? kb)
        {

        }
    }
}
