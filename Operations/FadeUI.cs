using CSV_Verarbeitung.Properties;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Verarbeitung.Operations
{
    internal class FadeUI
    {
        public static float uploadOpacity = 1;
        public static int[] uploadLabelOpacity = new int[] { 255, 255, 255 };
        public static string uploadOpacityUpDown = "up";
        private static float fadeOutOpacity;

        public static Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix
                {
                    Matrix33 = opacity
                };
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        public static float DoFadePictureBox()
        {
            if (uploadOpacityUpDown == "up")
            {
                if (uploadOpacity >= 1)
                {
                    uploadOpacityUpDown = "down";
                }
                uploadOpacity += 0.01F;
            }
            else
            {
                if (uploadOpacity <= 0)
                {
                    uploadOpacityUpDown = "up";
                }
                uploadOpacity -= 0.01F;
            }
            return uploadOpacity;
        }

        public static int[] DoFadeLabel()
        {
            // form backgroundcolor
            int y = 255;
            if (uploadOpacity.ToString() != "1")
            {
                double x = Math.Round(uploadOpacity * 100);
                int mp = int.Parse(x.ToString());
                y = (int)Math.Round((decimal)(y * mp / 100));
                y = 255 - y;
                //MessageBox.Show(y.ToString(), mp.ToString());
                if (y < 0)
                {
                    y = 0;
                }
                else if (y > 255)
                {
                    y = 255;
                }
            }
            else
            {
                y = 255;
            }
            uploadLabelOpacity = new int[] { y, y, y };
            return uploadLabelOpacity;
        }

        public static async void FadeOut(PictureBox pb)
        {
            while (fadeOutOpacity > 0)
            {
                fadeOutOpacity -= 0.01F;
                pb.Image = FadeUI.SetImageOpacity(Resources.loader, FadeUI.DoFadePictureBox());
                await Task.Delay(1000);
            }
        }
    }
}