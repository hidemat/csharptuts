using System;

namespace Stopwatch
{
    public class Timer
    {
        private bool _isActive = false;
        private DateTime _startTime;
        private DateTime _endTime;

        public TimeSpan Duration 
        { 
            get
            { 
                Stop();
                return _endTime - _startTime;
            }
        }

        public void Start()
        {
            if (!_isActive)
            {
                _startTime = DateTime.Now;
                _isActive = true;
            }
            else
            {
                throw new InvalidOperationException("You must stop before starting the timer again.\n");
            }
        }

        public void Stop()
        {
            if (_isActive)
            {
                _endTime = DateTime.Now;
                _isActive = false;
            }
        }
    }
}