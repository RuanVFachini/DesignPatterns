using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp.Structural.Adapter
{
    [XmlType("book")]
    public class Book
    {
        [XmlElement("author")]
        public string? Author { get; set; }
        [XmlElement("title")]
        public string? Title {get;set;}
        [XmlElement("genre")]
        public string? Genre {get;set;}
        [XmlElement("price")]
        public decimal? Price {get;set;}
        [XmlElement("publish_date")]
        public DateTime? PublishDate {get;set;}
        [XmlElement("description")]
        public string? Description {get;set;}
    }
}
