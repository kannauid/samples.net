using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serialization1.Repositories;
using Serialization1.Types;

namespace Serialization1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class JsonSerializationController : ControllerBase
    {
        private IJsonRepository _jsonRepository;

        public JsonSerializationController(IJsonRepository jsonRepository)
        {
            _jsonRepository = jsonRepository;
        }

        [HttpGet(Name = "GetUserDeserialized")]
        public IUserType GetUserDeserialized()
        {
            return _jsonRepository.GetUserDeserialized();
        }

        [HttpGet(Name = "GetUsersDeserialized")]
        public IEnumerable<IUserType> GetUsersDeserialized()
        {
            return _jsonRepository.GetUsersDeserialized();
        }

        [HttpGet(Name = "GetJson2XmlUser")]
        public string GetJson2XmlUser()
        {
            return _jsonRepository.GetUserSerialized();
        }

        [HttpGet(Name = "GetJson2XmlUsers")]
        public string GetJson2XmlUsers()
        {
            return _jsonRepository.GetUsersSerialized();
        }

    }
}