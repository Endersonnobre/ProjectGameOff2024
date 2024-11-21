using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;


namespace ProjectGameOff2024.Sprites.Base
{
    public class Sprite
    {
        Texture2D _sprite;
        Rectangle _destRect;
        ContentManager _contentManager;
        float velocity = 5.5f;
        

        public Sprite(String spritePath, Rectangle destRect, ContentManager contentManager)
        {
            _contentManager = contentManager;
            _sprite = this.LoadTexture(spritePath);
            _destRect = destRect;
        }

        public Texture2D LoadTexture(String texturePath)
        {
            return _contentManager.Load<Texture2D>(texturePath);
        }

        public void Update(GameTime gameTime)
        {
            var keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.A))
            {
                this.walkingLeft();
            }else if (keyboard.IsKeyDown(Keys.D))
            {
                this.walkingRight();
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_sprite, _destRect, Color.White);
        }

        public void walkingRight()
        {
            _destRect.X += (int)velocity;
        }

        public void walkingLeft()
        {
            _destRect.X -= (int)velocity;
        }

    }
}
