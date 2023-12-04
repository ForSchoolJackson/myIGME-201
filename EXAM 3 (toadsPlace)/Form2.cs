using System;
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

            //event handlers
            this.purgeButton.Click += new EventHandler(PurgeButton__Click);

            //handlers for radio
            this.radioButton1.CheckedChanged += new EventHandler(ToadRadioButton__CheckChanged);
            this.radioButton2.CheckedChanged += new EventHandler(ToadRadioButton__CheckChanged);
            this.radioButton3.CheckedChanged += new EventHandler(ToadRadioButton__CheckChanged);
            this.radioButton4.CheckedChanged += new EventHandler(ToadRadioButton__CheckChanged);

            //text box event handlers
            this.richTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.richTextBox.TextChanged += new EventHandler(TextBox__TextChanged);

            //timer thread handler
            this.timer.Tick += new EventHandler(Timer__Tick);
        }
        private void PurgeButton__Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ToadRadioButton__CheckChanged(object sender, EventArgs e)
        {
            RadioButton selectedButton = sender as RadioButton;
            if(selectedButton == radioButton1)
            {

            }else if(selectedButton == radioButton2)
            {

            }
            else if (selectedButton == radioButton3)
            {

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
        }

        private void TextBox__TextChanged(object sender, EventArgs e)
        {

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
