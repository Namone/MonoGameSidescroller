using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
namespace SideScroller
{
    class Player : Entity
    {
        EntityType player = new EntityType(); // Here is our struct coming into use
        // Should declare Player constants here!
        public Player() {
            //player.setEntityType(params)...
            player.TextureName = "";
            player.setEntityType(new Vector2(0, 0), player.EntityTexture, player.Health, player.Stamina);
        }
    }
}
