using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serialization1.Repositories;
using Serialization1.Types;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class XmlSerializationController : ControllerBase
    {
        public IXmlRepository _xmlRepository;        

        public XmlSerializationController(IXmlRepository xmlRepository)
        {
            _xmlRepository = xmlRepository;
        }

        [HttpGet(Name = "GetXmlUserDeserialized")]
        public IUserType GetUserDeserialized()
        {
            return _xmlRepository.GetUserDeserialized();
        }

        [HttpGet(Name = "GetXmlUsersDeserialized")]
        public IEnumerable<IUserType> GetXmlUsersDeserialized()
        {
            return _xmlRepository.GetUsersDeserialized();
        }

        [HttpGet(Name = "GetXmlOrderDeserialized")]
        public IOrderType GetOrdersDeserialized()
        {
            return _xmlRepository.GetOrderDeserialized();
        }

        [HttpGet(Name = "GetXmlOrdersDeserialized")]
        public IEnumerable<IOrderType> GetXmlOrdersDeserialized()
        {
            return _xmlRepository.GetOrdersDeserialized();
        }

        [HttpGet(Name = "GetXmlProductDeserialized")]
        public IProductType GetXmlProductDeserialized()
        {
            return _xmlRepository.GetProductDeserialized();
        }

        [HttpGet(Name = "GetXml2JsonUser")]
        public string GetXml2JsonUser()
        {
            return _xmlRepository.GetUserSerialized();
        }

        [HttpGet(Name = "GetXml2JsonUsers")]
        public string GetXml2JsonUsers()
        {
            return _xmlRepository.GetUsersSerialized();
        }
    }
}