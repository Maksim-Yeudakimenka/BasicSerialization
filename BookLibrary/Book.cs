﻿using System;
using System.Xml.Serialization;

namespace BookLibrary
{
    public class Book
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "isbn")]
        public string Isbn { get; set; }

        [XmlElement(ElementName = "author")]
        public string Author { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "genre")]
        public Genre Genre { get; set; }

        [XmlElement(ElementName = "publisher")]
        public string Publisher { get; set; }

        [XmlIgnore]
        public DateTime PublishDate { get; set; }

        [XmlElement(ElementName = "publish_date")]
        public string PublishDateFormatted
        {
            get { return PublishDate.ToString("yyyy-MM-dd"); }
            set { PublishDate = DateTime.Parse(value); }
        }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlIgnore]
        public DateTime RegistrationDate { get; set; }

        [XmlElement(ElementName = "registration_date")]
        public string RegistrationDateFormatted
        {
            get { return RegistrationDate.ToString("yyyy-MM-dd"); }
            set { RegistrationDate = DateTime.Parse(value); }
        }

        public override string ToString()
        {
            return
                $"Id: {Id}, ISBN: {Isbn ?? "N/A"}, Author: {Author}, Title: {Title}, " +
                $"Genre: {Genre}, Publisher: {Publisher}, PublishDate: {PublishDate}, RegistrationDate: {RegistrationDate}";
        }
    }
}