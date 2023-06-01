using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.Xml.Serialization;

namespace ConsoleApp.Structural.Adapter
{
    public class XmlResponseAdapter : ITarget
    {
        private readonly XmlResponse _adapteEntity;

        public XmlResponseAdapter(XmlResponse adapteEntity)
        {
            _adapteEntity = adapteEntity;
        }

        public string GetRequest()
        {
            var reader = new StringReader(_adapteEntity.GetData());

            XmlSerializer deserializer = new XmlSerializer(typeof(List<Book>),
                    new XmlRootAttribute("catalog"));

            var books = (List<Book>) deserializer.Deserialize(reader);

            return $"Response is: '{JsonSerializer.Serialize(books)}'";
        }
    }
}
