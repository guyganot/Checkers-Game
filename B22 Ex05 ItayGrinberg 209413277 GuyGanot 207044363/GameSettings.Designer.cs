namespace B22_Ex05_ItayGrinberg_209413277_GuyGanot_207044363
{
    partial class GameSettings
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
            this.textPlayerTwoName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPlayerOneName = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.checkboxIsPlayerHuman = new System.Windows.Forms.CheckBox();
            this.radioEightByEight = new System.Windows.Forms.RadioButton();
            this.radioSixBySix = new System.Windows.Forms.RadioButton();
            this.radioTenByTen = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPlayerTwoName
            // 
            this.textPlayerTwoName.Enabled = false;
            this.textPlayerTwoName.Location = new System.Drawing.Point(170, 195);
            this.textPlayerTwoName.Name = "textPlayerTwoName";
            this.textPlayerTwoName.Size = new System.Drawing.Size(169, 26);
            this.textPlayerTwoName.TabIndex = 3;
            this.textPlayerTwoName.Text = "[Computer]";
            this.textPlayerTwoName.TextChanged += new System.EventHandler(this.textPlayerTwoName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Board Size:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Players:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player 1:";
            // 
            // textPlayerOneName
            // 
            this.textPlayerOneName.Location = new System.Drawing.Point(170, 150);
            this.textPlayerOneName.Name = "textPlayerOneName";
            this.textPlayerOneName.Size = new System.Drawing.Size(169, 26);
            this.textPlayerOneName.TabIndex = 8;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(264, 251);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 38);
            this.buttonDone.TabIndex = 9;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // checkboxIsPlayerHuman
            // 
            this.checkboxIsPlayerHuman.AutoSize = true;
            this.checkboxIsPlayerHuman.Location = new System.Drawing.Point(60, 200);
            this.checkboxIsPlayerHuman.Name = "checkboxIsPlayerHuman";
            this.checkboxIsPlayerHuman.Size = new System.Drawing.Size(91, 24);
            this.checkboxIsPlayerHuman.TabIndex = 10;
            this.checkboxIsPlayerHuman.Text = "Player2:";
            this.checkboxIsPlayerHuman.UseVisualStyleBackColor = true;
            this.checkboxIsPlayerHuman.CheckedChanged += new System.EventHandler(this.checkboxIsPlayerHuman_CheckedChanged);
            // 
            // radioEightByEight
            // 
            this.radioEightByEight.AutoSize = true;
            this.radioEightByEight.Location = new System.Drawing.Point(100, 3);
            this.radioEightByEight.Name = "radioEightByEight";
            this.radioEightByEight.Size = new System.Drawing.Size(67, 24);
            this.radioEightByEight.TabIndex = 1;
            this.radioEightByEight.TabStop = true;
            this.radioEightByEight.Text = "8 x 8";
            this.radioEightByEight.UseVisualStyleBackColor = true;
            this.radioEightByEight.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioSixBySix
            // 
            this.radioSixBySix.AutoSize = true;
            this.radioSixBySix.Checked = true;
            this.radioSixBySix.Location = new System.Drawing.Point(5, 3);
            this.radioSixBySix.Name = "radioSixBySix";
            this.radioSixBySix.Size = new System.Drawing.Size(67, 24);
            this.radioSixBySix.TabIndex = 0;
            this.radioSixBySix.TabStop = true;
            this.radioSixBySix.Text = "6 x 6";
            this.radioSixBySix.UseVisualStyleBackColor = true;
            // 
            // radioTenByTen
            // 
            this.radioTenByTen.AutoSize = true;
            this.radioTenByTen.Location = new System.Drawing.Point(199, 3);
            this.radioTenByTen.Name = "radioTenByTen";
            this.radioTenByTen.Size = new System.Drawing.Size(85, 24);
            this.radioTenByTen.TabIndex = 2;
            this.radioTenByTen.Text = "10 x 10";
            this.radioTenByTen.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioEightByEight);
            this.panel1.Controls.Add(this.radioSixBySix);
            this.panel1.Controls.Add(this.radioTenByTen);
            this.panel1.Location = new System.Drawing.Point(42, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 35);
            this.panel1.TabIndex = 11;
            // 
            // GameSettings
            // 
            this.AcceptButton = this.buttonDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkboxIsPlayerHuman);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textPlayerOneName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPlayerTwoName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettings";
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.GameSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textPlayerTwoName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPlayerOneName;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.CheckBox checkboxIsPlayerHuman;
        private System.Windows.Forms.RadioButton radioEightByEight;
        private System.Windows.Forms.RadioButton radioSixBySix;
        private System.Windows.Forms.RadioButton radioTenByTen;
        private System.Windows.Forms.Panel panel1;
    }
}

