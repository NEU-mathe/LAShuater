namespace xxdswinform.CalculationDomain
{
    using Genetibase.MathX;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Xml;
    using xxdswinform.Tools;
    using xxdswinform.Utils;

    internal class C6
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmldocument = new XmlDocument();

        public void C6Generate(NuGenEQML control, string number)
        {
            this.xmldocument.Load("CalculationXML/c6.xml");
            foreach (XmlNode node in this.xmldocument.FirstChild.ChildNodes)
            {
                string innerText = null;
                string str2 = null;
                string str3 = null;
                string str4 = null;
                string str5 = null;
                string str6 = null;
                string str7 = null;
                string str8 = null;
                string str9 = null;
                string str10 = null;
                string str11 = null;
                int i = 0;
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
                if (StudentModel.isReGeneration)
                {
                    i = this.numberTools.myRandom(9);
                    innerText = ((i == 1) || (i == -1)) ? this.numberTools.compare(i).Replace("+", "").Replace("1", "") : this.numberTools.compare(i).Replace("+", "");
                    num2 = this.numberTools.myRandom(9);
                    str2 = ((num2 == 1) || (num2 == -1)) ? this.numberTools.compare(num2).Replace("1", "") : this.numberTools.compare(num2);
                    num3 = this.numberTools.myRandom(9);
                    str3 = ((num3 == 1) || (num3 == -1)) ? this.numberTools.compare(num3).Replace("1", "") : this.numberTools.compare(num3);
                    num4 = this.numberTools.myRandom(9);
                    str4 = ((num4 == 1) || (num4 == -1)) ? this.numberTools.compare(num4).Replace("+", "").Replace("1", "") : this.numberTools.compare(num4).Replace("+", "");
                    num5 = this.numberTools.myRandom(9);
                    str5 = ((num5 == 1) || (num5 == -1)) ? this.numberTools.compare(num5).Replace("1", "") : this.numberTools.compare(num5);
                    num6 = this.numberTools.myRandom(9);
                    str6 = ((num6 == 1) || (num6 == -1)) ? this.numberTools.compare(num6).Replace("1", "") : this.numberTools.compare(num6);
                    num7 = this.numberTools.myRandom(9);
                    str7 = ((num7 == 1) || (num7 == -1)) ? this.numberTools.compare(num7).Replace("1", "") : this.numberTools.compare(num7);
                    num8 = this.numberTools.myRandom(9);
                    str8 = ((num8 == 1) || (num8 == -1)) ? this.numberTools.compare(num8).Replace("+", "").Replace("1", "") : this.numberTools.compare(num8).Replace("+", "");
                    num9 = this.numberTools.myRandom(9);
                    str9 = ((num9 == 1) || (num9 == -1)) ? this.numberTools.compare(num9).Replace("1", "") : this.numberTools.compare(num9);
                    num10 = this.numberTools.myRandom(9);
                    str10 = ((num10 == 1) || (num10 == -1)) ? this.numberTools.compare(num10).Replace("1", "") : this.numberTools.compare(num10);
                    num11 = this.numberTools.myRandom(9);
                    str11 = ((num11 == 1) || (num11 == -1)) ? this.numberTools.compare(num11).Replace("1", "") : this.numberTools.compare(num11);
                    string str12 = SupportTools.getGuid();
                    string path = "temp/generate/c6.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str12);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("k1 ", innerText);
                    writer.WriteElementString("k2 ", str2);
                    writer.WriteElementString("k3 ", str3);
                    writer.WriteElementString("c1 ", str4);
                    writer.WriteElementString("c2 ", str5);
                    writer.WriteElementString("c3 ", str6);
                    writer.WriteElementString("c4", str7);
                    writer.WriteElementString("d1", str8);
                    writer.WriteElementString("d2", str9);
                    writer.WriteElementString("d3", str10);
                    writer.WriteElementString("d4", str11);
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("k1 ", i.ToString());
                    writer.WriteElementString("k2 ", num2.ToString());
                    writer.WriteElementString("k3 ", num3.ToString());
                    writer.WriteElementString("c1 ", num4.ToString());
                    writer.WriteElementString("c2 ", num5.ToString());
                    writer.WriteElementString("c3 ", num6.ToString());
                    writer.WriteElementString("c4", num7.ToString());
                    writer.WriteElementString("d1 ", num8.ToString());
                    writer.WriteElementString("d2 ", num9.ToString());
                    writer.WriteElementString("d3 ", num10.ToString());
                    writer.WriteElementString("d4", num11.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/c6.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("k1"))
                        {
                            innerText = node3.InnerText;
                        }
                        else if (node3.Name.Equals("k2"))
                        {
                            str2 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("k3"))
                        {
                            str3 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("c1"))
                        {
                            str4 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("c2"))
                        {
                            str5 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("c3"))
                        {
                            str6 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("c4"))
                        {
                            str7 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("d1"))
                        {
                            str8 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("d2"))
                        {
                            str9 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("d3"))
                        {
                            str10 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("d4"))
                        {
                            str11 = node3.InnerText;
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#m#", innerText).Replace("#n#", str2).Replace("#o#", str3).Replace("#p#", str4).Replace("#q#", str5).Replace("#r#", str6).Replace("#s#", str7).Replace("#t#", str8).Replace("#u#", str9).Replace("#v#", str10).Replace("#w#", str7).Replace("#y#", str11);
                control.Size = new Size(0x640, 70);
                control.Enabled = false;
                control.pub_LoadXML(sXML);
            }
        }
    }
}

