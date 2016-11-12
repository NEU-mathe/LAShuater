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

    internal class G_two_1
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmlDocument = new XmlDocument();

        public void g_two_1Generate(NuGenEQML control0, TableLayoutPanel tableLayoutPanel, List<TextBox> listT, string number)
        {
            this.xmlDocument.Load("GapfillingXML/g_two_1.xml");
            foreach (XmlNode node in this.xmlDocument.FirstChild.ChildNodes)
            {
                double num = 0.0;
                double num2 = 0.0;
                double num3 = 0.0;
                double num4 = 0.0;
                double num5 = 0.0;
                double num6 = 0.0;
                double num7 = 0.0;
                double num8 = 0.0;
                double num9 = 0.0;
                double num10 = 0.0;
                double num11 = 0.0;
                double num12 = 0.0;
                double num13 = 0.0;
                double num14 = 0.0;
                double num15 = 0.0;
                double num16 = 0.0;
                double num17 = 0.0;
                double num18 = 0.0;
                double num19 = 0.0;
                if (StudentModel.isReGeneration)
                {
                    num = 1.0;
                    num2 = this.numberTools.myRandom(5);
                    num3 = this.numberTools.myRandom(5);
                    num4 = this.numberTools.myRandom(5);
                    num5 = this.numberTools.myRandom(5);
                    num6 = this.numberTools.myRandom(5);
                    num7 = this.numberTools.myRandom(5);
                    num8 = this.numberTools.myRandom(3);
                    num9 = this.numberTools.myRandom(3);
                    num10 = this.numberTools.myRandom(3);
                    num11 = (num5 * num2) + 1.0;
                    num12 = (num6 * num2) + 1.0;
                    num13 = (num7 * num2) + 1.0;
                    num14 = (num5 * num3) + num8;
                    num15 = (num5 * num4) + num9;
                    num16 = ((num6 * num3) + num8) + 1.0;
                    num17 = ((num7 * num3) + num8) + 1.0;
                    num18 = ((num6 * num4) + num9) + num10;
                    num19 = (((num7 * num4) + num9) + num10) + 1.0;
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/g_two_1.xml";
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
                    writer.WriteElementString("a22", num11.ToString());
                    writer.WriteElementString("a23", num14.ToString());
                    writer.WriteElementString("a24", num15.ToString());
                    writer.WriteElementString("a31", num6.ToString());
                    writer.WriteElementString("a32", num12.ToString());
                    writer.WriteElementString("a33", num16.ToString());
                    writer.WriteElementString("a34", num18.ToString());
                    writer.WriteElementString("a41", num7.ToString());
                    writer.WriteElementString("a42", num13.ToString());
                    writer.WriteElementString("a43", num17.ToString());
                    writer.WriteElementString("a44", num19.ToString());
                    writer.WriteEndElement();
                    double k = ((((((num6 * num8) - (num5 * num8)) - num5) - (num6 * num9)) + (num7 * num9)) + ((num6 * num8) * num10)) - ((num7 * num8) * num10);
                    double num21 = num8 + 1.0;
                    double num22 = (num9 - num8) - (num8 * num10);
                    double num23 = (num8 * num10) - num9;
                    double num24 = ((num5 - num6) - (num6 * num10)) + (num7 * num10);
                    double num25 = -1.0;
                    double num26 = 1.0 + num10;
                    double num27 = -num10;
                    double num28 = num6 - num7;
                    double num29 = 0.0;
                    double num30 = -1.0;
                    double num31 = 1.0;
                    double num32 = (((((((((((((num2 * num5) - (num3 * num5)) + (num3 * num6)) - (num4 * num6)) + (num4 * num7)) + ((num2 * num5) * num8)) - ((num2 * num6) * num8)) + ((num2 * num6) * num9)) - ((num2 * num7) * num9)) + ((num3 * num6) * num10)) - ((num3 * num7) * num10)) - (((num2 * num6) * num8) * num10)) + (((num2 * num7) * num8) * num10)) + 1.0;
                    double num33 = (num3 - num2) - (num2 * num8);
                    double num34 = ((((num4 - num3) + (num2 * num8)) - (num2 * num9)) - (num3 * num10)) + ((num2 * num8) * num10);
                    double num35 = (((num2 * num9) - num4) + (num3 * num10)) - ((num2 * num8) * num10);
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("b11", SupportTools.DoubleFormat(num32).ToString());
                    writer.WriteElementString("b12", SupportTools.DoubleFormat(num33).ToString());
                    writer.WriteElementString("b13", SupportTools.DoubleFormat(num34).ToString());
                    writer.WriteElementString("b14", SupportTools.DoubleFormat(num35).ToString());
                    writer.WriteElementString("b21", SupportTools.DoubleFormat(k).ToString());
                    writer.WriteElementString("b22", SupportTools.DoubleFormat(num21).ToString());
                    writer.WriteElementString("b23", SupportTools.DoubleFormat(num22).ToString());
                    writer.WriteElementString("b24", SupportTools.DoubleFormat(num23).ToString());
                    writer.WriteElementString("b31", SupportTools.DoubleFormat(num24).ToString());
                    writer.WriteElementString("b32", SupportTools.DoubleFormat(num25).ToString());
                    writer.WriteElementString("b33", SupportTools.DoubleFormat(num26).ToString());
                    writer.WriteElementString("b34", SupportTools.DoubleFormat(num27).ToString());
                    writer.WriteElementString("b41", SupportTools.DoubleFormat(num28).ToString());
                    writer.WriteElementString("b42", SupportTools.DoubleFormat(num29).ToString());
                    writer.WriteElementString("b43", SupportTools.DoubleFormat(num30).ToString());
                    writer.WriteElementString("b44", SupportTools.DoubleFormat(num31).ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/g_two_1.xml");
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
                            num11 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a23"))
                        {
                            num14 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a24"))
                        {
                            num15 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a31"))
                        {
                            num6 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a32"))
                        {
                            num12 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a33"))
                        {
                            num16 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a34"))
                        {
                            num18 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a41"))
                        {
                            num7 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a42"))
                        {
                            num13 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a43"))
                        {
                            num17 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a44"))
                        {
                            num19 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b3"))
                        {
                            num8 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b4"))
                        {
                            num9 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c"))
                        {
                            num10 = int.Parse(node3.InnerText);
                        }
                    }
                }
                control0.pub_LoadXML(node.InnerText.Replace("#x#", number).Replace("#a#", num.ToString()).Replace("#b#", num2.ToString()).Replace("#c#", num3.ToString()).Replace("#d#", num4.ToString()).Replace("#e#", num5.ToString()).Replace("#f#", num11.ToString()).Replace("#g#", num14.ToString()).Replace("#h#", num15.ToString()).Replace("#i#", num6.ToString()).Replace("#j#", num12.ToString()).Replace("#k#", num16.ToString()).Replace("#l#", num18.ToString()).Replace("#m#", num7.ToString()).Replace("#n#", num13.ToString()).Replace("#o#", num17.ToString()).Replace("#p#", num19.ToString()));
                control0.Size = new Size(410, 120);
                control0.Anchor = AnchorStyles.None;
                control0.Enabled = false;
                new InitControls().matrixFourToFour(tableLayoutPanel, listT);
            }
        }
    }
}

