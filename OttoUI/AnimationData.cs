using System;

namespace OttoUI
{
    public class AnimationData
    {
        public int LL = 90;
        public int RL = 65;
        public int LF = 120;
        public int RF = 90;
        public int Time = 200;

        public AnimationData()
        { }
        public AnimationData(string text)
        {
            FromString(text);
        }

        public override string ToString()
        {
            return "LL:" + LL + "-LF:" + LF + "-RL:" + RL + "-RF:" + RF + "-Time:" + Time;
        }

        public void FromString(string text)
        {
            foreach (var item in text.Split('-'))
            {
                var itemName = item.Split(':')[0];
                var itemValue = Int32.Parse(item.Split(':')[1]);
                switch (itemName)
                {
                    case "LL": LL = itemValue; break;
                    case "LF": LF = itemValue; break;
                    case "RL": RL = itemValue; break;
                    case "RF": RF = itemValue; break;
                    case "Time": Time = itemValue; break;
                }
            }
        }

        public AnimationData Clone()
        {
            return new AnimationData
            {
                LL = this.LL,
                RL = this.RL,
                LF = this.LF,
                RF = this.RF,
                Time = this.Time
            };
        }
    }
}
