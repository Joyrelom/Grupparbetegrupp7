using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Grupparbetegrupp7
{
    public partial class Form1 : Form
    {
        Felhantering fel = new Felhantering();
        UpdateXmlFiles ux = new UpdateXmlFiles();
        List<Recept> recept = new List<Recept>();
        MissingFieldException ex = new MissingFieldException();
        DateTime datetime = DateTime.Now;
        //Kan vara 2 olika recept listor kolla det
        bool allaUppgifterIfyllda;
        public Form1()
        {
            
            InitializeComponent();
            string returvärde= ux.LaddaInRecept(recept);
            listRecept.Items.Add(returvärde);
           
            
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
            try
            {
                if (txtTitel.Text != "" && cxtAmne.Text != "" && rtxt.Text != "")
                {

                    allaUppgifterIfyllda = true;
                    recept[listRecept.SelectedIndex].Titel = txtTitel.Text;
                    recept[listRecept.SelectedIndex].Amne = cxtAmne.Text;
                    recept[listRecept.SelectedIndex].Beskrivning = rtxt.Text;

                }
                else
                {
                    //DateTime now = Convert.ToDateTime(datetime);
                    fel.ExceptionMethod("Exceptions", " \n Missing Fields in textbox/richtextbox/combobox", ex.ToString(), " | "+datetime.ToString());
                    MessageBox.Show("Alla uppgifter är ej ifyllda, vänligen kontrollera dina inmatade värden"); 

                }
            }
            catch {
                
            }
            return allaUppgifterIfyllda;
        }

        private void cmdSpara_Click(object sender, EventArgs e)
        {
            if (AllaUppgifterIfyllda(ex))
            {

                Recept r = new Recept();
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
            try
            {
                recept.RemoveAt(listRecept.SelectedIndex);
                listRecept.Items.Remove(listRecept.SelectedItems[0]);
                ux.UpdateXml(recept);
               listRecept.ClearSelected();
            }
            catch { }

            ResetText();
        }

        private void listRecept_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listRecept.SelectedItem != null)
            {
                string[] varden = listRecept.SelectedItem.ToString().Split(',');
                Recept r = recept.SingleOrDefault(x => x.Titel == varden[0]);
                txtTitel.Text = r.Titel;
                cxtAmne.Text = r.Amne;
                rtxt.Text = r.Beskrivning;
            }
        }

        private void txtSok_TextChanged(object sender, EventArgs e)
        {
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
    }

}
