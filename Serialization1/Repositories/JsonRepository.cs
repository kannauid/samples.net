using Newtonsoft.Json;
using Serialization1.Types;
using System.Xml.Serialization;

namespace Serialization1.Repositories
{
    public interface IJsonRepository
    {
        IUserType GetUserDeserialized();
        IEnumerable<IUserType> GetUsersDeserialized();
        string GetUserSerialized();
        string GetUsersSerialized();
    }

    public class JsonRepository : IJsonRepository
    {
        public IUserType _user;
        public IEnumerable<IUserType> _users;

        public JsonRepository()
        {
            var userJsonTxt = System.IO.File.ReadAllText("Data/user.json");
            _user = JsonConvert.DeserializeObject<UserType>(userJsonTxt);

            var usersJsonTxt = System.IO.File.ReadAllText("Data/users.json");
            _users = JsonConvert.DeserializeObject<IEnumerable<UserType>>(usersJsonTxt);
        }

        public IUserType GetUserDeserialized()
        {
            return _user;
        }

        public IEnumerable<IUserType> GetUsersDeserialized()
        {
            return _users;
        }

        public string GetUserSerialized()
        {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(UserType));

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, _user);
                return textWriter.ToString();
            }
        }

        public string GetUsersSerialized()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<UserType>));

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, _users);
                return textWriter.ToString();
            }
        }
    }
}
