using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competició_Ping_Pong
{
    public class Player
    {
        public String id { get; set; }
        public String name { get; set; }
        public String picture { get; set; }
        public int points { get; set; }
        public int played { get; set; }

        public Player(String name_, String picture_)
        {
            name = name_;
            picture = picture_;
            points = 0;
            played = 0;
        }

        public Player()
        {
        }

        public override String ToString()
        {
            return name + " / " + picture + " / " + points + " / " + played;
        }

    }
}
