using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public partial class DrawingFm 
    {
        public void changeMode(int mode)
        {
            currentMode = mode;

            selectTsmi.Checked = false;
            drawTsmi.Checked = false;

            if (mode == Mode.NONE)
            {
                modeTssl.Text = "選択モード";
                selectTsmi.Checked = true;
            }
            if (mode == Mode.DRAW)
            {
                modeTssl.Text = "描画モード";
                drawTsmi.Checked = true;
            }
            if (mode == Mode.ERASE)
            {
                modeTssl.Text = "消去モード";
            }
        }

        public void changeShape(int shape)
        {
            currentShape = shape;

            rectTsmi.Checked = false;
            ovalTsmi.Checked = false;
            lineTsmi.Checked = false;

            if (shape == Shape.RECT)
            {
                rectTsmi.Checked = true;
                fillTsmi.Enabled = true;
            }
            else if (shape == Shape.OVAL)
            {
                ovalTsmi.Checked = true;
                fillTsmi.Enabled = true;
            }
            else if (shape == Shape.LINE)
            {
                lineTsmi.Checked = true;
                fillTsmi.Enabled = false;
            }
        }
    }
}
