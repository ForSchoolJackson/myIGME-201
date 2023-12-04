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
        }
        private void PurgeButton__Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
















        private void toadBox_Click(object sender, EventArgs e)
        {

        }
    }
}
