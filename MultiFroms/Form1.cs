using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MultiFroms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            this.startButton.Click += new EventHandler(StartButton_Click);
            this.lowTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.highTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse
            lowNumber = Int32.Parse(this.lowTextBox.Text);
            highNumber = Int32.Parse(this.highTextBox.Text);

            // if not a valid range
            if ( lowNumber >= highNumber )
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog,
                // which makes the first form inactive
                gameForm.ShowDialog();
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
















        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
