using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing;


namespace AnalogClock
{


    public partial class MainForm : Form
    {
        private Rectangle rect;
        private LinearGradientBrush borderColor;
        private SolidBrush clockFaceColor;
        private SolidBrush numersColor;
        private SolidBrush signatureColor;
        private Pen hourPen;
        private Pen secPen;
        private int diameter;

        public void InitiationTools()
        {
            
        }


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
