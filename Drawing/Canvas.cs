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
        #region Modeの定義
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
            //  描画状態フラグを有効にする
            drawState = true;

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
            if (drawState)
            {
                redraw(e);
            }
        }

        private void DrawingFm_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentMode == Mode.DRAW)
            {
                drawModeMouseUp(e);
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
        #endregion
    }
}
