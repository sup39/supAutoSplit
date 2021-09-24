using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SupExtension {
  public static class SupEnum {
	public static E[] Enumerate<E>() => (E[])Enum.GetValues(typeof(E));
	public static IEnumerable<string> EnumerateDescription<E>() =>
	  Enumerate<E>().Select(e => e.ToDescription());
	public static string[] DescriptionList<E>() =>
	  Enumerate<E>().Select(e => e.ToDescription()).ToArray();
	public static string ToDescription<E>(this E val) {
	  DescriptionAttribute[] attributes = (DescriptionAttribute[])val
		 .GetType()
		 .GetField(val.ToString())
		 .GetCustomAttributes(typeof(DescriptionAttribute), false);
	  return attributes.Length > 0 ? attributes[0].Description : string.Empty;
	}
  }

  public static class SupEnumerable {
	public static void ForEach<T>(this IEnumerable<T> itr, Action<T> action) {
	  foreach (T item in itr) {
		action(item);
	  }
	}
  }

  public static class SupXml {
	public static XmlElement CreateElement(this XmlDocument document, string name, XmlElement parent) {
	  var elm = document.CreateElement(name);
	  parent?.AppendChild(elm);
	  return elm;
	}
  }

  public static class SupParse {
	public static int? Int(string s) => int.TryParse(s, out var result) ? (int?)result : null;
  }
}
