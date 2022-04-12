using System.Xml.Serialization;

namespace Serialization1.Types
{
    [XmlRoot("User")]
    [XmlType("User")]
    public interface IUserType
    {
        [XmlElement(ElementName = "Age")]
        int Age { get; set; }

        [XmlArray("EmailAddresses"), XmlArrayItem("EmailAddress")]
        string[]? EmailAddresses { get; set; }

        [XmlAttribute("IsActive")]
        bool IsActive { get; set; }

        [XmlElement(ElementName = "Name")]
        string? Name { get; set; }
    }

    [XmlRoot("User")]
    [XmlType("User")]
    public class UserType : IUserType
    {
        [XmlElement(ElementName = "Name")]
        public string? Name { get; set; }

        [XmlElement(ElementName = "Age")]
        public int Age { get; set; }

        [XmlAttribute("IsActive")]
        public bool IsActive { get; set; }

        [XmlArray("EmailAddresses"), XmlArrayItem("EmailAddress")]
        public string[]? EmailAddresses { get; set; }
    }
}
