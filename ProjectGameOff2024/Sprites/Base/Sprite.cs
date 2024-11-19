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
        ContentManager _content;
        

        public Sprite(String spritePath, Rectangle destRect)
        {
            _sprite = this.LoadTexture(spritePath);
            _destRect = destRect;
        }

        public Texture2D LoadTexture(String texturePath)
        {
            return _content.Load<Texture2D>(texturePath);
        }

    }
}
