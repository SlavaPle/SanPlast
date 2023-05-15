using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPlast.Model
{
    class Cabin
    {
        public int Wys { get; set; }
        public int SzB { get; set; }
        public int ObchB { get; set; }
        public int SzC { get; set; }
        public int OdchC { get; set; }
        public bool Strona { get; set; }
        public string Color { get; set; }
        public Image Img()
        {
            Bitmap i = new Bitmap(Image.FromFile(@"F:\SanPlast\Złożenie\ZL.jpg"));
            //Bitmap image2 = (Bitmap)i.Clone();
            if (!Strona) i.RotateFlip(RotateFlipType.RotateNoneFlipX);

            ////Merge two images in bitmap image,
            //Bitmap bitmap = new Bitmap(i.Width + image2.Width, Math.Max(i.Height, image2.Height));
            //using (Graphics g = Graphics.FromImage(bitmap))
            //{
            //    g.DrawImage(image1, 0, 0);
            //    g.DrawImage(image2, image1.Width, 0);
            //}
            ////Show them in a picturebox
            //pictureBox2.Image = bitmap;
            //Graphics G = i.to;
            return i;
        }
        public List<Komponent> LK { get; private set; }

        public void Policz()
        { }
    }

    class Komponent
    {

    }
}
