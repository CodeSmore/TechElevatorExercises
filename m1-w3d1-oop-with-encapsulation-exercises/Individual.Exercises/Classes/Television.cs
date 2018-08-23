using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        public Television()
        {
            IsOn = false;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }

        public bool IsOn
        {
            get;
            private set;
        }

        public int CurrentChannel
        {
            get;
            private set;
        }

        public int CurrentVolume
        {
            get;
            private set;
        }

        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }

        public void ChangeChannel(int newChannel)
        {
            if (IsOn && newChannel >= 3 && newChannel <= 18)
            {
                CurrentChannel = newChannel;
            }
        }

        public void ChannelUp()
        {
            if (IsOn)
            {
                CurrentChannel++;

                if (CurrentChannel > 18)
                {
                    CurrentChannel = 3;
                }
            }
        }

        public void ChannelDown()
        {
            if (IsOn)
            {
                CurrentChannel--;

                if (CurrentChannel < 3)
                {
                    CurrentChannel = 18;
                }
            }
        }

        public void RaiseVolume()
        {
            if (IsOn && CurrentVolume < 10)
            {
                CurrentVolume++;
            }
        }

        public void LowerVolume()
        {
            if (IsOn && CurrentVolume > 0)
            {
                CurrentVolume--;
            }
        }
    }
}
