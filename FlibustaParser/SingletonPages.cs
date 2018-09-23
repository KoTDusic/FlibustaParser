using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace FlibustaParser
{
    static class SingletonPages
    {
        static string _genrePageUrl = null;
        static string _customPageUrl = null;
        static private HtmlDocument _genrePage=null;
        static private HtmlDocument _customPage = null;
        static public HtmlDocument GetGenrePageHtml()
        {
            var genrePageUrl=ConfigsMain.GetDomen()+"/g";
            if(_genrePage==null) _genrePage = RequestSender.GetRequestPage(genrePageUrl);
            return _genrePage;
        }
        static public void ChangeCustomPage(string url)
        {
            _customPageUrl=url;
            _customPage = null;
        }
        static public HtmlDocument GetCustomPage()
        {
            if (_customPage == null) _customPage = RequestSender.GetRequestPage(_customPageUrl);
            return _customPage;
        }
    }
}
