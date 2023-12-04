namespace EXAM_3__toadsPlace_
{
    partial class Form2
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
            this.toadBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.toadBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toadBox
            // 
            this.toadBox.Location = new System.Drawing.Point(38, 40);
            this.toadBox.Name = "toadBox";
            this.toadBox.Size = new System.Drawing.Size(291, 379);
            this.toadBox.TabIndex = 1;
            this.toadBox.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toadBox);
            this.Name = "Form2";
            this.Text = "Toads House";
            ((System.ComponentModel.ISupportInitialize)(this.toadBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox toadBox;
    }
}