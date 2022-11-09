namespace B22_Ex05_ItayGrinberg_209413277_GuyGanot_207044363
{
    partial class FormGame
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
            this.labelPlayerOne = new System.Windows.Forms.Label();
            this.labelPlayerTwo = new System.Windows.Forms.Label();
            this.panelPlayersLabels = new System.Windows.Forms.Panel();
            this.panelPlayersLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPlayerOne
            // 
            this.labelPlayerOne.AutoSize = true;
            this.labelPlayerOne.Location = new System.Drawing.Point(75, 28);
            this.labelPlayerOne.Name = "labelPlayerOne";
            this.labelPlayerOne.Size = new System.Drawing.Size(69, 20);
            this.labelPlayerOne.TabIndex = 0;
            this.labelPlayerOne.Text = "Player 1:";
            // 
            // labelPlayerTwo
            // 
            this.labelPlayerTwo.AutoSize = true;
            this.labelPlayerTwo.Location = new System.Drawing.Point(319, 28);
            this.labelPlayerTwo.Name = "labelPlayerTwo";
            this.labelPlayerTwo.Size = new System.Drawing.Size(69, 20);
            this.labelPlayerTwo.TabIndex = 1;
            this.labelPlayerTwo.Text = "Player 2:";
            // 
            // panelPlayersLabels
            // 
            this.panelPlayersLabels.Controls.Add(this.labelPlayerOne);
            this.panelPlayersLabels.Controls.Add(this.labelPlayerTwo);
            this.panelPlayersLabels.Location = new System.Drawing.Point(10, 10);
            this.panelPlayersLabels.Name = "panelPlayersLabels";
            this.panelPlayersLabels.Size = new System.Drawing.Size(468, 79);
            this.panelPlayersLabels.TabIndex = 2;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 499);
            this.Controls.Add(this.panelPlayersLabels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.Text = "Damka";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.panelPlayersLabels.ResumeLayout(false);
            this.panelPlayersLabels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerOne;
        private System.Windows.Forms.Label labelPlayerTwo;
        private System.Windows.Forms.Panel panelPlayersLabels;
    }
}