﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine.entity
{
    abstract class BaseEntity
    {
        public abstract Texture2D Texture { get; protected set; }
        public abstract Point Pos { get; protected set; }
        public abstract Point Scale { get; protected set; }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            var scale = new Point(Texture.Width * Scale.X, Texture.Height * Scale.Y);
            var destinationRectange = new Rectangle(Pos, scale);
            spriteBatch.Draw(Texture, destinationRectange, Color.White);
        }

        public virtual void Update(MonoEngine engine, GameTime gameTime) {}
    }
}
