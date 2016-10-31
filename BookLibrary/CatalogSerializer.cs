using System.IO;
using System.Xml.Serialization;

namespace BookLibrary
{
    public class CatalogSerializer
    {
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(Catalog));

        public void Serialize(Catalog catalog, string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                _serializer.Serialize(stream, catalog);
            }
        }

        public Catalog Deserialize(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                return _serializer.Deserialize(stream) as Catalog;
            }
        }
    }
}