using System.Drawing;
using System.Windows.Forms;

namespace Drawing
{
    public partial class DrawingFm
    {
        public static int currentMode;
        public static int currentShape;
        public static Color currentColor;

        public class Mode
        {
            public static int DRAW = 0;
            public static int ERASE = 1;
        }

        public void DrawingFm_MouseDown(object sender, MouseEventArgs e)
        {
            Shape sh = null;
            if (currentShape == Shape.RECT)
            {
                sh = new Rect();
            }
            else if (currentShape == Shape.OVAL)
            {
                sh = new Oval();
            }
            else if (currentShape == Shape.LINE)
            {
                sh = new Line();
            }
            //  図形オブジェクトの色を設定
            sh.SetColor(currentColor);
            //  図形オブジェクトの座標を設定
            sh.SetStartPoint(e.X, e.Y);
            sh.SetEndPoint(e.X, e.Y);
            //  図形オブジェクトをリストに追加
            shapeList.Add(sh);
            //  再描画
            this.Invalidate();
        }

        private void DrawingFm_MouseUp(object sender, MouseEventArgs e)
        {
            //  図形オブジェクトをリストから取り出す
            Shape sh =
                (Shape)(shapeList[shapeList.Count - 1] as Shape);
            sh.SetEndPoint(e.X, e.Y);
            //  再描画
            this.Invalidate();
        }

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
