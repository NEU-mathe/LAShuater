namespace xxdswinform.Tools
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;

    internal class SupportTools
    {
        public static XmlNode AnswerXmlNode(XmlDocument xmldoc)
        {
            foreach (XmlNode node in xmldoc.ChildNodes)
            {
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    if (node2.Name.Equals("Answer"))
                    {
                        return node2;
                    }
                }
            }
            return null;
        }

        public static bool C1IJ(IList<int> a, IList<int> b)
        {
            if (a.Count == b.Count)
            {
                int num = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] == b[i])
                    {
                        num++;
                    }
                    if (num == a.Count)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool C1IJ(IList<int> a, IList<int> b, IList<int> c)
        {
            if ((a.Count == b.Count) && (b.Count == c.Count))
            {
                int num = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    if ((a[i] == b[i]) && (b[i] == c[i]))
                    {
                        num++;
                    }
                    if (num == a.Count)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static List<double> CalculationThree(List<string> NuGenMlist)
        {
            List<string> list = new List<string>();
            list = ConvertNuGenEQMLList(NuGenMlist);
            List<double> list2 = new List<double>();
            foreach (string str in list)
            {
                try
                {
                    list2.Add(double.Parse(str));
                }
                catch (Exception)
                {
                    list2.Add(1000.0);
                }
            }
            return list2;
        }

        public static List<double> ConvertNuGenEQMLDouble(List<string> NuGenEQMLList)
        {
            List<double> list = new List<double>();
            return TextBoxConvertToListDouble(ConvertNuGenEQMLList(NuGenEQMLList));
        }

        public static List<string> ConvertNuGenEQMLList(List<string> NuGenEQMLList)
        {
            List<string> list = new List<string>();
            foreach (string str in NuGenEQMLList)
            {
                list.Add(GetNuGenEQMLValue(str));
            }
            return list;
        }

        public static List<double> ConvertNuGenEQMLRawDouble(List<string> NuGenEQMLList)
        {
            List<string> list = new List<string>();
            list = ConvertNuGenEQMLList(NuGenEQMLList);
            List<double> list2 = new List<double>();
            foreach (string str in list)
            {
                double result = 0.0;
                if (double.TryParse(str, out result))
                {
                    list2.Add(result);
                }
            }
            return list2;
        }

        public static List<int> ConvertToListInt(List<string> listString)
        {
            List<int> list = new List<int>();
            foreach (string str in listString)
            {
                int result = 0;
                if (int.TryParse(str, out result))
                {
                    list.Add(result);
                }
            }
            return list;
        }

        public static void DeleteFile(string dir)
        {
            foreach (string str in Directory.GetFileSystemEntries(dir))
            {
                if (File.Exists(str))
                {
                    FileInfo info = new FileInfo(str);
                    if (info.Attributes.ToString().IndexOf("Readonly") != 1)
                    {
                        info.Attributes = FileAttributes.Normal;
                    }
                    File.Delete(str);
                }
                else
                {
                    DeleteFile(str);
                }
            }
        }

        public static void DirectoryIsExist(string directoryPath)
        {
            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                else
                {
                    FileInfo[] files = new DirectoryInfo(directoryPath).GetFiles();
                    foreach (FileInfo info2 in files)
                    {
                        info2.Delete();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public static bool DoubleEqualsInt(double d, int i)
        {
            d = Math.Round(d, 10, MidpointRounding.AwayFromZero);
            return (d == i);
        }

        public static double DoubleFormat(double k)
        {
            return Math.Round(k, 2, MidpointRounding.AwayFromZero);
        }

        public static void FileAllClean(string dirPath)
        {
            FileInfo[] files = new DirectoryInfo(dirPath).GetFiles();
            foreach (FileInfo info2 in files)
            {
                info2.Delete();
            }
        }

        public static void FilePathIsExist(string filepath)
        {
            try
            {
                int length = filepath.LastIndexOf("/");
                string path = filepath.Substring(0, length);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception)
            {
            }
        }

        public static string getGuid()
        {
            StreamReader reader = new StreamReader("temp/generate/id.txt");
            string str = reader.ReadLine();
            if (str != null)
            {
                return str;
            }
            return null;
        }

        public static int getIndex(List<int> lists, int index)
        {
            int count = lists.Count;
            for (int i = 0; i < count; i += 2)
            {
                if (lists[i] == index)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int GetL(int i, int j)
        {
            for (int k = 1; k <= 3; k++)
            {
                if ((i != k) && (j != k))
                {
                    return k;
                }
            }
            return 1;
        }

        public static string GetNuGenEQMLValue(string xml)
        {
            List<string> list = new List<string>();
            XmlDocument document = new XmlDocument();
            try
            {
                int num2;
                string[] strArray;
                string str2;
                double num3;
                int num5;
                string str5;
                string str = xml.Replace("&minus;", "-").Replace("&plus;", "+").Replace("&times;", "*").Replace("&sol;", "/");
                document.LoadXml(str);
                XmlNodeList elementsByTagName = document.GetElementsByTagName("mtable");
                if (elementsByTagName.Count > 0)
                {
                    int count = elementsByTagName.Count;
                    XmlNode node = elementsByTagName.Item(count - 1);
                    foreach (XmlNode node2 in node.ChildNodes)
                    {
                        if (node2.Name.Equals("mtr"))
                        {
                            foreach (XmlNode node3 in node2.ChildNodes)
                            {
                                if (node3.Name.Equals("mtd"))
                                {
                                    foreach (XmlNode node4 in node3.ChildNodes)
                                    {
                                        if (node4.Name.Equals("mn"))
                                        {
                                            list.Add(node4.InnerText);
                                        }
                                        else if (!node4.Name.Equals("mi"))
                                        {
                                            if (node4.Name.Equals("msqrt"))
                                            {
                                                foreach (XmlNode node5 in node4.ChildNodes)
                                                {
                                                    if (node5.Name.Equals("mrow"))
                                                    {
                                                        foreach (XmlNode node6 in node5.ChildNodes)
                                                        {
                                                            if (node6.Name.Equals("mn"))
                                                            {
                                                                num2 = list.Count;
                                                                strArray = list.ToArray();
                                                                if ((num2 - 1) >= 0)
                                                                {
                                                                    if ((((strArray[num2 - 1] != "+") && (strArray[num2 - 1] != "-")) && (strArray[num2 - 1] != "*")) && (strArray[num2 - 1] != "/"))
                                                                    {
                                                                        str2 = strArray[num2 - 1];
                                                                        num3 = Math.Sqrt((double) int.Parse(node6.InnerText)) * double.Parse(str2);
                                                                        list.RemoveAt(num2 - 1);
                                                                        list.Add(num3.ToString());
                                                                    }
                                                                    else
                                                                    {
                                                                        list.Add(Math.Sqrt((double) int.Parse(node6.InnerText)).ToString());
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    list.Add(Math.Sqrt((double) int.Parse(node6.InnerText)).ToString());
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            else if (node4.Name.Equals("mo"))
                                            {
                                                list.Add(node4.InnerText);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    XmlNodeList list3 = document.GetElementsByTagName("math");
                    XmlNode node7 = list3.Item(list3.Count - 1);
                    foreach (XmlNode node4 in node7.ChildNodes)
                    {
                        if (node4.Name.Equals("mn"))
                        {
                            list.Add(node4.InnerText);
                        }
                        else if (!node4.Name.Equals("mi"))
                        {
                            if (node4.Name.Equals("msqrt"))
                            {
                                foreach (XmlNode node5 in node4.ChildNodes)
                                {
                                    if (node5.Name.Equals("mrow"))
                                    {
                                        foreach (XmlNode node6 in node5.ChildNodes)
                                        {
                                            if (node6.Name.Equals("mn"))
                                            {
                                                num2 = list.Count;
                                                strArray = list.ToArray();
                                                if ((num2 - 1) >= 0)
                                                {
                                                    if ((((strArray[num2 - 1] != "+") && (strArray[num2 - 1] != "-")) && (strArray[num2 - 1] != "*")) && (strArray[num2 - 1] != "/"))
                                                    {
                                                        str2 = strArray[num2 - 1];
                                                        num3 = Math.Sqrt((double) int.Parse(node6.InnerText)) * double.Parse(str2);
                                                        list.RemoveAt(num2 - 1);
                                                        list.Add(num3.ToString());
                                                    }
                                                    else
                                                    {
                                                        list.Add(Math.Sqrt((double) int.Parse(node6.InnerText)).ToString());
                                                    }
                                                }
                                                else
                                                {
                                                    list.Add(Math.Sqrt((double) int.Parse(node6.InnerText)).ToString());
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (node4.Name.Equals("mo"))
                            {
                                list.Add(node4.InnerText);
                            }
                        }
                    }
                }
                string[] strArray2 = list.ToArray();
                double num4 = 0.0;
                string str3 = null;
                if (strArray2[0] == "-")
                {
                    strArray2[0] = "";
                    strArray2[1] = (double.Parse(strArray2[1]) * -1.0).ToString();
                    if (strArray2.Length == 2)
                    {
                        num4 = double.Parse(strArray2[1]);
                    }
                }
                double[] numArray = new double[strArray2.Length];
                if (strArray2.Length == 1)
                {
                    num4 = double.Parse(strArray2[0]);
                }
                for (num5 = 0; num5 < strArray2.Length; num5++)
                {
                    double num6;
                    double num7;
                    double num8;
                    if ((strArray2[num5] == "*") || (strArray2[num5] == "/"))
                    {
                        num6 = 0.0;
                        num7 = 0.0;
                        num8 = 0.0;
                        num7 = double.Parse(strArray2[num5 - 1]);
                        num8 = double.Parse(strArray2[num5 + 1]);
                        str5 = strArray2[num5];
                        if (str5 != null)
                        {
                            if (!(str5 == "*"))
                            {
                                if (str5 == "/")
                                {
                                    goto Label_089A;
                                }
                            }
                            else
                            {
                                num6 = (num7 * num8) * 1.0;
                                numArray[num5] = num6;
                            }
                        }
                    }
                    continue;
                Label_089A:
                    if (num8 != 0.0)
                    {
                        num6 = (num7 * 1.0) / num8;
                        numArray[num5] = num6;
                        if ((num5 + 3) > strArray2.Length)
                        {
                            num4 = num6;
                        }
                    }
                }
                for (num5 = 0; num5 < strArray2.Length; num5++)
                {
                    str3 = str3 + strArray2[num5];
                    if ((strArray2[num5] == "+") || ((strArray2[num5] == "-") && (num5 != 0)))
                    {
                        str5 = strArray2[num5];
                        if (str5 != null)
                        {
                            if (!(str5 == "+"))
                            {
                                if (str5 == "-")
                                {
                                    goto Label_0A9D;
                                }
                            }
                            else if ((num5 >= 3) && ((strArray2[num5 - 2] == "/") || (strArray2[num5 - 2] == "*")))
                            {
                                if ((num5 < (strArray2.Length - 3)) && ((strArray2[num5 + 2] == "/") || (strArray2[num5 + 2] == "*")))
                                {
                                    num4 = numArray[num5 + 2] + numArray[num5 - 2];
                                }
                                else
                                {
                                    num4 = numArray[num5 - 2] + double.Parse(strArray2[num5 + 1]);
                                }
                            }
                            else if ((num5 < (strArray2.Length - 3)) && ((strArray2[num5 + 2] == "/") || (strArray2[num5 + 2] == "*")))
                            {
                                num4 = double.Parse(strArray2[num5 - 1]) + numArray[num5 + 2];
                            }
                            else
                            {
                                num4 = double.Parse(strArray2[num5 - 1]) + double.Parse(strArray2[num5 + 1]);
                            }
                        }
                    }
                    continue;
                Label_0A9D:
                    if ((num5 >= 3) && ((strArray2[num5 - 2] == "/") || (strArray2[num5 - 2] == "*")))
                    {
                        if ((num5 < (strArray2.Length - 3)) && ((strArray2[num5 + 2] == "/") || (strArray2[num5 + 2] == "*")))
                        {
                            num4 = numArray[num5 + 2] - (-1.0 * numArray[num5 - 2]);
                        }
                        else
                        {
                            num4 = numArray[num5 - 2] - (-1.0 * double.Parse(strArray2[num5 + 1]));
                        }
                    }
                    else if ((num5 < (strArray2.Length - 3)) && ((strArray2[num5 + 2] == "/") || (strArray2[num5 + 2] == "*")))
                    {
                        num4 = double.Parse(strArray2[num5 - 1]) - numArray[num5 + 2];
                    }
                    else
                    {
                        num4 = double.Parse(strArray2[num5 - 1]) - double.Parse(strArray2[num5 + 1]);
                    }
                }
                if (((str3.Contains("/") && !str3.Contains("+")) && !str3.Contains("-")) && !str3.Contains("*"))
                {
                    string[] strArray3 = str3.Split(new char[] { '/' });
                    double num9 = double.Parse(strArray3[0]);
                    double num10 = double.Parse(strArray3[1]);
                    if (num10 == 0.0)
                    {
                        return "";
                    }
                    num4 = num9 / num10;
                }
                if (str3.Length == 0)
                {
                    return "";
                }
                return num4.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static bool JST1(List<int> esixt, int n)
        {
            return (((esixt.IndexOf(n) < 0) && (n >= 1)) && (n <= 5));
        }

        public static List<double> MyMethod(List<string> listString)
        {
            List<double> list = new List<double>();
            foreach (string str in listString)
            {
                double result = 0.0;
                if (double.TryParse(str, out result))
                {
                    list.Add(result);
                }
            }
            return list;
        }

        public static XmlNode ParamsXmlNode(XmlDocument xmldoc)
        {
            foreach (XmlNode node in xmldoc.ChildNodes)
            {
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    if (node2.Name.Equals("Params"))
                    {
                        return node2;
                    }
                }
            }
            return null;
        }

        public static string StringToDouble(string text)
        {
            if (text.Contains("/"))
            {
                double num;
                double num2;
                string[] strArray = text.Split(new char[] { '/' });
                if (((strArray.GetLength(0) == 2) && (double.TryParse(strArray[0], out num) && double.TryParse(strArray[1], out num2))) && !(num2 == 0.0))
                {
                    double num3 = num / num2;
                    return Math.Round(num3, 2, MidpointRounding.AwayFromZero).ToString();
                }
            }
            return text;
        }

        public static bool TextBoxAnswerJudge(string InnerText, string UserAnswer)
        {
            double num2;
            double num = double.Parse(InnerText);
            return (double.TryParse(StringToDouble(UserAnswer), out num2) && (Math.Abs((double) (num - num2)) < 0.5));
        }

        public static List<double> TextBoxConvertToListDouble(List<string> listString)
        {
            List<double> list = new List<double>();
            foreach (string str in listString)
            {
                double result = 0.0;
                if (double.TryParse(str, out result))
                {
                    double item = Math.Round(result, 2, MidpointRounding.AwayFromZero);
                    list.Add(item);
                }
            }
            return list;
        }
    }
}

