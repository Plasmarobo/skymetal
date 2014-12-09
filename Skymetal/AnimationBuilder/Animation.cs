using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationBuilder
{
    struct Frame
    {
        public Rectangle mSource;
        public Int32 mDuration;
        public string Description
        {
            get { return mSource.X.ToString() + "," + mSource.Y.ToString() + " " + mSource.Width.ToString() + "x" + mSource.Height.ToString() + " " + mDuration.ToString() + "ms"; } 
        }

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
        public List<Frame> mAnimation;
        public IEnumerator<Frame> mFrames;
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

        public void Write(FileStream file, String name)
        {
            BinaryWriter writer = new BinaryWriter(file);
            writer.Write(name);
            writer.Write((Int32)mAnimation.Count);
            foreach(Frame frame in mAnimation)
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
            for(Int32 i = 0; i < count; ++i)
            {
                Frame f = new Frame();
                f.Read(file);
                mAnimation.Add(f);
            }
            return name;
        }
    }
}
