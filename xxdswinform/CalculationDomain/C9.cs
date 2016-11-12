namespace xxdswinform.CalculationDomain
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

    internal class C9
    {
        private TestGenerateTools numberTools = new TestGenerateTools();
        private Random random = new Random();
        private XmlDocument xmldocument = new XmlDocument();

        public void C9Generate(NuGenEQML control, string number)
        {
            this.xmldocument.Load("CalculationXML/c9.xml");
            foreach (XmlNode node in this.xmldocument.FirstChild.ChildNodes)
            {
                int num5;
                int num = 0;
                int i = 0;
                int num3 = 0;
                int num4 = 0;
                if (StudentModel.isReGeneration)
                {
                    List<int> list = this.GenerateDifferent(9);
                    num = list[0];
                    i = list[1];
                    num3 = list[2];
                    num4 = list[3];
                    string str = SupportTools.getGuid();
                    string path = "temp/generate/c9.xml";
                    FileStream w = new FileStream(path, FileMode.Create);
                    XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                        Formatting = Formatting.Indented
                    };
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Info");
                    writer.WriteAttributeString("save", "false");
                    writer.WriteAttributeString("guid", str);
                    writer.WriteStartElement("Params");
                    writer.WriteElementString("a", num.ToString());
                    writer.WriteElementString("b", i.ToString());
                    writer.WriteElementString("c", num3.ToString());
                    writer.WriteElementString("d", num4.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("Answer");
                    num5 = ((i - num) * (num3 - num)) * (num3 - i);
                    writer.WriteElementString("D2", num5.ToString());
                    writer.WriteElementString("x1", SupportTools.DoubleFormat((((i - num4) * (num3 - num4)) * 1.0) / ((double) ((i - num) * (num3 - num)))).ToString());
                    writer.WriteElementString("x2", SupportTools.DoubleFormat((((num4 - num) * (num3 - num4)) * 1.0) / ((double) ((i - num) * (num3 - i)))).ToString());
                    writer.WriteElementString("x3", SupportTools.DoubleFormat((((num4 - num) * (num4 - i)) * 1.0) / ((double) ((num3 - i) * (num3 - num)))).ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load("temp/generate/c9.xml");
                    XmlNode node2 = SupportTools.ParamsXmlNode(xmldoc);
                    foreach (XmlNode node3 in node2.ChildNodes)
                    {
                        if (node3.Name.Equals("a"))
                        {
                            num = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("b"))
                        {
                            i = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("c"))
                        {
                            num3 = int.Parse(node3.InnerText);
                        }
                        else if (node3.Name.Equals("d"))
                        {
                            num4 = int.Parse(node3.InnerText);
                        }
                    }
                }
                num5 = num4 * num4;
                string sXML = node.InnerText.Replace("#x#", number).Replace("#k#", ((num == 1) || (num == -1)) ? num.ToString().Replace("1", "") : num.ToString()).Replace("#l#", ((i == 1) || (i == -1)) ? this.numberTools.compare(i).Replace("1", "") : this.numberTools.compare(i)).Replace("#m#", ((num3 == 1) || (num3 == -1)) ? this.numberTools.compare(num3).Replace("1", "") : this.numberTools.compare(num3)).Replace("#n#", num4.ToString()).Replace("#o#", ((num == 1) || (num == -1)) ? (num5 = num * num).ToString().Replace("1", "") : (num5 = num * num).ToString()).Replace("#p#", ((i == 1) || (i == -1)) ? this.numberTools.compare(i * i).Replace("1", "") : this.numberTools.compare(i * i)).Replace("#q#", ((num3 == 1) || (num3 == -1)) ? this.numberTools.compare(num3 * num3).Replace("1", "") : this.numberTools.compare(num3 * num3)).Replace("#r#", num5.ToString());
                control.Size = new Size(440, 100);
                control.Enabled = false;
                control.pub_LoadXML(sXML);
            }
        }

        private List<int> GenerateDifferent(int num)
        {
            List<int> list = new List<int>();
            int item = this.numberTools.myRandom(num);
            int num3 = this.numberTools.myRandom(num);
            int num4 = this.numberTools.myRandom(num);
            int num5 = this.numberTools.myRandom(num);
            list.Add(item);
            list.Add(num3);
            list.Add(num4);
            list.Add(num5);
            if (((item == num3) || (item == num4)) || (num4 == num3))
            {
                list = this.GenerateDifferent(num);
            }
            return list;
        }
    }
}

