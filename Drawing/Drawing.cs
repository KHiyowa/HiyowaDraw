using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Drawing
{
    //  描画モードに関するメソッド類

    public partial class DrawingFm
    {
        public int currentMode;
        public int currentShape;
        public bool shapeFilled;
        public int lineWidth;
        public Color currentEdgeColor;
        public Color currentFillColor;
        public static List<Shape> shapeList;

        #region Shapeの定義
        [Serializable]
        abstract public class Shape
        {
            public static int RECT = 0;
            public static int OVAL = 1;
            public static int LINE = 2;
            protected int x1, y1, x2, y2;
            protected Color ec;
            protected Color fc;
            protected int w;

            abstract public void Draw(Graphics g);

            public void SetColor(Color ec, Color fc)
            {
                this.ec = ec;
                this.fc = fc;
            }
            public void SetWidth(int w)
            {
                this.w = w;
            }
            public void SetStartPoint(int x, int y)
            {
                x1 = x; y1 = y;
            }
            public Point GetStartPoint()
            {
                return new Point(x1, y1);
            }
            public void SetEndPoint(int x, int y)
            {
                x2 = x; y2 = y;
            }
            public Point GetEndPoint()
            {
                return new Point(x2, y2);
            }
        }

        [Serializable]
        class OutlineRect : Shape
        {
            public override void Draw(Graphics g)
            {
                Pen p = new Pen(ec, w);
                g.DrawRectangle(p, x1, y1, x2 - x1, y2 - y1);
            }
        }

        [Serializable]
        class FillRect : Shape
        {
            public override void Draw(Graphics g)
            {
                SolidBrush sb = new SolidBrush(fc);
                Pen p = new Pen(ec, w);
                g.FillRectangle(sb, x1, y1, x2 - x1, y2 - y1);
                g.DrawRectangle(p, x1, y1, x2 - x1, y2 - y1);
            }
        }

        [Serializable]
        class OutlineOval : Shape
        {
            public override void Draw(Graphics g)
            {
                Pen p = new Pen(ec, w);
                g.DrawEllipse(p, x1, y1, x2 - x1, y2 - y1);
            }
        }

        [Serializable]
        class FillOval : Shape
        {
            public override void Draw(Graphics g)
            {
                SolidBrush sb = new SolidBrush(fc);
                Pen p = new Pen(ec, w);
                g.FillEllipse(sb, x1, y1, x2 - x1, y2 - y1);
                g.DrawEllipse(p, x1, y1, x2 - x1, y2 - y1);
            }
        }

        [Serializable]
        class Line : Shape
        {
            public override void Draw(Graphics g)
            {
                Pen p = new Pen(ec, w);
                g.DrawLine(p, x1, y1, x2, y2);
            }
        }
        #endregion

        #region 描画モード

        //  描画
        private void drawModeMouseDown(MouseEventArgs e)
        {
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

        private void drawModeMouseUp(MouseEventArgs e)
        {
            //  図形オブジェクトをリストから取り出す
            Shape sh =
                (Shape)(shapeList[shapeList.Count - 1] as Shape);
            sh.SetEndPoint(e.X, e.Y);
            //  再描画
            this.Invalidate();
            //  undoスタックに操作を追加
            undoPush(Cancellation.DRAW, shapeList.Count - 1, sh);
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
    }
}
