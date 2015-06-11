using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SideScroller
{
    class Player : Entity
    {
        int Stamina;
        public void Initialize(Vector2 Pos, Texture2D img, int HP, int SP)
        {
            this.Position = Pos;
            this.Texture = img;
            this.Health = HP;
            this.Stamina = SP;
        }

        public override void Update()
        {
            float movementFactor = 1.5f; // Helps for smooth movement?
            //float MAX_SPEED = 3f;
            float initialJumpTime = 0; // default... this compares to maxJumpTime
            float maxJumpTime = 3000f; // 3 seconds?
            KeyboardState state = Keyboard.GetState(); // To get keyboard input!

            // Hard to know if anything below works without a player to test it with. So we will see.

            // BEGIN PLAYER MOVEMENT
            // if entityType == player... run below code
            if (state.IsKeyDown(Keys.Space))
            { // Jump

                //while (initialJumpTime <= maxJumpTime)
                //{

                //}
            }

            else if (state.IsKeyDown(Keys.S))
            { // Crouch?
                // Change player model and height...
            }
            else if (state.IsKeyDown(Keys.A) || state.IsKeyDown(Keys.Left))
            { // Left
                this.Position.X -= 5;
            }
            else if (state.IsKeyDown(Keys.D) || state.IsKeyDown(Keys.Right))
            { // Right
                this.Position.X += 5;
            }
            // END PLAYER MOVEMENT
        }
    }
}
