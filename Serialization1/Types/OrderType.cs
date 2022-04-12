using System.Xml.Serialization;

namespace Serialization1.Types
{
    //[XmlRoot(ElementName = "Order", Namespace = "https://example.com", IsNullable = true)]
    [XmlRoot(ElementName = "Order")]
    [XmlType("Order")]
    public interface IOrderType
    {
        [XmlElement(ElementName = "OrderId", Namespace = "")]
        string? OrderId { get; set; }

        [XmlElement(ElementName = "Total", Namespace = "")]
        int Total { get; set; }

        [XmlAttribute("IsFullfilled", Namespace = "")]
        bool IsFullfilled { get; set; }

        [XmlArray("OrderItems", Namespace = ""), XmlArrayItem("OrderItem", Namespace = "")]
        string[]? OrderItems { get; set; }
    }

    //[XmlRoot(ElementName = "Order", Namespace = "https://example.com", IsNullable = true)]
    [XmlRoot(ElementName = "Order")]
    [XmlType("Order")]
    public class OrderType : IOrderType
    {
        [XmlElement(ElementName = "OrderId", Namespace = "")]
        public string? OrderId { get; set; }

        [XmlElement(ElementName = "Total", Namespace = "")]
        public int Total { get; set; }

        [XmlAttribute("IsFullfilled", Namespace = "")]
        public bool IsFullfilled { get; set; }

        [XmlArray("OrderItems", Namespace = ""), XmlArrayItem("OrderItem", Namespace = "")]
        public string[]? OrderItems { get; set; }
    }
}
