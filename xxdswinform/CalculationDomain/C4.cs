namespace xxdswinform.CalculationDomain
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

    internal class C4
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmldocument = new XmlDocument();

        public void C4Generate(NuGenEQML control, string number)
        {
            this.xmldocument.Load("CalculationXML/c4.xml");
            foreach (XmlNode node in this.xmldocument.FirstChild.ChildNodes)
            {
                int i = 0;
                int num2 = 0;
                int num3 = 0;
                int num4 = 0;
                int num5 = 0;
                int num6 = 0;
                string newValue = null;
                string innerText = null;
                string str3 = null;
                string str4 = null;
                string str5 = null;
                string str6 = null;
                if (StudentModel.isReGeneration)
                {
                    List<int> list = new List<int>();
                    list = this.numberTools.Generaterandom(7, 5, 4);
                    i = (list[3] + list[4]) + list[5];
                    num2 = (list[3] + list[4]) + list[5];
                    num3 = (list[4] + list[5]) - list[3];
                    num4 = list[4] - (2 * list[5]);
                    num5 = list[4] - (2 * list[5]);
                    num6 = list[4] + (4 * list[5]);
                    if ((i == 1) || (i == -1))
                    {
                        newValue = this.numberTools.compare(i).Replace("+", "").Replace("1", "");
                    }
                    else
                    {
                        newValue = this.numberTools.compare(i).Replace("+", "");
                    }
                    if ((num2 == 1) || (num2 == -1))
                    {
                        innerText = this.numberTools.compare(num2).Replace("1", "");
                    }
                    else
                    {
                        innerText = this.numberTools.compare(num2);
                    }
                    str4 = this.numberTools.compare(num3 * 2);
                    str5 = this.numberTools.compare(num4 * 2);
                    str6 = this.numberTools.compare(num5 * 2);
                    if ((num6 == 1) || (num6 == -1))
                    {
                        str3 = this.numberTools.compare(num6).Replace("1", "");
                    }
                    else
                    {
                        str3 = this.numberTools.compare(num6);
                    }
                    string str7 = SupportTools.getGuid();
                    string path = "temp/generate/c4.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str7);
                    writer.WriteStartElement("Params");
                    int num7 = list[3];
                    writer.WriteElementString("k ", num7.ToString());
                    num7 = list[4];
                    writer.WriteElementString("m ", num7.ToString());
                    num7 = list[5];
                    writer.WriteElementString("n ", num7.ToString());
                    writer.WriteElementString("s11 ", newValue.ToString());
                    writer.WriteElementString("s22 ", innerText.ToString());
                    writer.WriteElementString("s33 ", str3.ToString());
                    writer.WriteElementString("s12 ", str4.ToString());
                    writer.WriteElementString("s13 ", str5.ToString());
                    writer.WriteElementString("s23 ", str6.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    num7 = list[3];
                    writer.WriteElementString("k ", num7.ToString());
                    num7 = list[4];
                    writer.WriteElementString("m ", num7.ToString());
                    writer.WriteElementString("n ", list[5].ToString());
                    writer.WriteElementString("a11 ", i.ToString());
                    writer.WriteElementString("a22 ", num2.ToString());
                    writer.WriteElementString("a33 ", num6.ToString());
                    writer.WriteElementString("a12 ", num3.ToString());
                    writer.WriteElementString("a13 ", num4.ToString());
                    writer.WriteElementString("a23 ", num5.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/c4.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("s11"))
                        {
                            newValue = node3.InnerText;
                        }
                        else if (node3.Name.Equals("s22"))
                        {
                            innerText = node3.InnerText;
                        }
                        else if (node3.Name.Equals("s33"))
                        {
                            str3 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("s12"))
                        {
                            str4 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("s13"))
                        {
                            str5 = node3.InnerText;
                        }
                        else if (node3.Name.Equals("s23"))
                        {
                            str6 = node3.InnerText;
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#k#", newValue).Replace("#l#", innerText).Replace("#m#", str3).Replace("#n#", str4).Replace("#o#", str5).Replace("#p#", str6);
                control.Size = new Size(880, 60);
                control.Enabled = false;
                control.pub_LoadXML(sXML);
            }
        }
    }
}

