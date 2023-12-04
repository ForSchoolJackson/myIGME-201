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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            this.webBrowser.Url = new System.Uri("https://www.youtube.com/watch?v=jDwVkXVHIqg");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
