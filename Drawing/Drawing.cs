using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Drawing
{
    public partial class DrawingFm
    {
        public static int currentMode;
        public static int currentShape;
        public static int lineWidth;
        public static Color currentColor;
        public static bool drawState = false;

        public class Mode
        {
            public static int DRAW = 0;
            public static int ERASE = 1;
        }

        public void DrawingFm_MouseDown(object sender, MouseEventArgs e)
        {
            //  描画状態フラグを有効にする
            drawState = true;
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
            //  線の太さを設定
            sh.SetWidth(lineWidth);
            //  図形オブジェクトの座標を設定
            sh.SetStartPoint(e.X, e.Y);
            sh.SetEndPoint(e.X, e.Y);
            //  図形オブジェクトをリストに追加
            shapeList.Add(sh);
            //  再描画
            this.Invalidate();
        }

        private void DrawingFm_MouseMove(object sender, MouseEventArgs e)
        {
            //  ステータスバーに座標を表示
            coordinateXTssl.Text = "X = " + e.X.ToString();
            coordinateYTssl.Text = "Y = " + (e.Y - commandBarMs.Height).ToString();
            //  再描画
            if (drawState) { draw(e); }
        }

        private void DrawingFm_MouseUp(object sender, MouseEventArgs e)
        {
            //  再描画
            draw(e);
            //  保存状態フラグを無効に
            savedState = false;
            //  キャプションの更新
            setCaption();
            //  描画状態フラグを無効にする
            drawState = false;
        }

        //  再描画
        private void draw(MouseEventArgs e)
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

        //  新規作成
        private void newCanvas()
        {
            //  リストを初期化
            shapeList = new List<Shape>();
            //  デフォルトの図形と色を設定
            currentShape = Shape.RECT;
            currentColor = Color.Blue;
            lineWidth = 2;

            //  保存状態をクリア
            savedState = true;
            //  ファイル名をクリア
            fileName = null;

            //  再描画
            this.Invalidate();
            setCaption();
        }

        //  ステータスバーにキャンバスサイズを表示する
        private void indicateCanvasSize()
        {
            Size canvasSize = this.ClientSize;
            canvasXTssl.Text = "X = " + canvasSize.Width.ToString();
            canvasYTssl.Text = "Y = " + (canvasSize.Height - commandBarMs.Height).ToString();
        }
    }
}
