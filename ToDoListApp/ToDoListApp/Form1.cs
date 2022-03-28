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

namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        List<string> listaZadataka = new List<string>();
        public Form1()
        {
            InitializeComponent();
            UcitajBoje();
            UcitajDatoteku();
            
        }

        private void UcitajBoje()
        {
            BackColor = ColorTranslator.FromHtml("#fffcf2");
            dugmeDodaj.BackColor = ColorTranslator.FromHtml("#023047");
            dugmeObrisi.BackColor = ColorTranslator.FromHtml("#8ecae6");
        }

        private void UcitajDatoteku()
        {
            StreamReader sr = new StreamReader("datoteka.txt",Encoding.ASCII);
            string linijaDatoteka = null;

            while((linijaDatoteka=sr.ReadLine()) != null )
            {
                listaZadataka.Add(linijaDatoteka);
                
            }
            sr.Close();

            OsvjeziListu();
        }

        private void SacuvajDatoteku()
        {
           StreamWriter sw = new StreamWriter("datoteka.txt",false,Encoding.ASCII);
           foreach(string linija in listaZadataka)
           {
                sw.WriteLine(linija);
           }
           sw.Close();
        }

        private void DodajKlik(object sender, EventArgs e)
        {
            listaZadataka.Add(textBox1.Text);

            OsvjeziListu();
            
        }

        private void ObrisiKlik(object sender, EventArgs e)
        {
            int obrisiIndex = listBox.SelectedIndex;
            listaZadataka.RemoveAt(obrisiIndex);

            OsvjeziListu();
        }

        private void OsvjeziListu()
        {
            listBox.DataSource = null;
            listBox.DataSource = listaZadataka;
        }

        private void IskljucivanjePrograma(object sender, FormClosedEventArgs e)
        {
            SacuvajDatoteku();            
        }
    }
}
