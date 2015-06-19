using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SideScroller
{
    class Block
    {
        Texture2D texture;
        public Rectangle Rect;
        Vector2 position;

        public void Init(Texture2D img, Vector2 pos)
        {
            this.texture = img;
            this.position = pos;
            this.Rect = new Rectangle((int)this.position.X, (int)this.position.Y, this.texture.Width, this.texture.Height);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}
