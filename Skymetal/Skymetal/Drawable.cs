using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.IO;


namespace Skymetal
{
    struct Frame
    {
        public Rectangle mSource;
        public Int32 mDuration;

        public void Read(FileStream file)
        {
            BinaryReader reader = new BinaryReader(file);
            mSource.X = reader.ReadInt32();
            mSource.Y = reader.ReadInt32();
            mSource.Width = reader.ReadInt32();
            mSource.Height = reader.ReadInt32();
            mDuration = reader.ReadInt32();
        }

        public void Write(FileStream file)
        {
            BinaryWriter writer = new BinaryWriter(file);
            writer.Write((Int32)mSource.X);
            writer.Write((Int32)mSource.Y);
            writer.Write((Int32)mSource.Width);
            writer.Write((Int32)mSource.Height);
            writer.Write((Int32)mDuration);
        }
    }
    class Animation
    {
        protected List<Frame> mAnimation;
        protected IEnumerator<Frame> mFrames;
        protected float mTime;
        Boolean mLoop;
        Boolean mFinished;

        public Animation()
        {
            mFinished = false;
            mLoop = false;
            mTime = 0;
            mAnimation = new List<Frame>();
            mFrames = mAnimation.GetEnumerator();
        }

        public void AddFrame(Frame frame)
        {
            mAnimation.Add(frame);
        }

        protected void Advance(float milliseconds)
        {
            if (!mFinished)
            {
                mTime += milliseconds;
                while (mTime > mFrames.Current.mDuration)
                {
                    mTime -= mFrames.Current.mDuration;
                    if (!mFrames.MoveNext())
                    {
                        if (mLoop)
                        {
                            mFrames.Reset(); mFrames.MoveNext();
                        }
                        else
                        {
                            mFinished = true;
                            return;
                        }
                    }
                }
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch batch, Texture2D image, Vector3 pos, float rotation, Vector2 origin, SpriteEffects effects)
        {
            if (!mFinished)
            {
                var delta = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
                Advance(delta);
                batch.Draw(image, new Rectangle((int)(pos.X+0.5), (int)(pos.Y+0.5), mFrames.Current.mSource.Width, mFrames.Current.mSource.Height), mFrames.Current.mSource, Color.Pink, rotation, origin, effects, pos.Z);
            }
        }

        public void Write(FileStream file, String name)
        {
            BinaryWriter writer = new BinaryWriter(file);
            writer.Write(name);
            writer.Write((Int32)mAnimation.Count);
            foreach (Frame frame in mAnimation)
            {
                frame.Write(file);
            }
        }

        public String Read(FileStream file)
        {
            mAnimation = new List<Frame>();
            String name;
            BinaryReader reader = new BinaryReader(file);
            name = reader.ReadString();
            Int32 count = reader.ReadInt32();
            for (Int32 i = 0; i < count; ++i)
            {
                Frame f = new Frame();
                f.Read(file);
                mAnimation.Add(f);
            }
            return name;
        }

    }


    class Drawable
    {
        protected Texture2D mImage;
        protected Vector3 mPosition;
        protected Dictionary<String, Animation> mAnimations;
        protected String mAnimationState;
        protected float mRotation;
        protected Vector2 mOrigin;
        protected SpriteEffects mEffects;

        public void LoadImage(ContentManager content, String name)
        {
            mImage = content.Load<Texture2D>(name);
        }

        public void Draw(GameTime gameTime, SpriteBatch batch)
        {
            Animation anim;
            if(mAnimations.TryGetValue(mAnimationState, out anim))
            {
                anim.Draw(gameTime, batch, mImage, mPosition, mRotation, mOrigin, mEffects);
            }
        }
    }
}
