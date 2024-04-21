using System.ComponentModel;

namespace DebateTimers
{
    public partial class CountdownView : UserControl
    {
        #region INTERNAL VARIABLES

        private Countdown countdown = new();
        private Color foreColor;
        private Color backColor;
        private int secondsAlarm = -1;

        #endregion

        #region CONSTRUCTORS

        public CountdownView()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPERTIES

        [Description("Duration of countdown in seconds."), Category("data")]
        public int Seconds
        {
            get
            {
                return (int)this.countdown.Left.TotalSeconds;
            }
            set
            {
                this.countdown = new Countdown(value);
                this.countdown.CountdownUpdated += OnUpdate;
                this.countdown.CountdownFinished += OnFinish;
                this.countdown.CountdownReseted += OnUpdate;
                display.Text = this.countdown.Left.ToString("mm\\:ss");
            }
        }

        [Description("Background color."), Category("data")]
        public int SecondsAlarm
        {
            get
            {
                return secondsAlarm;
            }
            set
            {
                secondsAlarm = value;
            }
        }

        [Description("Name of the candidate."), Category("data")]
        public String Candidate
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                lblName.Text = value.Trim();
                lblName.Visible = lblName.Text.Length > 0;
            }

        }

        [Description("Font for the candidate name."), Category("data")]
        public Font CandidateFont
        {
            get
            {
                return this.lblName.Font;
            }
            set
            {
                this.lblName.Font = value;
            }
        }

        [Description("Text color."), Category("data")]
        public new Color ForeColor
        {
            get
            {
                return this.foreColor;
            }
            set
            {
                this.foreColor = value;
                this.display.ForeColor = value;
                this.lblName.ForeColor = value;
            }
        }

        [Description("Background color."), Category("data")]
        public new Color BackColor
        {
            get
            {
                return this.backColor;
            }
            set
            {
                this.backColor = value;
                this.display.BackColor = value;
                this.lblName.BackColor = value;
            }
        }

        public bool IsRunning
        {
            get
            {
                return this.countdown.Running;
            }
        }

        #endregion

        #region PUBLIC METHODS

        public void Start()
        {
            this.countdown.Start();
            this.display.ForeColor = foreColor;
            this.display.BackColor = backColor;
        }

        public void Stop()
        {
            this.countdown.Stop();
        }

        public void Reset()
        {
            this.countdown.Reset();
            this.display.ForeColor = foreColor;
            this.display.BackColor = backColor;
        }

        public void UpdateCountdown(TimeSpan lapse)
        {
            this.countdown?.Update(lapse);
            if (this.secondsAlarm >= 0)
            {
                if (this.countdown!.Running)
                {
                    if (this.countdown.Left.TotalSeconds == this.secondsAlarm) {
                        this.display.ForeColor = backColor;
                        this.display.BackColor = foreColor;
                    }
                }
                else
                {
                    this.display.ForeColor = foreColor;
                    this.display.BackColor = backColor;
                }

            }
        }

        public void OnUpdate(object? sender, EventArgs e)
        {
            display.Text = this.countdown?.Left.ToString("mm\\:ss");
        }

        public void OnFinish(object? sender, EventArgs e)
        {
            this.display.ForeColor = ForeColor;
            this.Finished?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region PRIVATE METHODS

        private void CountdownViewLoad(object? sender, EventArgs e)
        {
            this.countdown.CountdownUpdated += OnUpdate;
            this.countdown.CountdownFinished += OnFinish;
            this.countdown.CountdownReseted += OnUpdate;
            display.Text = this.countdown.Left.ToString("mm\\:ss");
        }

        #endregion

        private void DisplayDoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }

        #region EVENT HANDLERS

        public event EventHandler? Finished;

        #endregion
    }
}
