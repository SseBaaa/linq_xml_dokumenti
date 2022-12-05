using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    

namespace linq_xml_dokumenti
{
    public partial class Unos : Form
    {
        List<Osoba> osobe = new List<Osoba>();
        string document = "osobe.xml";
        public Unos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba(textBoxIme.Text, textBoxPrezime.Text, Convert.ToInt32(textBoxGodRod.Text));
            osobe.Add(osoba);
            DialogResult upit = MessageBox.Show("Želite li upisati jos osoba?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(upit == DialogResult.Yes)
            {
                textBoxIme.Clear();
                textBoxPrezime.Clear();
                textBoxGodRod.Clear();
            }
            else
            {
                if (File.Exists(document)) 
                { 
                var OsobeXML = XDocument.Load(document);
                   
                    
                    foreach (Osoba o in osobe)
                    {
                        var Osoba = new XElement("Osoba", new XElement("Ime", osoba.Ime), new XElement("Prezime", osoba.Prezime), new XElement("Godina_rođenja", osoba.GodRod));
                        OsobeXML.Root.Add(Osoba);
                    }
                    OsobeXML.Save(document);
                }
                else
                {
                    var OsobeXML = new XDocument();
                    OsobeXML.Add(new XElement("Osobe"));
                    foreach (Osoba o in osobe)
                    {
                        var Osoba = new XElement("Osoba", new XElement("Ime", osoba.Ime), new XElement("Prezime", osoba.Prezime), new XElement("Godina_rođenja", osoba.GodRod));
                        OsobeXML.Root.Add(Osoba);
                    }
                    OsobeXML.Save(document);
                }
                this.Close();
                /*
                 if (File.Exists(document))
                 {
                     DialogResult overwrite = MessageBox.Show("Dokument vec postoji" + "\r\nŽelite li prepisati stari dokument", "Dokument postoji!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                 }
                 if(DialogResult == DialogResult.Yes)
                 {
                     OsobeXML.Save(document);
                 }
                 else
                 {
                     SaveFileDialog noviDokument = new SaveFileDialog();
                     noviDokument.InitialDirectory = @"C:\";
                     noviDokument.Title = "Spremi novi dokument";
                     noviDokument.DefaultExt = "xml";
                     noviDokument.ShowDialog();
                     document = noviDokument.FileName;
                     OsobeXML.Save(document);
                    */
            }
            
            }
        }
    }

