using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HotdogDefender
{
    class LevelController
    {
        public List<ICharacter> actorList;
        public UIController uiControl;
        public List<GameObject> objectList; 

        public LevelController()
        {
            actorList = new List<ICharacter>();
            objectList = new List<GameObject>();

            actorList.Add(new PlayerController(this));
        }

        public void Update(KeyboardState? kb)
        {

        }
    }
}
