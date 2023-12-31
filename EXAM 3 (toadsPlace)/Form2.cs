﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM_3__toadsPlace_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ControlBox = false;
            this.progressBar.Visible = false;

            //button event handlers
            this.purgeButton.Click += new EventHandler(PurgeButton__Click);
            this.buttonCorrect.Click += new EventHandler(Correct__Click);

            //handlers for radio
            this.radioButton1.CheckedChanged += new EventHandler(ToadRadioButton__CheckChanged);
            this.radioButton2.CheckedChanged += new EventHandler(ToadRadioButton__CheckChanged);
            this.radioButton3.CheckedChanged += new EventHandler(ToadRadioButton__CheckChanged);
            this.radioButton4.CheckedChanged += new EventHandler(ToadRadioButton__CheckChanged);

            //text box event handlers
            this.richTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);

            //timer thread handler
            this.timer.Tick += new EventHandler(Timer__Tick);
        }
        private void PurgeButton__Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Correct__Click(object sender, EventArgs e)
        {
            //form object for second form
            Form3 toadMovie = new Form3();
            toadMovie.ShowDialog();
           
        }

        private void ToadRadioButton__CheckChanged(object sender, EventArgs e)
        {
            RadioButton selectedButton = sender as RadioButton;
            if(selectedButton == radioButton1)
            {
                this.toadBox.Image = System.Drawing.Image.FromFile("Resources/toadsworth.png");
            }
            else if(selectedButton == radioButton2)
            {
                this.toadBox.Image = System.Drawing.Image.FromFile("Resources/captainToad.png");
            }
            else if (selectedButton == radioButton3)
            {
                this.toadBox.Image = System.Drawing.Image.FromFile("Resources/toadette.png");
            }
            else if (selectedButton == radioButton4)
            {
                this.marioLabel.Text = "Mario is not here right now....";
            }

        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            //can only type letters in toad
            if(char.ToUpper(e.KeyChar) != 'T' && char.ToUpper(e.KeyChar) != 'O' && char.ToUpper(e.KeyChar) != 'A' && char.ToUpper(e.KeyChar) != 'D')
            {
                e.Handled = true;
            }

            this.timer.Start();
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            //decriment prgress bar
            --this.progressBar.Value;

            //when over
            if(this.progressBar.Value == 0)
            {
                //stop timer
                this.timer.Stop();
                //reset prgress bar
                this.progressBar.Value = 100;

                //reset the text
                this.richTextBox.ForeColor = Color.Red;
                this.richTextBox.Text = "TOO SLOW!! YOU MUST DO BETTER!";
            }

        }
















        private void toadBox_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
