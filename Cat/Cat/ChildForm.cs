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
            bars = new List<Bar>();

            Random rnd = new Random();
            double lastClose = 1 + rnd.NextDouble()/10;
            for (int i = 0; i < 155; i++)
            {
                Bar bar = new Bar();
                bar.Open = lastClose;
                bar.Low =  bar.Open - rnd.NextDouble()/100;
                bar.High = bar.Open + rnd.NextDouble()/100;
                int sing = 1;
                if (rnd.NextDouble()<0.5) sing = -1;
                bar.Close = bar.Open + sing*(bar.High-bar.Low)*rnd.NextDouble();
                lastClose = bar.Close;
                bars.Add(bar);
            }

            chartControl.Bars = bars;
        }

        private List<Bar> bars;
        public List<Bar> Bars
        {
            get { return bars; }
            set { bars = value; }
        }

    }
}
