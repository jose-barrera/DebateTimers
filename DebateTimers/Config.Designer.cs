namespace DebateTimers
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nmExtra = new NumericUpDown();
            bottomBar = new TableLayoutPanel();
            btnConfirm = new Button();
            btnCancel = new Button();
            lblExtra = new Label();
            lblClosure = new Label();
            nmClosure = new NumericUpDown();
            lblParticipation = new Label();
            nmParticipation = new NumericUpDown();
            lblDebate = new Label();
            nmDebate = new NumericUpDown();
            lblEntrance = new Label();
            nmEntrance = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmExtra).BeginInit();
            bottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmClosure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmParticipation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmDebate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmEntrance).BeginInit();
            SuspendLayout();
            // 
            // nmExtra
            // 
            nmExtra.Dock = DockStyle.Bottom;
            nmExtra.Font = new Font("Swis721 BlkCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nmExtra.ForeColor = Color.FromArgb(92, 15, 139);
            nmExtra.Location = new Point(0, 742);
            nmExtra.Margin = new Padding(161, 145, 161, 145);
            nmExtra.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nmExtra.Name = "nmExtra";
            nmExtra.Size = new Size(740, 94);
            nmExtra.TabIndex = 4;
            nmExtra.TextAlign = HorizontalAlignment.Center;
            // 
            // bottomBar
            // 
            bottomBar.ColumnCount = 2;
            bottomBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bottomBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bottomBar.Controls.Add(btnConfirm, 0, 0);
            bottomBar.Controls.Add(btnCancel, 1, 0);
            bottomBar.Dock = DockStyle.Bottom;
            bottomBar.Location = new Point(0, 836);
            bottomBar.Name = "bottomBar";
            bottomBar.RowCount = 1;
            bottomBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottomBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bottomBar.Size = new Size(740, 78);
            bottomBar.TabIndex = 5;
            // 
            // btnConfirm
            // 
            btnConfirm.Dock = DockStyle.Fill;
            btnConfirm.Font = new Font("Swis721 BlkCn BT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(3, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(364, 72);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirmar";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += ConfirmClick;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Font = new Font("Swis721 BlkCn BT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(373, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(364, 72);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += CancelClick;
            // 
            // lblExtra
            // 
            lblExtra.Dock = DockStyle.Bottom;
            lblExtra.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExtra.ForeColor = Color.DarkOrange;
            lblExtra.Location = new Point(0, 670);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(740, 72);
            lblExtra.TabIndex = 2;
            lblExtra.Text = "Indica la cantidad de segundos que dura cada TIEMPO EXTRA para una candidata o candidato.";
            // 
            // lblClosure
            // 
            lblClosure.Dock = DockStyle.Bottom;
            lblClosure.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClosure.ForeColor = Color.DarkOrange;
            lblClosure.Location = new Point(0, 504);
            lblClosure.Name = "lblClosure";
            lblClosure.Size = new Size(740, 72);
            lblClosure.TabIndex = 4;
            lblClosure.Text = "Indica la cantidad de segundos que dura cada CIERRE de una candidata o candidato.";
            // 
            // nmClosure
            // 
            nmClosure.Dock = DockStyle.Bottom;
            nmClosure.Font = new Font("Swis721 BlkCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nmClosure.ForeColor = Color.FromArgb(92, 15, 139);
            nmClosure.Location = new Point(0, 576);
            nmClosure.Margin = new Padding(161, 145, 161, 145);
            nmClosure.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nmClosure.Name = "nmClosure";
            nmClosure.Size = new Size(740, 94);
            nmClosure.TabIndex = 3;
            nmClosure.TextAlign = HorizontalAlignment.Center;
            // 
            // lblParticipation
            // 
            lblParticipation.Dock = DockStyle.Bottom;
            lblParticipation.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParticipation.ForeColor = Color.DarkOrange;
            lblParticipation.Location = new Point(0, 338);
            lblParticipation.Name = "lblParticipation";
            lblParticipation.Size = new Size(740, 72);
            lblParticipation.TabIndex = 6;
            lblParticipation.Text = "Indica la cantidad de segundos que dura cada PARTICIPACIÓN de una candidata o candidato.";
            // 
            // nmParticipation
            // 
            nmParticipation.Dock = DockStyle.Bottom;
            nmParticipation.Font = new Font("Swis721 BlkCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nmParticipation.ForeColor = Color.FromArgb(92, 15, 139);
            nmParticipation.Location = new Point(0, 410);
            nmParticipation.Margin = new Padding(161, 145, 161, 145);
            nmParticipation.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nmParticipation.Name = "nmParticipation";
            nmParticipation.Size = new Size(740, 94);
            nmParticipation.TabIndex = 2;
            nmParticipation.TextAlign = HorizontalAlignment.Center;
            nmParticipation.ValueChanged += ValidateValueChanged;
            // 
            // lblDebate
            // 
            lblDebate.Dock = DockStyle.Bottom;
            lblDebate.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDebate.ForeColor = Color.DarkOrange;
            lblDebate.Location = new Point(0, 172);
            lblDebate.Name = "lblDebate";
            lblDebate.Size = new Size(740, 72);
            lblDebate.TabIndex = 8;
            lblDebate.Text = "Indica la cantidad de segundos que dura cada BOLSA DE TIEMPO de una candidata o candidato.";
            // 
            // nmDebate
            // 
            nmDebate.Dock = DockStyle.Bottom;
            nmDebate.Font = new Font("Swis721 BlkCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nmDebate.ForeColor = Color.FromArgb(92, 15, 139);
            nmDebate.Location = new Point(0, 244);
            nmDebate.Margin = new Padding(161, 145, 161, 145);
            nmDebate.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nmDebate.Name = "nmDebate";
            nmDebate.Size = new Size(740, 94);
            nmDebate.TabIndex = 1;
            nmDebate.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEntrance
            // 
            lblEntrance.Dock = DockStyle.Bottom;
            lblEntrance.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEntrance.ForeColor = Color.DarkOrange;
            lblEntrance.Location = new Point(0, 6);
            lblEntrance.Name = "lblEntrance";
            lblEntrance.Size = new Size(740, 72);
            lblEntrance.TabIndex = 10;
            lblEntrance.Text = "Indica la cantidad de segundos que dura cada ENTRADA de una candidata o candidato.";
            // 
            // nmEntrance
            // 
            nmEntrance.Dock = DockStyle.Bottom;
            nmEntrance.Font = new Font("Swis721 BlkCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nmEntrance.ForeColor = Color.FromArgb(92, 15, 139);
            nmEntrance.Location = new Point(0, 78);
            nmEntrance.Margin = new Padding(161, 145, 161, 145);
            nmEntrance.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nmEntrance.Name = "nmEntrance";
            nmEntrance.Size = new Size(740, 94);
            nmEntrance.TabIndex = 0;
            nmEntrance.TextAlign = HorizontalAlignment.Center;
            // 
            // Config
            // 
            AutoScaleDimensions = new SizeF(73F, 173F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 914);
            ControlBox = false;
            Controls.Add(lblEntrance);
            Controls.Add(nmEntrance);
            Controls.Add(lblDebate);
            Controls.Add(nmDebate);
            Controls.Add(lblParticipation);
            Controls.Add(nmParticipation);
            Controls.Add(lblClosure);
            Controls.Add(nmClosure);
            Controls.Add(lblExtra);
            Controls.Add(nmExtra);
            Controls.Add(bottomBar);
            Font = new Font("Swis721 BlkCn BT", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(22, 21, 22, 21);
            Name = "Config";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONFIGURAR TIEMPOS";
            TopMost = true;
            FormClosing += FormIsClosing;
            ((System.ComponentModel.ISupportInitialize)nmExtra).EndInit();
            bottomBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmClosure).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmParticipation).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmDebate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmEntrance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown nmExtra;
        private TableLayoutPanel bottomBar;
        private Button btnConfirm;
        private Button btnCancel;
        private Label lblExtra;
        private Label lblClosure;
        private NumericUpDown nmClosure;
        private Label lblParticipation;
        private NumericUpDown nmParticipation;
        private Label lblDebate;
        private NumericUpDown nmDebate;
        private Label lblEntrance;
        private NumericUpDown nmEntrance;
    }
}