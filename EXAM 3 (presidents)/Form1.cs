using System;
using System.Windows.Forms;

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

            //event handlers for filter radio buttons
            this.radioButtonAll.CheckedChanged += new EventHandler(TypeRadioButton__CheckedChanged);
            this.radioButtonDem.CheckedChanged += new EventHandler(TypeRadioButton__CheckedChanged);
            this.radioButtonRep.CheckedChanged += new EventHandler(TypeRadioButton__CheckedChanged);
            this.radioButtonDR.CheckedChanged += new EventHandler(TypeRadioButton__CheckedChanged);
            this.radioButtonFed.CheckedChanged += new EventHandler(TypeRadioButton__CheckedChanged);

            //text box event handlers
            this.textBox1.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);

            //picture hnadlers
            this.pictureBox.MouseEnter += new EventHandler(PictureBox__MouseEnter);
            this.pictureBox.MouseLeave += new EventHandler(PictureBox__MouseLeave);

            //exit
            this.exitButton.Click += new EventHandler(ExitButton__Click);

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


                string imagePath;

                //barack obama is a png instead
                if (selectedRadioButton.Text == "Barack Obama")
                {
                    imagePath = $"Images/{selectedRadioButton.Text.Replace(" ", "")}.png";
                }
                //for all the other jpgs
                else
                {
                    imagePath = $"Images/{selectedRadioButton.Text.Replace(" ", "")}.jpeg";
                }

                //change image in picture box
                this.pictureBox.Image = System.Drawing.Image.FromFile(imagePath);

            }
        }

        private void TypeRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            //based on the radio button currectly selected
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton.Checked)
            {
                if (selectedRadioButton == this.radioButtonAll)
                {
                   
                }
                else if (selectedRadioButton == this.radioButtonDem)
                {
                    
                }
                else if (selectedRadioButton == this.radioButtonRep)
                {
                   
                }
                else if (selectedRadioButton == this.radioButtonDR)
                {
                   
                }
                else if (selectedRadioButton == this.radioButtonFed)
                {

                }
            }

        }

        private void PictureBox__MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox.BringToFront();
            this.pictureBox.Width = 200;
            this.pictureBox.Height = 300;
        }

        private void PictureBox__MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox.Width = 150;
            this.pictureBox.Height = 170;
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
