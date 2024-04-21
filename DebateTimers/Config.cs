namespace DebateTimers
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }
        public Config(int entrance, int debate, int participation, int closure, int extra)
        {
            InitializeComponent();

            Entrance = entrance;
            Debate = debate;
            Participation = participation;
            Closure = closure;
            Extra = extra;

            nmEntrance.Value = entrance;
            nmDebate.Value = debate;
            nmParticipation.Value = participation;
            nmClosure.Value = closure;
            nmExtra.Value = extra;
        }

        public int Entrance { get; set; }
        public int Debate { get; set; }
        public int Participation { get; set; }
        public int Closure { get; set; }
        public int Extra { get; set; }
        public bool Confirmation { get; set; }

        private void CancelClick(object sender, EventArgs e)
        {
            Confirmation = false;
            Hide();
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            if (nmParticipation.Value <= nmDebate.Value)
            {
                Confirmation = true;
                Entrance = (int)nmEntrance.Value;
                Debate = (int)nmDebate.Value;
                Participation = (int)nmParticipation.Value;
                Closure = (int)nmClosure.Value;
                Extra = (int)nmExtra.Value;
                Hide();
            }
        }

        private void ValidateValueChanged(object sender, EventArgs e)
        {
            if (nmParticipation.Value > nmDebate.Value)
            {
                nmDebate.BackColor = Color.Red;
                nmParticipation.BackColor = Color.Red;
            }
            else
            {
                nmDebate.BackColor = SystemColors.Window;
                nmParticipation.BackColor = SystemColors.Window;
            }
        }
    }
}
