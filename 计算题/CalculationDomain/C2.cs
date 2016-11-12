namespace 计算题.CalculationDomain
{
    using Genetibase.MathX;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Xml;
    using xxdswinform.Tools;
    using xxdswinform.Utils;

    internal class C2
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmldocument = new XmlDocument();

        public void C2Generate(NuGenEQML control1, string number)
        {
            this.xmldocument.Load("CalculationXML/c2.xml");
            foreach (XmlNode node in this.xmldocument.FirstChild.ChildNodes)
            {
                int minValue = 0;
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
                if (StudentModel.isReGeneration)
                {
                    List<int> list = new List<int>();
                    List<int> list2 = new List<int>();
                    List<int> list3 = new List<int>();
                    List<int> list4 = new List<int>();
                    for (int i = 0; i < 3; i++)
                    {
                        list.Add(this.numberTools.myRandom(9));
                        list2.Add(this.numberTools.myRandom(9));
                        list4.Add(this.numberTools.myRandom(4));
                    }
                    list4.Add(this.numberTools.myRandom(4));
                    list4.Add(this.numberTools.myRandom(4));
                    list4.Add(this.numberTools.myRandom(4));
                    list.Add(this.numberTools.myRandom(9));
                    list3.Add(this.numberTools.myRandom(9));
                    list3.Add(this.numberTools.myRandom(9));
                    minValue = this.random.Next(0, 2);
                    num2 = this.random.Next(minValue, 2);
                    if ((num2 == 1) && (minValue == 1))
                    {
                        num2 = 1;
                        minValue = 0;
                    }
                    num3 = 1;
                    num4 = list4[0];
                    num5 = ((1 - num2) * (list3[0] + (list4[0] * list3[1]))) + (num2 * list4[1]);
                    num6 = ((1 - minValue) * ((list2[0] + (list4[0] * list2[1])) + ((list4[1] * num2) * list2[2]))) + (minValue * list4[2]);
                    num7 = ((list[0] + (list4[0] * list[1])) + ((list4[1] * num2) * list[2])) + ((list4[2] * minValue) * list[3]);
                    num8 = list4[3];
                    num9 = (list4[3] * list4[0]) + 1;
                    num10 = (list4[3] * num5) + ((1 - num2) * list3[1]);
                    num11 = (num6 * list4[3]) + ((1 - minValue) * list2[1]);
                    num12 = (list4[3] * num7) + list[1];
                    num13 = list4[4];
                    num14 = list4[4] * list4[0];
                    num15 = (list4[4] * num5) + num2;
                    num16 = (list4[4] * num6) + ((num2 * (1 - minValue)) * list2[2]);
                    num17 = (list4[4] * num7) + (num2 * list[2]);
                    num18 = list4[5];
                    num19 = list4[5] * num4;
                    num20 = list4[5] * num5;
                    num21 = (list4[5] * num6) + minValue;
                    num22 = (list4[5] * num7) + (minValue * list[3]);
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/c2.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("a11", num3.ToString());
                    writer.WriteElementString("a12", num4.ToString());
                    writer.WriteElementString("a13", num5.ToString());
                    writer.WriteElementString("a14", num6.ToString());
                    writer.WriteElementString("a15", num7.ToString());
                    writer.WriteElementString("a21", num8.ToString());
                    writer.WriteElementString("a22", num9.ToString());
                    writer.WriteElementString("a23", num10.ToString());
                    writer.WriteElementString("a24", num11.ToString());
                    writer.WriteElementString("a25", num12.ToString());
                    writer.WriteElementString("a31", num13.ToString());
                    writer.WriteElementString("a32", num14.ToString());
                    writer.WriteElementString("a33", num15.ToString());
                    writer.WriteElementString("a34", num16.ToString());
                    writer.WriteElementString("a35", num17.ToString());
                    writer.WriteElementString("a41", num18.ToString());
                    writer.WriteElementString("a42", num19.ToString());
                    writer.WriteElementString("a43", num20.ToString());
                    writer.WriteElementString("a44", num21.ToString());
                    writer.WriteElementString("a45", num22.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    writer.WriteElementString("c", num2.ToString());
                    writer.WriteElementString("d", minValue.ToString());
                    int num24 = list[0];
                    writer.WriteElementString("x1", num24.ToString());
                    num24 = list[1];
                    writer.WriteElementString("x2", num24.ToString());
                    num24 = list[2];
                    writer.WriteElementString("x3", num24.ToString());
                    num24 = list[3];
                    writer.WriteElementString("x4", num24.ToString());
                    num24 = list2[0];
                    writer.WriteElementString("y1", num24.ToString());
                    num24 = list2[1];
                    writer.WriteElementString("y2", num24.ToString());
                    num24 = list2[2];
                    writer.WriteElementString("y3", num24.ToString());
                    num24 = list3[0];
                    writer.WriteElementString("z1", num24.ToString());
                    writer.WriteElementString("z2", list3[1].ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/c2.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a11"))
                        {
                            num3 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a12"))
                        {
                            num4 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a13"))
                        {
                            num5 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a14"))
                        {
                            num6 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a15"))
                        {
                            num7 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a21"))
                        {
                            num8 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a22"))
                        {
                            num9 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a23"))
                        {
                            num10 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a24"))
                        {
                            num11 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a25"))
                        {
                            num12 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a31"))
                        {
                            num13 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a32"))
                        {
                            num14 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a33"))
                        {
                            num15 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a34"))
                        {
                            num16 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a35"))
                        {
                            num17 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a41"))
                        {
                            num18 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a42"))
                        {
                            num19 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a43"))
                        {
                            num20 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a44"))
                        {
                            num21 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("a45"))
                        {
                            num22 = int.Parse(node3.InnerText);
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#aa#", num3.ToString()).Replace("#bb#", num4.ToString()).Replace("#cc#", num5.ToString()).Replace("#dd#", num6.ToString()).Replace("#ee#", num8.ToString()).Replace("#ff#", num9.ToString()).Replace("#gg#", num10.ToString()).Replace("#hh#", num11.ToString()).Replace("#ii#", num13.ToString()).Replace("#jj#", num14.ToString()).Replace("#kk#", num15.ToString()).Replace("#ll#", num16.ToString()).Replace("#mm#", num18.ToString()).Replace("#nn#", num19.ToString()).Replace("#oo#", num20.ToString()).Replace("#pp#", num21.ToString()).Replace("#e#", num7.ToString()).Replace("#f#", num12.ToString()).Replace("#g#", num17.ToString()).Replace("#o#", num22.ToString());
                control1.Size = new Size(410, 0x7d);
                control1.Enabled = false;
                control1.pub_LoadXML(sXML);
            }
        }
    }
}

