using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM_3__question_3_
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();

            //event handlers
            this.buttonExit.Click += new EventHandler(ButtonExit__Click);
            this.buttonStart.Click += new EventHandler(ButtonStart__Click);
            this.buttonScared.Click += new EventHandler(ButtonScared__Click);
        }

        //exit button
        private void ButtonExit__Click(object sender, EventArgs e)
        {

            this.exitText.Text = "you cannot leave. you are a part of us now.";

        }

        //start button
        private void ButtonStart__Click(object sender, EventArgs e)
        {
            //form object for second form
            ToadHouse toadHouse = new ToadHouse();
            toadHouse.ShowDialog();
            this.Hide();
        }

        //the extra button
        private void ButtonScared__Click(object sender, EventArgs e)
        {
            this.pictureBoxStart.Image = System.Drawing.Image.FromFile("Resources/toad.png");
            this.scaredLabel.Text = "Dont be scared. Its me toad. These are my friends.";
        }


















        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
