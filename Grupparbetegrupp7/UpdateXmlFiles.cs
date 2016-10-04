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
        string utskrift="";
       
        public void UpdateXml(List<Recept> recept)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            XmlDocument xDoc = new XmlDocument();

            xDoc.Load(path + "\\temp\\Grupp7\\installningar.xml");
            XmlNode xNode = xDoc.SelectSingleNode("AllaRecept");

            xNode.RemoveAll();

            foreach (Recept r in recept)
            {
                XmlNode xRecept = xDoc.CreateElement("Recept");
                XmlNode xID = xDoc.CreateElement("ID");
                XmlNode xTitel = xDoc.CreateElement("Titel");
                XmlNode xAmne = xDoc.CreateElement("Amne");
                XmlNode xBeskrivning = xDoc.CreateElement("Beskrivning");

                xID.InnerText = r.ID;
                xTitel.InnerText = r.Titel;
                xAmne.InnerText = r.Amne;
                xBeskrivning.InnerText = r.Beskrivning;

                xRecept.AppendChild(xID);
                xRecept.AppendChild(xTitel);
                xRecept.AppendChild(xAmne);
                xRecept.AppendChild(xBeskrivning);
               

                xDoc.DocumentElement.AppendChild(xRecept);


            }

            xDoc.Save(path + "\\temp\\Grupp7\\installningar.xml");

        }
        
    }
}
