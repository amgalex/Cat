using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cat
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {

            //e.Graphics.DrawRectangle(SystemPens.ControlDark, 10, 10, 50, 50);
            //e.Graphics.FillRectangle(SystemPens.ControlDark, 10, 10, 50, 50);
        }
    }
}
