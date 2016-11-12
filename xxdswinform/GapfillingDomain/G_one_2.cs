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

    internal class G_one_2
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmlDocument = new XmlDocument();

        public void g_one_2Generate(NuGenEQML control1, string number)
        {
            this.xmlDocument.Load("GapfillingXML/g_one_2.xml");
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
                int num16 = 0;
                if (StudentModel.isReGeneration)
                {
                    num = this.numberTools.myRandom(9);
                    num2 = -1 * num;
                    num3 = num;
                    num4 = 1 - num;
                    num5 = this.random.Next(-9, 10);
                    num6 = this.random.Next(-9, 10);
                    num7 = this.random.Next(-9, 10);
                    num8 = this.random.Next(-9, 10);
                    num9 = this.random.Next(-9, 10);
                    num10 = this.random.Next(-9, 10);
                    num11 = this.random.Next(-9, 10);
                    num12 = this.random.Next(-9, 10);
                    num13 = this.random.Next(-9, 10);
                    num14 = this.random.Next(-9, 10);
                    num15 = this.random.Next(-9, 10);
                    num16 = this.random.Next(-9, 10);
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/g_one_2.xml";
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
                    writer.WriteElementString("a22", num8.ToString());
                    writer.WriteElementString("a23", num9.ToString());
                    writer.WriteElementString("a24", num10.ToString());
                    writer.WriteElementString("a31", num6.ToString());
                    writer.WriteElementString("a32", num11.ToString());
                    writer.WriteElementString("a33", num12.ToString());
                    writer.WriteElementString("a34", num13.ToString());
                    writer.WriteElementString("a41", num7.ToString());
                    writer.WriteElementString("a42", num14.ToString());
                    writer.WriteElementString("a43", num15.ToString());
                    writer.WriteElementString("a44", num16.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("D", (((num6 + num11) * (num14 + num15)) - ((num11 + num12) * (num7 + num14))).ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/g_one_2.xml");
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
                            num8 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a23"))
                        {
                            num9 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a24"))
                        {
                            num10 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a31"))
                        {
                            num6 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a32"))
                        {
                            num11 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a33"))
                        {
                            num12 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a34"))
                        {
                            num13 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a41"))
                        {
                            num7 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a42"))
                        {
                            num14 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a43"))
                        {
                            num15 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a44"))
                        {
                            num16 = int.Parse(node3.InnerText);
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", num.ToString()).Replace("#b#", num2.ToString()).Replace("#c#", num3.ToString()).Replace("#d#", num4.ToString()).Replace("#e#", num5.ToString()).Replace("#f#", num8.ToString()).Replace("#g#", num9.ToString()).Replace("#h#", num10.ToString()).Replace("#i#", num6.ToString()).Replace("#j#", num11.ToString()).Replace("#k#", num12.ToString()).Replace("#l#", num13.ToString()).Replace("#m#", num7.ToString()).Replace("#n#", num14.ToString()).Replace("#o#", num15.ToString()).Replace("#p#", num16.ToString());
                control1.Size = new Size(540, 110);
                control1.Font = new Font("宋体", 14f, FontStyle.Bold);
                control1.Enabled = false;
                control1.Anchor = AnchorStyles.None;
                control1.pub_LoadXML(sXML);
            }
        }
    }
}

