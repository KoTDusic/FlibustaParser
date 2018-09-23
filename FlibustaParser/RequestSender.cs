using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Net;
using System.Drawing;

namespace FlibustaParser
{
    static class RequestSender
    {
        static public HtmlDocument GetRequestPage(string url)
        {
            try
            {
                var c = new WebClient();
                c.Encoding = Encoding.UTF8;
                var doc = new HtmlDocument();
                doc.LoadHtml(c.DownloadString(url));
                return doc;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        static public Image GetImageStub()
        {
            var filePath = Environment.CurrentDirectory + @"\Images\stub_book_image.jpg";
            return CompressImage(Image.FromFile(filePath));
        }
        static public Image LoadImageFromUrl(string url)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Proxy = null;
                using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (var stream = httpWebResponse.GetResponseStream())
                    {
                        var data = Image.FromStream(stream);
                        return CompressImage(data);
                    }
                }
            }
            catch
            {
                return GetImageStub();
            }
        }
        static private Image CompressImage(Image original)
        {
            return new Bitmap(original, 140, 200);
        }
    }
}
