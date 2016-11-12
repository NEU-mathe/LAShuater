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

    internal class C5
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmldocument = new XmlDocument();

        public void C5Generate(NuGenEQML control, string number)
        {
            this.xmldocument.Load("CalculationXML/c5.xml");
            foreach (XmlNode node in this.xmldocument.FirstChild.ChildNodes)
            {
                int num = 0;
                int num2 = 0;
                int num3 = 0;
                int num4 = 0;
                string newValue = null;
                if (StudentModel.isReGeneration)
                {
                    num = this.numberTools.myRandom(8);
                    num2 = this.numberTools.myRandom(8);
                    num3 = this.numberTools.myRandom(8);
                    num4 = this.numberTools.myRandom(8);
                    if ((num4 == num3) || (num4 == (2 * num3)))
                    {
                        num4 = -1 * num4;
                    }
                    if (((-1 * num) - num2) == 0)
                    {
                        num2++;
                    }
                    newValue = ((-1 * num) - num2).ToString();
                    string str2 = SupportTools.getGuid();
                    string path = "temp/generate/c5.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str2);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("k ", num3.ToString());
                    writer.WriteElementString("a ", num.ToString());
                    writer.WriteElementString("b ", num2.ToString());
                    writer.WriteElementString("m ", num4.ToString());
                    writer.WriteElementString("m1 ", newValue.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("k ", num3.ToString());
                    writer.WriteElementString("a ", num.ToString());
                    writer.WriteElementString("b ", num2.ToString());
                    writer.WriteElementString("m ", num4.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/c5.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("k"))
                        {
                            num3 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a"))
                        {
                            num = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b"))
                        {
                            num2 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("m"))
                        {
                            num4 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("m1"))
                        {
                            newValue = node3.InnerText;
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#k#", num3.ToString()).Replace("#a#", num.ToString()).Replace("#b#", num2.ToString()).Replace("#n#", newValue).Replace("#m#", num4.ToString());
                control.Size = new Size(0x410, 70);
                control.Enabled = false;
                control.pub_LoadXML(sXML);
            }
        }
    }
}

