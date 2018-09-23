using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Web;
using System.IO;
using System.Threading;
using HtmlAgilityPack;
using System.Drawing;
using ProjectClasses;

namespace FlibustaParser
{
    public class HtmlParser
    {
        private string _siteDomen;
        private string _siteUrl = "http://flibusta.is/g/detective";
        private string _bookAnotationLocator = "//div[@id='main']/p[1]";
        private string _bookLocator = "//ol/a";
        private string _imageLocator = "//*[@id='main']/img";
        private string _blankAnnotationString = "Для этой книги нет описания";
        
        public HtmlParser(string siteUrl)
        {
            _siteDomen = siteUrl;
        }
        public List<Book> GetBookList()
        {
            var doc = RequestSender.GetRequestPage(_siteUrl);
            var htmlBooksPage = doc.DocumentNode.SelectNodes(_bookLocator);
            var resultBooks = new List<Book>();
            foreach(var node in htmlBooksPage)
            {
                resultBooks.Add(new Book(node.InnerText, node.GetAttributeValue("href", "error")));
            }
            return resultBooks;
        }
        public string GetBookAnotation(string url)
        {
            var bookUri = _siteDomen + url;
            var doc = RequestSender.GetRequestPage(bookUri);
            var node = doc.DocumentNode.SelectSingleNode(_bookAnotationLocator);
            if (node == null)
            {
                return _blankAnnotationString;
            }
            else
            {
                return node.InnerText;
            }
        }
        public Image LoadBookImage(string url)
        {
            var bookUri = _siteDomen + url;
            var doc = RequestSender.GetRequestPage(bookUri);
            var node = doc.DocumentNode.SelectSingleNode(_imageLocator);
            if (node == null)
            {
                return RequestSender.GetImageStub(); 
            }
            else
            {
                var imageUrl = node.GetAttributeValue("src", "error");
                imageUrl = _siteDomen + imageUrl;
                return RequestSender.LoadImageFromUrl(imageUrl);
            }
            
        }
        
    }
    
}
