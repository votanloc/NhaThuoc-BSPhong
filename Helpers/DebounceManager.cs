using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace PhongKham.Helpers
{
    public static class DebounceManager
    {
        private static readonly Dictionary<string, Timer> _timers = new();

        public static void Execute(string key, int delay, Action action)
        {
            if (!_timers.TryGetValue(key, out Timer timer))
            {
                timer = new Timer();
                _timers[key] = timer;
            }

            timer.Stop();
            timer.Interval = delay;

            EventHandler handler = null;

            handler = (s, e) =>
            {
                timer.Stop();
                timer.Tick -= handler;
                action();
            };

            timer.Tick += handler;
            timer.Start();
        }
    }
}