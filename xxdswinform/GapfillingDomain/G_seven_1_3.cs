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

    public class G_seven_1_3
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmlDocument = new XmlDocument();

        public void g_seven_1_3Generate(NuGenEQML control0, TableLayoutPanel tableLayoutPanel, List<TextBox> list, string number)
        {
            this.xmlDocument.Load("GapfillingXML/g_seven_1_3.xml");
            foreach (XmlNode node in this.xmlDocument.FirstChild.ChildNodes)
            {
                int i = 0;
                int num2 = 0;
                int num3 = 0;
                int num4 = 0;
                string newValue = null;
                string str2 = null;
                string str3 = null;
                if (StudentModel.isReGeneration)
                {
                    i = this.numberTools.myRandom(6);
                    num2 = this.numberTools.myRandom(6);
                    num3 = this.numberTools.myRandom(6);
                    num4 = this.numberTools.myRandom(6);
                    newValue = this.numberTools.compare(i);
                    str2 = this.numberTools.compare(num2);
                    str3 = this.numberTools.compare(num3);
                    string str4 = SupportTools.getGuid();
                    string path = "temp/generate/g_seven_1_3.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str4);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("a", i.ToString());
                    writer.WriteElementString("b", num2.ToString());
                    writer.WriteElementString("c", num3.ToString());
                    writer.WriteElementString("d", num4.ToString());
                    writer.WriteEndElement();
                    int num5 = 0;
                    double num6 = SupportTools.DoubleFormat(1.0 / ((double) num4));
                    double num7 = SupportTools.DoubleFormat((num2 - (2.0 * i)) / ((double) num4));
                    int num8 = 0;
                    int num9 = 0;
                    int num10 = 2;
                    int num11 = 0;
                    int num12 = 0;
                    int num13 = 0;
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("b11", num5.ToString());
                    writer.WriteElementString("b12", num6.ToString());
                    writer.WriteElementString("b13", num7.ToString());
                    writer.WriteElementString("b21", num8.ToString());
                    writer.WriteElementString("b22", num9.ToString());
                    writer.WriteElementString("b23", num10.ToString());
                    writer.WriteElementString("b31", num11.ToString());
                    writer.WriteElementString("b32", num12.ToString());
                    writer.WriteElementString("b33", num13.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/g_seven_1_3.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a"))
                        {
                            i = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b"))
                        {
                            num2 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c"))
                        {
                            num3 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("d"))
                        {
                            num4 = int.Parse(node3.InnerText);
                        }
                    }
                    newValue = this.numberTools.compare(i);
                    str2 = this.numberTools.compare(num2);
                    str3 = this.numberTools.compare(num3);
                }
                if (str2 == "+1")
                {
                    str2 = "+";
                }
                else if (str2 == "-1")
                {
                    str2 = "-";
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", newValue).Replace("#b#", str2).Replace("#c#", str3).Replace("#d#", num4.ToString());
                control0.pub_LoadXML(sXML);
                control0.Size = new Size(850, 60);
                control0.Enabled = false;
                control0.Anchor = AnchorStyles.None;
                new InitControls().matrixThreeToThree(tableLayoutPanel, list);
            }
        }
    }
}

