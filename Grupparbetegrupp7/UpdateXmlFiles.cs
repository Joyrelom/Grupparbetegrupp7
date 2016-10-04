using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
namespace Grupparbetegrupp7
{
    class UpdateXmlFiles
    {
        List<Recept> recept = new List<Recept>();
        string utskrift="";
        public void UpdateXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            XmlDocument xDoc = new XmlDocument();

            xDoc.Load(path + "\\temp\\Grupp7\\settings.xml");
            XmlNode xNode = xDoc.SelectSingleNode("AllaRecept");

            xNode.RemoveAll();

            foreach (Recept r in recept)
            {
                XmlNode xRecept = xDoc.CreateElement("Recept");
                XmlNode xTitel = xDoc.CreateElement("Titel");
                XmlNode xAmne = xDoc.CreateElement("Amne");
                XmlNode xBeskrivning = xDoc.CreateElement("Beskrivning");

                xTitel.InnerText = r.Titel;
                xAmne.InnerText = r.Amne;
                xBeskrivning.InnerText = r.Beskrivning;

                xRecept.AppendChild(xTitel);
                xRecept.AppendChild(xAmne);
                xRecept.AppendChild(xBeskrivning);
               

                xDoc.DocumentElement.AppendChild(xRecept);


            }

            xDoc.Save(path + "\\temp\\Grupp7\\settings.xml");

        }
        public string LaddaInRecept()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\temp\\settings.xml"))
                Directory.CreateDirectory(path + "\\temp\\settings.xml");
            if (!File.Exists(path + "\\temp\\Grupp7\\settings.xml"))
            {
                XmlTextWriter xmlTW = new XmlTextWriter(path + "\\temp\\Grupp7\\settings.xml", Encoding.UTF8);
                xmlTW.WriteStartElement("Personer");
                xmlTW.WriteEndElement();
                xmlTW.Close();

            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\temp\\Grupp7\\settings.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("AllaRecept/Recept"))
            {

                Recept r = new Recept();
                r.Titel = xNode.SelectSingleNode("Titel").InnerText;
                r.Amne = xNode.SelectSingleNode("Amne").InnerText;
                r.Beskrivning = xNode.SelectSingleNode("Beskrivning").InnerText;
                recept.Add(r);
            }
            return utskrift;
        }
    }
}
