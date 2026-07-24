using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace PhongKham.Helpers
{
    public static class DebounceManager
    {
        private static readonly Dictionary<string, Timer> _timers =
            new Dictionary<string, Timer>();

        public static void Execute(string key, int delay, Action action)
        {
            if (!_timers.TryGetValue(key, out Timer timer))
            {
                timer = new Timer();
                _timers.Add(key, timer);
            }

            timer.Stop();
            timer.Interval = delay;

            timer.Tick -= Timer_Tick;

            void Timer_Tick(object sender, EventArgs e)
            {
                timer.Stop();
                timer.Tick -= Timer_Tick;
                action();
            }

            timer.Tick += Timer_Tick;
            timer.Start();
        }
    }
}