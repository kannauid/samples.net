using Newtonsoft.Json;
using Serialization1.Types;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization1.Repositories
{
    public interface IXmlRepository
    {
        IUserType GetUserDeserialized();
        IEnumerable<IUserType> GetUsersDeserialized();
        IOrderType GetOrderDeserialized();
        IEnumerable<IOrderType> GetOrdersDeserialized();
        IProductType GetProductDeserialized();
        string GetUserSerialized();
        string GetUsersSerialized();

    }

    public class XmlRepository : IXmlRepository
    {
        public IUserType _user;
        public IEnumerable<IUserType> _users;
        public IOrderType _order;
        public IEnumerable<IOrderType> _orders;
        public IProductType _product;

        public XmlRepository()
        {
            using var userXmlFileStream = new FileStream("Data/User.xml", FileMode.Open);
            var userSerializer = new XmlSerializer(typeof(UserType));
            _user = (UserType)userSerializer.Deserialize(userXmlFileStream);

            using var usersXmlFileStream = new FileStream("Data/Users.xml", FileMode.Open);
            var usersSerializer = new XmlSerializer(typeof(UsersType));
            var _usersObj = (UsersType)usersSerializer.Deserialize(usersXmlFileStream);
            _users = _usersObj.Users;


            XmlRootAttribute orderRoot = new XmlRootAttribute();
            orderRoot.ElementName = "Order";
            orderRoot.Namespace = "https://example.com/";
            orderRoot.IsNullable = false;
            using var orderXmlFileStream = new FileStream("Data/Order.xml", FileMode.Open);
            var orderSerializer = new XmlSerializer(typeof(OrderType), orderRoot);
            _order = (OrderType)orderSerializer.Deserialize(orderXmlFileStream);


            XmlRootAttribute ordersRoot = new XmlRootAttribute()
            {
                ElementName = "OrderList",
                Namespace = "https://example.com/",
                IsNullable = true
            };
            using var ordersXmlFileStream = new FileStream("Data/Orders.xml", FileMode.Open);
            var ordersSerializer = new XmlSerializer(typeof(OrdersType), ordersRoot);
            var _ordersObj = (OrdersType)ordersSerializer.Deserialize(ordersXmlFileStream);
            _orders = _ordersObj.Orders;


            XmlRootAttribute productRoot = new XmlRootAttribute();
            productRoot.ElementName = "Product";
            productRoot.Namespace = "https://example.com/";
            productRoot.IsNullable = false;
            using var productXmlFileStream = new FileStream("Data/Product.xml", FileMode.Open);
            var productSerializer = new XmlSerializer(typeof(ProductType), productRoot);
            _product = (ProductType)productSerializer.Deserialize(productXmlFileStream);


            XmlRootAttribute productModelRoot = new XmlRootAttribute();
            productModelRoot.ElementName = "ProductModel";
            productModelRoot.Namespace = "https://example.com/";
            productModelRoot.IsNullable = false;
            var productModelSerializer = new XmlSerializer(typeof(ProductModelType), productModelRoot);
            MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(_product.ProductDescription.Data));
            _product.ProductModel = (ProductModelType)productModelSerializer.Deserialize(memStream) ;
        }

        public IUserType GetUserDeserialized()
        {
            return _user;
        }

        public IEnumerable<IUserType> GetUsersDeserialized()
        {
            return _users;
        }

        public IOrderType GetOrderDeserialized()
        {
            return _order;
        }

        public IEnumerable<IOrderType> GetOrdersDeserialized()
        {
            return _orders;
        }

        public IProductType GetProductDeserialized()
        {
            return _product;
        }

        public string GetUserSerialized()
        {
            return JsonConvert.SerializeObject(_user);
        }

        public string GetUsersSerialized()
        {
            return JsonConvert.SerializeObject(_users);
        }
    }
}
