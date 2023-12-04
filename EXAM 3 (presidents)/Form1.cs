using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_3__presidents_
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            ControlBox = false;

            this.radioButtonAll.Checked = true;
            this.exitButton.Enabled = false;

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

            //for error checking incorrect
            this.textBox1.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox2.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox3.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox4.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox5.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox6.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox7.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox8.TextChanged += new EventHandler(TextBox_TextChanged);

            this.textBox16.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox15.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox14.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox13.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox12.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox11.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox10.TextChanged += new EventHandler(TextBox_TextChanged);
            this.textBox9.TextChanged += new EventHandler(TextBox_TextChanged);

            //make tool tip 
            this.textBox1.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox2.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox3.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox4.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox5.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox6.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox7.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox8.MouseHover += new EventHandler(TextBox_MouseHover);

            this.textBox16.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox15.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox14.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox13.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox12.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox11.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox10.MouseHover += new EventHandler(TextBox_MouseHover);
            this.textBox9.MouseHover += new EventHandler(TextBox_MouseHover);

            //picture handlers
            this.pictureBox.MouseEnter += new EventHandler(PictureBox__MouseEnter);
            this.pictureBox.MouseLeave += new EventHandler(PictureBox__MouseLeave);

            //on web brwoser
            this.webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser__DocumentCompleted);

            //timer
            this.timer.Tick += new EventHandler(Timer__Tick);

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

        private void Timer__Tick(object sender, EventArgs e)
        {
            //decriment progress bar
            --this.progressBar.Value;

            //when timer is up
            if (this.progressBar.Value == 0)
            {

                this.timer.Stop();
                this.progressBar.Value = 100;

                this.textBox1.Text = "0";
                this.textBox2.Text = "0";
                this.textBox3.Text = "0";
                this.textBox4.Text = "0";
                this.textBox5.Text = "0";
                this.textBox6.Text = "0";
                this.textBox7.Text = "0";
                this.textBox8.Text = "0";
                this.textBox9.Text = "0";
                this.textBox10.Text = "0";
                this.textBox11.Text = "0";
                this.textBox12.Text = "0";
                this.textBox13.Text = "0";
                this.textBox14.Text = "0";
                this.textBox15.Text = "0";
                this.textBox16.Text = "0";
                
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            //only allow digits
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            //start timer
            this.timer.Start();

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            //based on the radio button currectly selected
            TextBox selectedText = sender as TextBox;

            //set the errors for each president
            if (selectedText == this.textBox1)
            {
                if (this.textBox1.Text == "23")
                {
                    this.errorProvider.SetError(textBox1, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox1, "Wrong");
                }
            }
            else if(selectedText == this.textBox2)
            {
                if (this.textBox2.Text == "32")
                {
                    this.errorProvider.SetError(textBox2, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox2, "Wrong");
                }
            }
            else if (selectedText == this.textBox3)
            {
                if (this.textBox3.Text == "42")
                {
                    this.errorProvider.SetError(textBox3, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox3, "Wrong");
                }
            }
            else if (selectedText == this.textBox4)
            {
                if (this.textBox4.Text == "43")
                {
                    this.errorProvider.SetError(textBox4, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox4, "Wrong");
                }
            }
            else if (selectedText == this.textBox5)
            {
                if (this.textBox5.Text == "14")
                {
                    this.errorProvider.SetError(textBox5, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox5, "Wrong");
                }
            }
            else if (selectedText == this.textBox6)
            {
                if (this.textBox6.Text == "15")
                {
                    this.errorProvider.SetError(textBox6, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox6, "Wrong");
                }
            }
            else if (selectedText == this.textBox7)
            {
                if (this.textBox7.Text == "35")
                {
                    this.errorProvider.SetError(textBox7, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox7, "Wrong");
                }
            }
            else if (selectedText == this.textBox8)
            {
                if (this.textBox8.Text == "44")
                {
                    this.errorProvider.SetError(textBox8, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox8, "Wrong");
                }
            }
            else if (selectedText == this.textBox9)
            {
                if (this.textBox9.Text == "3")
                {
                    this.errorProvider.SetError(textBox9, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox9, "Wrong");
                }
            }
            else if (selectedText == this.textBox10)
            {
                if (this.textBox10.Text == "26")
                {
                    this.errorProvider.SetError(textBox10, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox10, "Wrong");
                }
            }
            else if (selectedText == this.textBox11)
            {
                if (this.textBox11.Text == "2")
                {
                    this.errorProvider.SetError(textBox11, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox11, "Wrong");
                }
            }
            else if (selectedText == this.textBox12)
            {
                if (this.textBox12.Text == "1")
                {
                    this.errorProvider.SetError(textBox12, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox12, "Wrong");
                }
            }
            else if (selectedText == this.textBox13)
            {
                if (this.textBox13.Text == "8")
                {
                    this.errorProvider.SetError(textBox13, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox13, "Wrong");
                }
            }
            else if (selectedText == this.textBox14)
            {
                if (this.textBox14.Text == "34")
                {
                    this.errorProvider.SetError(textBox14, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox14, "Wrong");
                }
            }
            else if (selectedText == this.textBox15)
            {
                if (this.textBox15.Text == "40")
                {
                    this.errorProvider.SetError(textBox15, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox15, "Wrong");
                }
            }
            else if (selectedText == this.textBox16)
            {
                if (this.textBox16.Text == "25")
                {
                    this.errorProvider.SetError(textBox16, "");
                }
                else
                {
                    this.errorProvider.SetError(textBox16, "Wrong");
                }
            }

            //all answers correct
            if(this.textBox1.Text == "23" && this.textBox2.Text == "32" && this.textBox3.Text == "42" && this.textBox4.Text == "43"
                && this.textBox5.Text == "14" && this.textBox6.Text == "15" && this.textBox7.Text == "35" && this.textBox8.Text == "44"
                && this.textBox9.Text == "3" && this.textBox10.Text == "26" && this.textBox11.Text == "2" && this.textBox12.Text == "1"
                && this.textBox13.Text == "8" && this.textBox14.Text == "34" && this.textBox15.Text == "40" && this.textBox16.Text == "25")
            {

                this.exitButton.Enabled = true;

                timer.Stop();

                //link for webbroswer
                string link = "https://media.istockphoto.com/id/1404630183/photo/usa-america-united-states-new-year-or-independence-day-celebration-holiday-background.jpg?s=612x612&w=0&k=20&c=wz_SQCm9_uDGK34EnrbBL_yGHIeHx2MCRgqLPtZwmLY=";

                //change web broser based on radio buttons
                this.webBrowser.Url = new System.Uri(link);


            }


        }

        private void TextBox_MouseHover(object sender, EventArgs e)
        {
            //based on the radio button currectly selected
            TextBox selectedTextBox = sender as TextBox; 

            //tool tip
            toolTip = new ToolTip();
            toolTip.SetToolTip(selectedTextBox, "Which # President");
        }

        private void WebBrowser__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection allLinks = webBrowser.Document.GetElementsByTagName("a");

            foreach(HtmlElement link in allLinks)
            {
                link.SetAttribute("title", "Jackson Heim for President!");
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
