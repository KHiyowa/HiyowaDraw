using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Drawing
{
    public partial class DrawingFm
    {
        //  名前をつけて保存
        private void saveAs()
        {
            menu.Hide();

            sfd.Filter = "HiyowaDraw グラフィックス|*.hdg";
            sfd.FileName = fileName;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                save(sfd.FileName);
            }
            menu.Show();
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
            fileName = name;
            setCaption();
        }

        public void setCaption()
        {
            //  キャプションをセット
            if (fileName != null)
            {
                Text = "HiyowaDraw - [" + Path.GetFileName(fileName) + "]";
            }
            else
            {
                Text = "HiyowaDraw - [無題]";
            }
        }
    }
}
