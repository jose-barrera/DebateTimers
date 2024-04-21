namespace DebateTimers
{
    partial class Chronometers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timerGeneral = new System.Windows.Forms.Timer(components);
            panelChronos = new TableLayoutPanel();
            countdown1 = new CountdownView();
            countdown3 = new CountdownView();
            countdown2 = new CountdownView();
            countdown4 = new CountdownView();
            countdown5 = new CountdownView();
            countdown6 = new CountdownView();
            countdown7 = new CountdownView();
            countdown8 = new CountdownView();
            panelMain = new Panel();
            countdownGeneral = new CountdownView();
            panel1 = new Panel();
            txtName1 = new RichTextBox();
            btnStart1 = new Button();
            btnReset1 = new Button();
            btnStop1 = new Button();
            panel2 = new Panel();
            txtName2 = new RichTextBox();
            btnStart2 = new Button();
            btnReset2 = new Button();
            btnStop2 = new Button();
            panel3 = new Panel();
            txtName3 = new RichTextBox();
            btnStart3 = new Button();
            btnReset3 = new Button();
            btnStop3 = new Button();
            panel4 = new Panel();
            txtName4 = new RichTextBox();
            btnStart4 = new Button();
            btnReset4 = new Button();
            btnStop4 = new Button();
            panel5 = new Panel();
            txtName5 = new RichTextBox();
            btnStart5 = new Button();
            btnReset5 = new Button();
            btnStop5 = new Button();
            panel6 = new Panel();
            txtName6 = new RichTextBox();
            btnStart6 = new Button();
            btnReset6 = new Button();
            btnStop6 = new Button();
            panel7 = new Panel();
            txtName7 = new RichTextBox();
            btnStart7 = new Button();
            btnReset7 = new Button();
            btnStop7 = new Button();
            panel8 = new Panel();
            txtName8 = new RichTextBox();
            btnStart8 = new Button();
            btnReset8 = new Button();
            btnStop8 = new Button();
            fontCountdown = new FontDialog();
            toolbar = new Panel();
            lblVersion = new Label();
            btnExcess = new Button();
            btnExtra = new Button();
            btnReset = new Button();
            rbClosures = new RadioButton();
            rbDebate = new RadioButton();
            rbEntrances = new RadioButton();
            rbSetup = new RadioButton();
            pictureBox1 = new PictureBox();
            splitContainer1 = new SplitContainer();
            notas = new ToolTip(components);
            panelChronos.SuspendLayout();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // timerGeneral
            // 
            timerGeneral.Interval = 1000;
            timerGeneral.Tick += TimerTick;
            // 
            // panelChronos
            // 
            panelChronos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelChronos.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            panelChronos.ColumnCount = 2;
            panelChronos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelChronos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelChronos.Controls.Add(countdown1, 0, 0);
            panelChronos.Controls.Add(countdown3, 0, 1);
            panelChronos.Controls.Add(countdown2, 1, 0);
            panelChronos.Controls.Add(countdown4, 1, 1);
            panelChronos.Controls.Add(countdown5, 0, 2);
            panelChronos.Controls.Add(countdown6, 1, 2);
            panelChronos.Controls.Add(countdown7, 0, 3);
            panelChronos.Controls.Add(countdown8, 1, 3);
            panelChronos.Dock = DockStyle.Fill;
            panelChronos.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            panelChronos.Location = new Point(0, 0);
            panelChronos.Margin = new Padding(0);
            panelChronos.Name = "panelChronos";
            panelChronos.RowCount = 4;
            panelChronos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelChronos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelChronos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelChronos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelChronos.Size = new Size(987, 933);
            panelChronos.TabIndex = 0;
            // 
            // countdown1
            // 
            countdown1.Candidate = "...";
            countdown1.CandidateFont = new Font("Swis721 BlkCn BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countdown1.Dock = DockStyle.Fill;
            countdown1.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countdown1.Location = new Point(3, 4);
            countdown1.Margin = new Padding(1, 2, 1, 2);
            countdown1.Name = "countdown1";
            countdown1.Seconds = 0;
            countdown1.SecondsAlarm = -1;
            countdown1.Size = new Size(488, 226);
            countdown1.TabIndex = 0;
            countdown1.TabStop = false;
            // 
            // countdown3
            // 
            countdown3.Candidate = "...";
            countdown3.CandidateFont = new Font("Swis721 BlkCn BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countdown3.Dock = DockStyle.Fill;
            countdown3.Font = new Font("Swis721 BlkCn BT", 14.25F);
            countdown3.Location = new Point(3, 236);
            countdown3.Margin = new Padding(1, 2, 1, 2);
            countdown3.Name = "countdown3";
            countdown3.Seconds = 0;
            countdown3.SecondsAlarm = -1;
            countdown3.Size = new Size(488, 226);
            countdown3.TabIndex = 2;
            countdown3.TabStop = false;
            // 
            // countdown2
            // 
            countdown2.Candidate = "...";
            countdown2.CandidateFont = new Font("Swis721 BlkCn BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countdown2.Dock = DockStyle.Fill;
            countdown2.Font = new Font("Swis721 BlkCn BT", 14.25F);
            countdown2.Location = new Point(495, 4);
            countdown2.Margin = new Padding(1, 2, 1, 2);
            countdown2.Name = "countdown2";
            countdown2.Seconds = 0;
            countdown2.SecondsAlarm = -1;
            countdown2.Size = new Size(489, 226);
            countdown2.TabIndex = 1;
            countdown2.TabStop = false;
            // 
            // countdown4
            // 
            countdown4.Candidate = "...";
            countdown4.CandidateFont = new Font("Swis721 BlkCn BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countdown4.Dock = DockStyle.Fill;
            countdown4.Font = new Font("Swis721 BlkCn BT", 14.25F);
            countdown4.Location = new Point(495, 236);
            countdown4.Margin = new Padding(1, 2, 1, 2);
            countdown4.Name = "countdown4";
            countdown4.Seconds = 0;
            countdown4.SecondsAlarm = -1;
            countdown4.Size = new Size(489, 226);
            countdown4.TabIndex = 3;
            countdown4.TabStop = false;
            // 
            // countdown5
            // 
            countdown5.Candidate = "...";
            countdown5.CandidateFont = new Font("Swis721 BlkCn BT", 24F);
            countdown5.Dock = DockStyle.Fill;
            countdown5.Font = new Font("Swis721 BlkCn BT", 14.25F);
            countdown5.Location = new Point(3, 468);
            countdown5.Margin = new Padding(1, 2, 1, 2);
            countdown5.Name = "countdown5";
            countdown5.Seconds = 0;
            countdown5.SecondsAlarm = -1;
            countdown5.Size = new Size(488, 226);
            countdown5.TabIndex = 4;
            countdown5.TabStop = false;
            // 
            // countdown6
            // 
            countdown6.Candidate = "...";
            countdown6.CandidateFont = new Font("Swis721 BlkCn BT", 24F);
            countdown6.Dock = DockStyle.Fill;
            countdown6.Font = new Font("Swis721 BlkCn BT", 14.25F);
            countdown6.Location = new Point(495, 468);
            countdown6.Margin = new Padding(1, 2, 1, 2);
            countdown6.Name = "countdown6";
            countdown6.Seconds = 0;
            countdown6.SecondsAlarm = -1;
            countdown6.Size = new Size(489, 226);
            countdown6.TabIndex = 5;
            countdown6.TabStop = false;
            // 
            // countdown7
            // 
            countdown7.Candidate = "...";
            countdown7.CandidateFont = new Font("Swis721 BlkCn BT", 24F);
            countdown7.Dock = DockStyle.Fill;
            countdown7.Font = new Font("Swis721 BlkCn BT", 14.25F);
            countdown7.Location = new Point(3, 700);
            countdown7.Margin = new Padding(1, 2, 1, 2);
            countdown7.Name = "countdown7";
            countdown7.Seconds = 0;
            countdown7.SecondsAlarm = -1;
            countdown7.Size = new Size(488, 229);
            countdown7.TabIndex = 6;
            countdown7.TabStop = false;
            // 
            // countdown8
            // 
            countdown8.Candidate = "...";
            countdown8.CandidateFont = new Font("Swis721 BlkCn BT", 24F);
            countdown8.Dock = DockStyle.Fill;
            countdown8.Font = new Font("Swis721 BlkCn BT", 14.25F);
            countdown8.Location = new Point(495, 700);
            countdown8.Margin = new Padding(1, 2, 1, 2);
            countdown8.Name = "countdown8";
            countdown8.Seconds = 0;
            countdown8.SecondsAlarm = -1;
            countdown8.Size = new Size(489, 229);
            countdown8.TabIndex = 7;
            countdown8.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(countdownGeneral);
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(panel2);
            panelMain.Controls.Add(panel3);
            panelMain.Controls.Add(panel4);
            panelMain.Controls.Add(panel5);
            panelMain.Controls.Add(panel6);
            panelMain.Controls.Add(panel7);
            panelMain.Controls.Add(panel8);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(3);
            panelMain.Size = new Size(888, 933);
            panelMain.TabIndex = 1;
            // 
            // countdownGeneral
            // 
            countdownGeneral.Candidate = "...";
            countdownGeneral.CandidateFont = new Font("Swis721 BlkCn BT", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countdownGeneral.Dock = DockStyle.Fill;
            countdownGeneral.Font = new Font("Swis721 BlkCn BT", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countdownGeneral.Location = new Point(3, 3);
            countdownGeneral.Margin = new Padding(1, 2, 1, 2);
            countdownGeneral.Name = "countdownGeneral";
            countdownGeneral.Seconds = 0;
            countdownGeneral.SecondsAlarm = -1;
            countdownGeneral.Size = new Size(880, 365);
            countdownGeneral.TabIndex = 3;
            countdownGeneral.TabStop = false;
            countdownGeneral.DoubleClick += TimerConfig;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(txtName1);
            panel1.Controls.Add(btnStart1);
            panel1.Controls.Add(btnReset1);
            panel1.Controls.Add(btnStop1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 368);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 70);
            panel1.TabIndex = 1;
            // 
            // txtName1
            // 
            txtName1.Dock = DockStyle.Fill;
            txtName1.Font = new Font("Consolas", 20F);
            txtName1.Location = new Point(140, 0);
            txtName1.Name = "txtName1";
            txtName1.ShortcutsEnabled = false;
            txtName1.Size = new Size(670, 70);
            txtName1.TabIndex = 0;
            txtName1.Text = "...";
            txtName1.Enter += NamesEnter;
            txtName1.KeyDown += NamesKeyDown;
            txtName1.Leave += NamesLeave;
            // 
            // btnStart1
            // 
            btnStart1.BackColor = Color.Transparent;
            btnStart1.BackgroundImage = Properties.Resources.play;
            btnStart1.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart1.Dock = DockStyle.Left;
            btnStart1.FlatStyle = FlatStyle.Popup;
            btnStart1.Location = new Point(70, 0);
            btnStart1.Name = "btnStart1";
            btnStart1.Size = new Size(70, 70);
            btnStart1.TabIndex = 3;
            btnStart1.TabStop = false;
            btnStart1.UseVisualStyleBackColor = false;
            // 
            // btnReset1
            // 
            btnReset1.BackgroundImage = Properties.Resources.reset;
            btnReset1.BackgroundImageLayout = ImageLayout.Stretch;
            btnReset1.Dock = DockStyle.Right;
            btnReset1.FlatStyle = FlatStyle.Popup;
            btnReset1.Location = new Point(810, 0);
            btnReset1.Name = "btnReset1";
            btnReset1.Size = new Size(70, 70);
            btnReset1.TabIndex = 2;
            btnReset1.TabStop = false;
            btnReset1.UseVisualStyleBackColor = true;
            btnReset1.Visible = false;
            // 
            // btnStop1
            // 
            btnStop1.BackgroundImage = Properties.Resources.stop_disabled;
            btnStop1.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop1.Dock = DockStyle.Left;
            btnStop1.FlatStyle = FlatStyle.Popup;
            btnStop1.Location = new Point(0, 0);
            btnStop1.Name = "btnStop1";
            btnStop1.Size = new Size(70, 70);
            btnStop1.TabIndex = 0;
            btnStop1.TabStop = false;
            btnStop1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(txtName2);
            panel2.Controls.Add(btnStart2);
            panel2.Controls.Add(btnReset2);
            panel2.Controls.Add(btnStop2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 70);
            panel2.TabIndex = 2;
            // 
            // txtName2
            // 
            txtName2.Dock = DockStyle.Fill;
            txtName2.Font = new Font("Consolas", 20F);
            txtName2.Location = new Point(140, 0);
            txtName2.Name = "txtName2";
            txtName2.ShortcutsEnabled = false;
            txtName2.Size = new Size(670, 70);
            txtName2.TabIndex = 0;
            txtName2.Text = "...";
            txtName2.Enter += NamesEnter;
            txtName2.KeyDown += NamesKeyDown;
            txtName2.Leave += NamesLeave;
            // 
            // btnStart2
            // 
            btnStart2.BackColor = Color.Transparent;
            btnStart2.BackgroundImage = Properties.Resources.play;
            btnStart2.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart2.Dock = DockStyle.Left;
            btnStart2.FlatStyle = FlatStyle.Popup;
            btnStart2.Location = new Point(70, 0);
            btnStart2.Name = "btnStart2";
            btnStart2.Size = new Size(70, 70);
            btnStart2.TabIndex = 0;
            btnStart2.TabStop = false;
            btnStart2.UseVisualStyleBackColor = false;
            // 
            // btnReset2
            // 
            btnReset2.BackgroundImage = Properties.Resources.reset;
            btnReset2.BackgroundImageLayout = ImageLayout.Stretch;
            btnReset2.Dock = DockStyle.Right;
            btnReset2.FlatStyle = FlatStyle.Popup;
            btnReset2.Location = new Point(810, 0);
            btnReset2.Name = "btnReset2";
            btnReset2.Size = new Size(70, 70);
            btnReset2.TabIndex = 2;
            btnReset2.TabStop = false;
            btnReset2.UseVisualStyleBackColor = true;
            btnReset2.Visible = false;
            // 
            // btnStop2
            // 
            btnStop2.BackgroundImage = Properties.Resources.stop_disabled;
            btnStop2.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop2.Dock = DockStyle.Left;
            btnStop2.FlatStyle = FlatStyle.Popup;
            btnStop2.Location = new Point(0, 0);
            btnStop2.Name = "btnStop2";
            btnStop2.Size = new Size(70, 70);
            btnStop2.TabIndex = 0;
            btnStop2.TabStop = false;
            btnStop2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(txtName3);
            panel3.Controls.Add(btnStart3);
            panel3.Controls.Add(btnReset3);
            panel3.Controls.Add(btnStop3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 508);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 70);
            panel3.TabIndex = 3;
            // 
            // txtName3
            // 
            txtName3.Dock = DockStyle.Fill;
            txtName3.Font = new Font("Consolas", 20F);
            txtName3.Location = new Point(140, 0);
            txtName3.Name = "txtName3";
            txtName3.ShortcutsEnabled = false;
            txtName3.Size = new Size(670, 70);
            txtName3.TabIndex = 0;
            txtName3.Text = "...";
            txtName3.Enter += NamesEnter;
            txtName3.KeyDown += NamesKeyDown;
            txtName3.Leave += NamesLeave;
            // 
            // btnStart3
            // 
            btnStart3.BackColor = Color.Transparent;
            btnStart3.BackgroundImage = Properties.Resources.play;
            btnStart3.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart3.Dock = DockStyle.Left;
            btnStart3.FlatStyle = FlatStyle.Popup;
            btnStart3.Location = new Point(70, 0);
            btnStart3.Name = "btnStart3";
            btnStart3.Size = new Size(70, 70);
            btnStart3.TabIndex = 0;
            btnStart3.TabStop = false;
            btnStart3.UseVisualStyleBackColor = false;
            // 
            // btnReset3
            // 
            btnReset3.BackgroundImage = Properties.Resources.reset;
            btnReset3.BackgroundImageLayout = ImageLayout.Stretch;
            btnReset3.Dock = DockStyle.Right;
            btnReset3.FlatStyle = FlatStyle.Popup;
            btnReset3.Location = new Point(810, 0);
            btnReset3.Name = "btnReset3";
            btnReset3.Size = new Size(70, 70);
            btnReset3.TabIndex = 2;
            btnReset3.TabStop = false;
            btnReset3.UseVisualStyleBackColor = true;
            btnReset3.Visible = false;
            // 
            // btnStop3
            // 
            btnStop3.BackgroundImage = Properties.Resources.stop_disabled;
            btnStop3.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop3.Dock = DockStyle.Left;
            btnStop3.FlatStyle = FlatStyle.Popup;
            btnStop3.Location = new Point(0, 0);
            btnStop3.Name = "btnStop3";
            btnStop3.Size = new Size(70, 70);
            btnStop3.TabIndex = 0;
            btnStop3.TabStop = false;
            btnStop3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Controls.Add(txtName4);
            panel4.Controls.Add(btnStart4);
            panel4.Controls.Add(btnReset4);
            panel4.Controls.Add(btnStop4);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 578);
            panel4.Name = "panel4";
            panel4.Size = new Size(880, 70);
            panel4.TabIndex = 4;
            // 
            // txtName4
            // 
            txtName4.Dock = DockStyle.Fill;
            txtName4.Font = new Font("Consolas", 20F);
            txtName4.Location = new Point(140, 0);
            txtName4.Name = "txtName4";
            txtName4.ShortcutsEnabled = false;
            txtName4.Size = new Size(670, 70);
            txtName4.TabIndex = 0;
            txtName4.Text = "...";
            txtName4.Enter += NamesEnter;
            txtName4.KeyDown += NamesKeyDown;
            txtName4.Leave += NamesLeave;
            // 
            // btnStart4
            // 
            btnStart4.BackColor = Color.Transparent;
            btnStart4.BackgroundImage = Properties.Resources.play;
            btnStart4.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart4.Dock = DockStyle.Left;
            btnStart4.FlatStyle = FlatStyle.Popup;
            btnStart4.Location = new Point(70, 0);
            btnStart4.Name = "btnStart4";
            btnStart4.Size = new Size(70, 70);
            btnStart4.TabIndex = 0;
            btnStart4.TabStop = false;
            btnStart4.UseVisualStyleBackColor = false;
            // 
            // btnReset4
            // 
            btnReset4.BackgroundImage = Properties.Resources.reset;
            btnReset4.BackgroundImageLayout = ImageLayout.Stretch;
            btnReset4.Dock = DockStyle.Right;
            btnReset4.FlatStyle = FlatStyle.Popup;
            btnReset4.Location = new Point(810, 0);
            btnReset4.Name = "btnReset4";
            btnReset4.Size = new Size(70, 70);
            btnReset4.TabIndex = 2;
            btnReset4.TabStop = false;
            btnReset4.UseVisualStyleBackColor = true;
            btnReset4.Visible = false;
            // 
            // btnStop4
            // 
            btnStop4.BackgroundImage = Properties.Resources.stop_disabled;
            btnStop4.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop4.Dock = DockStyle.Left;
            btnStop4.FlatStyle = FlatStyle.Popup;
            btnStop4.Location = new Point(0, 0);
            btnStop4.Name = "btnStop4";
            btnStop4.Size = new Size(70, 70);
            btnStop4.TabIndex = 2;
            btnStop4.TabStop = false;
            btnStop4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.CornflowerBlue;
            panel5.Controls.Add(txtName5);
            panel5.Controls.Add(btnStart5);
            panel5.Controls.Add(btnReset5);
            panel5.Controls.Add(btnStop5);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(3, 648);
            panel5.Name = "panel5";
            panel5.Size = new Size(880, 70);
            panel5.TabIndex = 5;
            // 
            // txtName5
            // 
            txtName5.Dock = DockStyle.Fill;
            txtName5.Font = new Font("Consolas", 20F);
            txtName5.Location = new Point(140, 0);
            txtName5.Name = "txtName5";
            txtName5.ShortcutsEnabled = false;
            txtName5.Size = new Size(670, 70);
            txtName5.TabIndex = 0;
            txtName5.Text = "...";
            txtName5.Enter += NamesEnter;
            txtName5.KeyDown += NamesKeyDown;
            txtName5.Leave += NamesLeave;
            // 
            // btnStart5
            // 
            btnStart5.BackColor = Color.Transparent;
            btnStart5.BackgroundImage = Properties.Resources.play;
            btnStart5.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart5.Dock = DockStyle.Left;
            btnStart5.FlatStyle = FlatStyle.Popup;
            btnStart5.Location = new Point(70, 0);
            btnStart5.Name = "btnStart5";
            btnStart5.Size = new Size(70, 70);
            btnStart5.TabIndex = 0;
            btnStart5.TabStop = false;
            btnStart5.UseVisualStyleBackColor = false;
            // 
            // btnReset5
            // 
            btnReset5.BackgroundImage = Properties.Resources.reset;
            btnReset5.BackgroundImageLayout = ImageLayout.Stretch;
            btnReset5.Dock = DockStyle.Right;
            btnReset5.FlatStyle = FlatStyle.Popup;
            btnReset5.Location = new Point(810, 0);
            btnReset5.Name = "btnReset5";
            btnReset5.Size = new Size(70, 70);
            btnReset5.TabIndex = 2;
            btnReset5.TabStop = false;
            btnReset5.UseVisualStyleBackColor = true;
            btnReset5.Visible = false;
            // 
            // btnStop5
            // 
            btnStop5.BackgroundImage = Properties.Resources.stop_disabled;
            btnStop5.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop5.Dock = DockStyle.Left;
            btnStop5.FlatStyle = FlatStyle.Popup;
            btnStop5.Location = new Point(0, 0);
            btnStop5.Name = "btnStop5";
            btnStop5.Size = new Size(70, 70);
            btnStop5.TabIndex = 1;
            btnStop5.TabStop = false;
            btnStop5.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.CornflowerBlue;
            panel6.Controls.Add(txtName6);
            panel6.Controls.Add(btnStart6);
            panel6.Controls.Add(btnReset6);
            panel6.Controls.Add(btnStop6);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(3, 718);
            panel6.Name = "panel6";
            panel6.Size = new Size(880, 70);
            panel6.TabIndex = 6;
            // 
            // txtName6
            // 
            txtName6.Dock = DockStyle.Fill;
            txtName6.Font = new Font("Consolas", 20F);
            txtName6.Location = new Point(140, 0);
            txtName6.Name = "txtName6";
            txtName6.ShortcutsEnabled = false;
            txtName6.Size = new Size(670, 70);
            txtName6.TabIndex = 0;
            txtName6.Text = "...";
            txtName6.Enter += NamesEnter;
            txtName6.KeyDown += NamesKeyDown;
            txtName6.Leave += NamesLeave;
            // 
            // btnStart6
            // 
            btnStart6.BackColor = Color.Transparent;
            btnStart6.BackgroundImage = Properties.Resources.play;
            btnStart6.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart6.Dock = DockStyle.Left;
            btnStart6.FlatStyle = FlatStyle.Popup;
            btnStart6.Location = new Point(70, 0);
            btnStart6.Name = "btnStart6";
            btnStart6.Size = new Size(70, 70);
            btnStart6.TabIndex = 0;
            btnStart6.TabStop = false;
            btnStart6.UseVisualStyleBackColor = false;
            // 
            // btnReset6
            // 
            btnReset6.BackgroundImage = Properties.Resources.reset;
            btnReset6.BackgroundImageLayout = ImageLayout.Stretch;
            btnReset6.Dock = DockStyle.Right;
            btnReset6.FlatStyle = FlatStyle.Popup;
            btnReset6.Location = new Point(810, 0);
            btnReset6.Name = "btnReset6";
            btnReset6.Size = new Size(70, 70);
            btnReset6.TabIndex = 2;
            btnReset6.TabStop = false;
            btnReset6.UseVisualStyleBackColor = true;
            btnReset6.Visible = false;
            // 
            // btnStop6
            // 
            btnStop6.BackgroundImage = Properties.Resources.stop_disabled;
            btnStop6.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop6.Dock = DockStyle.Left;
            btnStop6.FlatStyle = FlatStyle.Popup;
            btnStop6.Location = new Point(0, 0);
            btnStop6.Name = "btnStop6";
            btnStop6.Size = new Size(70, 70);
            btnStop6.TabIndex = 1;
            btnStop6.TabStop = false;
            btnStop6.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.CornflowerBlue;
            panel7.Controls.Add(txtName7);
            panel7.Controls.Add(btnStart7);
            panel7.Controls.Add(btnReset7);
            panel7.Controls.Add(btnStop7);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(3, 788);
            panel7.Name = "panel7";
            panel7.Size = new Size(880, 70);
            panel7.TabIndex = 7;
            // 
            // txtName7
            // 
            txtName7.Dock = DockStyle.Fill;
            txtName7.Font = new Font("Consolas", 20F);
            txtName7.Location = new Point(140, 0);
            txtName7.Name = "txtName7";
            txtName7.ShortcutsEnabled = false;
            txtName7.Size = new Size(670, 70);
            txtName7.TabIndex = 0;
            txtName7.Text = "...";
            txtName7.Enter += NamesEnter;
            txtName7.KeyDown += NamesKeyDown;
            txtName7.Leave += NamesLeave;
            // 
            // btnStart7
            // 
            btnStart7.BackColor = Color.Transparent;
            btnStart7.BackgroundImage = Properties.Resources.play;
            btnStart7.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart7.Dock = DockStyle.Left;
            btnStart7.FlatStyle = FlatStyle.Popup;
            btnStart7.Location = new Point(70, 0);
            btnStart7.Name = "btnStart7";
            btnStart7.Size = new Size(70, 70);
            btnStart7.TabIndex = 0;
            btnStart7.TabStop = false;
            btnStart7.UseVisualStyleBackColor = false;
            // 
            // btnReset7
            // 
            btnReset7.BackgroundImage = Properties.Resources.reset;
            btnReset7.BackgroundImageLayout = ImageLayout.Stretch;
            btnReset7.Dock = DockStyle.Right;
            btnReset7.FlatStyle = FlatStyle.Popup;
            btnReset7.Location = new Point(810, 0);
            btnReset7.Name = "btnReset7";
            btnReset7.Size = new Size(70, 70);
            btnReset7.TabIndex = 2;
            btnReset7.TabStop = false;
            btnReset7.UseVisualStyleBackColor = true;
            btnReset7.Visible = false;
            // 
            // btnStop7
            // 
            btnStop7.BackgroundImage = Properties.Resources.stop_disabled;
            btnStop7.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop7.Dock = DockStyle.Left;
            btnStop7.FlatStyle = FlatStyle.Popup;
            btnStop7.Location = new Point(0, 0);
            btnStop7.Name = "btnStop7";
            btnStop7.Size = new Size(70, 70);
            btnStop7.TabIndex = 1;
            btnStop7.TabStop = false;
            btnStop7.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.CornflowerBlue;
            panel8.Controls.Add(txtName8);
            panel8.Controls.Add(btnStart8);
            panel8.Controls.Add(btnReset8);
            panel8.Controls.Add(btnStop8);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(3, 858);
            panel8.Name = "panel8";
            panel8.Size = new Size(880, 70);
            panel8.TabIndex = 8;
            // 
            // txtName8
            // 
            txtName8.Dock = DockStyle.Fill;
            txtName8.Font = new Font("Consolas", 20F);
            txtName8.Location = new Point(140, 0);
            txtName8.Name = "txtName8";
            txtName8.ShortcutsEnabled = false;
            txtName8.Size = new Size(670, 70);
            txtName8.TabIndex = 0;
            txtName8.Text = "...";
            txtName8.Enter += NamesEnter;
            txtName8.KeyDown += NamesKeyDown;
            txtName8.Leave += NamesLeave;
            // 
            // btnStart8
            // 
            btnStart8.BackColor = Color.Transparent;
            btnStart8.BackgroundImage = Properties.Resources.play;
            btnStart8.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart8.Dock = DockStyle.Left;
            btnStart8.FlatStyle = FlatStyle.Popup;
            btnStart8.Location = new Point(70, 0);
            btnStart8.Name = "btnStart8";
            btnStart8.Size = new Size(70, 70);
            btnStart8.TabIndex = 0;
            btnStart8.TabStop = false;
            btnStart8.UseVisualStyleBackColor = false;
            // 
            // btnReset8
            // 
            btnReset8.BackgroundImage = Properties.Resources.reset;
            btnReset8.BackgroundImageLayout = ImageLayout.Stretch;
            btnReset8.Dock = DockStyle.Right;
            btnReset8.FlatStyle = FlatStyle.Popup;
            btnReset8.Location = new Point(810, 0);
            btnReset8.Name = "btnReset8";
            btnReset8.Size = new Size(70, 70);
            btnReset8.TabIndex = 2;
            btnReset8.TabStop = false;
            btnReset8.UseVisualStyleBackColor = true;
            btnReset8.Visible = false;
            // 
            // btnStop8
            // 
            btnStop8.BackgroundImage = Properties.Resources.stop_disabled;
            btnStop8.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop8.Dock = DockStyle.Left;
            btnStop8.FlatStyle = FlatStyle.Popup;
            btnStop8.Location = new Point(0, 0);
            btnStop8.Name = "btnStop8";
            btnStop8.Size = new Size(70, 70);
            btnStop8.TabIndex = 1;
            btnStop8.TabStop = false;
            btnStop8.UseVisualStyleBackColor = true;
            // 
            // toolbar
            // 
            toolbar.Controls.Add(lblVersion);
            toolbar.Controls.Add(btnExcess);
            toolbar.Controls.Add(btnExtra);
            toolbar.Controls.Add(btnReset);
            toolbar.Controls.Add(rbClosures);
            toolbar.Controls.Add(rbDebate);
            toolbar.Controls.Add(rbEntrances);
            toolbar.Controls.Add(rbSetup);
            toolbar.Controls.Add(pictureBox1);
            toolbar.Dock = DockStyle.Bottom;
            toolbar.Location = new Point(0, 933);
            toolbar.Margin = new Padding(4, 5, 4, 5);
            toolbar.Name = "toolbar";
            toolbar.Size = new Size(1879, 117);
            toolbar.TabIndex = 2;
            // 
            // lblVersion
            // 
            lblVersion.Dock = DockStyle.Fill;
            lblVersion.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVersion.ForeColor = Color.Coral;
            lblVersion.Location = new Point(1260, 0);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(319, 117);
            lblVersion.TabIndex = 8;
            lblVersion.Text = "Versión 1.0.0";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExcess
            // 
            btnExcess.BackgroundImage = Properties.Resources.crossedclock;
            btnExcess.BackgroundImageLayout = ImageLayout.Stretch;
            btnExcess.Dock = DockStyle.Right;
            btnExcess.FlatStyle = FlatStyle.Popup;
            btnExcess.Location = new Point(1579, 0);
            btnExcess.Name = "btnExcess";
            btnExcess.Size = new Size(100, 117);
            btnExcess.TabIndex = 6;
            btnExcess.TabStop = false;
            notas.SetToolTip(btnExcess, "Eliminar el exceso de tiempo en las bolsas.");
            btnExcess.UseVisualStyleBackColor = true;
            btnExcess.Click += RemoveExcess;
            // 
            // btnExtra
            // 
            btnExtra.BackgroundImage = Properties.Resources.extratime;
            btnExtra.BackgroundImageLayout = ImageLayout.Stretch;
            btnExtra.Dock = DockStyle.Right;
            btnExtra.FlatStyle = FlatStyle.Popup;
            btnExtra.Location = new Point(1679, 0);
            btnExtra.Name = "btnExtra";
            btnExtra.Size = new Size(100, 117);
            btnExtra.TabIndex = 5;
            btnExtra.TabStop = false;
            notas.SetToolTip(btnExtra, "Agregar tiempo extra a la candidata o candidato seleccionado.");
            btnExtra.UseVisualStyleBackColor = true;
            btnExtra.Visible = false;
            btnExtra.Click += ExtraTime;
            // 
            // btnReset
            // 
            btnReset.BackgroundImage = Properties.Resources.reset;
            btnReset.BackgroundImageLayout = ImageLayout.Stretch;
            btnReset.Dock = DockStyle.Right;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Location = new Point(1779, 0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 117);
            btnReset.TabIndex = 4;
            btnReset.TabStop = false;
            notas.SetToolTip(btnReset, "Reset del cronómetro general.");
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += ResetClick;
            // 
            // rbClosures
            // 
            rbClosures.Appearance = Appearance.Button;
            rbClosures.Dock = DockStyle.Left;
            rbClosures.Enabled = false;
            rbClosures.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbClosures.Location = new Point(1040, 0);
            rbClosures.Name = "rbClosures";
            rbClosures.Size = new Size(220, 117);
            rbClosures.TabIndex = 3;
            rbClosures.Text = "CIERRES";
            rbClosures.TextAlign = ContentAlignment.MiddleCenter;
            rbClosures.UseVisualStyleBackColor = true;
            rbClosures.Click += ClosuresClick;
            // 
            // rbDebate
            // 
            rbDebate.Appearance = Appearance.Button;
            rbDebate.Dock = DockStyle.Left;
            rbDebate.Enabled = false;
            rbDebate.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbDebate.Location = new Point(840, 0);
            rbDebate.Name = "rbDebate";
            rbDebate.Size = new Size(200, 117);
            rbDebate.TabIndex = 2;
            rbDebate.Text = "DEBATE";
            rbDebate.TextAlign = ContentAlignment.MiddleCenter;
            rbDebate.UseVisualStyleBackColor = true;
            rbDebate.Click += DebateClick;
            // 
            // rbEntrances
            // 
            rbEntrances.Appearance = Appearance.Button;
            rbEntrances.Dock = DockStyle.Left;
            rbEntrances.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbEntrances.Location = new Point(460, 0);
            rbEntrances.Name = "rbEntrances";
            rbEntrances.Size = new Size(380, 117);
            rbEntrances.TabIndex = 1;
            rbEntrances.Text = "PRESENTACIONES";
            rbEntrances.TextAlign = ContentAlignment.MiddleCenter;
            rbEntrances.UseVisualStyleBackColor = true;
            rbEntrances.Click += EntrancesClick;
            // 
            // rbSetup
            // 
            rbSetup.Appearance = Appearance.Button;
            rbSetup.Checked = true;
            rbSetup.Dock = DockStyle.Left;
            rbSetup.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbSetup.Location = new Point(100, 0);
            rbSetup.Name = "rbSetup";
            rbSetup.Size = new Size(360, 117);
            rbSetup.TabIndex = 0;
            rbSetup.TabStop = true;
            rbSetup.Text = "CONFIGURACIÓN";
            rbSetup.TextAlign = ContentAlignment.MiddleCenter;
            rbSetup.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 117);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panelChronos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelMain);
            splitContainer1.Size = new Size(1879, 933);
            splitContainer1.SplitterDistance = 987;
            splitContainer1.TabIndex = 3;
            // 
            // Chronometers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1879, 1050);
            Controls.Add(splitContainer1);
            Controls.Add(toolbar);
            Name = "Chronometers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRONÓMETROS";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormClosingAction;
            Load += FormLoad;
            panelChronos.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            toolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerGeneral;
        private TableLayoutPanel panelChronos;
        private Panel panelMain;
        private FontDialog fontCountdown;
        private Panel panel8;
        private Button btnReset8;
        private Button btnStop8;
        private Button btnStart8;
        private CountdownView countdown1;
        private CountdownView countdown3;
        private CountdownView countdown2;
        private CountdownView countdown4;
        private CountdownView countdown5;
        private CountdownView countdown6;
        private CountdownView countdown7;
        private CountdownView countdown8;
        private CountdownView countdownGeneral;
        private Panel panel6;
        private Button btnReset2;
        private Button btnStop2;
        private Button btnStart2;
        private Panel panel5;
        private Button btnReset3;
        private Button btnStop3;
        private Button btnStart3;
        private Panel panel4;
        private Button btnReset4;
        private Button btnStop4;
        private Button btnStart4;
        private Panel panel3;
        private Button btnReset5;
        private Button btnStop5;
        private Button btnStart5;
        private Panel panel2;
        private Button btnReset6;
        private Button btnStop6;
        private Button btnStart6;
        private Panel panel1;
        private Button btnReset7;
        private Button btnStop7;
        private Button btnStart7;
        private RichTextBox txtName2;
        private RichTextBox txtName3;
        private RichTextBox txtName4;
        private RichTextBox txtName5;
        private RichTextBox txtName6;
        private RichTextBox txtName7;
        private RichTextBox txtName8;
        private Panel panel7;
        private RichTextBox txtName1;
        private Button btnReset1;
        private Button btnStop1;
        private Button btnStart1;
        private Panel toolbar;
        private RadioButton rbClosures;
        private RadioButton rbDebate;
        private RadioButton rbEntrances;
        private RadioButton rbSetup;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Button btnExcess;
        private Button btnExtra;
        private Button btnReset;
        private Label lblVersion;
        private ToolTip notas;
    }
}
