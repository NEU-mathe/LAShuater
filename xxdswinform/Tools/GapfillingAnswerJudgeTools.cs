namespace xxdswinform.Tools
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    internal class GapfillingAnswerJudgeTools
    {
        public static XmlDocument xmldoc = new XmlDocument();

        internal static bool AnswerJudge_g_five_1(string g5_1Answer)
        {
            xmldoc.Load("temp/generate/g_five_1.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("k"))
                {
                    return SupportTools.TextBoxAnswerJudge(node2.InnerText, g5_1Answer);
                }
            }
            return false;
        }

        internal static bool AnswerJudge_g_four_1(string g4_1Answer)
        {
            xmldoc.Load("temp/generate/g_four_1.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("k"))
                {
                    return SupportTools.TextBoxAnswerJudge(node2.InnerText, g4_1Answer);
                }
            }
            return false;
        }

        internal static bool AnswerJudge_g_four_2(List<string> g4_2_1_list, List<string> g4_2_2_list, List<string> g4_2_3_list)
        {
            xmldoc.Load("temp/generate/g_four_2.xml");
            XmlNode node = SupportTools.ParamsXmlNode(xmldoc);
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
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("a11"))
                {
                    num = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a12"))
                {
                    num2 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a13"))
                {
                    num3 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a14"))
                {
                    num4 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a21"))
                {
                    num5 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a22"))
                {
                    num6 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a23"))
                {
                    num7 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a24"))
                {
                    num8 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a31"))
                {
                    num9 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a32"))
                {
                    num10 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a33"))
                {
                    num11 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a34"))
                {
                    num12 = int.Parse(node2.InnerText);
                }
            }
            List<double> list = SupportTools.ConvertNuGenEQMLRawDouble(g4_2_1_list);
            List<double> list2 = SupportTools.ConvertNuGenEQMLRawDouble(g4_2_2_list);
            List<double> list3 = SupportTools.ConvertNuGenEQMLRawDouble(g4_2_3_list);
            XmlNode node3 = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node3.ChildNodes)
            {
                if (node2.Name.Equals("d"))
                {
                    if (node2.InnerText == "1")
                    {
                        if (list.Count != 4)
                        {
                            return false;
                        }
                        double num13 = list[0];
                        double num14 = list[1];
                        double num15 = list[2];
                        double num16 = list[3];
                        if (((Math.Abs((double) ((((num * num13) + (num2 * num14)) + (num3 * num15)) + (num4 * num16))) < 0.15) && (Math.Abs((double) ((((num5 * num13) + (num6 * num14)) + (num7 * num15)) + (num8 * num16))) < 0.15)) && ((Math.Abs((double) ((((num9 * num13) + (num10 * num14)) + (num11 * num15)) + (num12 * num16))) < 0.15) & !((((num13 == 0.0) & (num14 == 0.0)) & (num15 == 0.0)) & (num16 == 0.0))))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if ((list.Count != 4) || (list2.Count != 4))
                        {
                            return false;
                        }
                        double num17 = list[0];
                        double num18 = list[1];
                        double num19 = list[2];
                        double num20 = list[3];
                        double num21 = list2[0];
                        double num22 = list2[1];
                        double num23 = list2[2];
                        double num24 = list2[3];
                        if ((((Math.Abs((double) ((((num * num17) + (num2 * num18)) + (num3 * num19)) + (num4 * num20))) < 0.15) && (Math.Abs((double) ((((num5 * num17) + (num6 * num18)) + (num7 * num19)) + (num8 * num20))) < 0.15)) && ((Math.Abs((double) ((((num * num21) + (num2 * num22)) + (num3 * num23)) + (num4 * num24))) < 0.15) && (Math.Abs((double) ((((num5 * num21) + (num6 * num22)) + (num7 * num23)) + (num8 * num24))) < 0.15))) && (((Math.Abs((double) ((num17 * num22) - (num18 * num21))) >= 0.15) || (Math.Abs((double) ((num17 * num23) - (num21 * num19))) >= 0.15)) || (Math.Abs((double) ((num17 * num24) - (num21 * num20))) >= 0.15)))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static bool AnswerJudge_g_one_1(string g1Answer)
        {
            xmldoc.Load("temp/generate/g_one_1.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("D"))
                {
                    return SupportTools.TextBoxAnswerJudge(node2.InnerText, g1Answer);
                }
            }
            return false;
        }

        public static bool AnswerJudge_g_one_2(string g2Answer)
        {
            xmldoc.Load("temp/generate/g_one_2.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("D"))
                {
                    return SupportTools.TextBoxAnswerJudge(node2.InnerText, g2Answer);
                }
            }
            return false;
        }

        internal static bool AnswerJudge_g_seven_1_1(List<string> g7_1_1_list)
        {
            int num = 0;
            xmldoc.Load("temp/generate/g_seven_1_1.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("b11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_1_list[0]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_1_list[1]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b13"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_1_list[2]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b21"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_1_list[3]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b22"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_1_list[4]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b23"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_1_list[5]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b31"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_1_list[6]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b32"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_1_list[7]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b33") && SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_1_list[8]))
                {
                    num++;
                }
            }
            return (num == 9);
        }

        internal static bool AnswerJudge_g_seven_1_2(List<string> g7_1_2_list)
        {
            int num = 0;
            xmldoc.Load("temp/generate/g_seven_1_2.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("c11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[0]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[1]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c13"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[2]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c14"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[3]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c21"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[4]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c22"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[5]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c23"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[6]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c24"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[7]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c31"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[8]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c32"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[9]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c33"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[10]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c34"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[11]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c41"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[12]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c42"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[13]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c43"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[14]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("c44") && SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_2_list[15]))
                {
                    num++;
                }
            }
            return (num == 0x10);
        }

        internal static bool AnswerJudge_g_seven_1_3(List<string> g7_1_3_list)
        {
            int num = 0;
            xmldoc.Load("temp/generate/g_seven_1_3.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("b11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_3_list[0]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_3_list[1]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b13"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_3_list[2]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b21"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_3_list[3]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b22"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_3_list[4]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b23"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_3_list[5]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b31"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_3_list[6]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b32"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_3_list[7]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b33") && SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_1_3_list[8]))
                {
                    num++;
                }
            }
            return (num == 9);
        }

        internal static bool AnswerJudge_g_seven_2(List<string> g7_2_list)
        {
            int num = 0;
            xmldoc.Load("temp/generate/g_seven_2.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("b11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_2_list[0]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_2_list[1]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b13") && SupportTools.TextBoxAnswerJudge(node2.InnerText, g7_2_list[2]))
                {
                    num++;
                }
            }
            return (num == 3);
        }

        internal static bool AnswerJudge_g_six_1(string g6_1Answer)
        {
            xmldoc.Load("temp/generate/g_six_1.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("k"))
                {
                    return SupportTools.TextBoxAnswerJudge(node2.InnerText, g6_1Answer);
                }
            }
            return false;
        }

        internal static bool AnswerJudge_g_three_1(string g3_1Answer)
        {
            xmldoc.Load("temp/generate/g_three_1.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("D"))
                {
                    return SupportTools.TextBoxAnswerJudge(node2.InnerText, g3_1Answer);
                }
            }
            return false;
        }

        internal static bool AnswerJudge_g_three_2(string g3_2Answer)
        {
            xmldoc.Load("temp/generate/g_three_2.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("D"))
                {
                    return SupportTools.TextBoxAnswerJudge(node2.InnerText, g3_2Answer);
                }
            }
            return false;
        }

        internal static bool AnswerJudge_g_two_1(List<string> g1_2_1_list)
        {
            int num = 0;
            xmldoc.Load("temp/generate/g_two_1.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("b11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[0]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[1]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b13"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[2]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b14"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[3]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b21"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[4]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b22"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[5]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b23"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[6]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b24"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[7]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b31"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[8]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b32"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[9]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b33"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[10]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b34"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[11]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b41"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[12]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b42"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[13]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b43"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[14]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b44") && SupportTools.TextBoxAnswerJudge(node2.InnerText, g1_2_1_list[15]))
                {
                    num++;
                }
            }
            return (num == 0x10);
        }

        internal static bool AnswerJudge_g_two_2_1(List<string> g2_1_list)
        {
            int num = 0;
            xmldoc.Load("temp/generate/g_two_2_1.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("b11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[0]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[1]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b13"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[2]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b21"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[3]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b22"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[4]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b23"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[5]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b31"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[6]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b32"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[7]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b33") && SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[8]))
                {
                    num++;
                }
            }
            return (num == 9);
        }

        internal static bool AnswerJudge_g_two_2_2(List<string> g2_1_list)
        {
            int num = 0;
            xmldoc.Load("temp/generate/g_two_2_2.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("b11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[0]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[1]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b13"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[2]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b21"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[3]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b22"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[4]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b23"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[5]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b31"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[6]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b32"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[7]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b33") && SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[8]))
                {
                    num++;
                }
            }
            return (num == 9);
        }

        internal static bool AnswerJudge_g_two_2_3(List<string> g2_1_list)
        {
            int num = 0;
            xmldoc.Load("temp/generate/g_two_2_3.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("b11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[0]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[1]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b13"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[2]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b21"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[3]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b22"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[4]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b23"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[5]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b31"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[6]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b32"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[7]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b33") && SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[8]))
                {
                    num++;
                }
            }
            return (num == 9);
        }

        internal static bool AnswerJudge_g_two_2_4(List<string> g2_1_list)
        {
            int num = 0;
            xmldoc.Load("temp/generate/g_two_2_4.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("b11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[0]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[1]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b13"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[2]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b21"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[3]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b22"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[4]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b23"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[5]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b31"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[6]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b32"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[7]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b33") && SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[8]))
                {
                    num++;
                }
            }
            return (num == 9);
        }

        internal static bool AnswerJudge_g_two_2_5(List<string> g2_1_list)
        {
            int num = 0;
            xmldoc.Load("temp/generate/g_two_2_5.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("b11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[0]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[1]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b13"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[2]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b21"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[3]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b22"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[4]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b23"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[5]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b31"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[6]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b32"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[7]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b33") && SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[8]))
                {
                    num++;
                }
            }
            return (num == 9);
        }

        internal static bool AnswerJudge_g_two_2_6(List<string> g2_1_list)
        {
            int num = 0;
            xmldoc.Load("temp/generate/g_two_2_6.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("b11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[0]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[1]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b13"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[2]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b21"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[3]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b22"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[4]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b23"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[5]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b31"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[6]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b32"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[7]))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("b33") && SupportTools.TextBoxAnswerJudge(node2.InnerText, g2_1_list[8]))
                {
                    num++;
                }
            }
            return (num == 9);
        }
    }
}

