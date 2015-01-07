using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Skymetal
{
    class ResourceManager
    {
        protected Dictionary<String, Texture2D> mTextures;
        protected Dictionary<String, SoundEffect> mSoundEffects;
    }
}
