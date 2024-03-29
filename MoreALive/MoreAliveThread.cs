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
                if (!config.schedule || Common.CheckRun(config))
                {
                    PressKey(config.pressedKey);
                    PressKey(config.pressedKey);
                    KeepState();
                }
                Thread.Sleep(config.interval * 1000);
            }
        }

        public void KeepState()
        {
            if (config.keepEndState)
            {
                bool isOn = Control.IsKeyLocked((Keys)config.pressedKey);

                if(config.endstatebool != isOn)
                {
                    PressKey(config.pressedKey);
                }
            }
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
