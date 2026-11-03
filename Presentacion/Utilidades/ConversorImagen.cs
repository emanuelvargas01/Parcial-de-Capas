
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Presentacion.Utilidades
{
    public class ConversorImagen
    {
        public static byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                ImageFormat format = ImageFormat.Png;

                if (image.RawFormat != null &&
                    !image.RawFormat.Equals(ImageFormat.MemoryBmp))
                {
                    format = image.RawFormat;
                }

                using (Bitmap cloneBitmap = new Bitmap(image))
                {
                    cloneBitmap.Save(memoryStream, format);
                }

                return memoryStream.ToArray();
            }
        }

        public static Bitmap ByteArrayToBitmap(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return null;

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                using (Image image = Image.FromStream(memoryStream))
                {
                    return new Bitmap(image);
                }
            }
        }
    }
}
