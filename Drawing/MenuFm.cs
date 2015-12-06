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
        DrawingFm df;
        public MenuFm(DrawingFm df)
        {
            InitializeComponent();

            this.df = df;
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

        //  フロートメニューの情報の更新
        //  コマンドバーから変更された設定をフロートメニューに反映する
        public void reflesh()
        {
            //  Undoの可否を反映
            if (DrawingFm.shapeList.Count != 0)
            {
                undoBtn.Enabled = true;
            }
            else
            {
                undoBtn.Enabled = false;
            }
            //  Redoの可否を反映
            if (DrawingFm.redoStack.Count != 0)
            {
                redoBtn.Enabled = true;
            }
            else
            {
                redoBtn.Enabled = false;
            }
            //  塗りつぶしの状態を反映
            fillBtn.Checked = DrawingFm.shapeFilled;
            if (DrawingFm.shapeFilled)
            {
                rectBtn.Text = "■";
            }
            else
            {
                rectBtn.Text = "□";
            }
            if (DrawingFm.shapeFilled)
            {
                ovalBtn.Text = "●";
            }
            else
            {
                ovalBtn.Text = "○";
            }

            //  現在選択されている図形の反映
            if (DrawingFm.currentShape == DrawingFm.Shape.RECT)
            {
                rectBtn.Checked = true;
                fillBtn.Text = rectBtn.Text;
                fillBtn.Enabled = true;
            }
            else if (DrawingFm.currentShape == DrawingFm.Shape.OVAL)
            {
                ovalBtn.Checked = true;
                fillBtn.Text = ovalBtn.Text;
                fillBtn.Enabled = true;
            }
            else if (DrawingFm.currentShape == DrawingFm.Shape.LINE)
            {
                lineBtn.Checked = true;
                fillBtn.Enabled = false;
                fillBtn.Text = "";
            }

            //  現在選択されている色の反映
            colorBtn.BackColor = DrawingFm.currentColor;

            //  線の太さを反映
            lineWidthNud.Value = DrawingFm.lineWidth;
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

        private void lineWidthNud_ValueChanged(object sender, EventArgs e)
        {
            DrawingFm.lineWidth = Decimal.ToInt32(lineWidthNud.Value);
        }

        private void fillBtn_CheckedChanged(object sender, EventArgs e)
        {
            DrawingFm.shapeFilled = fillBtn.Checked;
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            df.undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            df.redo();
        }
    }
}
