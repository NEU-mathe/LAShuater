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

    internal class G_four_2
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmlDocument = new XmlDocument();

        public void g_four_2Generate(NuGenEQML control1, string number)
        {
            this.xmlDocument.Load("GapfillingXML/g_four_2.xml");
            foreach (XmlNode node in this.xmlDocument.FirstChild.ChildNodes)
            {
                int num = 0;
                int num2 = 0;
                int num3 = 0;
                int num4 = 0;
                int num5 = 0;
                int num6 = 0;
                int num7 = 0;
                int num8 = 0;
                int num9 = 0;
                int num10 = 0;
                int num11 = 0;
                int num12 = 0;
                int num13 = 0;
                int num14 = 0;
                int num15 = 0;
                if (StudentModel.isReGeneration)
                {
                    num = 1;
                    num2 = this.numberTools.myRandom(5);
                    num3 = this.numberTools.myRandom(5);
                    num4 = this.numberTools.myRandom(5);
                    num5 = 6;
                    num6 = this.numberTools.myRandom(5);
                    num7 = this.numberTools.myRandom(5);
                    num8 = this.numberTools.myRandom(5);
                    num9 = this.numberTools.myRandom(3);
                    num10 = this.numberTools.myRandom(3);
                    num11 = this.random.Next(0, 2);
                    num12 = (num9 * num) + (num10 * num5);
                    num13 = (num9 * num2) + (num10 * num6);
                    num14 = ((num9 * num3) + (num10 * num7)) + num11;
                    num15 = ((num9 * num4) + (num10 * num8)) + num11;
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/g_four_2.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("a11", num.ToString());
                    writer.WriteElementString("a12", num2.ToString());
                    writer.WriteElementString("a13", num3.ToString());
                    writer.WriteElementString("a14", num4.ToString());
                    writer.WriteElementString("a21", num5.ToString());
                    writer.WriteElementString("a22", num6.ToString());
                    writer.WriteElementString("a23", num7.ToString());
                    writer.WriteElementString("a24", num8.ToString());
                    writer.WriteElementString("a31", num12.ToString());
                    writer.WriteElementString("a32", num13.ToString());
                    writer.WriteElementString("a33", num14.ToString());
                    writer.WriteElementString("a34", num15.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("d", num11.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/g_four_2.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a11"))
                        {
                            num = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a12"))
                        {
                            num2 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a13"))
                        {
                            num3 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a14"))
                        {
                            num4 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a21"))
                        {
                            num5 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a22"))
                        {
                            num6 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a23"))
                        {
                            num7 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a24"))
                        {
                            num8 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a31"))
                        {
                            num12 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a32"))
                        {
                            num13 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a33"))
                        {
                            num14 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a34"))
                        {
                            num15 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("k1"))
                        {
                            num9 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("k2"))
                        {
                            num10 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("d"))
                        {
                            num11 = int.Parse(node3.InnerText);
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", num.ToString()).Replace("#b#", num2.ToString()).Replace("#c#", num3.ToString()).Replace("#d#", num4.ToString()).Replace("#e#", num5.ToString()).Replace("#f#", num6.ToString()).Replace("#g#", num7.ToString()).Replace("#h#", num8.ToString()).Replace("#i#", num12.ToString()).Replace("#j#", num13.ToString()).Replace("#k#", num14.ToString()).Replace("#l#", num15.ToString());
                control1.Size = new Size(550, 110);
                control1.Enabled = false;
                control1.pub_LoadXML(sXML);
                control1.Anchor = AnchorStyles.None;
            }
        }
    }
}

