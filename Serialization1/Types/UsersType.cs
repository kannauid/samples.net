using System.Xml.Serialization;

namespace Serialization1.Types
{
    //[XmlRoot(ElementName = "UsersList", Namespace = ""), XmlType("UsersList")]
    [XmlRoot("UsersList"), XmlType("UsersList")]
    public interface IUsersType
    {
        [XmlArray("Users"), XmlArrayItem("User")]
        public List<UserType> Users { get; set; }

        //Working
        //[XmlArray("Users"), XmlArrayItem("User")]
        //public UserType[] Users { get; set; }
    }

    //[Serializable, XmlRoot(ElementName = "UsersList", Namespace = ""), XmlType("UsersList")]
    [XmlRoot("UsersList"), XmlType("UsersList")]
    public class UsersType : IUsersType
    {
        [XmlArray("Users"), XmlArrayItem("User")]
        public List<UserType> Users { get; set; }

        //Working
        //[XmlArray("Users"), XmlArrayItem("User")]
        //public UserType[] Users { get; set; }
    }
}
