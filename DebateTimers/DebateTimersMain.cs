using DebateTimers.Properties;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DebateTimers
{
    public partial class Chronometers : Form
    {
        private enum State { Setup, Entrances, Debate, Closures };
        private State appState = State.Setup;

        private int ENTRANCE_TIME = 15;
        private int DEBATE_TIME = 600;
        private int PARTICIPATION_TIME = 90;
        private int CLOSURE_TIME = 60;
        private int EXTRA_TIME = 60;
        private float EXCESS_TIME = 0.2f;
        private int ENTRANCE_ALARM = -1;
        private int PARTICIPATION_ALARM = 15;
        private int CLOSURE_ALARM = -1;
        private int PANELS_SIZE = 70;
        private Color FORECOLOR = Color.FromArgb(92, 15, 139);
        private Color BACKCOLOR = Color.White;

        private readonly CountdownView[] countdowns = new CountdownView[9];
        private readonly Button[,] buttons = new Button[8, 3];
        private readonly RichTextBox[] textboxes = new RichTextBox[8];
        private readonly Panel[] panels = new Panel[8];
        private readonly TimeSpan lapse = TimeSpan.FromSeconds(1);
        private int selectedIndex = -1;

        #region CONSTRUCTORS

        public Chronometers()
        {
            InitializeComponent();
        }

        #endregion

        #region PRIVATE METHODS

        private void FormLoad(object sender, EventArgs e)
        {
            // Loads the countdown objects into an array
            countdowns[0] = countdown1;
            countdowns[1] = countdown2;
            countdowns[2] = countdown3;
            countdowns[3] = countdown4;
            countdowns[4] = countdown5;
            countdowns[5] = countdown6;
            countdowns[6] = countdown7;
            countdowns[7] = countdown8;
            countdowns[8] = countdownGeneral;
            // Loads the buttons into an array
            buttons[0, 0] = btnStart1; buttons[0, 1] = btnStop1; buttons[0, 2] = btnReset1;
            buttons[1, 0] = btnStart2; buttons[1, 1] = btnStop2; buttons[1, 2] = btnReset2;
            buttons[2, 0] = btnStart3; buttons[2, 1] = btnStop3; buttons[2, 2] = btnReset3;
            buttons[3, 0] = btnStart4; buttons[3, 1] = btnStop4; buttons[3, 2] = btnReset4;
            buttons[4, 0] = btnStart5; buttons[4, 1] = btnStop5; buttons[4, 2] = btnReset5;
            buttons[5, 0] = btnStart6; buttons[5, 1] = btnStop6; buttons[5, 2] = btnReset6;
            buttons[6, 0] = btnStart7; buttons[6, 1] = btnStop7; buttons[6, 2] = btnReset7;
            buttons[7, 0] = btnStart8; buttons[7, 1] = btnStop8; buttons[7, 2] = btnReset8;
            // Loads the textboxes into an array
            textboxes[0] = txtName1;
            textboxes[1] = txtName2;
            textboxes[2] = txtName3;
            textboxes[3] = txtName4;
            textboxes[4] = txtName5;
            textboxes[5] = txtName6;
            textboxes[6] = txtName7;
            textboxes[7] = txtName8;
            // Loads the controls panels into an array
            panels[0] = panel1;
            panels[1] = panel2;
            panels[2] = panel3;
            panels[3] = panel4;
            panels[4] = panel5;
            panels[5] = panel6;
            panels[6] = panel7;
            panels[7] = panel8;

            SuspendLayout();
            LoadSettings();
            ApplySettings();
            Setup();
            ResumeLayout();
        }

        private void FinishedCountdown(object? sender, EventArgs e)
        {
            CountdownView countdown = (CountdownView)sender!;
            int i = (int)countdown.Name.Last() - 49;
            textboxes[i].BackColor = SystemColors.Window;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            foreach (CountdownView countdown in countdowns)
            {
                countdown.UpdateCountdown(lapse);
            }
        }

        private void TimerConfig(object sender, EventArgs e)
        {
            if (appState == State.Setup)
            {
                Config config = new(ENTRANCE_TIME, DEBATE_TIME, PARTICIPATION_TIME, CLOSURE_TIME, EXTRA_TIME);
                config.ShowDialog();
                if (config.Confirmation)
                {
                    ENTRANCE_TIME = config.Entrance;
                    DEBATE_TIME = config.Debate;
                    PARTICIPATION_TIME = config.Participation;
                    CLOSURE_TIME = config.Closure;
                    EXTRA_TIME = config.Extra;
                }
                config.Close();
            }
        }

        #endregion

        #region PRIVATE METHODS (states)

        private void StateButtons()
        {
            rbSetup.BackColor = appState == State.Setup ? Color.Orange : SystemColors.Control;
            rbEntrances.BackColor = appState == State.Entrances ? Color.Orange : SystemColors.Control;
            rbDebate.BackColor = appState == State.Debate ? Color.Orange : SystemColors.Control;
            rbClosures.BackColor = appState == State.Closures ? Color.Orange : SystemColors.Control;

            rbSetup.Enabled = false;
            rbEntrances.Enabled = appState == State.Setup;
            rbDebate.Enabled = appState == State.Entrances;
            rbClosures.Enabled = appState == State.Debate;
        }

        private void Setup()
        {
            // Sets the state
            countdownGeneral.Candidate = "";
            appState = State.Setup;
            StateButtons();

            for (int i = 0; i < 8; i++)
            {
                // Disables all buttons
                buttons[i, 0].Enabled = false;
                buttons[i, 0].BackgroundImage = Resources.play_disabled;
                buttons[i, 1].Enabled = false;
                buttons[i, 1].BackgroundImage = Resources.stop_disabled;
                buttons[i, 2].Enabled = false;
                buttons[i, 2].BackgroundImage = Resources.reset_disabled;

                // Enables all text boxes
                textboxes[i].ReadOnly = false;

                // Hides or shows the countdown according its textbox
                countdowns[i].Visible = textboxes[i].Text.Length > 0;

                // Sets the names of the countdowns according their textboxes
                countdowns[i].Candidate = textboxes[i].Text;
            }
        }

        private void Entrances()
        {
            // Sets the state
            appState = State.Entrances;
            StateButtons();

            for (int i = 0; i < 8; i++)
            {
                // Enables start buttons, disables the rest
                buttons[i, 0].Enabled = true;
                buttons[i, 0].BackgroundImage = Resources.play;
                buttons[i, 0].Click += EntranceStartClick;
                buttons[i, 1].Enabled = false;
                buttons[i, 1].BackgroundImage = Resources.stop_disabled;
                buttons[i, 2].Enabled = false;
                buttons[i, 2].BackgroundImage = Resources.reset_disabled;

                // Hides the controls according to visible countdowns
                textboxes[i].ReadOnly = true;
                textboxes[i].Enter -= NamesEnter;
                textboxes[i].Leave -= NamesLeave;
                textboxes[i].KeyDown -= NamesKeyDown;
                textboxes[i].BackColor = SystemColors.Window;
                panels[i].Visible = countdowns[i].Visible;

                // Sets the countdowns
                countdowns[i].Seconds = ENTRANCE_TIME;
                countdowns[i].Finished += FinishedCountdown;
            }

            countdownGeneral.Seconds = ENTRANCE_TIME;
        }

        private void Debate()
        {
            // Sets the state
            appState = State.Debate;
            StateButtons();

            for (int i = 0; i < 8; i++)
            {
                // Enables play and reset, disables the rest
                buttons[i, 0].Enabled = true;
                buttons[i, 0].BackgroundImage = Resources.play;
                buttons[i, 0].Click -= EntranceStartClick;
                buttons[i, 0].Click += DebateStartClick;
                buttons[i, 1].Enabled = false;
                buttons[i, 1].BackgroundImage = Resources.stop_disabled;
                buttons[i, 1].Click += DebateStopClick;
                buttons[i, 2].Enabled = false;
                buttons[i, 2].BackgroundImage = Resources.reset_disabled;

                // Hide the controls according to visible countdowns
                textboxes[i].ReadOnly = true;
                textboxes[i].BackColor = SystemColors.Window;
                panels[i].Visible = countdowns[i].Visible;

                // Sets the countdowns
                countdowns[i].Seconds = DEBATE_TIME;
            }

            countdownGeneral.Seconds = PARTICIPATION_TIME;
        }

        private void Closures()
        {
            // Sets the state
            appState = State.Closures;
            StateButtons();

            for (int i = 0; i < 8; i++)
            {
                // Enables start buttons, disables the rest
                buttons[i, 0].Enabled = true;
                buttons[i, 0].BackgroundImage = Resources.play;
                buttons[i, 0].Click -= EntranceStartClick;
                buttons[i, 0].Click += ClosureStartClick;
                buttons[i, 1].Enabled = false;
                buttons[i, 1].BackgroundImage = Resources.stop_disabled;
                buttons[i, 1].Click -= DebateStopClick;
                buttons[i, 1].Click += ClosureStopClick;
                buttons[i, 2].Enabled = false;
                buttons[i, 2].BackgroundImage = Resources.reset_disabled;

                // Hides the controls according to visible countdowns
                textboxes[i].ReadOnly = true;
                textboxes[i].BackColor = SystemColors.Window;
                panels[i].Visible = countdowns[i].Visible;

                // Sets the countdowns
                countdowns[i].Seconds = CLOSURE_TIME;
            }

            countdownGeneral.Seconds = CLOSURE_TIME;
        }

        #endregion

        #region PRIVATE METHODS (button behaviour)

        private void EntranceStartClick(object? sender, EventArgs e)
        {
            Button button = (Button)sender!;
            int i = (int)button.Name.Last() - 49;
            int previousIndex = selectedIndex;

            if (!countdownGeneral.IsRunning || (MessageBox.Show("Está activo el cronómetro principal, ¿estás seguro de continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                selectedIndex = i;
                timerGeneral.Stop();
                timerGeneral.Start();
                countdownGeneral.Reset();
                countdownGeneral.Start();
                countdowns[i].Start();
                buttons[i, 0].Enabled = false;
                buttons[i, 0].BackgroundImage = Properties.Resources.play_disabled;
                textboxes[i].BackColor = Color.Orange;
                if (previousIndex >= 0)
                {
                    countdowns[previousIndex].Stop();
                    textboxes[previousIndex].BackColor = SystemColors.Window;
                }
            }
        }

        private void DebateStartClick(object? sender, EventArgs e)
        {
            Button button = (Button)sender!;
            int i = (int)button.Name.Last() - 49;
            int previousIndex = selectedIndex;

            if (selectedIndex != i)
            {
                countdownGeneral.Reset();
                selectedIndex = i;
            }
            timerGeneral.Stop();
            timerGeneral.Start();
            countdownGeneral.Start();
            countdowns[i].Start();
            buttons[i, 0].Enabled = false;
            buttons[i, 0].BackgroundImage = Properties.Resources.play_disabled;
            buttons[i, 1].Enabled = true;
            buttons[i, 1].BackgroundImage = Properties.Resources.stop;
            textboxes[i].BackColor = Color.Orange;
            if (previousIndex >= 0 && previousIndex != selectedIndex)
            {
                countdowns[previousIndex].Stop();
                buttons[previousIndex, 0].Enabled = true;
                buttons[previousIndex, 0].BackgroundImage = Properties.Resources.play;
                buttons[previousIndex, 1].Enabled = false;
                buttons[previousIndex, 1].BackgroundImage = Properties.Resources.stop_disabled;
                textboxes[previousIndex].BackColor = SystemColors.Window;

            }
        }

        private void DebateStopClick(object? sender, EventArgs e)
        {
            Button button = (Button)sender!;
            int i = (int)button.Name.Last() - 49;

            countdownGeneral.Stop();
            countdowns[i].Stop();
            buttons[i, 0].Enabled = true;
            buttons[i, 0].BackgroundImage = Properties.Resources.play;
            buttons[i, 1].Enabled = false;
            buttons[i, 1].BackgroundImage = Properties.Resources.stop_disabled;
        }

        private void ClosureStartClick(object? sender, EventArgs e)
        {
            Button button = (Button)sender!;
            int i = (int)button.Name.Last() - 49;
            int previousIndex = selectedIndex;

            if (!countdownGeneral.IsRunning || (MessageBox.Show("Está activo el cronómetro principal, ¿estás seguro de continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                selectedIndex = i;
                timerGeneral.Stop();
                timerGeneral.Start();
                countdownGeneral.Reset();
                countdownGeneral.Start();
                countdowns[i].Start();
                buttons[i, 0].Enabled = false;
                buttons[i, 0].BackgroundImage = Properties.Resources.play_disabled;
                textboxes[i].BackColor = Color.Orange;
                if (previousIndex >= 0)
                {
                    countdowns[previousIndex].Stop();
                    textboxes[previousIndex].BackColor = SystemColors.Window;
                }
            }
        }

        private void ClosureStopClick(object? sender, EventArgs e)
        {
            Button button = (Button)sender!;
            int i = (int)button.Name.Last() - 49;

            countdownGeneral.Stop();
            countdowns[i].Stop();
            buttons[i, 0].Enabled = true;
            buttons[i, 0].BackgroundImage = Properties.Resources.play;
            buttons[i, 1].Enabled = false;
            buttons[i, 1].BackgroundImage = Properties.Resources.stop_disabled;
        }

        private void EntrancesClick(object? sender, EventArgs e)
        {
            if (MessageBox.Show("¿ESTÁS SEGURO DE PASAR A LA FASE DE PRESENTACIONES?\nNo podrás regresar a la configuración.",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Entrances();
            }
        }

        private void DebateClick(object? sender, EventArgs e)
        {
            if (MessageBox.Show("¿ESTÁS SEGURO DE PASAR A LA FASE DE DEBATE?\nNo podrás regresar a las presentaciones.",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Debate();
            }
        }

        private void ClosuresClick(object? sender, EventArgs e)
        {
            if (MessageBox.Show("¿ESTÁS SEGURO DE PASAR A LA FASE DE CIERRES?\nNo podrás regresar al debate.",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Closures();
            }
        }

        #endregion

        #region PRIVATE METHODS (names controls)

        private void NamesEnter(object? sender, EventArgs e)
        {
            RichTextBox textbox = (RichTextBox)sender!;
            textbox.BackColor = Color.Orange;
            textbox.Select(textbox.Text.Length, 0);
        }

        private void NamesLeave(object? sender, EventArgs e)
        {
            RichTextBox textbox = (RichTextBox)sender!;
            textbox.BackColor = SystemColors.Window;
            textbox.Text = textbox.Text.Trim();
            int i = (int)textbox.Name.Last() - 49;
            countdowns[i].Visible = textboxes[i].Text.Length > 0;
            countdowns[i].Candidate = textboxes[i].Text;
        }

        private void NamesKeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.ActiveControl = null;
            }
        }

        #endregion

        private void FormClosingAction(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void ApplySettings()
        {
            for (int i = 0; i < 8; i++)
            {
                panels[i].Height = PANELS_SIZE;
                buttons[i, 0].Size = new Size(PANELS_SIZE, PANELS_SIZE);
                buttons[i, 1].Size = new Size(PANELS_SIZE, PANELS_SIZE);
                buttons[i, 2].Size = new Size(PANELS_SIZE, PANELS_SIZE);
                countdowns[i].ForeColor = FORECOLOR;
                countdowns[i].BackColor = BACKCOLOR;
            }
            countdownGeneral.ForeColor = FORECOLOR;
            countdownGeneral.BackColor = BACKCOLOR;
            countdownGeneral.SecondsAlarm = PARTICIPATION_ALARM;
        }

        private void LoadSettings()
        {
            String filename = "config.txt";
            try
            {
                if (File.Exists(filename))
                {
                    using StreamReader streamReader = File.OpenText(filename);
                    String? line = "";
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        String[] words = line.Split(",");
                        if (words.Length > 0)
                        {
                            switch (words[0])
                            {
                                case "CANDIDATO":
                                    if (words.Length == 3)
                                    {
                                        int i = int.TryParse(words[1], out i) ? i : -1;
                                        if (i >= 0 && i <= 7)
                                        {
                                            textboxes[i].Text = words[2];
                                        }
                                    }
                                    break;
                                case "ENTRADA":
                                    if (words.Length == 2)
                                    {
                                        ENTRANCE_TIME = int.TryParse(words[1], out ENTRANCE_TIME) ? ENTRANCE_TIME : 15;
                                    }
                                    break;
                                case "BOLSA":
                                    if (words.Length == 2)
                                    {
                                        DEBATE_TIME = int.TryParse(words[1], out DEBATE_TIME) ? DEBATE_TIME : 600;
                                    }
                                    break;
                                case "PARTICIPACION":
                                    if (words.Length == 2)
                                    {
                                        PARTICIPATION_TIME = int.TryParse(words[1], out PARTICIPATION_TIME) ? PARTICIPATION_TIME : 90;
                                    }
                                    break;
                                case "CIERRE":
                                    if (words.Length == 2)
                                    {
                                        CLOSURE_TIME = int.TryParse(words[1], out CLOSURE_TIME) ? CLOSURE_TIME : 60;
                                    }
                                    break;
                                case "EXTRA":
                                    if (words.Length == 2)
                                    {
                                        EXTRA_TIME = int.TryParse(words[1], out EXTRA_TIME) ? EXTRA_TIME : 60;
                                    }
                                    break;
                                case "EXCESO":
                                    if (words.Length == 2)
                                    {
                                        EXCESS_TIME = float.TryParse(words[1], out EXCESS_TIME) ? EXCESS_TIME : 0.2f;
                                    }
                                    break;
                                case "ENTRADAW":
                                    if (words.Length == 2)
                                    {
                                        ENTRANCE_ALARM = int.TryParse(words[1], out ENTRANCE_ALARM) ? ENTRANCE_ALARM : -1;
                                    }
                                    break;
                                case "PARTICIPACIONW":
                                    if (words.Length == 2)
                                    {
                                        PARTICIPATION_ALARM = int.TryParse(words[1], out PARTICIPATION_ALARM) ? PARTICIPATION_ALARM : 15;
                                    }
                                    break;
                                case "CIERREW":
                                    if (words.Length == 2)
                                    {
                                        CLOSURE_ALARM = int.TryParse(words[1], out CLOSURE_ALARM) ? CLOSURE_ALARM : -1;
                                    }
                                    break;
                                case "PANELS":
                                    if (words.Length == 2)
                                    {
                                        PANELS_SIZE = int.TryParse(words[1], out PANELS_SIZE) ? PANELS_SIZE : 70;
                                    }
                                    break;
                                case "FORECOLOR":
                                    if (words.Length == 4)
                                    {
                                        int r = int.TryParse(words[1], out r) ? r : 92;
                                        int g = int.TryParse(words[2], out g) ? g : 15;
                                        int b = int.TryParse(words[3], out b) ? b : 139;
                                        FORECOLOR = Color.FromArgb(r, g, b);
                                    }
                                    break;
                                case "BACKCOLOR":
                                    if (words.Length == 4)
                                    {
                                        int r = int.TryParse(words[1], out r) ? r : 255;
                                        int g = int.TryParse(words[2], out g) ? g : 255;
                                        int b = int.TryParse(words[3], out b) ? b : 255;
                                        BACKCOLOR = Color.FromArgb(r, g, b);
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void SaveSettings()
        {
            String filename = "config.txt";
            try
            {
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                using StreamWriter streamWriter = File.CreateText(filename);
                for (int i = 0; i < 8; i++)
                {
                    streamWriter.WriteLine("CANDIDATO," + i + "," + textboxes[i].Text);
                }
                streamWriter.WriteLine("ENTRADA," + ENTRANCE_TIME);
                streamWriter.WriteLine("BOLSA," + DEBATE_TIME);
                streamWriter.WriteLine("PARTICIPACION," + PARTICIPATION_TIME);
                streamWriter.WriteLine("CIERRE," + CLOSURE_TIME);
                streamWriter.WriteLine("EXTRA," + EXTRA_TIME);
                streamWriter.WriteLine("EXCESO," + EXCESS_TIME);
                streamWriter.WriteLine("ENTRADAW," + ENTRANCE_ALARM);
                streamWriter.WriteLine("PARTICIPATIONW," + PARTICIPATION_ALARM);
                streamWriter.WriteLine("CIERREW," + CLOSURE_ALARM);
                streamWriter.WriteLine("PANELS," + PANELS_SIZE);
                streamWriter.WriteLine("FORECOLOR," + FORECOLOR.R + "," + FORECOLOR.G + "," + FORECOLOR.B);
                streamWriter.WriteLine("BACKCOLOR," + BACKCOLOR.R + "," + BACKCOLOR.G + "," + BACKCOLOR.B);
            }
            catch (Exception)
            {

            }
        }
    }
}
