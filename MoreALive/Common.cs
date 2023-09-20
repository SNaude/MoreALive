using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreALive
{
    public static class Common
    {
        public static bool CheckRun(Config config)
        {
            if (config.PauseScheduler)
                return true;

            var now = DateTime.Now;

            if (now.DayOfWeek == DayOfWeek.Monday && !config.mon) { return false; }
            if (now.DayOfWeek == DayOfWeek.Tuesday && !config.tue) { return false; }
            if (now.DayOfWeek == DayOfWeek.Wednesday && !config.wed) { return false; }
            if (now.DayOfWeek == DayOfWeek.Thursday && !config.thu) { return false; }
            if (now.DayOfWeek == DayOfWeek.Friday && !config.fri) { return false; }

            if (now.Hour > config.startHour && now.Hour < config.endHour)
                return true;
            if (now.Hour == config.startHour && now.Minute > config.startMinute)
                return true;
            if (now.Hour == config.endHour && now.Minute < config.endMinute)
                return true;

            return false;
        }
    }
}
