using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Pavilion.Helper
{
    public static class ImgeConverter
    {
        public static byte[] ImageToBytes(string filePath)
        {
            byte[] photo = null;
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    photo = reader.ReadBytes((int)stream.Length);
                }
            }
            return photo;
        }

        public static BitmapImage BytesToImage(byte[] bytes)
        {
            BitmapImage image = null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();
            }
            return image;
        }
    }
}
