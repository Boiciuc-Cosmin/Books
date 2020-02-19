using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Enumerable_Where
{
    class Program
    {
        private static object config;

        static void Main(string[] args)
        {
            string[] names = { "Tom", "Michael", "Harry", "Marry", "Jay" };
            IEnumerable<string> querry = names.Where(names => names.EndsWith("y"));

            //IEnumerable<string> query = from n in names
            //                            where n.EndsWith("y")
            //                            select n;
            //IEnumerable<string> query = names.Select((s, i) => i + "=" + s);


            //foreach (var name in query)
            //{
            //    Console.WriteLine(name);
            //}

            //Players();
            XElement e = new XElement("now", DateTime.Now);
            DateTime dt = (DateTime)e;
            Console.WriteLine(e);

            Xelements();
        }

        static void Players()
        {
            string[] players = { "Cosma", "Mondor", "Cezar" };
            IEnumerable<string> query = from name1 in players
                                        from name2 in players
                                        where name1.CompareTo(name2) < 0
                                        orderby name2
                                        select name1 + " vs " + name2;
            foreach (var player in query)
            {
                Console.WriteLine(player);
            }
        }

        static void Xelements()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.DtdProcessing = DtdProcessing.Parse; // Required to read DTDs
            using (XmlReader r = XmlReader.Create("customer.xml", settings))
                while (r.Read())
                {
                    Console.Write(r.NodeType.ToString().PadRight(17, '-'));
                    Console.Write("> ".PadRight(r.Depth * 3));
                    switch (r.NodeType)
                    {
                        case XmlNodeType.Element:
                        case XmlNodeType.EndElement:
                            Console.WriteLine(r.Name); break;
                        case XmlNodeType.Text:
                        case XmlNodeType.CDATA:
                        case XmlNodeType.Comment:
                        case XmlNodeType.XmlDeclaration:
                            Console.WriteLine(r.Value); break;
                        case XmlNodeType.DocumentType:
                            Console.WriteLine(r.Name + " - " + r.Value); break;
                        default: break;
                    }
                }
        }

    }
}
