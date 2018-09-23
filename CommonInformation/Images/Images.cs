using System;

namespace FlibustaUI.Images
{
    class Images
    {
        public static string BlankBookKey = "pack://application:,,,/CommonInformation;component/Images/stub_book_image.jpg";
        public static Uri BlankBookImage = new Uri(BlankBookKey, UriKind.Absolute);

        public static string LoadingKey = "pack://application:,,,/CommonInformation;component/Images/loading.gif";
        public static Uri LoadingImage = new Uri(LoadingKey, UriKind.Absolute);
    }
}
