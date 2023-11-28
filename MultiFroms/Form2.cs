using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFroms
{
    public partial class GameForm : Form
    {

        int nRandom;
        int nGuesses;

        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();

            //start timer
            this.timer.Start();

            //event hndler 
            this.timer.Tick += new EventHandler(Timer_Tick);
            this.guessButton.Click += new EventHandler(guessButton_Click);
            this.guessTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);

            //generate random number
            Random rand = new Random();
            nRandom = rand.Next(lowNumber, highNumber);


            this.progressBar1.Value = 90;
            nGuesses = 0;

        }

        //timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            //decriment progress bar
            --this.progressBar1.Value;

            //when timer is up
            if (this.progressBar1.Value == 0)
            {
                this.timer.Stop();

                // show a dialog that the numbers are not valid
                MessageBox.Show("Out of time! The answer was "+ nRandom);

            }

        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            nGuesses++;

            int guess = Int32.Parse(this.guessTextBox.Text);

            if (guess > nRandom)
            {
                guessLabel.Text = guess + " Is too high.";
            }
            if(guess < nRandom)
            {
                guessLabel.Text = guess + " Is too low.";
            }
            if(guess == nRandom)
            {
                timer.Stop();
                MessageBox.Show($"Woohoo, you got it in {nGuesses} guesses!");

                this.Close();

            }



        }
    }
}
