using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public partial class DrawingFm
    {
        //  新規作成
        private void newCanvas()
        {
            //  リストを初期化
            shapeList = new List<Shape>();
            //  デフォルトの図形と色を設定
            currentShape = Shape.RECT;
            currentColor = Color.Blue;
            shapeFilled = true;
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
