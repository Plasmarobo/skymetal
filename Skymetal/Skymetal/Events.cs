using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skymetal
{
    class Event
    {
        protected String mName;

        public Dictionary<String, String> Properties;

        
        public Event(String name)
        {
            mName = name;
            Properties = new Dictionary<string, string>();
        }

        public String GetName()
        {
            return mName;
        }
    }

    class EventListener
    {

    }

    class EventManager
    {

    }
}
