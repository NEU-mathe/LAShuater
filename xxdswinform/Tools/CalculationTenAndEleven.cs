namespace xxdswinform.Tools
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class CalculationTenAndEleven
    {
        public void Bracket(string AText, out string ALStr, out string ACStr, out string ARStr)
        {
            string str;
            int num = 0;
            int num2 = 0;
            ARStr = str = "";
            ALStr = ACStr = str;
            for (int i = 0; i < AText.Length; i++)
            {
                if (AText[i] == '(')
                {
                    num++;
                }
                else if (AText[i] == ')')
                {
                    num2++;
                }
                if (num == 0)
                {
                    ALStr = ALStr + AText[i];
                }
                else if (num > num2)
                {
                    ACStr = ACStr + AText[i];
                }
                else
                {
                    ARStr = AText.Substring(i + 1);
                    break;
                }
            }
            if (ACStr.Length >= 1)
            {
                ACStr = ACStr.Remove(0, 1);
            }
        }

        public string Calc(string AText)
        {
            string aText = "";
            int length = AText.Length;
            for (int i = 0; i < length; i++)
            {
                if (((AText[i] == '-') && ((i + 1) < length)) && ("+-()".IndexOf(AText[i + 1]) < 0))
                {
                    if ((i == 0) || ((i > 0) && ("*/".IndexOf(AText[i - 1]) >= 0)))
                    {
                        aText = aText + "_";
                    }
                    else if (((i > 0) && ("+-".IndexOf(AText[i - 1]) >= 0)) || (((i + 1) < length) && ("+-()".IndexOf(AText[i + 1]) < 0)))
                    {
                        aText = aText + "+_";
                    }
                    else
                    {
                        aText = aText + AText[i];
                    }
                }
                else
                {
                    aText = aText + AText[i];
                }
            }
            return this.fCalc(aText);
        }

        public List<string> CheckCharAndReplace(string str1, string str2, string str3)
        {
            int num = 0;
            string str = "cdk";
            List<string> list = new List<string>();
            int length = str1.Length;
            int num3 = str2.Length;
            int num4 = str3.Length;
            string str4 = "";
            for (int i = 0; i < length; i++)
            {
                char ch = str1[i];
                if (str.Contains(ch.ToString()))
                {
                    str4 = str1[i].ToString();
                    num++;
                }
            }
            if (str2.Contains(str4))
            {
                num++;
            }
            if (str3.Contains(str4))
            {
                num++;
            }
            if (num == 3)
            {
                list.Add(str1.Replace(str4, "1"));
                list.Add(str1.Replace(str4, "2"));
                list.Add(str2.Replace(str4, "1"));
                list.Add(str2.Replace(str4, "2"));
                list.Add(str3.Replace(str4, "1"));
                list.Add(str3.Replace(str4, "2"));
                return list;
            }
            return null;
        }

        public string fCalc(string AText)
        {
            string str;
            string str3;
            int index;
            int num2;
            int num3;
            double num4;
            if (AText.IndexOf('(') >= 0)
            {
                string str2;
                this.Bracket(AText, out str, out str2, out str3);
                return this.fCalc(str + this.fCalc(str2) + str3);
            }
            if ((AText.IndexOf('+') >= 0) || (AText.IndexOf('-') >= 0))
            {
                index = AText.IndexOf('+');
                num2 = AText.IndexOf('-');
                if (index < 0)
                {
                    index = AText.Length - 1;
                }
                if (num2 < 0)
                {
                    num2 = AText.Length - 1;
                }
                num3 = Math.Min(index, num2);
                str = AText.Substring(0, num3);
                str3 = AText.Substring(num3 + 1);
                if (str.Length <= 0)
                {
                    str = "0";
                }
                if (str3.Length <= 0)
                {
                    str3 = "0";
                }
                if (index == num3)
                {
                    num4 = double.Parse(this.fCalc(str)) + double.Parse(this.fCalc(str3));
                    return num4.ToString();
                }
                num4 = double.Parse(this.fCalc(str)) - double.Parse(this.fCalc(str3));
                return num4.ToString();
            }
            if ((AText.IndexOf('*') >= 0) || (AText.IndexOf('/') >= 0))
            {
                index = AText.IndexOf('*');
                num2 = AText.IndexOf('/');
                if (index < 0)
                {
                    index = AText.Length - 1;
                }
                if (num2 < 0)
                {
                    num2 = AText.Length - 1;
                }
                num3 = Math.Min(index, num2);
                str = AText.Substring(0, num3);
                str3 = AText.Substring(num3 + 1);
                if (str.Length <= 0)
                {
                    str = "0";
                }
                if (str3.Length <= 0)
                {
                    str3 = "0";
                }
                if (index == num3)
                {
                    num4 = double.Parse(this.fCalc(str)) * double.Parse(this.fCalc(str3));
                    return num4.ToString();
                }
                num4 = double.Parse(this.fCalc(str)) / double.Parse(this.fCalc(str3));
                return num4.ToString();
            }
            if (AText.IndexOf('_') >= 0)
            {
                num4 = -double.Parse(this.fCalc(AText.Substring(1)));
                return num4.ToString();
            }
            return double.Parse(AText).ToString();
        }
    }
}

