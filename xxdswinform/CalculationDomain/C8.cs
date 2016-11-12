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

    internal class C8
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmldocument = new XmlDocument();

        public void C8Generate(NuGenEQML control, string number)
        {
            this.xmldocument.Load("CalculationXML/c8.xml");
            foreach (XmlNode node in this.xmldocument.FirstChild.ChildNodes)
            {
                int num25;
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
                if (StudentModel.isReGeneration)
                {
                    num = this.numberTools.myRandom(5);
                    num2 = this.numberTools.myRandom(5);
                    num3 = this.numberTools.myRandom(5);
                    num4 = this.numberTools.myRandom(5);
                    num5 = this.random.Next(-3, 4);
                    num6 = this.random.Next(-3, 4);
                    num7 = this.random.Next(-9, 10);
                    num8 = this.random.Next(-9, 10);
                    num9 = this.random.Next(-9, 10);
                    num10 = this.random.Next(-9, 10);
                    num11 = this.random.Next(-9, 10);
                    num12 = this.random.Next(-9, 10);
                    num13 = this.random.Next(-9, 10);
                    num14 = this.random.Next(-9, 10);
                    num15 = this.random.Next(-9, 10);
                    num16 = this.random.Next(-9, 10);
                    num17 = this.random.Next(-9, 10);
                    num18 = this.random.Next(-9, 10);
                    num19 = ((num13 + (num * num15)) + (num3 * num17)) + num7;
                    num20 = ((num14 + (num * num16)) + (num3 * num18)) + num8;
                    num21 = (((num2 * num13) + ((1 + (num * num2)) * num15)) + (((num2 * num3) + num5) * num17)) + num9;
                    num22 = (((num2 * num14) + ((1 + (num * num2)) * num16)) + (((num2 * num3) + num5) * num18)) + num10;
                    num23 = (((num4 * num13) + (((num * num4) + num6) * num15)) + (((1 + (num4 * num3)) + (num6 * num5)) * num17)) + num11;
                    num24 = (((num4 * num14) + (((num * num4) + num6) * num16)) + (((1 + (num4 * num3)) + (num6 * num5)) * num18)) + num12;
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/c8.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("a1 ", num.ToString());
                    writer.WriteElementString("a2 ", num2.ToString());
                    writer.WriteElementString("b1 ", num3.ToString());
                    writer.WriteElementString("b2 ", num4.ToString());
                    writer.WriteElementString("c1 ", num5.ToString());
                    writer.WriteElementString("c2 ", num6.ToString());
                    writer.WriteElementString("b11", num7.ToString());
                    writer.WriteElementString("b12", num8.ToString());
                    writer.WriteElementString("b21", num9.ToString());
                    writer.WriteElementString("b22", num10.ToString());
                    writer.WriteElementString("b31", num11.ToString());
                    writer.WriteElementString("b32", num12.ToString());
                    writer.WriteElementString("x11", num13.ToString());
                    writer.WriteElementString("x12", num14.ToString());
                    writer.WriteElementString("x21", num15.ToString());
                    writer.WriteElementString("x22", num16.ToString());
                    writer.WriteElementString("x31", num17.ToString());
                    writer.WriteElementString("x32", num18.ToString());
                    writer.WriteElementString("c11", num19.ToString());
                    writer.WriteElementString("c12", num20.ToString());
                    writer.WriteElementString("c21", num21.ToString());
                    writer.WriteElementString("c22", num22.ToString());
                    writer.WriteElementString("c31", num23.ToString());
                    writer.WriteElementString("c32", num24.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    num25 = (1 + (num * num2)) + (((num * num5) - num3) * ((num2 * num6) - num4));
                    writer.WriteElementString("d11", num25.ToString());
                    num25 = (num3 * num6) - (num * (1 + (num5 * num6)));
                    writer.WriteElementString("d12", num25.ToString());
                    num25 = (num * num5) - num3;
                    writer.WriteElementString("d13", num25.ToString());
                    num25 = ((num4 - (num2 * num6)) * num5) - num2;
                    writer.WriteElementString("d14", num25.ToString());
                    num25 = 1 + (num5 * num6);
                    writer.WriteElementString("d15", num25.ToString());
                    num25 = -num5;
                    writer.WriteElementString("d16", num25.ToString());
                    num25 = (num2 * num6) - num4;
                    writer.WriteElementString("d17", num25.ToString());
                    num25 = -num6;
                    writer.WriteElementString("d18", num25.ToString());
                    num25 = 1;
                    writer.WriteElementString("d19", num25.ToString());
                    num25 = num19 - num7;
                    writer.WriteElementString("d20", num25.ToString());
                    num25 = num20 - num8;
                    writer.WriteElementString("d21", num25.ToString());
                    num25 = num21 - num9;
                    writer.WriteElementString("d22", num25.ToString());
                    num25 = num22 - num10;
                    writer.WriteElementString("d23", num25.ToString());
                    num25 = num23 - num11;
                    writer.WriteElementString("d24", num25.ToString());
                    num25 = num24 - num12;
                    writer.WriteElementString("d25", num25.ToString());
                    writer.WriteElementString("d26", num13.ToString());
                    writer.WriteElementString("d27", num14.ToString());
                    writer.WriteElementString("d28", num15.ToString());
                    writer.WriteElementString("d29", num16.ToString());
                    writer.WriteElementString("d30", num17.ToString());
                    writer.WriteElementString("d31", num18.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/c8.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a1"))
                        {
                            num = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a2"))
                        {
                            num2 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b1"))
                        {
                            num3 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b2"))
                        {
                            num4 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c1"))
                        {
                            num5 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c2"))
                        {
                            num6 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b11"))
                        {
                            num7 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b12"))
                        {
                            num8 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b21"))
                        {
                            num9 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b22"))
                        {
                            num10 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b31"))
                        {
                            num11 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b32"))
                        {
                            num12 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c11"))
                        {
                            num19 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c12"))
                        {
                            num20 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c21"))
                        {
                            num21 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c22"))
                        {
                            num22 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c31"))
                        {
                            num23 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c32"))
                        {
                            num24 = int.Parse(node3.InnerText);
                        }
                    }
                }
                num25 = 1 + (num * num2);
                num25 = (num2 * num3) + num5;
                num25 = (num * num4) + num6;
                num25 = (1 + (num4 * num3)) + (num5 * num6);
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", num.ToString()).Replace("#b#", num3.ToString()).Replace("#c#", num2.ToString()).Replace("#d#", num25.ToString()).Replace("#e#", num25.ToString()).Replace("#f#", num4.ToString()).Replace("#g#", num25.ToString()).Replace("#h#", num25.ToString()).Replace("#i#", num7.ToString()).Replace("#j#", num8.ToString()).Replace("#k#", num9.ToString()).Replace("#l#", num10.ToString()).Replace("#m#", num11.ToString()).Replace("#n#", num12.ToString()).Replace("#o#", num19.ToString()).Replace("#p#", num20.ToString()).Replace("#q#", num21.ToString()).Replace("#r#", num22.ToString()).Replace("#s#", num23.ToString()).Replace("#t#", num24.ToString());
                control.Size = new Size(440, 100);
                control.Enabled = false;
                control.pub_LoadXML(sXML);
            }
        }
    }
}

