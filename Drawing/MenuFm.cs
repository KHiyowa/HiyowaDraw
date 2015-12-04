using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class MenuFm : Form
    {
        public MenuFm()
        {
            InitializeComponent();
        }

        private void topMostCb_CheckedChanged(object sender, EventArgs e)
        {
            if (topMostCb.Checked == true)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }
        private void rectBtn_CheckedChanged(object sender, EventArgs e)
        {
            DrawingFm.currentShape = DrawingFm.Shape.RECT;
        }

        private void ovalBtn_CheckedChanged(object sender, EventArgs e)
        {
            DrawingFm.currentShape = DrawingFm.Shape.OVAL;
        }

        private void lineBtn_CheckedChanged(object sender, EventArgs e)
        {
            DrawingFm.currentShape = DrawingFm.Shape.LINE;
        }

        public void reflesh()
        {
            if (DrawingFm.currentShape == DrawingFm.Shape.RECT)
            {
                rectBtn.Checked = true;
            }
            else if (DrawingFm.currentShape == DrawingFm.Shape.OVAL)
            {
                ovalBtn.Checked = true;
            }
            else if (DrawingFm.currentShape == DrawingFm.Shape.LINE)
            {
                lineBtn.Checked = true;
            }
            colorBtn.BackColor = DrawingFm.currentColor;
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                DrawingFm.currentColor = cd.Color;
            }
        }

        private void refreshTm_Tick(object sender, EventArgs e)
        {
            reflesh();
        }
    }
}
