using System.Xml.Serialization;

namespace Serialization1.Types
{
    [XmlRoot(ElementName = "ProductModel", Namespace = "https://example.com", IsNullable = true)]
    //[XmlRoot(ElementName = "ProductModel")]
    [XmlType("ProductModel")]
    public interface IProductModelType
    {
        [XmlElement(ElementName = "ProductCode", Namespace = "")]
        string? ProductCode { get; set; }

        [XmlArray("ProductColors", Namespace = ""), XmlArrayItem("ProductColor", Namespace = "")]
        string[]? ProductColors { get; set; }

        [XmlElement(ElementName = "ProductPrice", Namespace = "")]
        int ProductPrice { get; set; }

        [XmlAttribute("IsPro", Namespace = "")]
        bool IsPro { get; set; }
    }

    [XmlRoot(ElementName = "ProductModel", Namespace = "https://example.com", IsNullable = true)]
    //[XmlRoot(ElementName = "ProductModel")]
    [XmlType("ProductModel")]
    public class ProductModelType : IProductModelType
    {
        [XmlElement(ElementName = "ProductCode", Namespace = "")]
        public string? ProductCode { get; set; }

        [XmlArray("ProductColors", Namespace = ""), XmlArrayItem("ProductColor", Namespace = "")]
        public string[]? ProductColors { get; set; }

        [XmlElement(ElementName = "ProductPrice", Namespace = "")]
        public int ProductPrice { get; set; }

        [XmlAttribute("IsPro", Namespace = "")]
        public bool IsPro { get; set; }
    }
}
