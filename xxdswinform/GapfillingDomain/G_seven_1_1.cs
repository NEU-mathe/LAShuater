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

    public class G_seven_1_1
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmlDocument = new XmlDocument();

        public void g_seven_1_1Generate(NuGenEQML control0, TableLayoutPanel tableLayoutPanel, List<TextBox> list, string number)
        {
            this.xmlDocument.Load("GapfillingXML/g_seven_1_1.xml");
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
                if (StudentModel.isReGeneration)
                {
                    num = this.random.Next(-5, 6);
                    num2 = this.random.Next(-5, 6);
                    num3 = this.random.Next(-5, 6);
                    num4 = this.random.Next(-5, 6);
                    num5 = this.random.Next(-5, 6);
                    num6 = this.random.Next(-5, 6);
                    num7 = this.random.Next(-5, 6);
                    num8 = this.random.Next(-5, 6);
                    num9 = this.random.Next(-5, 6);
                    num10 = this.numberTools.myRandom(4);
                    num11 = this.numberTools.myRandom(4);
                    num12 = this.numberTools.myRandom(4);
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/g_seven_1_1.xml";
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
                    writer.WriteElementString("a21", num4.ToString());
                    writer.WriteElementString("a22", num5.ToString());
                    writer.WriteElementString("a23", num6.ToString());
                    writer.WriteElementString("a31", num7.ToString());
                    writer.WriteElementString("a32", num8.ToString());
                    writer.WriteElementString("a33", num9.ToString());
                    writer.WriteElementString("a", num10.ToString());
                    writer.WriteElementString("b", num11.ToString());
                    writer.WriteElementString("c", num12.ToString());
                    writer.WriteEndElement();
                    int num13 = num;
                    double num14 = ((1.0 * num11) * num2) / ((double) num10);
                    double num15 = ((1.0 * num12) * num3) / ((double) num10);
                    double num16 = ((1.0 * num10) * num4) / ((double) num11);
                    int num17 = num5;
                    double num18 = ((1.0 * num12) * num6) / ((double) num11);
                    double num19 = ((1.0 * num10) * num7) / ((double) num12);
                    double num20 = ((1.0 * num11) * num8) / ((double) num12);
                    int num21 = num9;
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("b11", num13.ToString());
                    writer.WriteElementString("b12", num14.ToString());
                    writer.WriteElementString("b13", num15.ToString());
                    writer.WriteElementString("b21", num16.ToString());
                    writer.WriteElementString("b22", num17.ToString());
                    writer.WriteElementString("b23", num18.ToString());
                    writer.WriteElementString("b31", num19.ToString());
                    writer.WriteElementString("b32", num20.ToString());
                    writer.WriteElementString("b33", num21.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/g_seven_1_1.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a"))
                        {
                            num10 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b"))
                        {
                            num11 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c"))
                        {
                            num12 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a11"))
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
                        else if (node3.Name.Equals("a21"))
                        {
                            num4 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a22"))
                        {
                            num5 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a23"))
                        {
                            num6 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a31"))
                        {
                            num7 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a32"))
                        {
                            num8 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a33"))
                        {
                            num9 = int.Parse(node3.InnerText);
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", num.ToString()).Replace("#b#", num2.ToString()).Replace("#c#", num3.ToString()).Replace("#d#", num4.ToString()).Replace("#e#", num5.ToString()).Replace("#f#", num6.ToString()).Replace("#g#", num7.ToString()).Replace("#h#", num8.ToString()).Replace("#i#", num9.ToString()).Replace("#aa#", num10.ToString()).Replace("#bb#", num11.ToString()).Replace("#cc#", num12.ToString());
                control0.pub_LoadXML(sXML);
                control0.Size = new Size(950, 90);
                control0.Enabled = false;
                control0.Anchor = AnchorStyles.None;
                new InitControls().matrixThreeToThree(tableLayoutPanel, list);
            }
        }
    }
}

