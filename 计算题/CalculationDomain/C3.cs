namespace 计算题.CalculationDomain
{
    using Genetibase.MathX;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Xml;
    using xxdswinform.Tools;
    using xxdswinform.Utils;

    internal class C3
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmldocument = new XmlDocument();

        public void C3Generate(NuGenEQML control1, string number)
        {
            this.xmldocument.Load("CalculationXML/c3.xml");
            foreach (XmlNode node in this.xmldocument.FirstChild.ChildNodes)
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
                    List<int> list = new List<int>();
                    list = this.numberTools.Generaterandom(7, 5, 4);
                    num = list[0];
                    num2 = list[1];
                    num3 = list[2];
                    num4 = (list[3] + list[4]) + list[5];
                    num5 = (-list[3] + list[4]) + list[5];
                    num6 = list[4] - (2 * list[5]);
                    num7 = list[4] + (4 * list[5]);
                    num8 = num4;
                    num9 = num4;
                    num10 = num5;
                    num11 = num6;
                    num12 = num6;
                    num13 = num7;
                    num14 = 2 * list[3];
                    num15 = 3 * list[4];
                    num16 = 6 * list[5];
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/c3.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("a11", num8.ToString());
                    writer.WriteElementString("a12", num10.ToString());
                    writer.WriteElementString("a13", num11.ToString());
                    writer.WriteElementString("a22", num9.ToString());
                    writer.WriteElementString("a23", num12.ToString());
                    writer.WriteElementString("a33", num13.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("x1", num14.ToString());
                    writer.WriteElementString("x2", num15.ToString());
                    writer.WriteElementString("x3", num16.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/c3.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a11"))
                        {
                            num8 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a12"))
                        {
                            num10 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a13"))
                        {
                            num11 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a33"))
                        {
                            num13 = int.Parse(node3.InnerText);
                        }
                        num4 = num8;
                        num5 = num10;
                        num6 = num11;
                        num7 = num13;
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", num4.ToString()).Replace("#b#", num5.ToString()).Replace("#c#", num6.ToString()).Replace("#d#", num5.ToString()).Replace("#e#", num4.ToString()).Replace("#f#", num6.ToString()).Replace("#g#", num6.ToString()).Replace("#h#", num6.ToString()).Replace("#i#", num7.ToString());
                control1.Size = new Size(610, 110);
                control1.Enabled = false;
                control1.pub_LoadXML(sXML);
            }
        }
    }
}

