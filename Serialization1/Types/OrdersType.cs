using System.Xml.Serialization;

namespace Serialization1.Types
{
    [XmlRoot(ElementName="OrdersList", Namespace = "https://example.com", IsNullable = true), XmlType("OrdersList")]
    public interface IOrdersType
    {
        [XmlArray("Orders", Namespace = ""), XmlArrayItem("Order", Namespace = "")]
        List<OrderType> Orders { get; set; }

        //[XmlArray("Orders"), XmlArrayItem("Order")]
        //OrderType[] Orders { get; set; }
    }

    [XmlRoot(ElementName = "OrdersList", Namespace = "https://example.com", IsNullable = true), XmlType("OrdersList")]
    public class OrdersType : IOrdersType
    {
        [XmlArray("Orders", Namespace = ""), XmlArrayItem("Order", Namespace = "")]
        public List<OrderType> Orders { get; set; }

        //[XmlArray("Orders"), XmlArrayItem("Order")]
        //public OrderType[] Orders { get; set; }
    }
}
