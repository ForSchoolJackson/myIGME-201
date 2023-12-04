namespace EXAM_3__toadsPlace_
{
    partial class Form1
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
            this.scaredLabel = new System.Windows.Forms.Label();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.buttonScared = new System.Windows.Forms.Button();
            this.exitText = new System.Windows.Forms.Label();
            this.titleScreen = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.SuspendLayout();
            // 
            // scaredLabel
            // 
            this.scaredLabel.AutoSize = true;
            this.scaredLabel.Location = new System.Drawing.Point(117, 276);
            this.scaredLabel.Name = "scaredLabel";
            this.scaredLabel.Size = new System.Drawing.Size(0, 13);
            this.scaredLabel.TabIndex = 14;
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStart.Location = new System.Drawing.Point(208, 276);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(139, 147);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStart.TabIndex = 13;
            this.pictureBoxStart.TabStop = false;
            // 
            // buttonScared
            // 
            this.buttonScared.Location = new System.Drawing.Point(120, 296);
            this.buttonScared.Name = "buttonScared";
            this.buttonScared.Size = new System.Drawing.Size(75, 23);
            this.buttonScared.TabIndex = 12;
            this.buttonScared.Text = "Im scared";
            this.buttonScared.UseVisualStyleBackColor = true;
            // 
            // exitText
            // 
            this.exitText.AutoSize = true;
            this.exitText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitText.Location = new System.Drawing.Point(552, 217);
            this.exitText.Name = "exitText";
            this.exitText.Size = new System.Drawing.Size(0, 13);
            this.exitText.TabIndex = 11;
            // 
            // titleScreen
            // 
            this.titleScreen.AutoSize = true;
            this.titleScreen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.titleScreen.ForeColor = System.Drawing.Color.Firebrick;
            this.titleScreen.Location = new System.Drawing.Point(188, 28);
            this.titleScreen.Name = "titleScreen";
            this.titleScreen.Size = new System.Drawing.Size(528, 120);
            this.titleScreen.TabIndex = 10;
            this.titleScreen.Text = "JOIN US. ";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(555, 191);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(84, 28);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EXAM_3__toadsPlace_.Properties.Resources.cult;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scaredLabel);
            this.Controls.Add(this.pictureBoxStart);
            this.Controls.Add(this.buttonScared);
            this.Controls.Add(this.exitText);
            this.Controls.Add(this.titleScreen);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scaredLabel;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.Button buttonScared;
        private System.Windows.Forms.Label exitText;
        private System.Windows.Forms.Label titleScreen;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonStart;
    }
}

