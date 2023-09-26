using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem_Click);
            this.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem_Click);
            this.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem_Click);

            this.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem_Click);
            this.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem_Click);
            this.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem_Click);

            this.boldToolStripMenuItem.Click += new EventHandler(BoldToolStripMenuItem_Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(ItalicsToolStripMenuItem_Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(UnderlineToolStripMenuItem_Click);

            this.mSSansSerifToolStripMenuItem.Click += new EventHandler(MSSansSerifToolStripMenuItem_Click);
            this.timesNewRomanToolStripMenuItem.Click += new EventHandler(TimesNewRomanToolStripMenuItem_Click);

            this.testToolStripButton.Click += new EventHandler(TestToolStripButton_Click);

            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip_ItemClicked);

            this.richTextBox.SelectionChanged += new EventHandler(RichTextBox_SelectionChanged);

            this.countdownLabel.Visible = false;

            this.timer.Tick += new EventHandler(Timer_Tick);

            this.Text = "MyEditor";

        }

        //new tool
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "MyEditor";

        }

        //typing text
        private void TestToolStripButton_Click(object sender, EventArgs e)
        {
            this.timer.Interval = 500;

            this.toolStripProgressBar1.Value = 60;

            this.countdownLabel.Text = "3";
            this.countdownLabel.Visible = true;
            this.richTextBox.Visible = false;

            //while counting down
            for (int i = 3; i>0; --i)
            {
                this.countdownLabel.Text = i.ToString();
                this.Refresh();
                Thread.Sleep(1000);
            }

            this.countdownLabel.Visible = false;
            this.richTextBox.Visible = true;

            this.timer.Start();

        }

        //timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            //decriment progress bar
            --this.toolStripProgressBar1.Value;

            //when timer is up
            if (this.toolStripProgressBar1.Value == 0)
            {
                this.timer.Stop();
                //message for finish
                string performance = "Congratulations! You Typed " + Math.Round(this.richTextBox.TextLength / 30.0, 2) + " letters per second!";

                MessageBox.Show(performance);
            }

        }

        //bold menu strip
        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            //for multiple fonts
            if(selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            //unbolds bold text
            SetSelectionFont(fontStyle, !selectionFont.Bold);
        }

        //italics menu strip
        private void ItalicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            SetSelectionFont(fontStyle, !selectionFont.Italic);
        }

        //underline menu strip
        private void UnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;

            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            SetSelectionFont(fontStyle, !selectionFont.Underline);
        }

        //sans serif
        private void MSSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont = new Font("MS Sans Serif", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);

            richTextBox.SelectionFont = newFont;
        }

        //times new roman
        private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Times New Roman", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);

            richTextBox.SelectionFont = newFont;
        }

        //make selection show up on menu
        private void RichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            //if selected
            if(this.richTextBox.SelectionFont != null)
            {
                this.boldToolStripButton.Checked = richTextBox.SelectionFont.Bold;
                this.italicsToolStripButton.Checked = richTextBox.SelectionFont.Italic;
                this.underlineToolStripButton.Checked = richTextBox.SelectionFont.Underline;

            }
            //color of color picker changes
            this.colorToolStripButton.BackColor = richTextBox.SelectionColor;
        }



        //Open tool
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if(openFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.LoadFile(openFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + openFileDialog.FileName + ")";

            }
        }

        //save tool
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = openFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (saveFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.SaveFile(saveFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + saveFileDialog.FileName + ")";
            }
        }

        //exit tool
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //copy tool
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        //cut tool
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        //paste tool
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        //differnt text modes
        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;

            //bold
            if(e.ClickedItem == this.boldToolStripButton)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.boldToolStripButton;

            }//italic
            else if(e.ClickedItem == this.italicsToolStripButton)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicsToolStripButton;
            }//underline
            else if (e.ClickedItem == this.underlineToolStripButton)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton;
            }//color
            else if (e.ClickedItem == this.colorToolStripButton)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                    colorToolStripButton.BackColor = colorDialog.Color;
                }
            }

            //font styles
            if( fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }

        }

        //selecting font
        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;


            selectionFont = richTextBox.SelectionFont;
            if(selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {
                //underline = 4, Bold = 1, Italics + 2
                //all  three is 111
                //underline is 100
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }

            this.richTextBox.SelectionFont = newFont;

        }

        private void italicsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
