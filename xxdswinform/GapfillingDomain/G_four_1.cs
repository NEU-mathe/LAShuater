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

    internal class G_four_1
    {
        private int a;
        private int b;
        private int i;
        private int j;
        private int l;
        private TestGenerateTools numberTools = new TestGenerateTools();
        private int r;
        private Random random = new Random();
        private int s;
        private int t;
        private XmlDocument xmlDocument = new XmlDocument();

        public void g_four_1Generate(NuGenEQML control0, string number)
        {
            this.xmlDocument.Load("GapfillingXML/g_four_1.xml");
            foreach (XmlNode node in this.xmlDocument.FirstChild.ChildNodes)
            {
                Dictionary<int, string> dictionary = null;
                if (StudentModel.isReGeneration)
                {
                    dictionary = this.initial();
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/g_four_1.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("a11", dictionary[1].ToString());
                    writer.WriteElementString("a12", dictionary[2].ToString());
                    writer.WriteElementString("a13", dictionary[3].ToString());
                    writer.WriteElementString("a21", dictionary[4].ToString());
                    writer.WriteElementString("a22", dictionary[5].ToString());
                    writer.WriteElementString("a23", dictionary[6].ToString());
                    writer.WriteElementString("a31", dictionary[7].ToString());
                    writer.WriteElementString("a32", dictionary[8].ToString());
                    writer.WriteElementString("a33", dictionary[9].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    double num = int.Parse(dictionary[((this.i - 1) * 3) + this.r]) * ((int.Parse(dictionary[((this.j - 1) * 3) + this.s]) * int.Parse(dictionary[((this.l - 1) * 3) + this.t])) - (int.Parse(dictionary[((this.j - 1) * 3) + this.t]) * int.Parse(dictionary[((this.l - 1) * 3) + this.s])));
                    int num2 = (-1 * this.a) * ((int.Parse(dictionary[((this.j - 1) * 3) + this.t]) * int.Parse(dictionary[((this.l - 1) * 3) + this.r])) - (int.Parse(dictionary[((this.j - 1) * 3) + this.r]) * int.Parse(dictionary[((this.l - 1) * 3) + this.t])));
                    int num3 = this.b * ((int.Parse(dictionary[((this.j - 1) * 3) + this.s]) * int.Parse(dictionary[((this.l - 1) * 3) + this.r])) - (int.Parse(dictionary[((this.j - 1) * 3) + this.r]) * int.Parse(dictionary[((this.l - 1) * 3) + this.s])));
                    writer.WriteElementString("k", SupportTools.DoubleFormat(num / ((double) (num2 + num3))).ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/g_four_1.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    dictionary = new Dictionary<int, string>();
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a11"))
                        {
                            dictionary.Add(1, node3.InnerText);
                        }
                        else if (node3.Name.Equals("a12"))
                        {
                            dictionary.Add(2, node3.InnerText);
                        }
                        else if (node3.Name.Equals("a13"))
                        {
                            dictionary.Add(3, node3.InnerText);
                        }
                        else if (node3.Name.Equals("a21"))
                        {
                            dictionary.Add(4, node3.InnerText);
                        }
                        else if (node3.Name.Equals("a22"))
                        {
                            dictionary.Add(5, node3.InnerText);
                        }
                        else if (node3.Name.Equals("a23"))
                        {
                            dictionary.Add(6, node3.InnerText);
                        }
                        else if (node3.Name.Equals("a31"))
                        {
                            dictionary.Add(7, node3.InnerText);
                        }
                        else if (node3.Name.Equals("a32"))
                        {
                            dictionary.Add(8, node3.InnerText);
                        }
                        else if (node3.Name.Equals("a33"))
                        {
                            dictionary.Add(9, node3.InnerText);
                        }
                    }
                }
                string sXML = node.InnerText.Replace("#x#", number).Replace("#a#", dictionary[1].ToString()).Replace("#b#", dictionary[2].ToString()).Replace("#c#", dictionary[3].ToString()).Replace("#d#", dictionary[4].ToString()).Replace("#e#", dictionary[5].ToString()).Replace("#f#", dictionary[6].ToString()).Replace("#g#", dictionary[7].ToString()).Replace("#h#", dictionary[8].ToString()).Replace("#i#", dictionary[9].ToString());
                control0.pub_LoadXML(sXML);
                control0.Size = new Size(0x235, 90);
                control0.Enabled = false;
                control0.Anchor = AnchorStyles.None;
            }
        }

        private Dictionary<int, string> initial()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary[1] = "2,3";
            dictionary[2] = "1,3";
            dictionary[3] = "1,2";
            this.i = this.random.Next(1, 4);
            string[] strArray = dictionary[this.i].Split(new char[] { ',' });
            this.j = int.Parse(strArray[0]);
            this.l = int.Parse(strArray[1]);
            Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
            dictionary2[1] = "2,3";
            dictionary2[2] = "1,3";
            dictionary2[3] = "1,2";
            this.r = this.random.Next(1, 4);
            string[] strArray2 = dictionary2[this.r].Split(new char[] { ',' });
            this.s = int.Parse(strArray2[0]);
            this.t = int.Parse(strArray2[1]);
            List<int> list = new List<int>();
            int num = ((this.i - 1) * 3) + this.s;
            int num2 = ((this.i - 1) * 3) + this.t;
            this.a = this.numberTools.myRandom(9);
            Dictionary<int, string> dictionary3 = new Dictionary<int, string>();
            this.b = this.numberTools.myRandom(9);
            for (int i = 0; i < 9; i++)
            {
                if (((i + 1) != num) && ((i + 1) != num2))
                {
                    list.Add(this.random.Next(-9, 10));
                    dictionary3[i + 1] = list[i].ToString();
                }
                if ((i + 1) == num)
                {
                    list.Add(this.a);
                    if (this.a == 1)
                    {
                        dictionary3[num] = "k";
                    }
                    if (this.a == -1)
                    {
                        dictionary3[num] = "-k";
                    }
                    else
                    {
                        dictionary3[num] = this.a.ToString() + "k";
                    }
                }
                else if ((i + 1) == num2)
                {
                    list.Add(this.b);
                    if (this.b == 1)
                    {
                        dictionary3[num2] = "k";
                    }
                    if (this.b == -1)
                    {
                        dictionary3[num2] = "-k";
                    }
                    else
                    {
                        dictionary3[num2] = this.b.ToString() + "k";
                    }
                }
            }
            if (((this.a * ((int.Parse(dictionary3[((this.j - 1) * 3) + this.t]) * int.Parse(dictionary3[((this.l - 1) * 3) + this.r])) - (int.Parse(dictionary3[((this.j - 1) * 3) + this.r]) * int.Parse(dictionary3[((this.l - 1) * 3) + this.t])))) - (this.b * ((int.Parse(dictionary3[((this.j - 1) * 3) + this.s]) * int.Parse(dictionary3[((this.l - 1) * 3) + this.r])) - (int.Parse(dictionary3[((this.j - 1) * 3) + this.r]) * int.Parse(dictionary3[((this.l - 1) * 3) + this.s]))))) == 0)
            {
                dictionary3 = this.initial();
            }
            return dictionary3;
        }
    }
}

