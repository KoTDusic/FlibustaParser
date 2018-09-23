using System;
using System.Reflection;

namespace CommonComponents
{
    public static class Images
    {
        public static string LoadingKey = "pack://application:,,,/CommonComponents;Images/loading.gif";
        public static Uri LoadingImage = new Uri(LoadingKey, UriKind.Absolute);

        public static string EmptyBookKey = "pack://application:,,,/CommonComponents;Images/stub_book_image.jpg";
        public static Uri EmptyBookImage = new Uri(EmptyBookKey, UriKind.Absolute);

        static Images()
        {
            Assembly = System.Reflection.Assembly.GetCallingAssembly().FullName;
        }

        private static readonly string Assembly;
        public static string GetAssembly()
        {
            return Assembly;
        }
    }
}
