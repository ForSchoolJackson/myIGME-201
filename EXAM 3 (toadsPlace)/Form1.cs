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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ControlBox = true;

            //event handlers
            this.buttonExit.Click += new EventHandler(ButtonExit__Click);
            this.buttonStart.Click += new EventHandler(ButtonStart__Click);
            this.buttonScared.Click += new EventHandler(ButtonScared__Click);
        }

        //exit button
        private void ButtonExit__Click(object sender, EventArgs e)
        {
            //get a random
            Random random = new Random();

            //area width and height
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            //radmon widths and heights for button
            int randomX = random.Next(0, width);
            int randomY = random.Next(0, height);

            //radomize loaction of start button
            buttonStart.Location = new System.Drawing.Point(randomX, randomY);

            //add text
            this.exitText.Text = "you cannot leave. you are a part of us now.";

        }

        //start button
        private void ButtonStart__Click(object sender, EventArgs e)
        {
            //form object for second form
            Form2 toadHouse = new Form2();
            toadHouse.ShowDialog();
            //this.Hide();

        }

        //the extra button
        private void ButtonScared__Click(object sender, EventArgs e)
        {
            this.pictureBoxStart.Image = System.Drawing.Image.FromFile("Resources/toad.png");
            this.scaredLabel.Text = "Dont be scared. Its me toad. These are my friends.";
        }
    }
}
