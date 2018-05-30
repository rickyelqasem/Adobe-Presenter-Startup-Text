using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace AdobePresenter7_StartupText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                deTxt.Text = enTxt.Text;
                frTxt.Text = enTxt.Text;
                jaTxt.Text = enTxt.Text;
                koTxt.Text = enTxt.Text;
                esTxt.Text = enTxt.Text;
                ptTxt.Text = enTxt.Text;
                itTxt.Text = enTxt.Text;
                nlTxt.Text = enTxt.Text;
                cnTxt.Text = enTxt.Text;
                trTxt.Text = enTxt.Text;
                ruTxt.Text = enTxt.Text;
                deTxt.Enabled = false;
                frTxt.Enabled = false;
                jaTxt.Enabled = false;
                koTxt.Enabled = false;
                esTxt.Enabled = false;
                ptTxt.Enabled = false;
                itTxt.Enabled = false;
                nlTxt.Enabled = false;
                cnTxt.Enabled = false;
                trTxt.Enabled = false;
                ruTxt.Enabled = false;
            }
            else
            {
                deTxt.Enabled = true;
                frTxt.Enabled = true;
                jaTxt.Enabled = true;
                koTxt.Enabled = true;
                esTxt.Enabled = true;
                ptTxt.Enabled = true;
                itTxt.Enabled = true;
                nlTxt.Enabled = true;
                cnTxt.Enabled = true;
                trTxt.Enabled = true;
                ruTxt.Enabled = true;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
             OpenFileDialog openFileDialog1 = new OpenFileDialog();

             openFileDialog1.InitialDirectory = "c:\\" ;
             openFileDialog1.Filter = "xml Files (*.xml)|*.xml|All Files (*.*)|*.*";
             openFileDialog1.FilterIndex = 1 ;
             openFileDialog1.RestoreDirectory = true ;

             if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 XmlDocument xmlDoc = new XmlDocument();
                 try
                 {
                     xmlDoc.Load(openFileDialog1.OpenFile());
                 }
                 catch
                 {
                     MessageBox.Show("Error loading file");
                 }
                 try
                 {
                     XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='en']/uitext[@name='ADOBE_PRESENTER']");
                     enTxt.Text = ennode.Attributes[1].Value;
                 }
                 catch
                 {
                     enTxt.Text = "";
                 }
                 try
                 {
                     XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='de']/uitext[@name='ADOBE_PRESENTER']");
                     deTxt.Text = ennode.Attributes[1].Value;
                 }
                 catch
                 {
                     deTxt.Text = "";
                 }
                 try
                 {
                     XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='fr']/uitext[@name='ADOBE_PRESENTER']");
                     frTxt.Text = ennode.Attributes[1].Value;
                 }
                 catch
                 {
                     frTxt.Text = "";
                 }
                 try
                 {
                     XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='ja']/uitext[@name='ADOBE_PRESENTER']");
                     jaTxt.Text = ennode.Attributes[1].Value;
                 }
                 catch
                 {
                     jaTxt.Text = "";
                 }
                 try
                 {
                     XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='ko']/uitext[@name='ADOBE_PRESENTER']");
                     koTxt.Text = ennode.Attributes[1].Value;
                 }
                 catch
                 {
                     koTxt.Text = "";
                 }
                 try
                 {
                     XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='es']/uitext[@name='ADOBE_PRESENTER']");
                     esTxt.Text = ennode.Attributes[1].Value;
                 }
                 catch
                 {
                     esTxt.Text = "";
                 }
                 try
                 {
                     XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='pt']/uitext[@name='ADOBE_PRESENTER']");
                     ptTxt.Text = ennode.Attributes[1].Value;
                 }
                 catch
                 {
                     ptTxt.Text = "";
                 }
                 try
                 {
                     XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='it']/uitext[@name='ADOBE_PRESENTER']");
                     itTxt.Text = ennode.Attributes[1].Value;
                 }
                 catch
                 {
                     itTxt.Text = "";
                 }
                 try
                 {
                     XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='nl']/uitext[@name='ADOBE_PRESENTER']");
                     nlTxt.Text = ennode.Attributes[1].Value;
                 }
                 catch
                 {
                     nlTxt.Text = "";
                 }
                 try
                 {
                     XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='cn']/uitext[@name='ADOBE_PRESENTER']");
                     cnTxt.Text = ennode.Attributes[1].Value;
                 }
                 catch
                 {
                     cnTxt.Text = "";
                 }
                 try
                 {
                     XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='tr']/uitext[@name='ADOBE_PRESENTER']");
                     trTxt.Text = ennode.Attributes[1].Value;
                 }
                 catch
                 {
                     trTxt.Text = "";
                 }
                 try
                 {
                     XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='ru']/uitext[@name='ADOBE_PRESENTER']");
                     ruTxt.Text = ennode.Attributes[1].Value;
                 }
                 catch
                 {
                     ruTxt.Text = "";
                 }
             }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Update";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "xml Files (*.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(@openFileDialog1.FileName);
                
            }
            catch
            {
            }
            try
            {
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='en']/uitext[@name='ADOBE_PRESENTER']");
                ennode.Attributes[1].Value = enTxt.Text;
            }
            catch
            {
                
                
                XmlElement xmlfolder = xmlDoc.CreateElement(null, "uitext", null);
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='en']");
                XmlAttribute newAtt = xmlDoc.CreateAttribute("name");
                newAtt.Value = "ADOBE_PRESENTER";
                xmlfolder.Attributes.Append(newAtt);
                newAtt = xmlDoc.CreateAttribute("value");
                newAtt.Value = enTxt.Text;
                xmlfolder.Attributes.Append(newAtt);
                ennode.AppendChild(xmlfolder);

            }

            try
            {
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='de']/uitext[@name='ADOBE_PRESENTER']");
                ennode.Attributes[1].Value = deTxt.Text;
            }
            catch
            {
                XmlElement xmlfolder = xmlDoc.CreateElement(null, "uitext", null);
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='de']");
                XmlAttribute newAtt = xmlDoc.CreateAttribute("name");
                newAtt.Value = "ADOBE_PRESENTER";
                xmlfolder.Attributes.Append(newAtt);
                newAtt = xmlDoc.CreateAttribute("value");
                newAtt.Value = deTxt.Text;
                xmlfolder.Attributes.Append(newAtt);
                ennode.AppendChild(xmlfolder);
            }
            try
            {
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='fr']/uitext[@name='ADOBE_PRESENTER']");
                ennode.Attributes[1].Value = frTxt.Text;
            }
            catch
            {
                XmlElement xmlfolder = xmlDoc.CreateElement(null, "uitext", null);
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='fr']");
                XmlAttribute newAtt = xmlDoc.CreateAttribute("name");
                newAtt.Value = "ADOBE_PRESENTER";
                xmlfolder.Attributes.Append(newAtt);
                newAtt = xmlDoc.CreateAttribute("value");
                newAtt.Value = frTxt.Text;
                xmlfolder.Attributes.Append(newAtt);
                ennode.AppendChild(xmlfolder);
            }
            try
            {
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='ja']/uitext[@name='ADOBE_PRESENTER']");
                ennode.Attributes[1].Value = jaTxt.Text;
            }
            catch
            {
                XmlElement xmlfolder = xmlDoc.CreateElement(null, "uitext", null);
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='ja']");
                XmlAttribute newAtt = xmlDoc.CreateAttribute("name");
                newAtt.Value = "ADOBE_PRESENTER";
                xmlfolder.Attributes.Append(newAtt);
                newAtt = xmlDoc.CreateAttribute("value");
                newAtt.Value = jaTxt.Text;
                xmlfolder.Attributes.Append(newAtt);
                ennode.AppendChild(xmlfolder);
            }
            try
            {
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='ko']/uitext[@name='ADOBE_PRESENTER']");
                ennode.Attributes[1].Value = koTxt.Text;
            }
            catch
            {
                XmlElement xmlfolder = xmlDoc.CreateElement(null, "uitext", null);
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='ko']");
                XmlAttribute newAtt = xmlDoc.CreateAttribute("name");
                newAtt.Value = "ADOBE_PRESENTER";
                xmlfolder.Attributes.Append(newAtt);
                newAtt = xmlDoc.CreateAttribute("value");
                newAtt.Value = koTxt.Text;
                xmlfolder.Attributes.Append(newAtt);
                ennode.AppendChild(xmlfolder);
            }
            try
            {
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='es']/uitext[@name='ADOBE_PRESENTER']");
                ennode.Attributes[1].Value = esTxt.Text;
            }
            catch
            {
                XmlElement xmlfolder = xmlDoc.CreateElement(null, "uitext", null);
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='es']");
                XmlAttribute newAtt = xmlDoc.CreateAttribute("name");
                newAtt.Value = "ADOBE_PRESENTER";
                xmlfolder.Attributes.Append(newAtt);
                newAtt = xmlDoc.CreateAttribute("value");
                newAtt.Value = esTxt.Text;
                xmlfolder.Attributes.Append(newAtt);
                ennode.AppendChild(xmlfolder);
            }
            try
            {
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='pt']/uitext[@name='ADOBE_PRESENTER']");
                ennode.Attributes[1].Value = ptTxt.Text;
            }
            catch
            {
                XmlElement xmlfolder = xmlDoc.CreateElement(null, "uitext", null);
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='pt']");
                XmlAttribute newAtt = xmlDoc.CreateAttribute("name");
                newAtt.Value = "ADOBE_PRESENTER";
                xmlfolder.Attributes.Append(newAtt);
                newAtt = xmlDoc.CreateAttribute("value");
                newAtt.Value = ptTxt.Text;
                xmlfolder.Attributes.Append(newAtt);
                ennode.AppendChild(xmlfolder);
            }
            try
            {
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='it']/uitext[@name='ADOBE_PRESENTER']");
                ennode.Attributes[1].Value = itTxt.Text;
            }
            catch
            {
                XmlElement xmlfolder = xmlDoc.CreateElement(null, "uitext", null);
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='it']");
                XmlAttribute newAtt = xmlDoc.CreateAttribute("name");
                newAtt.Value = "ADOBE_PRESENTER";
                xmlfolder.Attributes.Append(newAtt);
                newAtt = xmlDoc.CreateAttribute("value");
                newAtt.Value = itTxt.Text;
                xmlfolder.Attributes.Append(newAtt);
                ennode.AppendChild(xmlfolder);
            }
            try
            {
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='nl']/uitext[@name='ADOBE_PRESENTER']");
                ennode.Attributes[1].Value = nlTxt.Text;
            }
            catch
            {
                XmlElement xmlfolder = xmlDoc.CreateElement(null, "uitext", null);
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='nl']");
                XmlAttribute newAtt = xmlDoc.CreateAttribute("name");
                newAtt.Value = "ADOBE_PRESENTER";
                xmlfolder.Attributes.Append(newAtt);
                newAtt = xmlDoc.CreateAttribute("value");
                newAtt.Value = nlTxt.Text;
                xmlfolder.Attributes.Append(newAtt);
                ennode.AppendChild(xmlfolder);
            }
            try
            {
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='cn']/uitext[@name='ADOBE_PRESENTER']");
                ennode.Attributes[1].Value = cnTxt.Text;
            }
            catch
            {
                XmlElement xmlfolder = xmlDoc.CreateElement(null, "uitext", null);
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='cn']");
                XmlAttribute newAtt = xmlDoc.CreateAttribute("name");
                newAtt.Value = "ADOBE_PRESENTER";
                xmlfolder.Attributes.Append(newAtt);
                newAtt = xmlDoc.CreateAttribute("value");
                newAtt.Value = cnTxt.Text;
                xmlfolder.Attributes.Append(newAtt);
                ennode.AppendChild(xmlfolder);
            }
            try
            {
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='tr']/uitext[@name='ADOBE_PRESENTER']");
                ennode.Attributes[1].Value = trTxt.Text;
            }
            catch
            {
                XmlElement xmlfolder = xmlDoc.CreateElement(null, "uitext", null);
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='tr']");
                XmlAttribute newAtt = xmlDoc.CreateAttribute("name");
                newAtt.Value = "ADOBE_PRESENTER";
                xmlfolder.Attributes.Append(newAtt);
                newAtt = xmlDoc.CreateAttribute("value");
                newAtt.Value = trTxt.Text;
                xmlfolder.Attributes.Append(newAtt);
                ennode.AppendChild(xmlfolder);
            }
            try
            {
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='ru']/uitext[@name='ADOBE_PRESENTER']");
                ennode.Attributes[1].Value = ruTxt.Text;
            }
            catch
            {
                XmlElement xmlfolder = xmlDoc.CreateElement(null, "uitext", null);
                XmlNode ennode = xmlDoc.SelectSingleNode("//language[@id='ru']");
                XmlAttribute newAtt = xmlDoc.CreateAttribute("name");
                newAtt.Value = "ADOBE_PRESENTER";
                xmlfolder.Attributes.Append(newAtt);
                newAtt = xmlDoc.CreateAttribute("value");
                newAtt.Value = ruTxt.Text;
                xmlfolder.Attributes.Append(newAtt);
                ennode.AppendChild(xmlfolder);
            }
            xmlDoc.Save(openFileDialog1.FileName);
            

               
            }
        }

        private void enTxt_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                deTxt.Text = enTxt.Text;
                frTxt.Text = enTxt.Text;
                jaTxt.Text = enTxt.Text;
                koTxt.Text = enTxt.Text;
                esTxt.Text = enTxt.Text;
                ptTxt.Text = enTxt.Text;
                itTxt.Text = enTxt.Text;
                nlTxt.Text = enTxt.Text;
                cnTxt.Text = enTxt.Text;
                trTxt.Text = enTxt.Text;
                ruTxt.Text = enTxt.Text;
            }
        }
    }
}
