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

    internal class C11
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmldocument = new XmlDocument();

        public void C11Generate(NuGenEQML control, string number)
        {
            this.xmldocument.Load("CalculationXML/c11.xml");
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
                int i = 0;
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
                if (StudentModel.isReGeneration)
                {
                    num = this.numberTools.myRandom(5);
                    num2 = this.numberTools.myRandom(5);
                    num3 = this.numberTools.myRandom(5);
                    num4 = this.numberTools.myRandom(5);
                    num5 = this.numberTools.myRandom(5);
                    num6 = this.numberTools.myRandom(5);
                    num7 = this.numberTools.myRandom(5);
                    num8 = this.numberTools.myRandom(5);
                    num9 = this.numberTools.myRandom(5);
                    num10 = this.numberTools.myRandom(5);
                    i = num5;
                    num12 = (num5 * num3) + num;
                    num13 = (num5 * num4) + num2;
                    num14 = num8;
                    num15 = (num5 * num8) + 1;
                    num16 = (num8 * num12) + num3;
                    num17 = (num8 * num13) + num4;
                    num18 = num9;
                    num19 = num6;
                    num20 = (num9 * num) + (num6 * num3);
                    num21 = num10;
                    num22 = num7;
                    num23 = (num10 * num2) + (num7 * num4);
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/c11.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("b1", num3.ToString());
                    writer.WriteElementString("a12", i.ToString());
                    writer.WriteElementString("a13", num12.ToString());
                    writer.WriteElementString("a14", num13.ToString());
                    writer.WriteElementString("a21", num14.ToString());
                    writer.WriteElementString("a22", num15.ToString());
                    writer.WriteElementString("a23", num16.ToString());
                    writer.WriteElementString("a24", num17.ToString());
                    writer.WriteElementString("a31", num18.ToString());
                    writer.WriteElementString("a32", num19.ToString());
                    writer.WriteElementString("a33", num20.ToString());
                    writer.WriteElementString("a41", num21.ToString());
                    writer.WriteElementString("a42", num22.ToString());
                    writer.WriteElementString("a44", num23.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("a1", num.ToString());
                    writer.WriteElementString("a2", num2.ToString());
                    writer.WriteElementString("b1", num3.ToString());
                    writer.WriteElementString("b2", num4.ToString());
                    writer.WriteElementString("n1", num5.ToString());
                    writer.WriteElementString("n2", num6.ToString());
                    writer.WriteElementString("n3", num7.ToString());
                    writer.WriteElementString("m1", num8.ToString());
                    writer.WriteElementString("m2", num9.ToString());
                    writer.WriteElementString("m3", num10.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/c11.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a12"))
                        {
                            i = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a13"))
                        {
                            num12 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a14"))
                        {
                            num13 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a21"))
                        {
                            num14 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a22"))
                        {
                            num15 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a23"))
                        {
                            num16 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a24"))
                        {
                            num17 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a31"))
                        {
                            num18 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a32"))
                        {
                            num19 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a33"))
                        {
                            num20 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a41"))
                        {
                            num21 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a42"))
                        {
                            num22 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a44"))
                        {
                            num23 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b1"))
                        {
                            num3 = int.Parse(node3.InnerText);
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", this.numberTools.compare(i)).Replace("#b#", this.numberTools.compare(num12)).Replace("#c#", num13.ToString()).Replace("#d#", num14.ToString()).Replace("#e#", this.numberTools.compare(num15)).Replace("#f#", this.numberTools.compare(num16)).Replace("#g#", num17.ToString()).Replace("#h#", num18.ToString()).Replace("#i#", this.numberTools.compare(num19)).Replace("#j#", this.numberTools.compare(num20)).Replace("#k#", num3.ToString()).Replace("#l#", num21.ToString()).Replace("#m#", this.numberTools.compare(num22)).Replace("#n#", this.numberTools.compare(i)).Replace("#o#", num23.ToString());
                control.Size = new Size(440, 100);
                control.Enabled = false;
                control.pub_LoadXML(sXML);
            }
        }
    }
}

