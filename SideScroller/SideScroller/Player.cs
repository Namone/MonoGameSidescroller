using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

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
            KeyboardState keyState = Keyboard.GetState(); // To get keyboard input!

            // BEGIN PLAYER MOVEMENT
            // if entityType == player... run below code
            if (keyState.IsKeyDown(Keys.Space))
            { 
                // Jump
                //while (initialJumpTime <= maxJumpTime)
                //{
                //}
            }

            else if (keyState.IsKeyDown(Keys.S))
            { // Crouch?
                // Change player model and height...
            }
            else if (keyState.IsKeyDown(Keys.A))
            { // Left
                this.Position.X -= 5;
            }
            else if (keyState.IsKeyDown(Keys.D))
            { // Right
                this.Position.X += 5;
            }
            // END PLAYER MOVEMENT

            //Gravity
        }
    }
}
