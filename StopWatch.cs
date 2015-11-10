using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoshSection2Exercises
{
    class StopWatch
    {
        private DateTime _startTime;
        private TimeSpan _timeSpan;
        private bool _isRunning = false;

        public void Start()
        {
            if (this._isRunning == false)
            {
                this._startTime = DateTime.Now;
                this._isRunning = true;
            }
            else
                throw new InvalidOperationException("StopWatch is already running!!");
        }

        public void Stop()
        {
            var timeSpan = DateTime.Now;
            this._timeSpan = timeSpan - this._startTime;
            this._isRunning = false;
        }

        public TimeSpan GetDuration()
        {
            return this._timeSpan;
        }
       
    }
}
