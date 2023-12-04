namespace EXAM_3__question_3_
{
    partial class Start
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.titleScreen = new System.Windows.Forms.Label();
            this.exitText = new System.Windows.Forms.Label();
            this.buttonScared = new System.Windows.Forms.Button();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.scaredLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(30, 43);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(501, 206);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // titleScreen
            // 
            this.titleScreen.AutoSize = true;
            this.titleScreen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.titleScreen.ForeColor = System.Drawing.Color.Firebrick;
            this.titleScreen.Location = new System.Drawing.Point(134, 43);
            this.titleScreen.Name = "titleScreen";
            this.titleScreen.Size = new System.Drawing.Size(528, 120);
            this.titleScreen.TabIndex = 3;
            this.titleScreen.Text = "JOIN US. ";
            // 
            // exitText
            // 
            this.exitText.AutoSize = true;
            this.exitText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitText.Location = new System.Drawing.Point(498, 232);
            this.exitText.Name = "exitText";
            this.exitText.Size = new System.Drawing.Size(0, 13);
            this.exitText.TabIndex = 4;
            // 
            // buttonScared
            // 
            this.buttonScared.Location = new System.Drawing.Point(66, 311);
            this.buttonScared.Name = "buttonScared";
            this.buttonScared.Size = new System.Drawing.Size(75, 23);
            this.buttonScared.TabIndex = 5;
            this.buttonScared.Text = "Im scared";
            this.buttonScared.UseVisualStyleBackColor = true;
            this.buttonScared.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStart.Location = new System.Drawing.Point(154, 291);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(139, 147);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStart.TabIndex = 6;
            this.pictureBoxStart.TabStop = false;
            // 
            // scaredLabel
            // 
            this.scaredLabel.AutoSize = true;
            this.scaredLabel.Location = new System.Drawing.Point(63, 291);
            this.scaredLabel.Name = "scaredLabel";
            this.scaredLabel.Size = new System.Drawing.Size(0, 13);
            this.scaredLabel.TabIndex = 7;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EXAM_3__question_3_.Properties.Resources.cult;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scaredLabel);
            this.Controls.Add(this.pictureBoxStart);
            this.Controls.Add(this.buttonScared);
            this.Controls.Add(this.exitText);
            this.Controls.Add(this.titleScreen);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Name = "Start";
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label exitText;
        private System.Windows.Forms.Label titleScreen;
        private System.Windows.Forms.Button buttonScared;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.Label scaredLabel;
    }
}

