using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW6.OOP.Classes
{
    public class Player:Device
    {
        public Format[] Formats { get; private set; }
        public Player(string model, int power, Format[] formats):base(model,power)
        {
            this.Formats = formats;
        }
        public override string ToString()
        {
            string descriptionFormat = "";
            for (int i = 0; i < this.Formats.Length; i++)
            {
                descriptionFormat = descriptionFormat + this.Formats[i].Name + " " + this.Formats[i].Bitrate + ",";

            }
            return $"{this.Id}. {this.GetType().Name} model {this.Model}, power {this.Power} W, playback formats: {descriptionFormat}";
        }
    }
}
