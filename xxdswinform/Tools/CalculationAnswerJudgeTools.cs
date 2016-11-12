namespace xxdswinform.Tools
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Windows.Forms;

    internal class CalculationAnswerJudgeTools
    {
        public static XmlDocument xmldoc = new XmlDocument();

        public static List<bool> AnswerJudge_c1(string l1, List<string> l2_list, List<string> l3_1_list, List<string> l3_2_list, List<string> l3_3_list, List<string> l3_4_list)
        {
            int num9;
            int num10;
            int num11;
            int num12;
            int num13;
            int num14;
            int num15;
            int num16;
            int num17;
            int num20;
            int num21;
            int num22;
            int num23;
            int num24;
            int num25;
            int num26;
            int num27;
            List<bool> list = new List<bool>();
            List<int> esixt = SupportTools.ConvertToListInt(l2_list);
            List<int> lists = SupportTools.ConvertToListInt(l3_1_list);
            List<int> list4 = SupportTools.ConvertToListInt(l3_2_list);
            List<int> list5 = SupportTools.ConvertToListInt(l3_3_list);
            List<int> list6 = SupportTools.ConvertToListInt(l3_4_list);
            xmldoc.Load("temp/generate/c1.xml");
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = 0;
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("c"))
                {
                    num = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("d"))
                {
                    num2 = int.Parse(node2.InnerText);
                }
            }
            XmlNode node3 = SupportTools.ParamsXmlNode(xmldoc);
            List<int> list7 = new List<int>();
            foreach (XmlNode node2 in node3.ChildNodes)
            {
                if (node2.Name.Equals("a11"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a12"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a13"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a14"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a15"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a21"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a22"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a23"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a24"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a25"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a31"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a32"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a33"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a34"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a35"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a41"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a42"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a43"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a44"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("a45"))
                {
                    list7.Add(int.Parse(node2.InnerText));
                }
                else if (node2.Name.Equals("x1"))
                {
                    num3 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("x2"))
                {
                    num4 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("x3"))
                {
                    num5 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("y1"))
                {
                    num6 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("y2"))
                {
                    num7 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("y3"))
                {
                    num8 = int.Parse(node2.InnerText);
                }
            }
            bool flag = false;
            if ((num == 0) && (num2 == 0))
            {
                if (l1 == "2")
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
                if (esixt.Count != 2)
                {
                    list.Add(false);
                }
                else
                {
                    num9 = esixt[0];
                    num10 = esixt[1];
                    if (((((num10 >= 1) && (num10 <= 5)) && ((num9 >= 1) && (num9 <= 5))) && (((list7[num9 - 1] * list7[(5 + num10) - 1]) - (list7[num10 - 1] * list7[(5 + num9) - 1])) != 0)) && (num9 != num10))
                    {
                        list.Add(true);
                        flag = true;
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                if (flag)
                {
                    if (((lists.Count != 5) || (list4.Count != 5)) || (list5.Count != 5))
                    {
                        list.Add(false);
                        return list;
                    }
                    num11 = lists[0];
                    num12 = list4[0];
                    num13 = list5[0];
                    if (!((SupportTools.JST1(esixt, num11) && SupportTools.JST1(esixt, num12)) && SupportTools.JST1(esixt, num13)))
                    {
                        list.Add(false);
                        return list;
                    }
                    num14 = esixt[0];
                    num15 = esixt[1];
                    num16 = SupportTools.getIndex(lists, num14);
                    num17 = SupportTools.getIndex(lists, num15);
                    num9 = SupportTools.getIndex(list4, num14);
                    num10 = SupportTools.getIndex(list4, num15);
                    int num18 = SupportTools.getIndex(list5, num14);
                    int num19 = SupportTools.getIndex(list5, num15);
                    if (((((num16 != -1) && (num17 != -1)) && ((num9 != -1) && (num10 != -1))) && (num18 != -1)) && (num19 != -1))
                    {
                        num20 = lists[num16 - 1];
                        num21 = lists[num17 - 1];
                        num22 = list4[num9 - 1];
                        num23 = list4[num10 - 1];
                        num24 = list5[num18 - 1];
                        num25 = list5[num19 - 1];
                        if (((((list7[num11 - 1] == ((num20 * list7[num14 - 1]) + (num21 * list7[num15 - 1]))) && (list7[num11 + 4] == ((num20 * list7[num14 + 4]) + (num21 * list7[num15 + 4])))) && ((list7[num12 - 1] == ((num22 * list7[num14 - 1]) + (num23 * list7[num15 - 1]))) && (list7[num12 + 4] == ((num22 * list7[num14 + 4]) + (num23 * list7[num15 + 4]))))) && (list7[num13 - 1] == ((num24 * list7[num14 - 1]) + (num25 * list7[num15 - 1])))) && (list7[num13 + 4] == ((num24 * list7[num14 + 4]) + (num25 * list7[num15 + 4]))))
                        {
                            list.Add(true);
                            return list;
                        }
                        list.Add(false);
                        return list;
                    }
                    list.Add(false);
                    return list;
                }
                list.Add(false);
                return list;
            }
            if ((num == 1) && (num2 == 0))
            {
                if (l1 == "3")
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
                if (esixt.Count == 3)
                {
                    if (((((num3 * num7) != (num4 * num6)) && esixt.Contains(3)) && esixt.Contains(4)) && esixt.Contains(5))
                    {
                        list.Add(true);
                        flag = true;
                    }
                    else if (((((num3 * num8) != (num5 * num6)) && esixt.Contains(2)) && esixt.Contains(4)) && esixt.Contains(5))
                    {
                        list.Add(true);
                        flag = true;
                    }
                    else if (((((num5 * num7) != (num4 * num8)) && esixt.Contains(1)) && esixt.Contains(4)) && esixt.Contains(5))
                    {
                        list.Add(true);
                        flag = true;
                    }
                    else if (((esixt[0] != esixt[1]) && (esixt[0] != esixt[2])) && (esixt[1] != esixt[2]))
                    {
                        list.Add(true);
                        flag = true;
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
                if (flag)
                {
                    if ((lists.Count != 7) || (list4.Count != 7))
                    {
                        list.Add(false);
                        return list;
                    }
                    num12 = lists[0];
                    num13 = list4[0];
                    if (!(SupportTools.JST1(esixt, num12) && SupportTools.JST1(esixt, num13)))
                    {
                        list.Add(false);
                        return list;
                    }
                    num14 = esixt[0];
                    num15 = esixt[1];
                    num11 = esixt[2];
                    num16 = SupportTools.getIndex(lists, num14);
                    num17 = SupportTools.getIndex(lists, num15);
                    num26 = SupportTools.getIndex(lists, num11);
                    num9 = SupportTools.getIndex(list4, num14);
                    num10 = SupportTools.getIndex(list4, num15);
                    num27 = SupportTools.getIndex(list4, num11);
                    if (((((num16 != -1) && (num17 != -1)) && ((num26 != -1) && (num9 != -1))) && (num10 != -1)) && (num27 != -1))
                    {
                        num20 = lists[num16 - 1];
                        num21 = lists[num17 - 1];
                        num22 = lists[num26 - 1];
                        num23 = list4[num9 - 1];
                        num24 = list4[num10 - 1];
                        num25 = list4[num27 - 1];
                        if (((((list7[num12 - 1] == (((num20 * list7[num14 - 1]) + (num21 * list7[num15 - 1])) + (num22 * list7[num11 - 1]))) && (list7[num12 + 4] == (((num20 * list7[num14 + 4]) + (num21 * list7[num15 + 4])) + (num22 * list7[num11 + 4])))) && ((list7[num12 + 9] == (((num20 * list7[num14 + 9]) + (num21 * list7[num15 + 9])) + (num22 * list7[num11 + 9]))) && (list7[num13 - 1] == (((num23 * list7[num14 - 1]) + (num24 * list7[num15 - 1])) + (num25 * list7[num11 - 1]))))) && (list7[num13 + 4] == (((num23 * list7[num14 + 4]) + (num24 * list7[num15 + 4])) + (num25 * list7[num11 + 4])))) && (list7[num13 + 9] == (((num23 * list7[num14 + 9]) + (num24 * list7[num15 + 9])) + (num25 * list7[num11 + 9]))))
                        {
                            list.Add(true);
                            return list;
                        }
                        list.Add(false);
                        return list;
                    }
                    list.Add(false);
                    return list;
                }
                list.Add(false);
                return list;
            }
            if ((num == 1) && (num2 == 1))
            {
                if (l1 == "4")
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
                if (esixt.Count != 4)
                {
                    list.Add(false);
                }
                else
                {
                    num9 = esixt[0];
                    num10 = esixt[1];
                    num27 = esixt[2];
                    int num28 = esixt[3];
                    if ((((((num9 >= 1) && (num9 <= 5)) && ((num10 >= 1) && (num10 <= 5))) && (((num27 >= 1) && (num27 <= 5)) && ((num28 >= 1) && (num28 <= 5)))) && ((((num9 != num10) && (num9 != num27)) && ((num9 != num28) && (num10 != num27))) && (num10 != num28))) && (num27 != num28))
                    {
                        list.Add(true);
                        flag = true;
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                if (flag)
                {
                    if (lists.Count != 9)
                    {
                        list.Add(false);
                        return list;
                    }
                    num13 = lists[0];
                    if (!SupportTools.JST1(esixt, num13))
                    {
                        list.Add(false);
                        return list;
                    }
                    num14 = esixt[0];
                    num15 = esixt[1];
                    num11 = esixt[2];
                    num12 = esixt[3];
                    num16 = SupportTools.getIndex(lists, num14);
                    num17 = SupportTools.getIndex(lists, num15);
                    num26 = SupportTools.getIndex(lists, num11);
                    int num29 = SupportTools.getIndex(lists, num12);
                    if ((((num16 != -1) && (num17 != -1)) && (num26 != -1)) && (num29 != -1))
                    {
                        num20 = lists[num16 - 1];
                        num21 = lists[num17 - 1];
                        num22 = lists[num26 - 1];
                        num23 = lists[num29 - 1];
                        if ((((list7[num13 - 1] == ((((num20 * list7[num14 - 1]) + (num21 * list7[num15 - 1])) + (num22 * list7[num11 - 1])) + (num23 * list7[num12 - 1]))) && (list7[num13 + 4] == ((((num20 * list7[num14 + 4]) + (num21 * list7[num15 + 4])) + (num22 * list7[num11 + 4])) + (num23 * list7[num12 + 4])))) && (list7[num13 + 9] == ((((num20 * list7[num14 + 9]) + (num21 * list7[num15 + 9])) + (num22 * list7[num11 + 9])) + (num23 * list7[num12 + 9])))) && (list7[num13 + 14] == ((((num20 * list7[num14 + 14]) + (num21 * list7[num15 + 14])) + (num22 * list7[num11 + 14])) + (num23 * list7[num12 + 14]))))
                        {
                            list.Add(true);
                            return list;
                        }
                        list.Add(false);
                        return list;
                    }
                    list.Add(false);
                    return list;
                }
                list.Add(false);
            }
            return list;
        }

        internal static List<bool> AnswerJudge_c10(List<int> c11_comboBox_list, string c11_1_b, List<string> c11_2_list, List<string> c11_3_list)
        {
            int num41;
            List<bool> list = new List<bool>();
            xmldoc.Load("temp/generate/c10.xml");
            string str = "a";
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
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("k"))
                {
                    num = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a3"))
                {
                    num2 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a1"))
                {
                    num3 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("b"))
                {
                    num4 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("d1"))
                {
                    num6 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("d2"))
                {
                    num8 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("d3"))
                {
                    num5 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a2"))
                {
                    num7 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("n1"))
                {
                    num9 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("n2"))
                {
                    num10 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("m1"))
                {
                    num11 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("m2"))
                {
                    num12 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("n3"))
                {
                    num13 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("m3"))
                {
                    num14 = int.Parse(node2.InnerText);
                }
            }
            double num15 = num9;
            double num16 = (num9 * num6) + num3;
            double num17 = (num9 * num8) + num7;
            double num18 = (num9 * num5) + num2;
            double num19 = num11;
            double num20 = (num9 * num11) + 1.0;
            double num21 = (num11 * num16) + num6;
            double num22 = (num11 * num17) + num8;
            double num23 = (num11 * num18) + num5;
            double num24 = num12;
            double num25 = num10;
            double num26 = (num12 * num3) + (num10 * num6);
            double num27 = (num12 * num7) + (num10 * num8);
            double num28 = ((num12 * num2) + (num10 * num5)) + num4;
            double num29 = num14;
            double num30 = num13;
            double num31 = (num14 * num3) + (num13 * num6);
            double num32 = (num14 * num7) + (num13 * num8);
            double num33 = ((num14 * num2) + (num13 * num5)) + num4;
            if ((c11_comboBox_list[0] == 1) && (c11_1_b == (num41 = 0).ToString()))
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (((c11_comboBox_list[1] == 2) && (c11_comboBox_list[3] == 1)) && (c11_comboBox_list[2] == 2))
            {
                num41 = 0;
                if (((c11_2_list[0] != num41.ToString()) || (c11_2_list[1] != num.ToString())) && (c11_2_list[0] == num.ToString()))
                {
                    num41 = 0;
                    if (c11_2_list[1] != num41.ToString())
                    {
                    }
                }
            }
            if (((((c11_2_list[2] == string.Concat(new object[] { num2, "-", num3 * num4, "/", str }).Replace("--", "+").Replace("+-", "-").Replace("-+", "-")) || (c11_2_list[2] == string.Concat(new object[] { "-", num3 * num4, "/", str, num2 }).Replace("--", "+").Replace("+-", "-").Replace("-+", "-"))) && ((c11_2_list[3] == string.Concat(new object[] { num5, "-", num6 * num4, "/", str }).Replace("--", "+").Replace("+-", "-").Replace("-+", "-")) || (c11_2_list[3] == string.Concat(new object[] { "-", num6 * num4, "/", str, num5 }).Replace("--", "+").Replace("+-", "-").Replace("-+", "-")))) && (c11_2_list[4] == (num4 + "/" + str))) && (c11_2_list[5] == "0"))
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if ((c11_comboBox_list[4] == 1) && (c11_3_list[0] == num.ToString()))
            {
                try
                {
                    CalculationTenAndEleven eleven = new CalculationTenAndEleven();
                    string str2 = c11_3_list[1];
                    string str3 = c11_3_list[2];
                    string str4 = c11_3_list[4];
                    List<string> list2 = eleven.CheckCharAndReplace(str2, str3, str4);
                    if (list2 != null)
                    {
                        double num34 = double.Parse(eleven.Calc(list2[0]));
                        double num35 = double.Parse(eleven.Calc(list2[1]));
                        double num36 = double.Parse(eleven.Calc(list2[2]));
                        double num37 = double.Parse(eleven.Calc(list2[3]));
                        double num38 = double.Parse(eleven.Calc(c11_3_list[3]));
                        double num39 = double.Parse(eleven.Calc(list2[4]));
                        double num40 = double.Parse(eleven.Calc(list2[5]));
                        if (((Math.Abs((double) (num38 - ((num4 * 1.0) / num))) < 0.01) && (Math.Abs((double) (num40 - (num39 * 2.0))) < 0.01)) && (num39 != 0.0))
                        {
                            bool flag = Math.Abs((double) ((((num34 + (num15 * num36)) + (num16 * num38)) + (num17 * num39)) - num18)) < 0.01;
                            bool flag2 = Math.Abs((double) (((((num19 * num34) + (num20 * num36)) + (num21 * num38)) + (num22 * num39)) - num23)) < 0.01;
                            bool flag3 = Math.Abs((double) (((((num24 * num34) + (num25 * num36)) + ((num + num26) * num38)) + (num27 * num39)) - num28)) < 0.01;
                            bool flag4 = Math.Abs((double) (((((num29 * num34) + (num30 * num36)) + ((num + num31) * num38)) + (num32 * num39)) - num33)) < 0.01;
                            if (((flag && flag2) && flag3) && flag4)
                            {
                                list.Add(true);
                            }
                            else
                            {
                                list.Add(false);
                            }
                            return list;
                        }
                        list.Add(false);
                        return list;
                    }
                    list.Add(false);
                }
                catch (Exception)
                {
                    list.Add(false);
                    return list;
                }
                return list;
            }
            list.Add(false);
            return list;
        }

        internal static List<bool> AnswerJudge_c11(List<int> c11_comboBox_list, string c11_1_b, List<string> c11_2_list, List<string> c11_3_list)
        {
            int num30 = 0;
            List<bool> list = new List<bool>();
            xmldoc.Load("temp/generate/c11.xml");
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
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("a1"))
                {
                    num = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a2"))
                {
                    num2 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("b1"))
                {
                    num3 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("b2"))
                {
                    num4 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("n1"))
                {
                    num5 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("n2"))
                {
                    num6 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("n3"))
                {
                    num7 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("m1"))
                {
                    num8 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("m2"))
                {
                    num9 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("m3"))
                {
                    num10 = int.Parse(node2.InnerText);
                }
            }
            int num11 = num5;
            int num12 = (num5 * num3) + num;
            int num13 = (num5 * num4) + num2;
            int num14 = num8;
            int num15 = (num5 * num8) + 1;
            int num16 = (num8 * num12) + num3;
            int num17 = (num8 * num13) + num4;
            int num18 = num9;
            int num19 = num6;
            int num20 = (num9 * num) + (num6 * num3);
            int num21 = num10;
            int num22 = num7;
            int num23 = (num10 * num2) + (num7 * num4);
            if ((c11_comboBox_list[1] == 2) && (c11_1_b == (num30 = (num9 * num2) + (num6 * num4)).ToString()))
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if ((c11_comboBox_list[2] == 2) && (c11_comboBox_list[3] == 1))
            {
                num30 = (num10 * num) + (num7 * num3);
                if (c11_2_list[0] == num30.ToString())
                {
                    num30 = (num9 * num2) + (num6 * num4);
                }
            }
            if ((((c11_2_list[1] == num30.ToString()) && (c11_2_list[2] == num2.ToString())) && (c11_2_list[3] == num4.ToString())) && (c11_2_list[4] == "0"))
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if ((c11_comboBox_list[4] == 1) && (c11_comboBox_list[5] == 1))
            {
                num30 = (num10 * num) + (num7 * num3);
            }
            if ((c11_3_list[0] == num30.ToString()) && (c11_3_list[1] == (num30 = (num9 * num2) + (num6 * num4)).ToString()))
            {
                try
                {
                    CalculationTenAndEleven eleven = new CalculationTenAndEleven();
                    string str = c11_3_list[2];
                    string str2 = c11_3_list[3];
                    string str3 = c11_3_list[4];
                    List<string> list2 = eleven.CheckCharAndReplace(str, str2, str3);
                    if (list2 != null)
                    {
                        double num24 = double.Parse(eleven.Calc(list2[0]));
                        double num25 = double.Parse(eleven.Calc(list2[1]));
                        double num26 = double.Parse(eleven.Calc(list2[2]));
                        double num27 = double.Parse(eleven.Calc(list2[3]));
                        double num28 = double.Parse(eleven.Calc(list2[4]));
                        if ((Math.Abs((double) (double.Parse(eleven.Calc(list2[5])) - (2.0 * num28))) < 0.01) && (num28 != 0.0))
                        {
                            bool flag = Math.Abs((double) (((num24 + (num11 * num26)) + (num12 * num28)) - num13)) < 0.01;
                            bool flag2 = Math.Abs((double) ((((num14 * num24) + (num15 * num26)) + (num16 * num28)) - num17)) < 0.01;
                            if (flag && flag2)
                            {
                                list.Add(true);
                            }
                            else
                            {
                                list.Add(false);
                            }
                            return list;
                        }
                        list.Add(false);
                        return list;
                    }
                    list.Add(false);
                }
                catch (Exception)
                {
                    list.Add(false);
                    return list;
                }
                return list;
            }
            list.Add(false);
            return list;
        }

        public static List<bool> AnswerJudge_c2(List<string> l1_list, List<string> l2_list, List<string> l3_1_list, List<string> l3_2_list, List<string> l3_3_list, List<string> l4_list)
        {
            double num52;
            double num53;
            double num54;
            double num55;
            double num60;
            double num61;
            double num62;
            double num63;
            List<bool> list = new List<bool>();
            xmldoc.Load("temp/generate/c2.xml");
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
            List<double> list2 = SupportTools.ConvertNuGenEQMLDouble(l3_1_list);
            List<double> list3 = SupportTools.ConvertNuGenEQMLDouble(l3_2_list);
            List<double> list4 = SupportTools.ConvertNuGenEQMLDouble(l3_3_list);
            List<double> list5 = SupportTools.ConvertNuGenEQMLDouble(l4_list);
            double result = 0.0;
            double num13 = 0.0;
            double num14 = 0.0;
            double num15 = 0.0;
            double num16 = 0.0;
            double num17 = 0.0;
            double num18 = 0.0;
            double num19 = 0.0;
            double num20 = 0.0;
            double num21 = 0.0;
            double num22 = 0.0;
            double num23 = 0.0;
            double num24 = 0.0;
            double num25 = 0.0;
            double num26 = 0.0;
            double num27 = 0.0;
            double num28 = 0.0;
            double num29 = 0.0;
            double num30 = 0.0;
            double num31 = 0.0;
            double num32 = 0.0;
            double num33 = 0.0;
            double num34 = 0.0;
            double num35 = 0.0;
            double num36 = 0.0;
            double num37 = 0.0;
            double num38 = 0.0;
            double num39 = 0.0;
            double num40 = 0.0;
            double num41 = 0.0;
            double num42 = 0.0;
            double num43 = 0.0;
            double num44 = 0.0;
            double num45 = 0.0;
            double num46 = 0.0;
            double num47 = 0.0;
            double num48 = 0.0;
            double num49 = 0.0;
            double num50 = 0.0;
            double num51 = 0.0;
            bool flag = false;
            if (((((((((((((((((((double.TryParse(SupportTools.StringToDouble(l1_list[0]), out result) & double.TryParse(SupportTools.StringToDouble(l1_list[1]), out num13)) & double.TryParse(SupportTools.StringToDouble(l1_list[2]), out num14)) & double.TryParse(SupportTools.StringToDouble(l1_list[3]), out num15)) & double.TryParse(SupportTools.StringToDouble(l1_list[4]), out num16)) & double.TryParse(SupportTools.StringToDouble(l1_list[5]), out num17)) & double.TryParse(SupportTools.StringToDouble(l1_list[6]), out num18)) & double.TryParse(SupportTools.StringToDouble(l1_list[7]), out num19)) & double.TryParse(SupportTools.StringToDouble(l1_list[8]), out num20)) & double.TryParse(SupportTools.StringToDouble(l1_list[9]), out num21)) & double.TryParse(SupportTools.StringToDouble(l1_list[10]), out num22)) & double.TryParse(SupportTools.StringToDouble(l1_list[11]), out num23)) & double.TryParse(SupportTools.StringToDouble(l1_list[12]), out num24)) & double.TryParse(SupportTools.StringToDouble(l1_list[13]), out num25)) & double.TryParse(SupportTools.StringToDouble(l1_list[14]), out num26)) & double.TryParse(SupportTools.StringToDouble(l1_list[15]), out num27)) & double.TryParse(SupportTools.StringToDouble(l1_list[0x10]), out num28)) & double.TryParse(SupportTools.StringToDouble(l1_list[0x11]), out num29)) & double.TryParse(SupportTools.StringToDouble(l1_list[0x12]), out num30)) & double.TryParse(SupportTools.StringToDouble(l1_list[0x13]), out num31))
            {
                flag = true;
            }
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("c"))
                {
                    num = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("d"))
                {
                    num2 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("x1"))
                {
                    num3 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("x2"))
                {
                    num4 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("x3"))
                {
                    num5 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("x4"))
                {
                    num6 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("y1"))
                {
                    num7 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("y2"))
                {
                    num8 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("y3"))
                {
                    num9 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("z1"))
                {
                    num10 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("z2"))
                {
                    num11 = int.Parse(node2.InnerText);
                }
            }
            XmlNode node3 = SupportTools.ParamsXmlNode(xmldoc);
            foreach (XmlNode node2 in node3.ChildNodes)
            {
                if (node2.Name.Equals("a11"))
                {
                    num32 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a12"))
                {
                    num33 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a13"))
                {
                    num34 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a14"))
                {
                    num35 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a15"))
                {
                    num36 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a21"))
                {
                    num37 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a22"))
                {
                    num38 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a23"))
                {
                    num39 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a24"))
                {
                    num40 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a25"))
                {
                    num41 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a31"))
                {
                    num42 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a32"))
                {
                    num43 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a33"))
                {
                    num44 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a34"))
                {
                    num45 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a35"))
                {
                    num46 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a41"))
                {
                    num47 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a42"))
                {
                    num48 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a43"))
                {
                    num49 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a44"))
                {
                    num50 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a45"))
                {
                    num51 = double.Parse(node2.InnerText);
                }
            }
            if ((num == 0) && (num2 == 0))
            {
                if ((((((num17 == 0.0) && (num22 == 0.0)) && ((num23 == 0.0) && (num24 == 0.0))) && (((num25 == 0.0) && (num26 == 0.0)) && ((num27 == 0.0) && (num28 == 0.0)))) && (((num29 == 0.0) && (num30 == 0.0)) && (num31 == 0.0))) && flag)
                {
                    if (((((((result * num3) + (num13 * num4)) == num16) && ((num18 * num4) == num21)) && ((((result * num7) + (num13 * num8)) == num15) && ((num18 * num8) == num20))) && (((result * num10) + (num13 * num11)) == num14)) && ((num18 * num11) == num19))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
                if (SupportTools.TextBoxAnswerJudge("2", l2_list[0]))
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
                if (SupportTools.TextBoxAnswerJudge("2", l2_list[1]))
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
                if ("true" == l2_list[2])
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
                if (list2.Count == 4)
                {
                    num52 = list2[0];
                    num53 = list2[1];
                    num54 = list2[2];
                    num55 = list2[3];
                    if ((((((num32 * num52) + (num33 * num53)) + (num34 * num54)) + (num35 * num55)) == 0.0) && (((((num37 * num52) + (num38 * num53)) + (num39 * num54)) + (num40 * num55)) == 0.0))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
                if (list3.Count == 4)
                {
                    double num56 = list3[0];
                    double num57 = list3[1];
                    double num58 = list3[2];
                    double num59 = list3[3];
                    if ((((((num32 * num56) + (num33 * num57)) + (num34 * num58)) + (num35 * num59)) == 0.0) && (((((num37 * num56) + (num38 * num57)) + (num39 * num58)) + (num40 * num59)) == 0.0))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
                if (list5.Count != 4)
                {
                    list.Add(false);
                    return list;
                }
                num60 = list5[0];
                num61 = list5[1];
                num62 = list5[2];
                num63 = list5[3];
                if ((((((num32 * num60) + (num33 * num61)) + (num34 * num62)) + (num35 * num63)) == num36) && (((((num37 * num60) + (num38 * num61)) + (num39 * num62)) + (num40 * num63)) == num41))
                {
                    list.Add(true);
                    return list;
                }
                list.Add(false);
                return list;
            }
            if ((num == 1) && (num2 == 0))
            {
                if (((((num17 == 0.0) && (num22 == 0.0)) && ((num23 == 0.0) && (num27 == 0.0))) && (((num28 == 0.0) && (num29 == 0.0)) && ((num30 == 0.0) && (num31 == 0.0)))) && flag)
                {
                    if ((((((((result * num3) + (num13 * num4)) + (num14 * num5)) == num16) && (((num18 * num4) + (num19 * num5)) == num21)) && (((num24 * num5) == num26) && ((((result * num7) + (num13 * num8)) + (num14 * num9)) == num15))) && (((num18 * num8) + (num19 * num9)) == num20)) && ((num24 * num9) == num25))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
                if (SupportTools.TextBoxAnswerJudge("3", l2_list[0]))
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
                if (SupportTools.TextBoxAnswerJudge("3", l2_list[1]))
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
                if ("true" == l2_list[2])
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
                if (list2.Count != 4)
                {
                    list.Add(false);
                    list.Add(false);
                }
                else
                {
                    num52 = list2[0];
                    num53 = list2[1];
                    num54 = list2[2];
                    num55 = list2[3];
                    if (((((((num32 * num52) + (num33 * num53)) + (num34 * num54)) + (num35 * num55)) == 0.0) && (((((num37 * num52) + (num38 * num53)) + (num39 * num54)) + (num40 * num55)) == 0.0)) && (((((num42 * num52) + (num43 * num53)) + (num44 * num54)) + (num45 * num55)) == 0.0))
                    {
                        list.Add(true);
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                        list.Add(false);
                    }
                }
                if (list5.Count != 4)
                {
                    list.Add(false);
                    return list;
                }
                num60 = list5[0];
                num61 = list5[1];
                num62 = list5[2];
                num63 = list5[3];
                if (((((((num32 * num60) + (num33 * num61)) + (num34 * num62)) + (num35 * num63)) == num36) && (((((num37 * num60) + (num38 * num61)) + (num39 * num62)) + (num40 * num63)) == num41)) && (((((num42 * num60) + (num43 * num61)) + (num44 * num62)) + (num45 * num63)) == num46))
                {
                    list.Add(true);
                    return list;
                }
                list.Add(false);
                return list;
            }
            if ((num == 1) && (num2 == 1))
            {
                if (((((num17 == 0.0) && (num22 == 0.0)) && ((num23 == 0.0) && (num27 == 0.0))) && ((num28 == 0.0) && (num29 == 0.0))) && flag)
                {
                    if ((((((((result * num3) + (num13 * num4)) + (num14 * num5)) + (num15 * num6)) == num16) && ((((num18 * num4) + (num19 * num5)) + (num20 * num6)) == num21)) && (((num24 * num5) + (num25 * num6)) == num26)) && ((num30 * num6) == num31))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
                if (SupportTools.TextBoxAnswerJudge("4", l2_list[0]))
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
                if (SupportTools.TextBoxAnswerJudge("4", l2_list[1]))
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
                if ("true" == l2_list[2])
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
                if (((list4.Count == 0) && (list2.Count == 0)) && (list3.Count == 0))
                {
                    list.Add(true);
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                    list.Add(false);
                }
                if (list5.Count != 4)
                {
                    list.Add(false);
                    return list;
                }
                num60 = list5[0];
                num61 = list5[1];
                num62 = list5[2];
                num63 = list5[3];
                if ((((num3 == num60) && (num4 == num61)) && (num5 == num62)) && (num6 == num63))
                {
                    list.Add(true);
                    return list;
                }
                list.Add(false);
            }
            return list;
        }

        internal static List<bool> AnswerJudge_c3(List<string> c3_1_list, List<string> c3_2_1_list, List<string> c3_2_2_list, List<string> c3_2_3_list, List<string> c3_3_list, List<string> c3_4_list)
        {
            double num13;
            double num14;
            double num15;
            double num16;
            double num17;
            double num18;
            double num19;
            double num20;
            double num21;
            List<bool> list = new List<bool>();
            xmldoc.Load("temp/generate/c3.xml");
            double num = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            double num5 = 0.0;
            double num6 = 0.0;
            double num7 = 0.0;
            double num8 = 0.0;
            double num9 = 0.0;
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("x1"))
                {
                    num7 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("x2"))
                {
                    num8 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("x3"))
                {
                    num9 = int.Parse(node2.InnerText);
                }
            }
            XmlNode node3 = SupportTools.ParamsXmlNode(xmldoc);
            foreach (XmlNode node2 in node3.ChildNodes)
            {
                if (node2.Name.Equals("a11"))
                {
                    num = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a12"))
                {
                    num2 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a13"))
                {
                    num3 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a22"))
                {
                    num4 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a23"))
                {
                    num5 = double.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a33"))
                {
                    num6 = double.Parse(node2.InnerText);
                }
            }
            List<double> list2 = SupportTools.CalculationThree(c3_1_list);
            List<double> list3 = SupportTools.ConvertNuGenEQMLRawDouble(c3_2_1_list);
            List<double> list4 = SupportTools.ConvertNuGenEQMLRawDouble(c3_2_2_list);
            List<double> list5 = SupportTools.ConvertNuGenEQMLRawDouble(c3_2_3_list);
            double num10 = list2[0];
            double num11 = list2[1];
            double num12 = list2[2];
            if (list2[0] == num7)
            {
                list.Add(true);
                if (list3.Count == 3)
                {
                    num13 = list3[0];
                    num14 = list3[1];
                    num15 = list3[2];
                    if ((((Math.Abs((double) ((((num - list2[0]) * num13) + (num2 * num14)) + (num3 * num15))) < 0.15) && (Math.Abs((double) (((num2 * num13) + ((num4 - list2[0]) * num14)) + (num5 * num15))) < 0.15)) && (Math.Abs((double) (((num3 * num13) + (num5 * num14)) + ((num6 - list2[0]) * num15))) < 0.15)) && (((num13 != 0.0) || (num14 != 0.0)) || (num15 != 0.0)))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
            }
            else if (list2[0] == num8)
            {
                list.Add(true);
                if (list3.Count == 3)
                {
                    num16 = list3[0];
                    num17 = list3[1];
                    num18 = list3[2];
                    if ((((Math.Abs((double) ((((num - list2[0]) * num16) + (num2 * num17)) + (num3 * num18))) < 0.15) && (Math.Abs((double) (((num2 * num16) + ((num4 - list2[0]) * num17)) + (num5 * num18))) < 0.15)) && (Math.Abs((double) (((num3 * num16) + (num5 * num17)) + ((num6 - list2[0]) * num18))) < 0.15)) && (((num16 != 0.0) || (num17 != 0.0)) || (num18 != 0.0)))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
            }
            else if (list2[0] == num9)
            {
                list.Add(true);
                if (list3.Count == 3)
                {
                    num19 = list3[0];
                    num20 = list3[1];
                    num21 = list3[2];
                    if ((((Math.Abs((double) ((((num - list2[0]) * num19) + (num2 * num20)) + (num3 * num21))) < 0.15) && (Math.Abs((double) (((num2 * num19) + ((num4 - list2[0]) * num20)) + (num5 * num21))) < 0.15)) && (Math.Abs((double) (((num3 * num19) + (num5 * num20)) + ((num6 - list2[0]) * num21))) < 0.15)) && (((num19 != 0.0) || (num20 != 0.0)) || (num21 != 0.0)))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
            }
            else
            {
                list.Add(false);
                list.Add(false);
            }
            if (list2[1] == num7)
            {
                list.Add(true);
                if (list4.Count == 3)
                {
                    num13 = list4[0];
                    num14 = list4[1];
                    num15 = list4[2];
                    if ((((Math.Abs((double) ((((num - list2[1]) * num13) + (num2 * num14)) + (num3 * num15))) < 0.15) && (Math.Abs((double) (((num2 * num13) + ((num4 - list2[1]) * num14)) + (num5 * num15))) < 0.15)) && (Math.Abs((double) (((num3 * num13) + (num5 * num14)) + ((num6 - list2[1]) * num15))) < 0.15)) && (((num13 != 0.0) || (num14 != 0.0)) || (num15 != 0.0)))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
            }
            else if (list2[1] == num8)
            {
                list.Add(true);
                if (list4.Count == 3)
                {
                    num16 = list4[0];
                    num17 = list4[1];
                    num18 = list4[2];
                    if ((((Math.Abs((double) ((((num - list2[1]) * num16) + (num2 * num17)) + (num3 * num18))) < 0.15) && (Math.Abs((double) (((num2 * num16) + ((num4 - list2[1]) * num17)) + (num5 * num18))) < 0.15)) && (Math.Abs((double) (((num3 * num16) + (num5 * num17)) + ((num6 - list2[1]) * num18))) < 0.15)) && (((num16 != 0.0) || (num17 != 0.0)) || (num18 != 0.0)))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
            }
            else if (list2[1] == num9)
            {
                list.Add(true);
                if (list4.Count == 3)
                {
                    num19 = list4[0];
                    num20 = list4[1];
                    num21 = list4[2];
                    if ((((Math.Abs((double) ((((num - list2[1]) * num19) + (num2 * num20)) + (num3 * num21))) < 0.15) && (Math.Abs((double) (((num2 * num19) + ((num4 - list2[1]) * num20)) + (num5 * num21))) < 0.15)) && (Math.Abs((double) (((num3 * num19) + (num5 * num20)) + ((num6 - list2[1]) * num21))) < 0.15)) && (((num19 != 0.0) || (num20 != 0.0)) || (num21 != 0.0)))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
            }
            else
            {
                list.Add(false);
                list.Add(false);
            }
            if (list2[2] == num7)
            {
                list.Add(true);
                if (list5.Count == 3)
                {
                    num13 = list5[0];
                    num14 = list5[1];
                    num15 = list5[2];
                    if ((((Math.Abs((double) ((((num - list2[2]) * num13) + (num2 * num14)) + (num3 * num15))) < 0.15) && (Math.Abs((double) (((num2 * num13) + ((num4 - list2[2]) * num14)) + (num5 * num15))) < 0.15)) && (Math.Abs((double) (((num3 * num13) + (num5 * num14)) + ((num6 - list2[2]) * num15))) < 0.15)) && (((num13 != 0.0) || (num14 != 0.0)) || (num15 != 0.0)))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
            }
            else if (list2[2] == num8)
            {
                list.Add(true);
                if (list5.Count == 3)
                {
                    num16 = list5[0];
                    num17 = list5[1];
                    num18 = list5[2];
                    if ((((Math.Abs((double) ((((num - list2[2]) * num16) + (num2 * num17)) + (num3 * num18))) < 0.15) && (Math.Abs((double) (((num2 * num16) + ((num4 - list2[2]) * num17)) + (num5 * num18))) < 0.15)) && (Math.Abs((double) (((num3 * num16) + (num5 * num17)) + ((num6 - list2[2]) * num18))) < 0.15)) && (((num16 != 0.0) || (num17 != 0.0)) || (num18 != 0.0)))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
            }
            else if (list2[2] == num9)
            {
                list.Add(true);
                if (list5.Count == 3)
                {
                    num19 = list5[0];
                    num20 = list5[1];
                    num21 = list5[2];
                    if ((((Math.Abs((double) ((((num - list2[2]) * num19) + (num2 * num20)) + (num3 * num21))) < 0.15) && (Math.Abs((double) (((num2 * num19) + ((num4 - list2[2]) * num20)) + (num5 * num21))) < 0.15)) && (Math.Abs((double) (((num3 * num19) + (num5 * num20)) + ((num6 - list2[2]) * num21))) < 0.15)) && (((num19 != 0.0) || (num20 != 0.0)) || (num21 != 0.0)))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                else
                {
                    list.Add(false);
                }
            }
            else
            {
                list.Add(false);
                list.Add(false);
            }
            List<double> list6 = new List<double>();
            List<double> list7 = SupportTools.ConvertNuGenEQMLRawDouble(c3_3_list);
            if (list7.Count != 9)
            {
                list.Add(false);
                list.Add(false);
                list.Add(false);
            }
            else
            {
                double num22 = list7[0];
                double num23 = list7[1];
                double num24 = list7[2];
                double num25 = list7[3];
                double num26 = list7[4];
                double num27 = list7[5];
                double num28 = list7[6];
                double num29 = list7[7];
                double num30 = list7[8];
                foreach (double num31 in list2)
                {
                    if ((((Math.Abs((double) ((((num - num31) * num22) + (num2 * num23)) + (num3 * num24))) < 0.15) && (Math.Abs((double) (((num2 * num22) + ((num4 - num31) * num23)) + (num5 * num24))) < 0.15)) && (Math.Abs((double) (((num3 * num22) + (num5 * num23)) + ((num6 - num31) * num24))) < 0.15)) && (Math.Abs((double) ((((num22 * num22) + (num23 * num23)) + (num24 * num24)) - 1.0)) < 0.15))
                    {
                        list6.Add(num31);
                        list2.Remove(num31);
                        list.Add(true);
                        break;
                    }
                }
                if (list.Count < 7)
                {
                    list.Add(false);
                }
                foreach (double num31 in list2)
                {
                    if ((((Math.Abs((double) ((((num - num31) * num25) + (num2 * num26)) + (num3 * num27))) < 0.15) && (Math.Abs((double) (((num2 * num25) + ((num4 - num31) * num26)) + (num5 * num27))) < 0.15)) && (Math.Abs((double) (((num3 * num25) + (num5 * num26)) + ((num6 - num31) * num27))) < 0.15)) && (Math.Abs((double) ((((num25 * num25) + (num26 * num26)) + (num27 * num27)) - 1.0)) < 0.15))
                    {
                        list6.Add(num31);
                        list2.Remove(num31);
                        list.Add(true);
                        break;
                    }
                }
                if (list.Count < 8)
                {
                    list.Add(false);
                }
                foreach (double num31 in list2)
                {
                    if ((((Math.Abs((double) ((((num - num31) * num28) + (num2 * num29)) + (num3 * num30))) < 0.15) && (Math.Abs((double) (((num2 * num28) + ((num4 - num31) * num29)) + (num5 * num30))) < 0.15)) && (Math.Abs((double) (((num3 * num28) + (num5 * num29)) + ((num6 - num31) * num30))) < 0.15)) && (Math.Abs((double) ((((num28 * num28) + (num29 * num29)) + (num30 * num30)) - 1.0)) < 0.15))
                    {
                        list6.Add(num31);
                        list2.Remove(num31);
                        list.Add(true);
                        break;
                    }
                }
                if (list.Count < 9)
                {
                    list.Add(false);
                }
            }
            List<double> list8 = SupportTools.ConvertNuGenEQMLRawDouble(c3_4_list);
            if ((list6.Count != 3) || (list8.Count != 3))
            {
                list.Add(false);
                return list;
            }
            if (((list8[0] == list6[0]) && (list8[1] == list6[1])) && (list8[2] == list6[2]))
            {
                list.Add(true);
                return list;
            }
            list.Add(false);
            return list;
        }

        public static List<bool> AnswerJudge_c4(List<TextBox> list1, List<string> list2, List<string> list3, List<string> list4, List<string> list5, List<string> list6)
        {
            int num8;
            List<bool> list = new List<bool>();
            xmldoc.Load("temp/generate/c4.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            List<double> list7 = new List<double>();
            string innerText = null;
            string str2 = null;
            string str3 = null;
            string str4 = null;
            string str5 = null;
            string str6 = null;
            int num5 = 0;
            int num6 = 0;
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("k"))
                {
                    num = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("m"))
                {
                    num2 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("n"))
                {
                    num3 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a11"))
                {
                    innerText = node2.InnerText;
                    if (SupportTools.TextBoxAnswerJudge(innerText, list1[0].Text.Trim()))
                    {
                        num4++;
                    }
                }
                else if (node2.Name.Equals("a22"))
                {
                    str2 = node2.InnerText;
                    if (SupportTools.TextBoxAnswerJudge(str2, list1[4].Text.Trim()))
                    {
                        num4++;
                    }
                }
                else if (node2.Name.Equals("a12"))
                {
                    str4 = node2.InnerText;
                    if (SupportTools.TextBoxAnswerJudge(str4, list1[1].Text.Trim()) && SupportTools.TextBoxAnswerJudge(str4, list1[3].Text.Trim()))
                    {
                        num4++;
                    }
                }
                else if (node2.Name.Equals("a13"))
                {
                    str5 = node2.InnerText;
                    if (SupportTools.TextBoxAnswerJudge(str5, list1[2].Text.Trim()) && SupportTools.TextBoxAnswerJudge(str5, list1[6].Text.Trim()))
                    {
                        num4++;
                    }
                }
                else if (node2.Name.Equals("a23"))
                {
                    str6 = node2.InnerText;
                    if (SupportTools.TextBoxAnswerJudge(str6, list1[5].Text.Trim()) && SupportTools.TextBoxAnswerJudge(str6, list1[7].Text.Trim()))
                    {
                        num4++;
                    }
                }
                else if (node2.Name.Equals("a33"))
                {
                    str3 = node2.InnerText;
                    if (SupportTools.TextBoxAnswerJudge(str3, list1[8].Text.Trim()))
                    {
                        num4++;
                    }
                }
            }
            if (num4 == 6)
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            List<double> list8 = SupportTools.ConvertNuGenEQMLDouble(list2);
            List<double> list9 = SupportTools.ConvertNuGenEQMLDouble(list3);
            List<double> list10 = SupportTools.ConvertNuGenEQMLDouble(list4);
            if (list8.Count != 1)
            {
                list.Add(false);
            }
            else
            {
                int num7 = 0;
                for (num8 = 1; num8 < 4; num8++)
                {
                    if (list8[0] == (2 * num))
                    {
                        num5 = 1;
                        list.Add(true);
                        break;
                    }
                    if (list8[0] == (6 * num3))
                    {
                        num5 = 2;
                        list.Add(true);
                        break;
                    }
                    if (list8[0] == (3 * num2))
                    {
                        num5 = 3;
                        list.Add(true);
                        break;
                    }
                    num7++;
                }
                if (num7 == 3)
                {
                    list.Add(false);
                }
            }
            if (list9.Count != 1)
            {
                list.Add(false);
            }
            else
            {
                int num9 = 0;
                for (num8 = 1; num8 < 4; num8++)
                {
                    if ((list9[0] == (2 * num)) && (num8 != num5))
                    {
                        num6 = 1;
                        list.Add(true);
                        break;
                    }
                    if ((list9[0] == (6 * num3)) && (num8 != num5))
                    {
                        num6 = 2;
                        list.Add(true);
                        break;
                    }
                    if ((list9[0] == (3 * num2)) && (num8 != num5))
                    {
                        num6 = 3;
                        list.Add(true);
                        break;
                    }
                    num9++;
                }
                if (num9 == 3)
                {
                    list.Add(false);
                }
            }
            if (list10.Count != 1)
            {
                list.Add(false);
            }
            else
            {
                int num10 = 0;
                for (num8 = 1; num8 < 4; num8++)
                {
                    if (((list10[0] == (2 * num)) && (num8 != num5)) && (num8 != num6))
                    {
                        list.Add(true);
                        break;
                    }
                    if (((list10[0] == (6 * num3)) && (num8 != num5)) && (num8 != num6))
                    {
                        list.Add(true);
                        break;
                    }
                    if (((list10[0] == (3 * num2)) && (num8 != num5)) && (num8 != num6))
                    {
                        list.Add(true);
                        break;
                    }
                    num10++;
                }
                if (num10 == 3)
                {
                    list.Add(false);
                }
            }
            int num11 = int.Parse(innerText);
            int num12 = int.Parse(str2);
            int num13 = int.Parse(str3);
            int num14 = int.Parse(str4);
            int num15 = int.Parse(str5);
            int num16 = int.Parse(str6);
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            List<double> list11 = SupportTools.MyMethod(SupportTools.ConvertNuGenEQMLList(list5));
            if (list11.Count != 9)
            {
                list.Add(false);
            }
            else
            {
                double num17 = list11[0];
                double num18 = list11[1];
                double num19 = list11[2];
                double num20 = list11[3];
                double num21 = list11[4];
                double num22 = list11[5];
                double num23 = list11[6];
                double num24 = list11[7];
                double num25 = list11[8];
                List<double> list12 = new List<double> {
                    (double) (2 * num),
                    (double) (3 * num2),
                    (double) (6 * num3)
                };
                foreach (double num26 in list12)
                {
                    if ((((Math.Abs((double) ((((num11 - num26) * num17) + (num14 * num20)) + (num15 * num23))) < 0.15) && (Math.Abs((double) (((num14 * num17) + ((num12 - num26) * num20)) + (num16 * num23))) < 0.15)) && (Math.Abs((double) (((num15 * num17) + (num16 * num20)) + ((num13 - num26) * num23))) < 0.15)) && (Math.Abs((double) ((((num17 * num17) + (num20 * num20)) + (num23 * num23)) - 1.0)) < 0.15))
                    {
                        list7.Add(num26);
                        flag = true;
                        break;
                    }
                }
                foreach (double num26 in list12)
                {
                    if ((((Math.Abs((double) ((((num11 - num26) * num18) + (num14 * num21)) + (num15 * num24))) < 0.15) && (Math.Abs((double) (((num14 * num18) + ((num12 - num26) * num21)) + (num16 * num24))) < 0.15)) && (Math.Abs((double) (((num15 * num18) + (num16 * num21)) + ((num13 - num26) * num24))) < 0.15)) && (Math.Abs((double) ((((num18 * num18) + (num21 * num21)) + (num24 * num24)) - 1.0)) < 0.15))
                    {
                        list7.Add(num26);
                        flag2 = true;
                        break;
                    }
                }
                foreach (double num26 in list12)
                {
                    if ((((Math.Abs((double) ((((num11 - num26) * num19) + (num14 * num22)) + (num15 * num25))) < 0.15) && (Math.Abs((double) (((num14 * num19) + ((num12 - num26) * num22)) + (num16 * num25))) < 0.15)) && (Math.Abs((double) (((num15 * num19) + (num16 * num22)) + ((num13 - num26) * num25))) < 0.15)) && (Math.Abs((double) ((((num19 * num19) + (num22 * num22)) + (num25 * num25)) - 1.0)) < 0.15))
                    {
                        list7.Add(num26);
                        flag3 = true;
                        break;
                    }
                }
                if ((flag & flag2) & flag3)
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
            }
            List<double> list14 = SupportTools.ConvertNuGenEQMLDouble(list6);
            if ((list7.Count != 3) || (list14.Count != 3))
            {
                list.Add(false);
                return list;
            }
            if (((list14[0] == list7[0]) && (list14[1] == list7[1])) && (list14[2] == list7[2]))
            {
                list.Add(true);
                return list;
            }
            list.Add(false);
            return list;
        }

        public static List<bool> AnswerJudge_c5(List<string> list1, List<string> list2, List<string> list3, List<string> list4, List<string> list5, List<string> list6, List<string> list7)
        {
            List<bool> list = new List<bool>();
            xmldoc.Load("temp/generate/c5.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            double num5 = 0.0;
            double num6 = 0.0;
            double num7 = 0.0;
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("k"))
                {
                    num = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("a"))
                {
                    num2 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("b"))
                {
                    num3 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("m"))
                {
                    num4 = int.Parse(node2.InnerText);
                }
            }
            List<double> list8 = SupportTools.ConvertNuGenEQMLDouble(list1);
            List<double> list9 = SupportTools.ConvertNuGenEQMLDouble(list2);
            List<double> list10 = SupportTools.ConvertNuGenEQMLDouble(list3);
            List<double> list11 = SupportTools.ConvertNuGenEQMLDouble(list4);
            List<double> list12 = SupportTools.ConvertNuGenEQMLDouble(list5);
            List<double> list13 = SupportTools.ConvertNuGenEQMLDouble(list6);
            List<double> list14 = SupportTools.ConvertNuGenEQMLDouble(list7);
            if (list8.Count != 1)
            {
                list.Add(false);
            }
            else if (((list8[0] == num) || (list8[0] == 0.0)) || (list8[0] == (num4 - num)))
            {
                list.Add(true);
                flag = true;
            }
            else
            {
                list.Add(false);
            }
            if (list9.Count != 1)
            {
                list.Add(false);
            }
            else if (((list9[0] == num) || (list9[0] == 0.0)) || (list9[0] == (num4 - num)))
            {
                if (flag && (list8[0] == list9[0]))
                {
                    list.Add(false);
                }
                else
                {
                    flag2 = true;
                    list.Add(true);
                }
            }
            else
            {
                list.Add(false);
            }
            if (list10.Count != 1)
            {
                list.Add(false);
            }
            else if (((list10[0] == num) || (list10[0] == 0.0)) || (list10[0] == (num4 - num)))
            {
                if ((flag && (list10[0] == list8[0])) || (flag2 && (list10[0] == list9[0])))
                {
                    list.Add(false);
                }
                else
                {
                    flag3 = true;
                    list.Add(true);
                }
            }
            else
            {
                list.Add(false);
            }
            if (!((list11.Count == 3) && flag))
            {
                list.Add(false);
            }
            else if (list8[0] == num)
            {
                if (((list11[0] == list11[1]) && (list11[0] == list11[2])) && (list11[0] != 0.0))
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
            }
            else if (list8[0] == 0.0)
            {
                if ((((list11[0] / ((double) num2)) == (list11[1] / ((double) num3))) && ((list11[0] / ((double) num2)) == (list11[2] / ((double) (-num2 - num3))))) && (list11[0] != 0.0))
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
            }
            else if (((((list11[0] + list11[1]) + list11[2]) == 0.0) && ((((list11[0] * list11[0]) + (list11[1] * list11[1])) + (list11[2] * list11[2])) != 0.0)) && (((((list11[0] * num2) + (num3 * list11[1])) - (num2 * list11[2])) - (num3 * list11[2])) == 0.0))
            {
                num5 = list11[0];
                num6 = list11[1];
                num7 = list11[2];
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (!((list12.Count == 3) && flag2))
            {
                list.Add(false);
            }
            else if (list9[0] == num)
            {
                if (((list12[0] == list12[1]) && (list12[0] == list12[2])) && (list12[0] != 0.0))
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
            }
            else if (list9[0] == 0.0)
            {
                if ((((list12[0] / ((double) num2)) == (list12[1] / ((double) num3))) && ((list12[0] / ((double) num2)) == (list12[2] / ((double) (-num2 - num3))))) && (list12[0] != 0.0))
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
            }
            else if (((((list12[0] + list12[1]) + list12[2]) == 0.0) && ((((list12[0] * list12[0]) + (list12[1] * list12[1])) + (list12[2] * list12[2])) != 0.0)) && (((((list12[0] * num2) + (num3 * list12[1])) - (num2 * list12[2])) - (num3 * list12[2])) == 0.0))
            {
                num5 = list12[0];
                num6 = list12[1];
                num7 = list12[2];
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (!((list13.Count == 3) && flag3))
            {
                list.Add(false);
            }
            else if (list10[0] == num)
            {
                if (((list13[0] == list13[1]) && (list13[0] == list13[2])) && (list13[0] != 0.0))
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
            }
            else if (list10[0] == 0.0)
            {
                if ((((list13[0] / ((double) num2)) == (list13[1] / ((double) num3))) && ((list13[0] / ((double) num2)) == (list13[2] / ((double) (-num2 - num3))))) && (list13[0] != 0.0))
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
            }
            else if (((((list13[0] + list13[1]) + list13[2]) == 0.0) && ((((list13[0] * list13[0]) + (list13[1] * list13[1])) + (list13[2] * list13[2])) != 0.0)) && (((((list13[0] * num2) + (num3 * list13[1])) - (num2 * list13[2])) - (num3 * list13[2])) == 0.0))
            {
                num5 = list13[0];
                num6 = list13[1];
                num7 = list13[2];
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (list14.Count != 9)
            {
                list.Add(false);
                return list;
            }
            int num8 = 0;
            double num9 = ((num5 * num5) + (num6 * num6)) + (num7 * num7);
            if (num9 == 0.0)
            {
                list.Add(false);
                return list;
            }
            if (Math.Abs((double) (list14[0] - (((num * 1.0) / 3.0) + ((((num5 * num5) * (num4 - num)) * 1.0) / num9)))) < 0.2)
            {
                num8++;
            }
            if (Math.Abs((double) (list14[1] - (((num * 1.0) / 3.0) + ((((num5 * num6) * (num4 - num)) * 1.0) / num9)))) < 0.2)
            {
                num8++;
            }
            if (Math.Abs((double) (list14[2] - (((num * 1.0) / 3.0) + ((((num5 * num7) * (num4 - num)) * 1.0) / num9)))) < 0.2)
            {
                num8++;
            }
            if (Math.Abs((double) (list14[3] - (((num * 1.0) / 3.0) + ((((num5 * num6) * (num4 - num)) * 1.0) / num9)))) < 0.2)
            {
                num8++;
            }
            if (Math.Abs((double) (list14[4] - (((num * 1.0) / 3.0) + ((((num6 * num6) * (num4 - num)) * 1.0) / num9)))) < 0.2)
            {
                num8++;
            }
            if (Math.Abs((double) (list14[5] - (((num * 1.0) / 3.0) + ((((num6 * num7) * (num4 - num)) * 1.0) / num9)))) < 0.2)
            {
                num8++;
            }
            if (Math.Abs((double) (list14[6] - (((num * 1.0) / 3.0) + ((((num5 * num7) * (num4 - num)) * 1.0) / num9)))) < 0.2)
            {
                num8++;
            }
            if (Math.Abs((double) (list14[7] - (((num * 1.0) / 3.0) + ((((num6 * num7) * (num4 - num)) * 1.0) / num9)))) < 0.2)
            {
                num8++;
            }
            if (Math.Abs((double) (list14[8] - (((num * 1.0) / 3.0) + ((((num7 * num7) * (num4 - num)) * 1.0) / num9)))) < 0.2)
            {
                num8++;
            }
            if (num8 == 9)
            {
                list.Add(true);
                return list;
            }
            list.Add(false);
            return list;
        }

        public static List<bool> AnswerJudge_c6(List<TextBox> list1, List<string> list2, List<string> list3)
        {
            List<bool> list = new List<bool>();
            xmldoc.Load("temp/generate/c6.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
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
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("k1"))
                {
                    num = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("k2"))
                {
                    num2 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("k3"))
                {
                    num3 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("c1"))
                {
                    num8 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("c2"))
                {
                    num9 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("c3"))
                {
                    num10 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("c4"))
                {
                    num11 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("d1"))
                {
                    num4 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("d2"))
                {
                    num5 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("d3"))
                {
                    num6 = int.Parse(node2.InnerText);
                }
                else if (node2.Name.Equals("d4"))
                {
                    num7 = int.Parse(node2.InnerText);
                }
            }
            List<double> list4 = SupportTools.ConvertNuGenEQMLDouble(list2);
            List<double> list5 = SupportTools.ConvertNuGenEQMLDouble(list3);
            if (SupportTools.TextBoxAnswerJudge("3", list1[0].Text))
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (SupportTools.TextBoxAnswerJudge("3", list1[1].Text))
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (list4.Count != 10)
            {
                list.Add(false);
            }
            else if (((((list4[0] == (((num * list4[3]) / ((double) num3)) + (((num4 - num8) * list4[4]) / ((double) num7)))) && (list4[1] == (((num2 * list4[3]) / ((double) num3)) + (((num5 - num9) * list4[4]) / ((double) num7))))) && ((list4[2] == ((-list4[3] / ((double) num3)) + (((num6 - num10) * list4[4]) / ((double) num7)))) && (list4[5] == (((num * list4[8]) / ((double) num3)) + (((num4 - num8) * list4[9]) / ((double) num7)))))) && ((list4[6] == (((num2 * list4[8]) / ((double) num3)) + (((num5 - num9) * list4[9]) / ((double) num7)))) && (list4[7] == ((-list4[8] / ((double) num3)) + (((num6 - num10) * list4[9]) / ((double) num7)))))) && (((list4[4] * list4[8]) - (list4[3] * list4[9])) != 0.0))
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (list5.Count != 5)
            {
                list.Add(false);
                return list;
            }
            if ((((list5[0] - num8) == (((num * (list5[3] - num11)) / ((double) num3)) + (((num4 - num8) * list5[4]) / ((double) num7)))) && ((list5[1] - num9) == (((num2 * (list5[3] - num11)) / ((double) num3)) + (((num5 - num9) * list5[4]) / ((double) num7))))) && ((list5[2] - num10) == (((num11 - list5[3]) / ((double) num3)) + (((num6 - num10) * list5[4]) / ((double) num7)))))
            {
                list.Add(true);
                return list;
            }
            list.Add(false);
            return list;
        }

        public static List<bool> AnswerJudge_c7(List<TextBox> list1, List<TextBox> list2, List<TextBox> list3)
        {
            List<bool> list = new List<bool>();
            xmldoc.Load("temp/generate/c7.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("d11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[0].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[1].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d13"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[2].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d14"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[3].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d15"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[4].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d16"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[5].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d17"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[6].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d18"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[7].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d19"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[8].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d20"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list2[0].Text.Trim()))
                    {
                        num2++;
                    }
                }
                else if (node2.Name.Equals("d21"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list2[1].Text.Trim()))
                    {
                        num2++;
                    }
                }
                else if (node2.Name.Equals("d22"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list2[2].Text.Trim()))
                    {
                        num2++;
                    }
                }
                else if (node2.Name.Equals("d23"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list2[3].Text.Trim()))
                    {
                        num2++;
                    }
                }
                else if (node2.Name.Equals("d24"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list3[0].Text.Trim()))
                    {
                        num3++;
                    }
                }
                else if (node2.Name.Equals("d25"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list3[1].Text.Trim()))
                    {
                        num3++;
                    }
                }
                else if (node2.Name.Equals("d26"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list3[2].Text.Trim()))
                    {
                        num3++;
                    }
                }
                else if (node2.Name.Equals("d27"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list3[3].Text.Trim()))
                    {
                        num3++;
                    }
                }
                else if (node2.Name.Equals("d28"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list3[4].Text.Trim()))
                    {
                        num3++;
                    }
                }
                else if (node2.Name.Equals("d29") && SupportTools.TextBoxAnswerJudge(node2.InnerText, list3[5].Text.Trim()))
                {
                    num3++;
                }
            }
            if (num == 9)
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (num2 == 4)
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (num3 == 6)
            {
                list.Add(true);
                return list;
            }
            list.Add(false);
            return list;
        }

        public static List<bool> AnswerJudge_c8(List<TextBox> list1, List<TextBox> list2, List<TextBox> list3)
        {
            List<bool> list = new List<bool>();
            xmldoc.Load("temp/generate/c8.xml");
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("d11"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[0].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d12"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[1].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d13"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[2].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d14"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[3].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d15"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[4].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d16"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[5].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d17"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[6].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d18"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[7].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d19"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list1[8].Text.Trim()))
                    {
                        num++;
                    }
                }
                else if (node2.Name.Equals("d20"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list2[0].Text.Trim()))
                    {
                        num2++;
                    }
                }
                else if (node2.Name.Equals("d21"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list2[1].Text.Trim()))
                    {
                        num2++;
                    }
                }
                else if (node2.Name.Equals("d22"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list2[2].Text.Trim()))
                    {
                        num2++;
                    }
                }
                else if (node2.Name.Equals("d23"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list2[3].Text.Trim()))
                    {
                        num2++;
                    }
                }
                else if (node2.Name.Equals("d24"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list2[4].Text.Trim()))
                    {
                        num2++;
                    }
                }
                else if (node2.Name.Equals("d25"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list2[5].Text.Trim()))
                    {
                        num2++;
                    }
                }
                else if (node2.Name.Equals("d26"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list3[0].Text.Trim()))
                    {
                        num3++;
                    }
                }
                else if (node2.Name.Equals("d27"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list3[1].Text.Trim()))
                    {
                        num3++;
                    }
                }
                else if (node2.Name.Equals("d28"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list3[2].Text.Trim()))
                    {
                        num3++;
                    }
                }
                else if (node2.Name.Equals("d29"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list3[3].Text.Trim()))
                    {
                        num3++;
                    }
                }
                else if (node2.Name.Equals("d30"))
                {
                    if (SupportTools.TextBoxAnswerJudge(node2.InnerText, list3[4].Text.Trim()))
                    {
                        num3++;
                    }
                }
                else if (node2.Name.Equals("d31") && SupportTools.TextBoxAnswerJudge(node2.InnerText, list3[5].Text.Trim()))
                {
                    num3++;
                }
            }
            if (num == 9)
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (num2 == 6)
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (num3 == 6)
            {
                list.Add(true);
                return list;
            }
            list.Add(false);
            return list;
        }

        public static List<bool> AnswerJudge_c9(string c9, List<RadioButton> list1, List<TextBox> list2)
        {
            List<bool> list = new List<bool>();
            xmldoc.Load("temp/generate/c9.xml");
            string innerText = null;
            string str2 = null;
            string str3 = null;
            string str4 = null;
            XmlNode node = SupportTools.AnswerXmlNode(xmldoc);
            foreach (XmlNode node2 in node.ChildNodes)
            {
                if (node2.Name.Equals("D2"))
                {
                    innerText = node2.InnerText;
                }
                else if (node2.Name.Equals("x1"))
                {
                    str2 = node2.InnerText;
                }
                else if (node2.Name.Equals("x2"))
                {
                    str3 = node2.InnerText;
                }
                else if (node2.Name.Equals("x3"))
                {
                    str4 = node2.InnerText;
                }
            }
            if (SupportTools.TextBoxAnswerJudge(innerText, c9))
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (list1[1].Checked)
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (SupportTools.TextBoxAnswerJudge(str2, list2[0].Text.Trim()))
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (SupportTools.TextBoxAnswerJudge(str3, list2[1].Text.Trim()))
            {
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (SupportTools.TextBoxAnswerJudge(str4, list2[2].Text.Trim()))
            {
                list.Add(true);
                return list;
            }
            list.Add(false);
            return list;
        }
    }
}

