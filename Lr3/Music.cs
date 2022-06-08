using System;

namespace Lr3
{
   public class Music
    {
       
       public string _number
       {
            get;
            set;
       }
       public string _name
       {
            get;
            set;
       }

        public bool _playorstop
        {
            get;
            set;
        }

        public Music()
        {

        }

        public Music( string number,string name)
        {
            _name = name;
            _number = number;
        }

        public virtual string optins()
        {
            return null;
        }

    }
}
