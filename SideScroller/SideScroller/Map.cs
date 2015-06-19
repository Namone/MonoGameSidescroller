using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SideScroller
{
    class Map
    {

        public void collisionCheck(Player x, Block y)
        {
            if (x.Rect.Intersects(y.Rect))
            {
                x.onGround = true;
            }
            else
            {
                x.onGround = false;
            }
        }
    }
}
