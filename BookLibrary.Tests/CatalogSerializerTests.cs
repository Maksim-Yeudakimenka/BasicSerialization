using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookLibrary.Tests
{
    [TestClass]
    public class CatalogSerializerTests
    {
        private readonly List<Book> _books;
        private readonly CatalogSerializer _serializer = new CatalogSerializer();

        public CatalogSerializerTests()
        {
            var bk101 = new Book
            {
                Id = "bk101",
                Isbn = "0-596-00103-7",
                Author = "Löwy, Juval",
                Title = "COM and .NET Component Services",
                Genre = Genre.Computer,
                Publisher = "O'Reilly",
                PublishDate = new DateTime(2001, 9, 1),
                Description = @"
      COM & .NET Component Services provides both traditional COM programmers and new .NET
      component developers with the information they need to begin developing applications that take full advantage of COM+ services.
      This book focuses on COM+ services, including support for transactions, queued components, events, concurrency management, and security
    ",
                RegistrationDate = new DateTime(2016, 1, 5)
            };

            var bk102 = new Book
            {
                Id = "bk102",
                Author = "Ralls, Kim",
                Title = "Midnight Rain",
                Genre = Genre.Fantasy,
                Publisher = "R & D",
                PublishDate = new DateTime(2000, 12, 16),
                Description = @"
      A former architect battles corporate zombies,
      an evil sorceress, and her own childhood to become queen
      of the world.
    ",
                RegistrationDate = new DateTime(2017, 1, 1)
            };

            var bk109 = new Book
            {
                Id = "bk109",
                Author = "Kress, Peter",
                Title = "Paradox Lost",
                Genre = Genre.ScienceFiction,
                Publisher = "R & D",
                PublishDate = new DateTime(2000, 11, 2),
                Description = @"
      After an inadvertant trip through a Heisenberg
      Uncertainty Device, James Salway discovers the problems
      of being quantum.
    ",
                RegistrationDate = new DateTime(2016, 1, 5)
            };

            _books = new List<Book> { bk101, bk102, bk109 };
        }

        [TestMethod]
        public void SerializeTest()
        {
            var catalog = new Catalog
            {
                Date = new DateTime(2016, 2, 5),
                Books = _books
            };

            _serializer.Serialize(catalog, "books_serialized.xml");
        }

        [TestMethod]
        public void DeserializeTest()
        {
            var catalog = _serializer.Deserialize("books_serialized.xml");

            Console.WriteLine(catalog);
        }
    }
}