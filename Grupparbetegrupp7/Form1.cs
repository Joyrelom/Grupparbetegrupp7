using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
namespace Grupparbetegrupp7
{
    public partial class Form1 : Form
    {
        int i = 0;
        int id = 1;
        Felhantering fel = new Felhantering();
        UpdateXmlFiles ux = new UpdateXmlFiles();
        List<Recept> recept = new List<Recept>();
        MissingFieldException ex = new MissingFieldException();
        DateTime datetime = DateTime.Now;
        bool allaUppgifterIfyllda;

        public Form1()
        {
            
            InitializeComponent();
            LaddaInRecept();
           
            
        }


        public override void ResetText()
        {
            txtTitel.Text = "";
            cxtAmne.Text = "";
            rtxt.Text = "";
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtSok.Text = "";
            ux.UpdateXml(recept);
            ResetText();

        }
        private bool AllaUppgifterIfyllda(MissingFieldException ex)
        {
           
            allaUppgifterIfyllda = false;

                if (txtTitel.Text != "" && cxtAmne.Text != "" && rtxt.Text != "")
                {

                    allaUppgifterIfyllda = true;
                    

                }
                else
                {
                    //DateTime now = Convert.ToDateTime(datetime);
                    fel.ExceptionMethod("Exceptions", " \n Missing Fields in textbox/richtextbox/combobox", ex.ToString(), " | " + datetime.ToString());
                    MessageBox.Show("Alla uppgifter är ej ifyllda, vänligen kontrollera dina inmatade värden"); 

                }
            

            return allaUppgifterIfyllda;
        }

        private void cmdSpara_Click(object sender, EventArgs e)
        {
            if (AllaUppgifterIfyllda(ex))
            {

                Recept r = new Recept();
                r.ID = id.ToString();
                id++;
                r.Titel = txtTitel.Text;
                r.Amne = cxtAmne.Text;
                r.Beskrivning= rtxt.Text;
                recept.Add(r);
                listRecept.Items.Add(r.Titel);
                ux.UpdateXml(recept);

                MessageBox.Show("Ditt recept är nu sparat");
                ResetText();
            }
        }

        private void cmdAndra_Click(object sender, EventArgs e)
        {
                if (AllaUppgifterIfyllda(ex))
                {
                    recept.RemoveAt(listRecept.SelectedIndex);
                    listRecept.Items.Remove(listRecept.SelectedItems[0]);

                    Recept r = new Recept();
                    r.Titel = txtTitel.Text;
                    r.Amne = cxtAmne.Text;
                    r.Beskrivning = rtxt.Text;

                    recept.Add(r);
                    listRecept.Items.Add(r.Titel);
                    ux.UpdateXml(recept);
                    ResetText();

                    MessageBox.Show("Ditt recept är nu ändrat");

                }

        }

        private void cmdTaBort_Click(object sender, EventArgs e)
        {
            if (listRecept.SelectedItems!= null)
            { 
                recept.RemoveAt(listRecept.SelectedIndex);
                listRecept.Items.Remove(listRecept.SelectedItems[0]);
                ux.UpdateXml(recept);
               listRecept.ClearSelected();
            }
            else{
                fel.ExceptionMethod("Exceptions", " \n Missing Fields in textbox/richtextbox/combobox", ex.ToString(), " | " + datetime.ToString());
                MessageBox.Show("Alla uppgifter är ej ifyllda, vänligen kontrollera dina inmatade värden");
            }

            ResetText();
        }

        private void listRecept_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // No need to make a search on the recept list we allready have the code we need to pass to the 
                // textboxes in the string varden. 
                string[] varden = listRecept.SelectedItem.ToString().Split(',');
                txtTitel.Text = varden[1];
                cxtAmne.Text = varden[2];
                rtxt.Text = varden[3];

               // Recept r = recept.SingleOrDefault(x => x.ID == varden[0]);
               // txtTitel.Text = r.Titel;
               // cxtAmne.Text = r.Amne;
               // rtxt.Text = r.Beskrivning;
            }
            catch { }
        }

        private void txtSok_TextChanged(object sender, EventArgs e)
        {
            listRecept.ClearSelected();
            ResetText();
            listRecept.Items.Clear();
            if (txtSok.Text == "")
            {
                foreach (var item in recept)
                {
                    listRecept.Items.Add(item.Titel);
                }
            }
         
        }

        private void cmdSok_Click(object sender, EventArgs e)
        {
            
            if (txtSok.Text != "")
            {

                var temp = recept.Where(a => a.Titel.ToLower().Contains(txtSok.Text.ToLower()) ||
                 a.Amne.ToLower().Contains(txtSok.Text.ToLower())).ToList();

                listRecept.Items.Clear();

                foreach (var item in temp)
                {
                    listRecept.Items.Add(item.Titel);
                }

            }

            else
            {
                listRecept.Items.Clear();

                foreach (var item in recept)
                {
                    listRecept.Items.Add(item.Titel);
                }


            }
        }
        public void LaddaInRecept()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\temp\\Grupp7"))
                Directory.CreateDirectory(path + "\\temp\\Grupp7");
            if (!File.Exists(path + "\\temp\\Grupp7\\installningar.xml"))
            {
                XmlTextWriter xmlTW = new XmlTextWriter(path + "\\temp\\Grupp7\\installningar.xml", Encoding.UTF8);
                xmlTW.WriteStartElement("AllaRecept");
                xmlTW.WriteEndElement();
                xmlTW.Close();

            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\temp\\Grupp7\\installningar.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("AllaRecept/Recept"))
            {

                Recept r = new Recept();
                //r.ID = xNode.SelectSingleNode("ID").InnerText;
                r.Titel = xNode.SelectSingleNode("Titel").InnerText;
                r.Amne = xNode.SelectSingleNode("Amne").InnerText;
                r.Beskrivning = xNode.SelectSingleNode("Beskrivning").InnerText;
                recept.Add(r);
                listRecept.Items.Add(r.ID + ", " + r.Titel);
            }

        }

    }


}
