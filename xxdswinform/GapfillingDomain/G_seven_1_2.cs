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

    internal class G_seven_1_2
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmlDocument = new XmlDocument();

        public void g_seven_1_2Generate(NuGenEQML control0, TableLayoutPanel tableLayoutPanel, List<TextBox> list, string number)
        {
            this.xmlDocument.Load("GapfillingXML/g_seven_1_2.xml");
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
                if (StudentModel.isReGeneration)
                {
                    num = this.random.Next(-5, 6);
                    num2 = this.random.Next(-5, 6);
                    num3 = this.random.Next(-5, 6);
                    num4 = this.random.Next(-5, 6);
                    num5 = this.numberTools.myRandom(4);
                    num6 = this.numberTools.myRandom(4);
                    num7 = this.numberTools.myRandom(4);
                    num8 = this.numberTools.myRandom(4);
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/g_seven_1_2.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("b11", num.ToString());
                    writer.WriteElementString("b12", num2.ToString());
                    writer.WriteElementString("b21", num3.ToString());
                    writer.WriteElementString("b22", num4.ToString());
                    writer.WriteElementString("a", num5.ToString());
                    writer.WriteElementString("b", num6.ToString());
                    writer.WriteElementString("c", num7.ToString());
                    writer.WriteElementString("d", num8.ToString());
                    writer.WriteEndElement();
                    int num9 = num;
                    double num10 = SupportTools.DoubleFormat(((1.0 * num6) * num3) / ((double) num5));
                    int num11 = 0;
                    int num12 = 0;
                    double num13 = SupportTools.DoubleFormat(((1.0 * num5) * num2) / ((double) num6));
                    int num14 = num4;
                    int num15 = 0;
                    int num16 = 0;
                    int num17 = 0;
                    int num18 = 0;
                    int num19 = num;
                    double num20 = SupportTools.DoubleFormat(((1.0 * num8) * num3) / ((double) num7));
                    int num21 = 0;
                    int num22 = 0;
                    double num23 = SupportTools.DoubleFormat(((1.0 * num7) * num2) / ((double) num8));
                    int num24 = num4;
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("c11", num9.ToString());
                    writer.WriteElementString("c12", num10.ToString());
                    writer.WriteElementString("c13", num11.ToString());
                    writer.WriteElementString("c14", num12.ToString());
                    writer.WriteElementString("c21", num13.ToString());
                    writer.WriteElementString("c22", num14.ToString());
                    writer.WriteElementString("c23", num15.ToString());
                    writer.WriteElementString("c24", num16.ToString());
                    writer.WriteElementString("c31", num17.ToString());
                    writer.WriteElementString("c32", num18.ToString());
                    writer.WriteElementString("c33", num19.ToString());
                    writer.WriteElementString("c34", num20.ToString());
                    writer.WriteElementString("c41", num21.ToString());
                    writer.WriteElementString("c42", num22.ToString());
                    writer.WriteElementString("c43", num23.ToString());
                    writer.WriteElementString("c44", num24.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/g_seven_1_2.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a"))
                        {
                            num5 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b"))
                        {
                            num6 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c"))
                        {
                            num7 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("d"))
                        {
                            num8 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b11"))
                        {
                            num = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b12"))
                        {
                            num2 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b21"))
                        {
                            num3 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b22"))
                        {
                            num4 = int.Parse(node3.InnerText);
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", num.ToString()).Replace("#b#", num2.ToString()).Replace("#c#", num3.ToString()).Replace("#d#", num4.ToString()).Replace("#e#", num5.ToString()).Replace("#f#", num6.ToString()).Replace("#g#", num7.ToString()).Replace("#h#", num8.ToString());
                control0.pub_LoadXML(sXML);
                control0.Size = new Size(0x47e, 0x41);
                control0.Enabled = false;
                control0.Anchor = AnchorStyles.None;
                new InitControls().matrixFourToFour(tableLayoutPanel, list);
            }
        }
    }
}

