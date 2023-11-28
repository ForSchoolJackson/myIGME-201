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
        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();

            //start timer
            this.timer.Start();

            //event hndler 
            this.timer.Tick += new EventHandler(Timer_Tick);
            this.guessButton.Click += new EventHandler(guessButton_Click);

            //generate random number
            Random rand = new Random();
            int nRandom = rand.Next(lowNumber, highNumber);

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
         
            }

        }

        private void guessButton_Click(object sender, EventArgs e)
        {

        }
    }
}
