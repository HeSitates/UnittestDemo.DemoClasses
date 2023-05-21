using System.Xml;
using System.Xml.Linq;

namespace DemoClasses.Extensions;

public static class XElementExtensions
{
  public static XmlNode? ToXmlNode(this XElement element, XmlDocument? xmlDoc = null)
  {
    xmlDoc ??= new XmlDocument();

    using var xmlReader = element.CreateReader();
    return xmlDoc.ReadNode(xmlReader);
  }
}
