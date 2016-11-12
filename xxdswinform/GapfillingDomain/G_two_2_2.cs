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

    internal class G_two_2_2
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmlDocument = new XmlDocument();

        public void g_two_2_2Generate(NuGenEQML control1, string number)
        {
            this.xmlDocument.Load("GapfillingXML/g_two_2_2.xml");
            foreach (XmlNode node in this.xmlDocument.FirstChild.ChildNodes)
            {
                int num = 0;
                int num2 = 0;
                int i = 0;
                int j = 0;
                int num5 = 0;
                int num6 = 0;
                int num7 = 0;
                if (StudentModel.isReGeneration)
                {
                    int l;
                    num = this.numberTools.myRandom(9);
                    if (num == 1)
                    {
                        num = 2;
                    }
                    num2 = this.numberTools.myRandom(9);
                    i = this.random.Next(1, 3);
                    j = this.random.Next(i + 1, 4);
                    num5 = this.random.Next(1, 3);
                    num6 = this.random.Next(num5 + 1, 4);
                    num7 = this.random.Next(1, 4);
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/g_two_2_2.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("k", num.ToString());
                    writer.WriteElementString("t", num7.ToString());
                    writer.WriteElementString("i", i.ToString());
                    writer.WriteElementString("j", j.ToString());
                    writer.WriteEndElement();
                    List<int> list = new List<int>();
                    for (int k = 0; k < 9; k++)
                    {
                        list.Add(0);
                    }
                    if (i == num7)
                    {
                        list[(((i - 1) * 3) + j) - 1] = 1;
                        list[(((j - 1) * 3) + i) - 1] = num;
                        l = SupportTools.GetL(i, j);
                        list[(((l - 1) * 3) + l) - 1] = 1;
                    }
                    else if (j == num7)
                    {
                        list[(((i - 1) * 3) + j) - 1] = num;
                        list[(((j - 1) * 3) + i) - 1] = 1;
                        l = SupportTools.GetL(i, j);
                        list[(((l - 1) * 3) + l) - 1] = 1;
                    }
                    else
                    {
                        list[(((i - 1) * 3) + j) - 1] = 1;
                        list[(((j - 1) * 3) + i) - 1] = 1;
                        list[(((num7 - 1) * 3) + num7) - 1] = num;
                    }
                    writer.WriteStartElement("Answer");
                    int num10 = list[0];
                    writer.WriteElementString("b11", num10.ToString());
                    num10 = list[1];
                    writer.WriteElementString("b12", num10.ToString());
                    num10 = list[2];
                    writer.WriteElementString("b13", num10.ToString());
                    num10 = list[3];
                    writer.WriteElementString("b21", num10.ToString());
                    num10 = list[4];
                    writer.WriteElementString("b22", num10.ToString());
                    num10 = list[5];
                    writer.WriteElementString("b23", num10.ToString());
                    num10 = list[6];
                    writer.WriteElementString("b31", num10.ToString());
                    num10 = list[7];
                    writer.WriteElementString("b32", num10.ToString());
                    writer.WriteElementString("b33", list[8].ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/g_two_2_2.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("k"))
                        {
                            num = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("s"))
                        {
                            num2 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("i"))
                        {
                            i = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("j"))
                        {
                            j = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("m"))
                        {
                            num5 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("n"))
                        {
                            num6 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("t"))
                        {
                            num7 = int.Parse(node3.InnerText);
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#k#", num.ToString()).Replace("#s#", num2.ToString()).Replace("#i#", i.ToString()).Replace("#j#", j.ToString()).Replace("#m#", num5.ToString()).Replace("#n#", num6.ToString()).Replace("#t#", num7.ToString());
                control1.Size = new Size(950, 60);
                control1.Enabled = false;
                control1.Anchor = AnchorStyles.None;
                control1.pub_LoadXML(sXML);
            }
        }
    }
}

