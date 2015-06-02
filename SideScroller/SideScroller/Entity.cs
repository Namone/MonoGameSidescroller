using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace SideScroller
{
    class Entity
    {
        public int Health;
        public bool isAlive;
        public Texture2D EntityTexture;
        public Vector2 Position;

        public int Width 
        {
            get { return EntityTexture.Width; }
        }

        public int Height
        {
            get { return EntityTexture.Height; }
        }
    }
}
