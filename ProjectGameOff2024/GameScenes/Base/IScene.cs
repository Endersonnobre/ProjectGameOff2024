using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProjectGameOff2024.GameScenes.Base
{
    public interface IScene
    {

        public void Update(GameTime gameTime);

        public void Draw(SpriteBatch spriteBatch);
    }
}
