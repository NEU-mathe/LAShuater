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

    internal class G_one_1
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmlDocument = new XmlDocument();

        public void g_one_1Generate(NuGenEQML control1, string number)
        {
            this.xmlDocument.Load("GapfillingXML/g_one_1.xml");
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
                int num17 = 0;
                int num18 = 0;
                int num19 = 0;
                int num20 = 0;
                int num21 = 0;
                int num22 = 0;
                int num23 = 0;
                int num24 = 0;
                int num25 = 0;
                if (StudentModel.isReGeneration)
                {
                    num = this.numberTools.myRandom(5);
                    num2 = this.numberTools.myRandom(5);
                    num3 = this.numberTools.myRandom(5);
                    num4 = this.numberTools.myRandom(5);
                    num5 = this.numberTools.myRandom(5);
                    num6 = this.numberTools.myRandom(5);
                    num7 = this.numberTools.myRandom(5);
                    num8 = this.numberTools.myRandom(5);
                    num9 = this.numberTools.myRandom(5);
                    num10 = 1;
                    num11 = num4;
                    num12 = num5;
                    num13 = num6;
                    num14 = num;
                    num15 = num2;
                    num16 = num3;
                    num17 = (num * num4) + num7;
                    num18 = num * num5;
                    num19 = (num * num6) - num7;
                    num20 = num2 * num4;
                    num21 = (num2 * num5) + num8;
                    num22 = (num2 * num6) - num8;
                    num23 = num3 * num4;
                    num24 = num3 * num5;
                    num25 = (num3 * num6) + num9;
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/g_one_1.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("guid", str);
                    writer.WriteAttributeString("save", "false");
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("a11", num10.ToString());
                    writer.WriteElementString("a12", num11.ToString());
                    writer.WriteElementString("a13", num12.ToString());
                    writer.WriteElementString("a14", num13.ToString());
                    writer.WriteElementString("a21", num14.ToString());
                    writer.WriteElementString("a22", num17.ToString());
                    writer.WriteElementString("a23", num18.ToString());
                    writer.WriteElementString("a24", num19.ToString());
                    writer.WriteElementString("a31", num15.ToString());
                    writer.WriteElementString("a32", num20.ToString());
                    writer.WriteElementString("a33", num21.ToString());
                    writer.WriteElementString("a34", num22.ToString());
                    writer.WriteElementString("a41", num16.ToString());
                    writer.WriteElementString("a42", num23.ToString());
                    writer.WriteElementString("a43", num24.ToString());
                    writer.WriteElementString("a44", num25.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("D", ((num7 * num8) * num9).ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/g_one_1.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a11"))
                        {
                            num10 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a12"))
                        {
                            num11 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a13"))
                        {
                            num12 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a14"))
                        {
                            num13 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a21"))
                        {
                            num14 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a22"))
                        {
                            num17 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a23"))
                        {
                            num18 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a24"))
                        {
                            num19 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a31"))
                        {
                            num15 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a32"))
                        {
                            num20 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a33"))
                        {
                            num21 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a34"))
                        {
                            num22 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a41"))
                        {
                            num16 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a42"))
                        {
                            num23 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a43"))
                        {
                            num24 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a44"))
                        {
                            num25 = int.Parse(node3.InnerText);
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", num10.ToString()).Replace("#b#", num11.ToString()).Replace("#c#", num12.ToString()).Replace("#d#", num13.ToString()).Replace("#e#", num14.ToString()).Replace("#f#", num17.ToString()).Replace("#g#", num18.ToString()).Replace("#h#", num19.ToString()).Replace("#i#", num15.ToString()).Replace("#j#", num20.ToString()).Replace("#k#", num21.ToString()).Replace("#l#", num22.ToString()).Replace("#m#", num16.ToString()).Replace("#n#", num23.ToString()).Replace("#o#", num24.ToString()).Replace("#p#", num25.ToString());
                control1.Size = new Size(360, 120);
                control1.Enabled = false;
                control1.Font = new Font("宋体", 14f, FontStyle.Bold);
                control1.Anchor = AnchorStyles.None;
                control1.pub_LoadXML(sXML);
            }
        }
    }
}

