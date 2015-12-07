using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class DrawingFm
    {
        //  元に戻す/やり直しのスタック
        public static Stack<Shape> redoStack;

        //  新規作成
        private void newCanvas()
        {
            //  リストを初期化
            shapeList = new List<Shape>();
            redoStack = new Stack<Shape>();

            //  保存状態をクリア
            savedState = true;
            //  ファイル名をクリア
            fileName = null;

            //  再描画
            this.Invalidate();
            setCaption();
        }

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

        //  元に戻す
        public void undo()
        {
            if (shapeList.Count == 0) { return; }
            redoStack.Push(shapeList[shapeList.Count - 1]);
            shapeList.RemoveAt(shapeList.Count - 1);
            this.Invalidate();
        }

        //  やり直し
        public void redo()
        {
            if (redoStack.Count == 0) { return; }
            shapeList.Add(redoStack.Pop());
            this.Invalidate();
        }
    }
}
