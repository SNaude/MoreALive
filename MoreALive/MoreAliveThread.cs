﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreALive
{
    public class MoreAliveThread
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private static ThreadStart moreAliveRef;
        private static Thread moreAliveThread;
        private static Config config;


        public void ThreadMain(ref Config configuration)
        {
            config = configuration;
            moreAliveRef = new ThreadStart(RunThread);
            moreAliveThread = new Thread(moreAliveRef);
            moreAliveThread.Start();
        }

        public void Start()
        {
            moreAliveThread.Resume();
        }

        public void Stop()
        {
            moreAliveThread.Suspend();
        }

        public void RunThread()
        {
            while (true)
            {
                if (CheckRun() || !config.schedule)
                {
                    PressKey(config.pressedKey);
                    PressKey(config.pressedKey);
                    Thread.Sleep(config.interval * 1000);
                }
            }
        }

        public bool CheckRun()
        {
            var now = DateTime.Now;
            if (now.Hour > config.startHour && now.Hour < config.endHour)
                return true;
            if (now.Hour == config.startHour && now.Minute > config.startMinute)
                return true;
            if (now.Hour == config.endHour && now.Minute < config.endMinute)
                return true;

            return false;
        }


        public void PressKey(byte key)
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;

            keybd_event(key, 0x45, KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event(key, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

    }
}