using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace DeviceManagement.Utils
{   
    public class ImageHelper
    {
        public static byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null) return null;
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null) return null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
