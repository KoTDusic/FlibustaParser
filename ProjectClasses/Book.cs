namespace ProjectClasses
{
    public struct Book
    {
        private string Name { get; set; }
        private string Href { get; set; }
        private string Annotation { get; set; }
        public string ImageUri { get; set; }
        public Book(string name, string href)
        {
            Href = href;
            Name = name;
            Annotation = string.Empty;
            ImageUri = string.Empty;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetRef()
        {
            return Href;
        }
    }
}
