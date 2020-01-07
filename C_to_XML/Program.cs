using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_to_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument(new XDeclaration("1.0","utf-8","yes") , new XComment("Menuo Food"),


        new XElement("breakfast_Menu",
             new XElement("Food", new XAttribute("id", "501"),
                new XElement("name", "waffles"),
                new XElement("Description", "waffles with coffe"),
                new XElement("price", " 20$"),
                 new XElement("Calories", "50")),

             new XElement("Food", new XAttribute("id", "502"),
                new XElement("name", "wa"),
                new XElement("Description", " coffe"),
                 new XElement("price", " 90$"),
                 new XElement("Calories", "90")),

             new XElement("Food", new XAttribute("id", "503"),
                new XElement("name", "fles"),
                new XElement("Description", "waffles with tea"),
                new XElement("price", " 270$"),
                 new XElement("Calories", "500"))));

            // xdoc.Save("Desk.xml");

            //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& SELECT
            /*
           IEnumerable<string> names = from Food in XDocument.Load(@"C:\\Users\\Alaa\\Documents\\Visual Studio 2015\\Projects\\C_to_XML\\C_to_XML\\XMLFile1.xml")
             .Descendants("Food")
                                       where (int)Food.Element("calories") > 50
                         select Food.Element("name").Value;


           foreach (string item in names)
           {

               Console.WriteLine(item);
               Console.WriteLine("****************************88");
               \
           }
              */

            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ ADD

            /*
                       try
                    {
                        XDocument xdoce = XDocument.Load(@"C:\\Users\\Alaa\\Documents\\Visual Studio 2015\\Projects\\C_to_XML\\C_to_XML\\XMLFile1.xml");
                        xdoce.Element("breakfast_Menu").AddFirst(
                            new XElement("Food", new XAttribute("id", "599"),
                            new XElement("name", "watertttttttttttttt"),
                            new XElement("Description", " colayyyyyyyyyyyyy"),
                             new XElement("price", " 99999$"),
                             new XElement("Calories", "0000")));
                        xdoce.Save(@"C:\\Users\\Alaa\\Documents\\Visual Studio 2015\\Projects\\C_to_XML\\C_to_XML\\XMLFile1.xml");


                    }
                    catch(NullReferenceException e)
                    {

                    }
                    */

            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ UPDATE

            XDocument xdocee = XDocument.Load(@"C:\\Users\\Alaa\\Documents\\Visual Studio 2015\\Projects\\C_to_XML\\C_to_XML\\XMLFile1.xml");

            xdocee.Element("breakfast_Menu").Elements("Food").Where(x => x.Attribute("id").Value == "502").FirstOrDefault()
            .SetElementValue("name", "hot dog");

            xdocee.Save(@"C:\\Users\\Alaa\\Documents\\Visual Studio 2015\\Projects\\C_to_XML\\C_to_XML\\XMLFile1.xml");

            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

            Console.ReadKey();
        }
    }
}
