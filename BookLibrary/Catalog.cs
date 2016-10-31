using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace BookLibrary
{
    [XmlRoot(ElementName = "catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        public Catalog()
        {
            Books = new List<Book>();
        }

        [XmlIgnore]
        public DateTime Date { get; set; }

        [XmlAttribute(AttributeName = "date")]
        public string DateFormatted
        {
            get { return Date.ToString("yyyy-MM-dd"); }
            set { Date = DateTime.Parse(value); }
        }

        [XmlElement(ElementName = "book")]
        public List<Book> Books { get; set; }

        public override string ToString()
        {
            return
                $"Catalog Date: {Date}{Environment.NewLine}" +
                $"Books:{Environment.NewLine}" +
                $"{string.Join(Environment.NewLine, Books.Select(book => book.ToString()))}";
        }
    }
}