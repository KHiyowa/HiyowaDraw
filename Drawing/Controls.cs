using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Drawing
{
    public partial class DrawingFm
    {
        private void openTsmi_Click(object sender, EventArgs e)
        {
            ofd.Filter = "グラフィックファイル|*.g";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(ofd.FileName,
                    FileMode.Open, FileAccess.Read);
                shapeList.Clear();
                shapeList = (List<Shape>)bf.Deserialize(fs);
                fs.Close();
                this.Invalidate();
            }
        }

        private void saveTsmi_Click(object sender, EventArgs e)
        {
            sfd.Filter = "グラフィックファイル|*.g";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs =
                    new FileStream(sfd.FileName,
                        FileMode.OpenOrCreate,
                            FileAccess.Write);
                bf.Serialize(fs, shapeList);
                fs.Close();
            }
        }

        private void printPreviewTsmi_Click(object sender, EventArgs e)
        {
            pp.Document = pd;
            pp.ShowDialog();
        }

        private void printTsmi_Click(object sender, EventArgs e)
        {
            pd.Print();
        }

        private void rectTsmi_Click(object sender, EventArgs e)
        {
            currentShape = Shape.RECT;
        }

        private void ovalTsmi_Click(object sender, EventArgs e)
        {
            currentShape = Shape.OVAL;
        }

        private void lineTsmi_Click(object sender, EventArgs e)
        {
            currentShape = Shape.LINE;
        }

        private void colorTsmi_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                currentColor = cd.Color;
            }
        }
    }
}
