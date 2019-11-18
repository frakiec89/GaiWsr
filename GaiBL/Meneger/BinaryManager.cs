using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace GaiBL.Meneger
{
    /// <summary>
    /// бинарные  операции  
    /// </summary>
    public class BinaryManager
    {
        public string  GetStringToBinary (  byte [] arrya)
        {
            try
            {
                return System.Text.Encoding.Default.GetString(arrya);
            }
            catch
            {
                return null;
            }
        }

        public  byte [] GetBinatyToString (  string text)
        {
            try
            {
                return Encoding.Default.GetBytes(text);
            }
            catch
            {
                return null;
            }
        }


        public byte [] GetBinaryToImega ( string fileName)
        {
            byte[] imageByte;

            if (File.Exists(fileName))
            {
                try
                {
                    FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
                    imageByte = new byte[fileStream.Length];
                    fileStream.Read(imageByte, 0, imageByte.Length);
                    return imageByte;
                }
                catch  (Exception ex)
                {
                    throw  new   Exception(ex.Message);
                }

            }
            else
            {
                throw new Exception("Файл не найден");
            }
        }


        public byte[] GetBinaryToImega(Bitmap x)
        {

            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;

        }

        public  System.Drawing.Image GetImageToBinary (  byte [] arrya)
        {

            Image image ;
            if (arrya != null)
            {
                MemoryStream memoryStream = new MemoryStream(arrya, 0, arrya.Length);
                memoryStream.Write(arrya, 0, arrya.Length);

                try
                {
                    return image = Image.FromStream(memoryStream, true);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                return null;
            }
        }


        public System.Drawing.Image GetImageToBinary(byte[] arrya , int width , int  height  )
        {
            if (!(arrya is null))
            {
                Bitmap newBitmap = new Bitmap(GetImageToBinary(arrya), width, height);
                return newBitmap;
            }
            else
            {
                return null;
            }

          
        }
    }
}
