using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MoreALive
{
    public enum KeyPressEnum
    {
        [EnumMember(Value = "NumLock")]
        NumLock = 1,

        [EnumMember(Value = "ScrollLock")]
        ScrollLock = 2,
    }

    public enum EndStateEnum
    {
        [EnumMember(Value = "On")]
        On = 1,

        [EnumMember(Value = "Off")]
        Off = 2,
    }

    public class Config
    {
        [JsonIgnore]
        public byte pressedKey;
        public bool endstatebool;

        public bool schedule = true;
        public int startHour = 0;
        public int startMinute = 0;
        public int endHour = 0;
        public int endMinute = 0;
        public int interval = 0;
        public KeyPressEnum keyPress;
        public EndStateEnum endState;
        public bool keepEndState = true;


        public void Setup()
        {
            if (File.Exists(@"Config.Json"))
            {
                string configFile = File.ReadAllText(@"Config.Json");
                Config _config = JsonConvert.DeserializeObject<Config>(configFile);
                schedule = _config.schedule;
                interval = _config.interval;
                keyPress = _config.keyPress;
                startHour = _config.startHour;
                startMinute = _config.startMinute;
                endHour = _config.endHour;
                endMinute = _config.endMinute;
                keepEndState = _config.keepEndState;
                endState = _config.endState;
                setKeyPress();
                setEndStatebool();
            }
            else
                CreateDefault();
        }

        public void CreateDefault()
        {
            schedule = false;
            interval = 120;
            keyPress = KeyPressEnum.NumLock;
            startHour = 08;
            startMinute = 30;
            endHour = 17;
            endMinute = 30;
            endState = EndStateEnum.On;
            keepEndState = true;
            setKeyPress();
            setEndStatebool();
            SaveSettings();

        }

        public void SaveSettings()
        {
            var configText = JsonConvert.SerializeObject(this);
            File.WriteAllText(@"Config.Json", configText);
        }

        private void setKeyPress()
        {
            switch (keyPress)
            {
                case KeyPressEnum.NumLock: pressedKey = (byte)Keys.NumLock; break;
                case KeyPressEnum.ScrollLock: pressedKey = (byte)Keys.Scroll; break;
            }
        }

        private void setEndStatebool()
        {
            switch (endState)
            {
                case EndStateEnum.On: endstatebool = true; break;
                case EndStateEnum.Off: endstatebool = false; break;
            }
        }

    }
}
