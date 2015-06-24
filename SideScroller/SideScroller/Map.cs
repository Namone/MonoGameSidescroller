using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
namespace SideScroller
{
    class Map
    {
        public Map()
        {
            List<String> stringArray = new List<String> { "G", "G", "G", "G", "G" };
            List<Block> blockMap = new List<Block>();
            Vector2 position = new Vector2(-128, 0);
        }
            /*
            foreach (String i in stringArray)
            {
                position.X += 128;
                if (i == "G")
                {
                    Block newBlock = new Block();
                    newBlock.Init(Content.Load<Texture2D>("PNG\\Ground\\Grass\\grass"), new Vector2(position.X, 400));
                    blockMap.Add(new Block());
                }
            }
        }
           */

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
