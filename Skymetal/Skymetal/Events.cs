using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLua;

namespace Skymetal
{
    class Event
    {
        protected String mName;
        protected DateTime mTimeStamp;
        public Dictionary<String, String> Properties;

        
        public Event(String name)
        {
            mName = name;
            mTimeStamp = DateTime.Now;
            Properties = new Dictionary<string, string>();
        }

        public String GetName()
        {
            return mName;
        }

        public DateTime GetTimeStamp()
        {
            return mTimeStamp;
        }

        public virtual String ToLuaTable()
        {
            String table = "event={";
            foreach (KeyValuePair<String, String> kvp in Properties)
            {
                table += kvp.Key + '=' + kvp.Value + ",";
            }
            table += "}";
            return table;

        }
    }

    class EventListener
    {
        protected Lua mLua;
        protected Dictionary<String, String> mProperties;
        protected Dictionary<String, String> mBehaviors;
        public virtual String ToLuaTable()
        {
            String table = "self={";
            foreach(KeyValuePair<String, String> kvp in mProperties)
            {
                table += kvp.Key + '=' + kvp.Value + ",";
            }
            table += "}";
            return table;

        }

        public void BeginEvents()
        {
            mLua = new Lua();
            mLua.DoString(ToLuaTable());
        }

        public void ProcessEvent(Event e)
        {
            String behavior = mBehaviors[e.GetName()];
            mLua.DoString(e.ToLuaTable());
            mLua.DoFile(behavior);
            
        }

        public void EndEvents()
        {
            LuaTable self = (LuaTable)mLua.DoString("return self")[0];
            foreach (var value in self)
            {
                //Get table members
                Console.WriteLine(value);
            }
        }
    }

    class EventManager
    {

    }
}
