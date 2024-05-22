using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC103_Finals
{
    public static class ImageProccessor
    {
        //Compress an image to reduce size
        public static byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        //Decompress image to get near original image
        public static Image ConvertByteArrayToImage(byte[] compressedImageData)
        {
            using (MemoryStream ms = new MemoryStream(compressedImageData))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
