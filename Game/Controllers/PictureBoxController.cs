using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.Controllers
{
    public class PictureBoxController
    {
        public Image RotateImage(Image img, float angulo)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.TranslateTransform(img.Width / 2, img.Height / 2);
            g.RotateTransform(angulo);
            g.TranslateTransform(-img.Width/2, -img.Height/2);
            g.DrawImage(img, new Point(0, 0));
            return bmp;
        }
    }
}
