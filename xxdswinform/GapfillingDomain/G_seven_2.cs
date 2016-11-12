namespace xxdswinform.GapfillingDomain
{
    using Genetibase.MathX;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml;
    using xxdswinform.Tools;
    using xxdswinform.Utils;

    internal class G_seven_2
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmlDocument = new XmlDocument();

        public void g_seven_2Generate(NuGenEQML control0, TableLayoutPanel tableLayoutPanel, List<TextBox> list, string number)
        {
            this.xmlDocument.Load("GapfillingXML/g_seven_2.xml");
            foreach (XmlNode node in this.xmlDocument.FirstChild.ChildNodes)
            {
                int num = 0;
                int num2 = 0;
                int num3 = 0;
                int num4 = 0;
                int num5 = 0;
                int num6 = 0;
                if (StudentModel.isReGeneration)
                {
                    num = this.numberTools.myRandom(6);
                    num2 = this.numberTools.myRandom(6);
                    num3 = this.numberTools.myRandom(6);
                    num4 = this.numberTools.myRandom(6);
                    num5 = this.numberTools.myRandom(6);
                    num6 = this.numberTools.myRandom(6);
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/g_seven_2.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("a1", num.ToString());
                    writer.WriteElementString("a2", num2.ToString());
                    writer.WriteElementString("a3", num3.ToString());
                    writer.WriteElementString("a", num4.ToString());
                    writer.WriteElementString("b", num5.ToString());
                    writer.WriteElementString("c", num6.ToString());
                    writer.WriteEndElement();
                    int num7 = ((num - (num4 * num2)) + ((num4 * num6) * num3)) - (num5 * num3);
                    int num8 = num2 - (num6 * num3);
                    int num9 = num3;
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("b11", num7.ToString());
                    writer.WriteElementString("b12", num8.ToString());
                    writer.WriteElementString("b13", num9.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/g_seven_2.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a"))
                        {
                            num4 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b"))
                        {
                            num5 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c"))
                        {
                            num6 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a1"))
                        {
                            num = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a2"))
                        {
                            num2 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a3"))
                        {
                            num3 = int.Parse(node3.InnerText);
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", num.ToString()).Replace("#b#", num2.ToString()).Replace("#c#", num3.ToString()).Replace("#ba#", num4.ToString()).Replace("#ca#", num5.ToString()).Replace("#cb#", num6.ToString());
                control0.pub_LoadXML(sXML);
                control0.Size = new Size(600, 90);
                control0.Enabled = false;
                control0.Anchor = AnchorStyles.None;
                new InitControls().matrixOneToThree(tableLayoutPanel, list);
            }
        }
    }
}

