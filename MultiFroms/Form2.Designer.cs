namespace MultiFroms
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(262, 50);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(69, 20);
            this.guessTextBox.TabIndex = 0;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(237, 88);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 1;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guess:";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.ForeColor = System.Drawing.Color.Red;
            this.guessLabel.Location = new System.Drawing.Point(259, 126);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(0, 13);
            this.guessLabel.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 194);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(546, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 194);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(546, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 216);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessTextBox);
            this.Name = "GameForm";
            this.Text = "Guesses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer;
    }
}