namespace DebateTimers
{
    internal class Countdown
    {
        #region INTERNAL VARIABLES

        private readonly TimeSpan duration;
        private TimeSpan left;
        private bool running;

        #endregion

        #region CONSTRUCTORS

        public Countdown()
        {
            this.duration = TimeSpan.FromSeconds(30);
            this.left = this.duration;
            this.running = false;
        }

        public Countdown(int seconds)
        {
            this.duration = TimeSpan.FromSeconds(seconds);
            this.left = this.duration;
            this.running = false;
        }

        #endregion

        #region PROPERTIES

        public TimeSpan Duration
        {
            get 
            { 
                return duration; 
            }
        }

        public TimeSpan Left
        {
            get
            {
                return left;    
            }
        }

        public Boolean Running
        {
            get
            {
                return running;
            }
        }

        #endregion

        #region PUBLIC METHODS

        public void Start()
        {
            this.running = true;
        }

        public void Stop()
        {
            this.running = false;
        }

        public void Reset()
        {
            this.left = this.duration;
            this.running = false;
            CountdownReseted?.Invoke(this, EventArgs.Empty);
        }

        public void Update(TimeSpan elapsed)
        {
            if (this.running)
            {
                this.left -= elapsed;
                this.CountdownUpdated?.Invoke(this, EventArgs.Empty);
                if (this.left.Ticks <= 0)
                {
                    this.left = TimeSpan.Zero;
                    this.running = false;
                    this.CountdownFinished?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        #endregion

        #region EVENT HANDLERS

        public event EventHandler? CountdownUpdated;
        public event EventHandler? CountdownFinished;
        public event EventHandler? CountdownReseted;

        #endregion
    }
}
