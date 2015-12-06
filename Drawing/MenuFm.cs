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
            df.currentShape = DrawingFm.Shape.RECT;
        }

        private void ovalBtn_CheckedChanged(object sender, EventArgs e)
        {
            df.currentShape = DrawingFm.Shape.OVAL;
        }

        private void lineBtn_CheckedChanged(object sender, EventArgs e)
        {
            df.currentShape = DrawingFm.Shape.LINE;
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            if (df.currentMode == DrawingFm.Mode.DRAW)
            {
                df.changeMode(DrawingFm.Mode.NONE);
            }
            else
            {
                df.changeMode(DrawingFm.Mode.DRAW);
            }
        }

        private void eraseBtn_Click(object sender, EventArgs e)
        {
            if (df.currentMode == DrawingFm.Mode.ERASE)
            {
                df.changeMode(DrawingFm.Mode.NONE);
            }
            else
            {
                df.changeMode(DrawingFm.Mode.ERASE);
            }
        }

        //  フロートメニューの情報の更新
        //  コマンドバーから変更された設定をフロートメニューに反映する
        public void reflesh()
        {
            //  Undoの可否を反映
            if (DrawingFm.shapeList.Count != 0)
            {
                undoBtn.Enabled = true;
                undoBtn.BackgroundImage = Properties.Resources.undoEnabled;
            }
            else
            {
                undoBtn.Enabled = false;
                undoBtn.BackgroundImage = Properties.Resources.undoDisabled;
            }
            //  Redoの可否を反映
            if (DrawingFm.redoStack.Count != 0)
            {
                redoBtn.Enabled = true;
                redoBtn.BackgroundImage = Properties.Resources.redoEnabled;
            }
            else
            {
                redoBtn.Enabled = false;
                redoBtn.BackgroundImage = Properties.Resources.redoDisabled;
            }

            //  モード選択の反映
            if (df.currentMode == DrawingFm.Mode.NONE)
            {
                drawBtn.Checked = false;
                eraseBtn.Checked = false;
            }
            else if (df.currentMode == DrawingFm.Mode.DRAW)
            {
                drawBtn.Checked = true;
            }
            else if (df.currentMode == DrawingFm.Mode.ERASE)
            {
                eraseBtn.Checked = true;
            }

            //  塗りつぶしの状態を反映
            fillBtn.Checked = df.shapeFilled;
            if (df.shapeFilled)
            {
                rectBtn.Text = "■";
                ovalBtn.Text = "●";
                fillColorBtn.Visible = true;
            }
            else
            {
                rectBtn.Text = "□";
                ovalBtn.Text = "○";
                fillColorBtn.Visible = false;
            }

            //  現在選択されている図形の反映
            if (df.currentShape == DrawingFm.Shape.RECT)
            {
                rectBtn.Checked = true;
                fillBtn.Text = rectBtn.Text;
                fillBtn.Visible = true;
            }
            else if (df.currentShape == DrawingFm.Shape.OVAL)
            {
                ovalBtn.Checked = true;
                fillBtn.Text = ovalBtn.Text;
                fillBtn.Visible = true;
            }
            else if (df.currentShape == DrawingFm.Shape.LINE)
            {
                lineBtn.Checked = true;
                fillBtn.Visible = false;
            }

            //  現在選択されている色の反映
            edgeColorBtn.BackColor = df.currentEdgeColor;
            fillColorBtn.BackColor = df.currentFillColor;

            //  線の太さを反映
            lineWidthNud.Value = df.lineWidth;
        }

        private void edgeColorBtn_Click(object sender, EventArgs e)
        {
            if (df.cd.ShowDialog() == DialogResult.OK)
            {
                df.currentEdgeColor = df.cd.Color;
            }
        }
        private void fillColorBtn_Click(object sender, EventArgs e)
        {
            if (df.cd.ShowDialog() == DialogResult.OK)
            {
                df.currentFillColor = df.cd.Color;
            }
        }

        private void refreshTm_Tick(object sender, EventArgs e)
        {
            reflesh();
        }

        private void lineWidthNud_ValueChanged(object sender, EventArgs e)
        {
            df.lineWidth = Decimal.ToInt32(lineWidthNud.Value);
        }

        private void fillBtn_CheckedChanged(object sender, EventArgs e)
        {
            df.shapeFilled = fillBtn.Checked;
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
