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
    public partial class ChartControl : Control
    {
        public ChartControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Pen pen = new Pens()
            base.OnPaint(pe);
            // pe.Graphics.DrawRectangle(SystemPens.ControlDark, 10, 10, 50, 50);
            //

            double minQuote = 0.9;
            // 1.5 = this.Height
            // bars[i].Low = (this.Height/1000)*bars[i].Low

            double scaleY = 1000;
            int scaleX = 8;
            int shiftY = (int)(Math.Round(this.Height*0.5));
            int widthB = 3;
            for (int i = 0; i < bars.Count; i++)
            {
                pe.Graphics.DrawRectangle(Pens.Blue, i * scaleX, (int)(shiftY + (bars[i].Low - minQuote) * scaleY), widthB, (int)((bars[i].High - bars[i].Low) * scaleY));
                // pe.Graphics.DrawRectangle(Pens.Violet, i*scaleX, (int)(shiftY+bars[i].Low*scaleY), widthB, (int)((bars[i].High-bars[i].Low)*scaleY));
            }
        }

        private List<Bar> bars;
        public List<Bar> Bars
        {
            get { return bars; }
            set { bars = value; }
        }
    }
}
