using System;
using System.Linq;
using System.Xml.Linq;

namespace LinqToXml.Samples
{
  public static class XmlHelper
  {
    public static T GetAs<T>(this XElement elem, T defaultValue = default(T))
    {
      T ret = defaultValue;

      if (elem != null && !string.IsNullOrEmpty(elem.Value)) {
        // Cast to Return Data Type
        // NOTE: ChangeType can not cast to a Nullable type
        ret = (T)Convert.ChangeType(elem.Value, typeof(T));
      }

      return ret;
    }

    public static T GetAs<T>(this XAttribute attr, T defaultValue = default(T))
    {
      T ret = defaultValue;

      if (attr != null && !string.IsNullOrEmpty(attr.Value)) {
        // Cast to Return Data Type
        // NOTE: ChangeType can not cast to a Nullable type
        ret = (T)Convert.ChangeType(attr.Value, typeof(T));
      }

      return ret;
    }
  }
}
