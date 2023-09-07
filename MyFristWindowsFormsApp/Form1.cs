using System;
using System.Windows.Forms;

namespace MyFristWindowsFormsApp
{
    // Class: HoudiniForm 
    // Purpose: A form that shows a picture of Houdini, but hides him if the mouse hovers over it 
    // Restrictions: None 
    public partial class HoudiniForm : Form
    {
        // the Form constructor initializes control properties and event handlers 
        public HoudiniForm()
        {
            // auto-generated method that creates the controls from the Form Designer 
            // InitializeComponent() is defined in the auto-generated file Form1.Designer.cs 
            // THIS MUST BE THE FIRST STATEMENT IN THE FORM CONSTRUCTOR 
            InitializeComponent();
            // every Windows control has a Tag field that can be used for any purpose 
            // let's use it to determine whether the houdiniPictureBox is visible 
            this.houdiniPictureBox.Tag = true;

            // set the URL of the houdiniPictureBox image location 
            this.houdiniPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/Houdini.jpg";

            // set the event handler when the mouse enters the PictureBox to call HoudiniPictureBox__MouseEnterLeave 
            this.houdiniPictureBox.MouseEnter += new EventHandler(HoudiniPictureBox__MouseEnterLeave);

            // set the event handler when the mouse leaves the PictureBox to call HoudiniPictureBox__MouseEnterLeave 
            this.houdiniPictureBox.MouseLeave += new EventHandler(HoudiniPictureBox__MouseEnterLeave);

            // set the event handler when the exitButton is clicked to call ExitButton__Click and exit the app 
            this.exitButton.Click += new EventHandler(ExitButton__Click);
        }

        // Method: ExitButton__Click 
        // Purpose: Exit the app when the exit button is clicked 
        private void Form1_Load(object sender, EventArgs e)
        {
            // exit the application 
            Application.Exit();
        }
    }
}

