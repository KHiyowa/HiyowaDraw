using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;

namespace Drawing
{
    public partial class DrawingFm
    {
        private static bool savedState = true;
        //  開く
        private void open()
        {
            ofd.Filter = "HiyowaDraw グラフィックス|*.hdg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(ofd.FileName,
                    FileMode.Open, FileAccess.Read);
                shapeList.Clear();
                shapeList = (List<Shape>)bf.Deserialize(fs);
                fs.Close();
                this.Invalidate();
                fileName = ofd.FileName;
                setCaption();
            }
        }

        //  名前をつけて保存
        private void saveAs()
        {
            sfd.Filter = "HiyowaDraw グラフィックス|*.hdg";
            sfd.FileName = fileName;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                save(sfd.FileName);
            }
        }

        //  上書き保存
        private void save(string name)
        {
            //  パスがnullであれば、名前をつけて保存ダイアログを表示
            if (name == null)
            {
                saveAs();
                return;
            }
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs =
                new FileStream(name,
                    FileMode.OpenOrCreate,
                        FileAccess.Write);
            bf.Serialize(fs, shapeList);
            fs.Close();
            savedState = true;
            fileName = name;
            setCaption();
        }

        //  保存の確認
        private DialogResult confirmSave()
        {
            return MessageBox.Show(getFileName() +
                " は変更されています。保存しますか?",
                "HiyowaDraw",
                MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);
        }


        //  タイトルバーの保存状態とファイル名の更新
        private void setCaption()
        {
            string text = getFileName();
            //  最終の保存から変更されていれば、タイトルバーに「*」を表示
            if (savedState == false)
            {
                text += " *";
            }

            //  キャプションをセット
            Text = "HiyowaDraw - [" + text + "]";
        }

        //  ファイル名の取得
        private string getFileName()
        {
            string text;

            //  fileNameに値が存在すれば、ファイル名を返す
            if (fileName != null)
            {
                text = Path.GetFileName(fileName);
            }
            //  値が存在しなければ、"無題"を返す
            else
            {
                text = "無題";
            }
            return text;
        }
    }
}
