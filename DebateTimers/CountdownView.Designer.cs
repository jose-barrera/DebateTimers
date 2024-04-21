namespace DebateTimers
{
    partial class CountdownView
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            display = new Label();
            lblName = new Label();
            SuspendLayout();
            // 
            // display
            // 
            display.BackColor = Color.White;
            display.Dock = DockStyle.Fill;
            display.Font = new Font("Swis721 BlkCn BT", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            display.ForeColor = Color.FromArgb(92, 15, 139);
            display.Location = new Point(0, 50);
            display.Name = "display";
            display.Size = new Size(682, 262);
            display.TabIndex = 0;
            display.Text = "00:00";
            display.TextAlign = ContentAlignment.MiddleCenter;
            display.DoubleClick += DisplayDoubleClick;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Top;
            lblName.ImageAlign = ContentAlignment.TopCenter;
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(682, 50);
            lblName.TabIndex = 1;
            lblName.Text = "...";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CountdownView
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(display);
            Controls.Add(lblName);
            Font = new Font("Swis721 BlkCn BT", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CountdownView";
            Size = new Size(682, 312);
            Load += CountdownViewLoad;
            ResumeLayout(false);
        }

        #endregion

        private Label display;
        private Label lblName;
    }
}
