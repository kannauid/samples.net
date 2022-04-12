using System.Xml;
using System.Xml.Serialization;

namespace Serialization1.Types
{
    [XmlRoot(ElementName = "Product")]
    [XmlType("Product")]
    public interface IProductType
    {
        [XmlElement(ElementName = "ProductId", Namespace = "")]
        string? ProductId { get; set; }

        [XmlElement(ElementName = "ProductName", Namespace = "")]
        string? ProductName { get; set; }

        [XmlElement(ElementName = "ProductDescription", Namespace = "")]
        public XmlCDataSection? ProductDescription { get; set; }

        [XmlAttribute("Stock", Namespace = "")]
        int Stock { get; set; }

        [XmlAttribute("IsDiscontinued", Namespace = "")]
        bool IsDiscontinued { get; set; }

        [XmlIgnore]
        public ProductModelType? ProductModel { get; set; }
    }

    [XmlRoot(ElementName = "Product")]
    [XmlType("Product")]
    public class ProductType : IProductType
    {
        [XmlElement(ElementName = "ProductId", Namespace = "")]
        public string? ProductId { get; set; }

        [XmlElement(ElementName = "ProductName", Namespace = "")]
        public string? ProductName { get; set; }

        [XmlElement(ElementName = "ProductDescription", Namespace = "")]
        public XmlCDataSection? ProductDescription { get; set; }

        [XmlAttribute("Stock", Namespace = "")]
        public int Stock { get; set; }

        [XmlAttribute("IsDiscontinued", Namespace = "")]
        public bool IsDiscontinued { get; set; }

        [XmlIgnore]
        public ProductModelType? ProductModel { get; set; }
    }
}
