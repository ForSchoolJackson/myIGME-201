using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleLib;
using CourseLib;
using PeopleAppGlobals;
using EditPerson;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
 * Comtrols
 * TeacherButton
 * StudentButton
 * ImageList
 * SplitContainer
 * FlowLayoutPanel
 * Panel
 * ToolStrip
 * ToolStipLinkLabel
 * ToolStripButton
 * EmailLabel
 * PhotoGroupBox
 * PhotoPictureBox
 * PlusImage
 * MinusImage
 * PeopleGlobals.dll
 * EditPerson.dll
 */

namespace Tutorial5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Globals.AddPeopleSampleData();

            this.teacherButton.Click += new EventHandler(TeacherButton__Click);
            this.studentButton.Click += new EventHandler(StudentButton__Click);

            this.panel1.Visible = false;
        }

        private void TeacherButton__Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();

            foreach(KeyValuePair<string,Person>keyValuePair in Globals.people.sortedList)
            {
                if(keyValuePair.Value.GetType() == typeof(Teacher))
                {
                    AddPanel(keyValuePair.Value);
                }
            }

            teacherButton.Text = this.flowLayoutPanel1.Controls.Count.ToString();
        }

        private void StudentButton__Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();

            foreach (KeyValuePair<string, Person> keyValuePair in Globals.people.sortedList)
            {
                if (keyValuePair.Value.GetType() == typeof(Student))
                {
                    AddPanel(keyValuePair.Value);
                }
            }

            studentButton.Text = this.flowLayoutPanel1.Controls.Count.ToString();
        }

        private void AddPanel(Person person)
        {
            Panel panel1 = new System.Windows.Forms.Panel();

            AddPersonToPanel(ref panel1, person);

            this.flowLayoutPanel1.Controls.Add(panel1);
            this.flowLayoutPanel1.Controls.SetChildIndex(panel1,flowLayoutPanel1.Controls.Count);
        }

        private void AddPersonToPanel(ref Panel panel1, Person person)
        {
           ToolStrip toolStrip1 = new System.Windows.Forms.ToolStrip();
           ToolStripButton toolStripButton1 = new System.Windows.Forms.ToolStripButton();
           ToolStripLabel toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
           Label emailLabel = new System.Windows.Forms.Label();
           GroupBox photoGroupBox = new System.Windows.Forms.GroupBox();
           PictureBox photoPictureBox = new System.Windows.Forms.PictureBox();

            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(photoGroupBox);
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(189, 25);
            panel1.TabIndex = 0;
            panel1.Tag = person;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripButton1,
            toolStripLabel1});
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            toolStrip1.Size = new System.Drawing.Size(185, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            //
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = global::Tutorial5.Properties.Resources.plus;
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += new EventHandler(ToolStripButton1__Click);
            toolStripButton1.Tag = panel1;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.AutoSize = false;
            toolStripLabel1.IsLink = true;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            toolStripLabel1.Size = new System.Drawing.Size(140, 22);
            toolStripLabel1.Text = person.name;
            toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolStripLabel1.Click += new EventHandler(ToolStripLabel1__Click);
            toolStripLabel1.Tag = panel1;
            // 
            // emailLabel
            // 
            emailLabel.Location = new System.Drawing.Point(3, 25);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(174, 23);
            emailLabel.TabIndex = 1;
            emailLabel.Text = person.email;
            // 
            // photoGroupBox
            // 
            photoGroupBox.Controls.Add(photoPictureBox);
            photoGroupBox.Location = new System.Drawing.Point(6, 52);
            photoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            photoGroupBox.Name = "photoGroupBox";
            photoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            photoGroupBox.Size = new System.Drawing.Size(126, 98);
            photoGroupBox.TabIndex = 52;
            photoGroupBox.TabStop = false;
            photoGroupBox.Text = "Photo";
            // 
            // photoPictureBox
            // 
            photoPictureBox.BackColor = System.Drawing.Color.LightGray;
            photoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            photoPictureBox.Location = new System.Drawing.Point(4, 17);
            photoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            photoPictureBox.Name = "photoPictureBox";
            photoPictureBox.Size = new System.Drawing.Size(118, 77);
            photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            photoPictureBox.TabIndex = 0;
            photoPictureBox.TabStop = false;
            photoPictureBox.ImageLocation = person.photoPath;
        }

        //expands and shrinks panel
        private void ToolStripButton1__Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = (ToolStripButton)sender;
            Panel p = (Panel)tsb.Tag;

            if (tsb.Checked)
            {
                tsb.Image = global::Tutorial5.Properties.Resources.plus;
                p.Size = new System.Drawing.Size(189, 25);
                tsb.Checked = false;
            }
            else
            {
                tsb.Image = global::Tutorial5.Properties.Resources.minus;
                p.Size = new System.Drawing.Size(189, 159);
                tsb.Checked = true;
            }

            p.Refresh();
        }

        private void ToolStripLabel1__Click(object sender, EventArgs e)
        {
            ToolStripLabel tsl = (ToolStripLabel)sender;
            Panel p = (Panel)tsl.Tag;

            PersonEditForm pef = new PersonEditForm((Person)p.Tag, this);
            pef.Visible = false;

            pef.ShowDialog();

            Person person = pef.formPerson;

            p.Controls.Clear();

            AddPersonToPanel(ref p, person);

            p.Refresh();
        }
    }
}
