using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EXAM_3__presidents_
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            //event handlers for presidents radio buttons
            this.radioButtonBH.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonFDR.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonWJC.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonJB.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonFP.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonGWB.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonBO.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonJFK.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);

            this.radioButtonWMK.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonRR.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonDDE.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonMVB.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonGW.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonJA.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonTR.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.radioButtonTJ.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);


        }

        //when radio button is checked/changed
        private void ClassRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            //based on the radio button currectly selected
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                //link for webbroswer to go to
                string link = "https://en.m.wikipedia.org/wiki/";
                string website = selectedRadioButton.Text.Replace(" ", "_");

                //add the extra name to the wikipedia website link
                link += website;

                //change web broser based on radio buttons
                this.webBrowser.Url = new System.Uri(link);

                if(selectedRadioButton.Text == "Barack Obama")
                {
                    this.pictureBox.Image = Image.FromFile("Images/BarackObama,png");
                }


            }
        }








        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
