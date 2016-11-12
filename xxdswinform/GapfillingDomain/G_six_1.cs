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

    internal class G_six_1
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmlDocument = new XmlDocument();

        public void g_six_1Generate(NuGenEQML control1, string number)
        {
            this.xmlDocument.Load("GapfillingXML/g_six_1.xml");
            foreach (XmlNode node in this.xmlDocument.FirstChild.ChildNodes)
            {
                int num = 0;
                int num2 = 0;
                int num3 = 0;
                int num4 = 0;
                int num5 = 0;
                int num6 = 0;
                int num7 = 0;
                int i = 0;
                int num9 = 0;
                int num10 = 0;
                int num11 = 0;
                int num12 = 0;
                if (StudentModel.isReGeneration)
                {
                    num = this.numberTools.myRandom(3);
                    num2 = this.numberTools.myRandom(3);
                    num3 = this.numberTools.myRandom(3);
                    num4 = this.numberTools.myRandom(3);
                    num5 = this.numberTools.myRandom(3);
                    num6 = this.numberTools.myRandom(3);
                    num7 = num;
                    i = ((num * num4) * num4) + num2;
                    num9 = (((num * num5) * num5) + ((num2 * num6) * num6)) + num3;
                    num10 = num * num4;
                    num11 = num * num5;
                    num12 = ((num * num4) * num5) + (num2 * num6);
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/g_six_1.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("a11", num7.ToString());
                    writer.WriteElementString("a12", num10.ToString());
                    writer.WriteElementString("a13", num11.ToString());
                    writer.WriteElementString("a22", i.ToString());
                    writer.WriteElementString("a23", num12.ToString());
                    writer.WriteElementString("a33", num9.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    int num13 = 0;
                    if (num > 0)
                    {
                        num13++;
                    }
                    if (num2 > 0)
                    {
                        num13++;
                    }
                    if (num3 > 0)
                    {
                        num13++;
                    }
                    writer.WriteElementString("k", num13.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/g_six_1.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a"))
                        {
                            num = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b"))
                        {
                            num2 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c"))
                        {
                            num3 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("m"))
                        {
                            num4 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("n"))
                        {
                            num5 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("t"))
                        {
                            num6 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a11"))
                        {
                            num7 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a22"))
                        {
                            i = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a33"))
                        {
                            num9 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a12"))
                        {
                            num10 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a13"))
                        {
                            num11 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a23"))
                        {
                            num12 = int.Parse(node3.InnerText);
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", num7.ToString()).Replace("#b#", this.numberTools.compare(i)).Replace("#c#", this.numberTools.compare(num9)).Replace("#d#", this.numberTools.compare(2 * num10)).Replace("#e#", this.numberTools.compare(2 * num11)).Replace("#f#", this.numberTools.compare(2 * num12));
                control1.Size = new Size(580, 0x2d);
                control1.Enabled = false;
                control1.pub_LoadXML(sXML);
                control1.Anchor = AnchorStyles.None;
            }
        }
    }
}

