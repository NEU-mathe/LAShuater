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

    internal class C10
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmldocument = new XmlDocument();

        public void C10Generate(NuGenEQML control, string number)
        {
            this.xmldocument.Load("CalculationXML/c10.xml");
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
                int num25 = 0;
                int i = 0;
                int num27 = 0;
                int num28 = 0;
                int num29 = 0;
                int num30 = 0;
                int num31 = 0;
                int num32 = 0;
                int num33 = 0;
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
                    num11 = this.numberTools.myRandom(5);
                    num12 = this.numberTools.myRandom(5);
                    num13 = this.numberTools.myRandom(5);
                    num14 = this.numberTools.myRandom(5);
                    num15 = num7;
                    num16 = (num7 * num4) + num;
                    num17 = (num7 * num5) + num2;
                    num18 = (num7 * num6) + num3;
                    num19 = num10;
                    num20 = (num7 * num10) + 1;
                    num21 = (num10 * num16) + num4;
                    num22 = (num10 * num17) + num5;
                    num23 = (num10 * num18) + num6;
                    num24 = num11;
                    num25 = num8;
                    i = (num11 * num) + (num8 * num4);
                    num27 = (num11 * num2) + (num8 * num5);
                    num28 = ((num11 * num3) + (num8 * num6)) + num13;
                    num29 = num12;
                    num30 = num9;
                    num31 = (num12 * num) + (num9 * num4);
                    num32 = (num12 * num2) + (num9 * num5);
                    num33 = ((num12 * num3) + (num9 * num6)) + num13;
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/c10.xml";
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
                    writer.WriteElementString("d1", num4.ToString());
                    writer.WriteElementString("d2", num5.ToString());
                    writer.WriteElementString("d3", num6.ToString());
                    writer.WriteElementString("n1", num7.ToString());
                    writer.WriteElementString("n2", num8.ToString());
                    writer.WriteElementString("n3", num9.ToString());
                    writer.WriteElementString("m1", num10.ToString());
                    writer.WriteElementString("m2", num11.ToString());
                    writer.WriteElementString("m3", num12.ToString());
                    writer.WriteElementString("b", num13.ToString());
                    writer.WriteElementString("k", num14.ToString());
                    writer.WriteElementString("a12", num15.ToString());
                    writer.WriteElementString("a13", num16.ToString());
                    writer.WriteElementString("a14", num17.ToString());
                    writer.WriteElementString("a15", num18.ToString());
                    writer.WriteElementString("a21", num19.ToString());
                    writer.WriteElementString("a22", num20.ToString());
                    writer.WriteElementString("a23", num21.ToString());
                    writer.WriteElementString("a24", num22.ToString());
                    writer.WriteElementString("a25", num23.ToString());
                    writer.WriteElementString("a31", num24.ToString());
                    writer.WriteElementString("a32", num25.ToString());
                    writer.WriteElementString("a33", i.ToString());
                    writer.WriteElementString("a34", num27.ToString());
                    writer.WriteElementString("a35", num28.ToString());
                    writer.WriteElementString("a41", num29.ToString());
                    writer.WriteElementString("a42", num30.ToString());
                    writer.WriteElementString("a43", num31.ToString());
                    writer.WriteElementString("a44", num32.ToString());
                    writer.WriteElementString("a45", num33.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("k", num14.ToString());
                    writer.WriteElementString("a3", num3.ToString());
                    writer.WriteElementString("a1", num.ToString());
                    writer.WriteElementString("b", num13.ToString());
                    writer.WriteElementString("d3", num6.ToString());
                    writer.WriteElementString("d1", num4.ToString());
                    writer.WriteElementString("a2", num2.ToString());
                    writer.WriteElementString("d2", num5.ToString());
                    writer.WriteElementString("n1", num7.ToString());
                    writer.WriteElementString("n2", num8.ToString());
                    writer.WriteElementString("n3", num9.ToString());
                    writer.WriteElementString("m1", num10.ToString());
                    writer.WriteElementString("m2", num11.ToString());
                    writer.WriteElementString("m3", num12.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/c10.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a12"))
                        {
                            num15 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a13"))
                        {
                            num16 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a14"))
                        {
                            num17 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a15"))
                        {
                            num18 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a21"))
                        {
                            num19 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a22"))
                        {
                            num20 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a23"))
                        {
                            num21 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a24"))
                        {
                            num22 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a25"))
                        {
                            num23 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a31"))
                        {
                            num24 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a32"))
                        {
                            num25 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a33"))
                        {
                            i = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a34"))
                        {
                            num27 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a35"))
                        {
                            num28 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a41"))
                        {
                            num29 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a42"))
                        {
                            num30 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a43"))
                        {
                            num31 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a44"))
                        {
                            num32 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a45"))
                        {
                            num33 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("k"))
                        {
                            num14 = int.Parse(node3.InnerText);
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", num15.ToString()).Replace("#b#", num16.ToString()).Replace("#c#", num17.ToString()).Replace("#d#", num19.ToString()).Replace("#e#", num20.ToString()).Replace("#f#", num21.ToString()).Replace("#g#", num22.ToString()).Replace("#h#", num24.ToString()).Replace("#i#", num25.ToString()).Replace("#j#", this.numberTools.compare(i)).Replace("#k#", num27.ToString()).Replace("#l#", num29.ToString()).Replace("#m#", num30.ToString()).Replace("#n#", this.numberTools.compare(num31)).Replace("#o#", ((num14 == 1) || (num14 == -1)) ? this.numberTools.compare(-num14).Replace("1", "") : this.numberTools.compare(-num14)).Replace("#p#", this.numberTools.compare(num32)).Replace("#q#", num18.ToString()).Replace("#r#", num23.ToString()).Replace("#s#", num28.ToString()).Replace("#t#", num33.ToString());
                control.Size = new Size(540, 120);
                control.Enabled = false;
                control.pub_LoadXML(sXML);
            }
        }
    }
}

