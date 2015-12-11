using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    //  キャンバスの操作に関するメソッド類

    public partial class DrawingFm
    {
        public bool dragState = false;

        #region モード
        abstract public class Mode
        {
            public static int SELECT = 0;
            public static int DRAW = 1;
        }

        public void changeMode(int mode)
        {
            currentMode = mode;
            select = null;
            if (mode == Mode.SELECT)
            {
                modeTssl.Text = "選択モード";
                selectMode = SelectMode.ERASE;
            }
            if (mode == Mode.DRAW)
            {
                modeTssl.Text = "描画モード";
            }
        }

        #endregion

        #region 新規作成
        //  新規作成
        private void newCanvas()
        {
            //  リストを初期化
            shapeList = new List<Shape>();
            undoStack = new Stack<Cancellation>();
            redoStack = new Stack<Cancellation>();

            //  保存状態をクリア
            savedState = true;
            //  ファイル名をクリア
            fileName = null;

            //  再描画
            this.Invalidate();
            setCaption();
        }
        #endregion

        #region キャンバスサイズ

        //  キャンバスのサイズを取得する
        private Size getCanvasSize()
        {
            return new Size(this.ClientSize.Width, 
                this.ClientSize.Height - commandBarMs.Height - statusBarSs.Height);
        }

        //  ステータスバーにキャンバスサイズを表示する
        private void indicateCanvasSize()
        {
            Size canvasSize = getCanvasSize();
            canvasXTssl.Text = "X = " + canvasSize.Width.ToString();
            canvasYTssl.Text = "Y = " + canvasSize.Height.ToString();
        }

        #endregion

        #region マウスイベント
        public void DrawingFm_MouseDown(object sender, MouseEventArgs e)
        {
            //  ドラグ状態フラグを有効にする
            dragState = true;

            if (currentMode == Mode.SELECT)
            {
                selectModeMouseDown(e);
            }
            else if (currentMode == Mode.DRAW)
            {
                drawModeMouseDown(e);
            }
        }

        private void DrawingFm_MouseMove(object sender, MouseEventArgs e)
        {
            //  ステータスバーに座標を表示
            coordinateXTssl.Text = "X = " + e.X.ToString();
            coordinateYTssl.Text = "Y = " + (e.Y - commandBarMs.Height).ToString();
            //  再描画
            if (currentMode == Mode.DRAW && dragState)
            {
                redraw(e);
            }

            if (currentMode == Mode.SELECT)
            {
                 
            }
        }

        private void DrawingFm_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentMode == Mode.DRAW)
            {
                drawModeMouseUp(e);
            }
            //  ドラグ状態フラグを無効にする
            dragState = false;
            //  保存状態フラグを無効に
            savedState = false;
            //  キャプションの更新
            setCaption();
        }
        #endregion

        //  キャンバスの描画
        private void DrawingFm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //  shapeListの内容を描画
            foreach (Shape sh in shapeList)
            {
                sh.Draw(g);
            }

            //  選択モード中で、矩形がnullでなければ
            if (currentMode == Mode.SELECT && select != null)
            {
                select.Draw(g);
            }

        }
    }
}
