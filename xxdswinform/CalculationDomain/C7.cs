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

    internal class C7
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmldocument = new XmlDocument();

        public void C7Generate(NuGenEQML control, string number)
        {
            this.xmldocument.Load("CalculationXML/c7.xml");
            foreach (XmlNode node in this.xmldocument.FirstChild.ChildNodes)
            {
                int num21;
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
                if (StudentModel.isReGeneration)
                {
                    num = this.numberTools.myRandom(4);
                    num2 = this.numberTools.myRandom(4);
                    num3 = this.numberTools.myRandom(4);
                    num4 = this.numberTools.myRandom(6);
                    num5 = this.numberTools.myRandom(6);
                    num6 = this.numberTools.myRandom(6);
                    num7 = this.numberTools.myRandom(6);
                    if (((num4 * num7) - (num5 * num6)) == 0)
                    {
                        num4 = -1 * num4;
                    }
                    num8 = (num4 * num7) - (num5 * num6);
                    num9 = this.numberTools.myRandom(9);
                    num10 = this.numberTools.myRandom(9);
                    num11 = this.numberTools.myRandom(9);
                    num12 = this.numberTools.myRandom(9);
                    num13 = this.numberTools.myRandom(9);
                    num14 = this.numberTools.myRandom(9);
                    num15 = ((num9 + (num * num11)) * num4) + ((num10 + (num * num12)) * num6);
                    num16 = ((num9 + (num * num11)) * num5) + ((num10 + (num * num12)) * num7);
                    num17 = ((num11 + (num2 * num13)) * num4) + ((num12 + (num2 * num14)) * num6);
                    num18 = ((num11 + (num2 * num13)) * num5) + ((num12 + (num2 * num14)) * num7);
                    num19 = ((((num3 * num9) + ((num * num3) * num11)) + num13) * num4) + ((((num3 * num10) + ((num * num3) * num12)) + num14) * num6);
                    num20 = ((((num3 * num9) + ((num * num3) * num11)) + num13) * num5) + ((((num3 * num10) + ((num * num3) * num12)) + num14) * num7);
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/c7.xml";
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
                    writer.WriteElementString("a3 ", num3.ToString());
                    writer.WriteElementString("b11 ", num4.ToString());
                    writer.WriteElementString("b12 ", num5.ToString());
                    writer.WriteElementString("b21 ", num6.ToString());
                    writer.WriteElementString("b22 ", num7.ToString());
                    writer.WriteElementString("x11", num9.ToString());
                    writer.WriteElementString("x12", num10.ToString());
                    writer.WriteElementString("x21", num11.ToString());
                    writer.WriteElementString("x22", num12.ToString());
                    writer.WriteElementString("x31", num13.ToString());
                    writer.WriteElementString("x32", num14.ToString());
                    writer.WriteElementString("c11", num15.ToString());
                    writer.WriteElementString("c12", num16.ToString());
                    writer.WriteElementString("c21", num17.ToString());
                    writer.WriteElementString("c22", num18.ToString());
                    writer.WriteElementString("c31", num19.ToString());
                    writer.WriteElementString("c32", num20.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    num21 = 1 - ((num * num2) * num3);
                    writer.WriteElementString("d11", num21.ToString());
                    num21 = -1 * num;
                    writer.WriteElementString("d12", num21.ToString());
                    num21 = num * num2;
                    writer.WriteElementString("d13", num21.ToString());
                    num21 = num2 * num3;
                    writer.WriteElementString("d14", num21.ToString());
                    num21 = 1;
                    writer.WriteElementString("d15", num21.ToString());
                    num21 = -1 * num2;
                    writer.WriteElementString("d16", num21.ToString());
                    num21 = -1 * num3;
                    writer.WriteElementString("d17", num21.ToString());
                    num21 = 0;
                    writer.WriteElementString("d18", num21.ToString());
                    num21 = 1;
                    writer.WriteElementString("d19", num21.ToString());
                    writer.WriteElementString("d20", SupportTools.DoubleFormat((1.0 * num7) / ((double) num8)).ToString());
                    writer.WriteElementString("d21", SupportTools.DoubleFormat((-num5 * 1.0) / ((double) num8)).ToString());
                    writer.WriteElementString("d22", SupportTools.DoubleFormat((-num6 * 1.0) / ((double) num8)).ToString());
                    writer.WriteElementString("d23", SupportTools.DoubleFormat((num4 * 1.0) / ((double) num8)).ToString());
                    writer.WriteElementString("d24", num9.ToString());
                    writer.WriteElementString("d25", num10.ToString());
                    writer.WriteElementString("d26", num11.ToString());
                    writer.WriteElementString("d27", num12.ToString());
                    writer.WriteElementString("d28", num13.ToString());
                    writer.WriteElementString("d29", num14.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/c7.xml");
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
                        else if (node3.Name.Equals("a3"))
                        {
                            num3 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b11"))
                        {
                            num4 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b12"))
                        {
                            num5 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b21"))
                        {
                            num6 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b22"))
                        {
                            num7 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c11"))
                        {
                            num15 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c12"))
                        {
                            num16 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c21"))
                        {
                            num17 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c22"))
                        {
                            num18 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c31"))
                        {
                            num19 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c32"))
                        {
                            num20 = int.Parse(node3.InnerText);
                        }
                    }
                }
                num21 = num * num3;
                string sXML = node.InnerText.Replace("#x#", number).Replace("#k#", num.ToString()).Replace("#l#", num2.ToString()).Replace("#m#", num3.ToString()).Replace("#n#", num21.ToString()).Replace("#o#", num4.ToString()).Replace("#p#", num5.ToString()).Replace("#q#", num6.ToString()).Replace("#r#", num7.ToString()).Replace("#s#", num15.ToString()).Replace("#t#", num16.ToString()).Replace("#u#", num17.ToString()).Replace("#v#", num18.ToString()).Replace("#w#", num19.ToString()).Replace("#y#", num20.ToString());
                control.Size = new Size(440, 100);
                control.Enabled = false;
                control.pub_LoadXML(sXML);
            }
        }
    }
}

