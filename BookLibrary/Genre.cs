using System.Xml.Serialization;

namespace BookLibrary
{
    public enum Genre
    {
        Computer,

        Fantasy,

        Romance,

        Horror,

        [XmlEnum(Name = "Science Fiction")]
        ScienceFiction
    }
}