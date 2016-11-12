namespace xxdswinform.GapfillingDomain
{
    using Genetibase.MathX;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml;
    using xxdswinform.Tools;
    using xxdswinform.Utils;

    internal class G_five_1
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmlDocument = new XmlDocument();

        public void g_five_1Generate(NuGenEQML control1, string number)
        {
            this.xmlDocument.Load("GapfillingXML/g_five_1.xml");
            foreach (XmlNode node in this.xmlDocument.FirstChild.ChildNodes)
            {
                int num4;
                int num = 0;
                int i = 0;
                string innerText = null;
                string str2 = null;
                string str3 = null;
                string str4 = null;
                string str5 = null;
                string str6 = null;
                string str7 = null;
                string str8 = null;
                string str9 = null;
                if (StudentModel.isReGeneration)
                {
                    num = this.numberTools.myRandom(5);
                    i = this.numberTools.myRandom(5);
                    innerText = "k" + this.numberTools.compare(i);
                    str2 = "k" + this.numberTools.compare(i);
                    str3 = "k" + this.numberTools.compare(-1 * i);
                    str4 = "k" + this.numberTools.compare(-1 * i);
                    num4 = -1 * i;
                    str5 = num4.ToString();
                    num4 = -1 * i;
                    str6 = num4.ToString();
                    str7 = i.ToString();
                    str8 = i.ToString();
                    str9 = i.ToString();
                    string str10 = SupportTools.getGuid();
                    string path = "temp/generate/g_five_1.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str10);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("a", num.ToString());
                    writer.WriteElementString("b", i.ToString());
                    writer.WriteElementString("a11", innerText.ToString());
                    writer.WriteElementString("a12", str3.ToString());
                    writer.WriteElementString("a13", str5.ToString());
                    writer.WriteElementString("a21", str4.ToString());
                    writer.WriteElementString("a22", str2.ToString());
                    writer.WriteElementString("a23", str7.ToString());
                    writer.WriteElementString("a31", str6.ToString());
                    writer.WriteElementString("a32", str8.ToString());
                    writer.WriteElementString("a33", str9.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("k", SupportTools.DoubleFormat(((double) num) / 2.0).ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/g_five_1.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a"))
                        {
                            num = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b"))
                        {
                            i = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a11"))
                        {
                            innerText = node3.InnerText;
                        }
                        else if (node3.Name.Equals("a22"))
                        {
                            str2 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("a12"))
                        {
                            str3 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("a21"))
                        {
                            str4 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("a13"))
                        {
                            str5 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("a31"))
                        {
                            str6 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("a23"))
                        {
                            str7 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("a32"))
                        {
                            str8 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("a33"))
                        {
                            str9 = node3.InnerText;
                        }
                    }
                }
                num4 = 3 * i;
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", innerText.ToString()).Replace("#b#", str3.ToString()).Replace("#c#", str5.ToString()).Replace("#d#", str4.ToString()).Replace("#e#", str2.ToString()).Replace("#f#", str7.ToString()).Replace("#g#", str6.ToString()).Replace("#h#", str8.ToString()).Replace("#i#", str9.ToString()).Replace("#j#", num.ToString()).Replace("#k#", num4.ToString()).Replace("#l#", "");
                control1.Size = new Size(500, 80);
                control1.Enabled = false;
                control1.pub_LoadXML(sXML);
                control1.Anchor = AnchorStyles.None;
            }
        }
    }
}

