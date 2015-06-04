using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace SideScroller
{
    class Entity
    {
        public bool isAlive; // is the entity still alive?

        // Data pertaining to each entity - 

        // I don't know if you have used Structs before... it is "basically" a class.
        // The way before, with a lot of variables, also works fine - this is cleaner and works better
        // for storing large portions of data. In our case, we could make a massive array of EntityTypes, all with
        // their own location, texture, height, width, health, stamina, etc. and it will be easier to store all that
        // data using a struct. If you have used structs then... ignore this :)
        public struct EntityType
        {
            //Ended up putting all them to public most of them to public O:
            //You can change it later if you see a better option
            public Vector2 Position;
            public Texture2D EntityTexture;
            public String TextureName;
            //protected float EntityHeight, EntityWidth; I don't think that's really necessary now with the rect
            protected Rectangle EntityRect;
            public int Health = 100, Stamina=100;

            public void LoadContent(ContentManager Content) {
                this.EntityTexture = Content.Load<Texture2D>(this.TextureName);
            }

            public void setEntityType(Vector2 pos, Texture2D texture, int health, int stamina)
            {
                this.Position = pos;
                this.EntityTexture = texture;
                this.EntityRect = new Rectangle((int)pos.X,(int)pos.Y,texture.Width, texture.Height);
                //this.EntityHeight = EH;
                //this.EntityWidth = EW;
                this.Health = health;
                this.Stamina = stamina;
            }


            internal void setEntityType(Vector2 vector2, string p1, Texture2D texture2D, int p2, int p3)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Move the player
        /// </summary>
        /// <param name="currentPos">Current position - to be changed and returned</param>
        /// <param name="state">Current state of keyboard - W, S, A, D, etc</param>
        /// <returns></returns>
        public EntityType moveEntity(EntityType typeOfEntity) {
            float movementFactor = 1.5f; // Helps for smooth movement?
            //float MAX_SPEED = 3f;
            float initialJumpTime = 0; // default... this compares to maxJumpTime
            float maxJumpTime = 3000f; // 3 seconds?
            KeyboardState state = Keyboard.GetState(); // To get keyboard input!

            // Hard to know if anything below works without a player to test it with. So we will see.

            // BEGIN PLAYER MOVEMENT
            // if entityType == player... run below code
            if (state.IsKeyDown(Keys.Space)) { // Jump
                while (initialJumpTime <= maxJumpTime) {

                }

            } else if (state.IsKeyDown(Keys.S)) { // Crouch?
                // Change player model and height...
            } else if (state.IsKeyDown(Keys.A)) { // Left
                
            } else if (state.IsKeyDown(Keys.D)) { // Right
       
            }
            // END PLAYER MOVEMENT

            return typeOfEntity;

        }

    }
}
