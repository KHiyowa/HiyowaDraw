using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Drawing
{
    public partial class DrawingFm
    {
        public int currentMode;
        public int currentShape;
        public bool shapeFilled;
        public int lineWidth;
        public Color currentEdgeColor;
        public Color currentFillColor;
        public bool drawState = false;

        abstract public class Mode
        {
            public static int SELECT = 0;
            public static int DRAW = 1;
            public static int ERASE = 2;
        }

        public void changeMode(int mode)
        {
            currentMode = mode;
            if (mode == Mode.SELECT)
            {
                modeTssl.Text = "選択モード";
            }
            if (mode == Mode.DRAW)
            {
                modeTssl.Text = "描画モード";
            }
            if (mode == Mode.ERASE)
            {
                modeTssl.Text = "消去モード";
            }
            
        }

        public void DrawingFm_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentMode == Mode.SELECT)
            {

            }
            else if (currentMode == Mode.DRAW)
            {
                drawModeMouseDown(e);
            }
            else if (currentMode == Mode.ERASE)
            {
                eraseModeMouseDown(e);
            }
        }

        private void DrawingFm_MouseMove(object sender, MouseEventArgs e)
        {
            //  ステータスバーに座標を表示
            coordinateXTssl.Text = "X = " + e.X.ToString();
            coordinateYTssl.Text = "Y = " + (e.Y - commandBarMs.Height).ToString();
            //  再描画
            if (drawState) { redraw(e); }
        }

        private void DrawingFm_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentMode == Mode.DRAW)
            {
                //  再描画
                redraw(e);
                //  描画状態フラグを無効にする
                drawState = false;
            }
            else if (currentMode == Mode.ERASE)
            {
                this.Invalidate();
            }
            //  保存状態フラグを無効に
            savedState = false;
            //  キャプションの更新
            setCaption();
        }

        #region 描画モード

        //  描画
        private void drawModeMouseDown(MouseEventArgs e)
        {
            //  描画状態フラグを有効にする
            drawState = true;
            //  Redoスタックをクリアする
            redoStack.Clear();

            Shape sh = null;
            if (currentShape == Shape.RECT)
            {
                if (shapeFilled)
                {
                    sh = new FillRect();
                }
                else
                {
                    sh = new OutlineRect();
                }

            }
            else if (currentShape == Shape.OVAL)
            {
                if (shapeFilled)
                {
                    sh = new FillOval();
                }
                else
                {
                    sh = new OutlineOval();
                }

            }
            else if (currentShape == Shape.LINE)
            {
                sh = new Line();
            }
            //  図形オブジェクトの色を設定
            sh.SetColor(currentEdgeColor, currentFillColor);
            //  線の太さを設定
            sh.SetWidth(lineWidth);
            //  図形オブジェクトの座標を設定
            sh.SetStartPoint(e.X, e.Y);
            sh.SetEndPoint(e.X, e.Y);
            //  図形オブジェクトをリストに追加
            shapeList.Add(sh);
            //  再描画
            redraw(e);
        }

        private void redraw(MouseEventArgs e)
        {
            //  図形オブジェクトをリストから取り出す
            Shape sh =
                (Shape)(shapeList[shapeList.Count - 1] as Shape);
            sh.SetEndPoint(e.X, e.Y);
            //  再描画
            this.Invalidate();
        }
        #endregion

        #region 消去モード
        public void eraseModeMouseDown(MouseEventArgs e)
        {
            for (int i = shapeList.Count - 1; i >= 0; i--)
            {
                Shape sh =
                    (Shape)(shapeList[i] as Shape);
                Point sp = sh.GetStartPoint();
                Point ep = sh.GetEndPoint();
                if (e.X > sp.X && e.X < ep.X && e.Y > sp.Y && e.Y < ep.Y)
                {
                    shapeList.RemoveAt(i);
                    break;
                }
            }
        }
        #endregion

        private void DrawingFm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Shape sh in shapeList)
            {
                sh.Draw(g);
            }
        }
    }
}
