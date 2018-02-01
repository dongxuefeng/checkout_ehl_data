

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;



namespace Ehl.Atms.Tgs.ExportPeccancy.VioDataInfos
{
    class MergeImg
    {
        private const int AREA_STRING_RECT_HEIGHT = 120;
        //下载图片
        public Bitmap LoadImg(string imgurl)
        {
            Bitmap bmp = null;
            try
            {
                System.Net.WebClient wc = new System.Net.WebClient();
                byte[] byData = wc.DownloadData(imgurl);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byData, true);
                bmp = new Bitmap(stream);
                return bmp;
            }
            catch (System.Net.WebException we)
            {
                Log.WriteLog(we.ToString());
            }
            return bmp;
        }

        public string mergelpic(VioDataInfo vioinfo, string picpath)
        {

            Log.WriteLog("1  " + vioinfo.img1 + vioinfo.img2);
            Bitmap bmp1 = LoadImg(vioinfo.img1);
            Bitmap bmp2 = LoadImg(vioinfo.img2);
            Bitmap newbmp = new Bitmap(bmp1.Width + bmp2.Width, bmp1.Height + AREA_STRING_RECT_HEIGHT);
            Log.WriteLog("2  newbmp ok");
            Graphics g = Graphics.FromImage(newbmp);
            g.Clear(Color.White);
            g.DrawImage(bmp1, 0, AREA_STRING_RECT_HEIGHT);
            g.DrawImage(bmp2, bmp1.Width, AREA_STRING_RECT_HEIGHT);
            Font f = new Font("宋体", 40);
            Brush b = new SolidBrush(Color.Red);
            Log.WriteLog("3  font ok");
        //    g.FillRectangle(new SolidBrush(Color.White),0, 0, bmp1.Width + bmp2.Width, 100);
            g.DrawString(vioinfo.toString(), f, b, new RectangleF(0, 0, bmp1.Width + bmp2.Width, AREA_STRING_RECT_HEIGHT));
            g.Save();
            Log.WriteLog("4  g.save ok");
            newbmp.Save(picpath, ImageFormat.Jpeg);
            /*
            ImageCodecInfo myImageCodecInfo;
            myImageCodecInfo = GetEncoderInfo("image/jpeg");
            System.Drawing.Imaging.Encoder myEncoder;
            myEncoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;
            myEncoderParameters = new EncoderParameters(1);
            myEncoderParameter = new EncoderParameter(myEncoder, 75L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            newbmp.Save(picpath, myImageCodecInfo, myEncoderParameters);
             * */
            Log.WriteLog("5  picpath=" + picpath);
            newbmp.Dispose();
            bmp1.Dispose();
            bmp2.Dispose();
            return picpath;
        }

        private ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
    }
}
