using System;
using System.Windows.Forms;

namespace EXAM_3__presidents_
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            radioButtonAll.Checked = true;

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
            this.textBox2.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox3.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox4.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox5.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox6.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox7.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox8.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);

            this.textBox16.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox15.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox14.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox13.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox12.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox11.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox10.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.textBox9.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);

            this.textBox1.TextChanged += new EventHandler(TextBox_TextChanged);



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
                    this.radioButtonBH.Checked = true;

                    this.radioButtonBH.Show();
                    this.radioButtonFDR.Show();
                    this.radioButtonWJC.Show();
                    this.radioButtonJB.Show();
                    this.radioButtonFP.Show();
                    this.radioButtonGWB.Show();
                    this.radioButtonBO.Show();
                    this.radioButtonJFK.Show();
                    this.radioButtonWMK.Show();
                    this.radioButtonRR.Show();
                    this.radioButtonDDE.Show();
                    this.radioButtonMVB.Show();
                    this.radioButtonGW.Show();
                    this.radioButtonJA.Show();
                    this.radioButtonTR.Show();
                    this.radioButtonTJ.Show();


                }
                else if (selectedRadioButton == this.radioButtonDem)
                {
                    this.radioButtonFDR.Checked = true;

                    this.radioButtonFDR.Show();
                    this.radioButtonWJC.Show();
                    this.radioButtonJB.Show();
                    this.radioButtonFP.Show();
                    this.radioButtonBO.Show();
                    this.radioButtonJFK.Show();
                    this.radioButtonMVB.Show();

                    this.radioButtonBH.Hide();
                    this.radioButtonGWB.Hide();
                    this.radioButtonWMK.Hide();
                    this.radioButtonRR.Hide();
                    this.radioButtonDDE.Hide();
                    this.radioButtonGW.Hide();
                    this.radioButtonJA.Hide();
                    this.radioButtonTR.Hide();
                    this.radioButtonTJ.Hide();

                }
                else if (selectedRadioButton == this.radioButtonRep)
                {
                    this.radioButtonBH.Checked = true;

                    this.radioButtonBH.Show();
                    this.radioButtonGWB.Show();
                    this.radioButtonWMK.Show();
                    this.radioButtonRR.Show();
                    this.radioButtonDDE.Show();
                    this.radioButtonTR.Show();

                    this.radioButtonFDR.Hide();
                    this.radioButtonWJC.Hide();
                    this.radioButtonJB.Hide();
                    this.radioButtonFP.Hide();
                    this.radioButtonBO.Hide();
                    this.radioButtonJFK.Hide();
                    this.radioButtonMVB.Hide();
                    this.radioButtonGW.Hide();
                    this.radioButtonJA.Hide();
                    this.radioButtonTJ.Hide();

                }
                else if (selectedRadioButton == this.radioButtonDR)
                {
                    this.radioButtonTJ.Checked = true;

                    this.radioButtonTJ.Show();

                    this.radioButtonBH.Hide();
                    this.radioButtonFDR.Hide();
                    this.radioButtonWJC.Hide();
                    this.radioButtonJB.Hide();
                    this.radioButtonFP.Hide();
                    this.radioButtonGWB.Hide();
                    this.radioButtonBO.Hide();
                    this.radioButtonJFK.Hide();
                    this.radioButtonWMK.Hide();
                    this.radioButtonRR.Hide();
                    this.radioButtonDDE.Hide();
                    this.radioButtonMVB.Hide();
                    this.radioButtonGW.Hide();
                    this.radioButtonJA.Hide();
                    this.radioButtonTR.Hide();

                }
                else if (selectedRadioButton == this.radioButtonFed)
                {
                    this.radioButtonGW.Checked = true;

                    this.radioButtonGW.Show();
                    this.radioButtonJA.Show();

                    this.radioButtonBH.Hide();
                    this.radioButtonFDR.Hide();
                    this.radioButtonWJC.Hide();
                    this.radioButtonJB.Hide();
                    this.radioButtonFP.Hide();
                    this.radioButtonGWB.Hide();
                    this.radioButtonBO.Hide();
                    this.radioButtonJFK.Hide();
                    this.radioButtonWMK.Hide();
                    this.radioButtonRR.Hide();
                    this.radioButtonDDE.Hide();
                    this.radioButtonMVB.Hide();
                    this.radioButtonTR.Hide();
                    this.radioButtonTJ.Hide();


                }
            }

        }

        private void PictureBox__MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox.BringToFront();
            this.pictureBox.Width = 200;
            this.pictureBox.Height = 220;
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

            //only allow digits
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            //based on the radio button currectly selected
            TextBox selectedText = sender as TextBox;

            //if null
           // if(selectedText.Text == "")
            //{
          //      selectedText.Text = "0";
           // }

            //set the errors for each president
            if (this.textBox1.Text != "23")
            {
                this.errorProvider.SetError(textBox1, "Wrong");
            }
            else
            {
                this.errorProvider.SetError(textBox1, "");
            }
            if (this.textBox2.Text != "")
            {
                this.errorProvider.SetError(textBox1, "Wrong");
            }
            else
            {
                this.errorProvider.SetError(textBox1, "");
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

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
