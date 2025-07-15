using System.Xml.Serialization;

namespace Clc.Api.Models
{
    public class ItemInfo
    {
        public int ItemRecordID { get; set; } = 0;
        public string Title { get; set; }
        public string Author { get; set; }
        public int OwningLibraryID { get; set; }
        public string OwningLibraryName { get; set; }
        public string OwningLibraryAbbreviation { get; set; }
        [XmlElement(IsNullable = true)]
        public string Barcode { get; set; }
        [XmlElement(IsNullable = true)]
        public string Prefix { get; set; }
        [XmlElement(IsNullable = true)]
        public string Classification { get; set; }
        [XmlElement(IsNullable = true)]
        public string Cutter { get; set; }
        [XmlElement(IsNullable = true)]
        public string Suffix { get; set; }
        [XmlElement(IsNullable = true)]
        public string Volume { get; set; }
        [XmlElement(IsNullable = true)]
        public string ISBN { get; set; }
        [XmlElement(IsNullable = true)]
        public string UPC { get; set; }

        public ItemInfo()
        {

        }
    }
}
