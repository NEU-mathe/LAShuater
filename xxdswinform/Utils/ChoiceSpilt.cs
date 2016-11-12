namespace xxdswinform.Utils
{
    using System;
    using System.Collections.Generic;

    public static class ChoiceSpilt
    {
        public static List<int> chooseFiveAnswer = new List<int>();
        public static List<int> chooseFourAnswer = new List<int>();
        public static List<int> chooseOneAnswer = new List<int>();
        public static List<int> chooseThreeAnswer = new List<int>();
        public static List<int> chooseTwoAnswer = new List<int>();
        public static List<string> StacticChoicegString = new List<string>();

        public static void splitChoice()
        {
            string[] strArray = StudentModel.chooseNumber.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strArray.Length; i++)
            {
                string[] strArray2 = strArray[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                StacticChoicegString.Add(strArray2[0]);
                for (int j = 1; j < strArray2.Length; j++)
                {
                    switch (i)
                    {
                        case 0:
                            chooseOneAnswer.Add(int.Parse(strArray2[j]));
                            break;

                        case 1:
                            chooseTwoAnswer.Add(int.Parse(strArray2[j]));
                            break;

                        case 2:
                            chooseThreeAnswer.Add(int.Parse(strArray2[j]));
                            break;

                        case 3:
                            chooseFourAnswer.Add(int.Parse(strArray2[j]));
                            break;

                        case 4:
                            chooseFiveAnswer.Add(int.Parse(strArray2[j]));
                            break;
                    }
                }
            }
        }
    }
}

