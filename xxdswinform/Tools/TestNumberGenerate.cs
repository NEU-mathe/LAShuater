namespace xxdswinform.Tools
{
    using System;
    using System.Collections.Generic;

    public class TestNumberGenerate
    {
        private Random random = new Random();

        public List<string> CalculationGenerate(int count)
        {
            List<int> list = this.GenerateCalculationNumber(count, 11);
            List<string> list2 = new List<string>();
            for (int i = 0; i < count; i++)
            {
                switch (list[i])
                {
                    case 1:
                        list2.Add("c1.xml");
                        break;

                    case 2:
                        list2.Add("c2.xml");
                        break;

                    case 3:
                        list2.Add("c3.xml");
                        break;

                    case 4:
                        list2.Add("c4.xml");
                        break;

                    case 5:
                        list2.Add("c5.xml");
                        break;

                    case 6:
                        list2.Add("c6.xml");
                        break;

                    case 7:
                        list2.Add("c7.xml");
                        break;

                    case 8:
                        list2.Add("c8.xml");
                        break;

                    case 9:
                        list2.Add("c9.xml");
                        break;

                    case 10:
                        list2.Add("c10.xml");
                        break;

                    case 11:
                        list2.Add("c11.xml");
                        break;
                }
            }
            return list2;
        }

        public List<string> ChoiceGenerate(ref List<int> choicenumber)
        {
            List<int> list = this.NumberGenerate(5, 6);
            List<string> choiceString = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i])
                {
                    case 1:
                        choiceString.Add("ChapterOne_" + this.random.Next(1, 3));
                        break;

                    case 2:
                        choiceString.Add("ChapterTwo_" + this.random.Next(1, 3));
                        break;

                    case 3:
                        choiceString.Add("ChapterThree_" + this.random.Next(1, 3));
                        break;

                    case 4:
                        choiceString.Add("ChapterFour_" + this.random.Next(1, 3));
                        break;

                    case 5:
                        choiceString.Add("ChapterFive_" + this.random.Next(1, 3));
                        break;

                    case 6:
                        choiceString.Add("ChapterSix_" + this.random.Next(1, 3));
                        break;

                    case 7:
                        choiceString.Add("ChapterSeven_" + this.random.Next(1, 3));
                        break;
                }
            }
            choicenumber = new ChoiceAnwserNumber().GetChoiceAnwserNumber(choiceString);
            return choiceString;
        }

        private List<int> ChooseNumberGenerate(int count)
        {
            List<int> list = new List<int>();
            while (list.Count < count)
            {
                int item = this.random.Next(3, 8);
                if (!list.Contains(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public List<string> GapfillingGenerate(int count)
        {
            List<int> list = this.ChooseNumberGenerate(count - 2);
            List<int> list2 = new List<int>();
            while (list2.Count < count)
            {
                int item = this.random.Next(1, 8);
                if (!((item > 2) || list2.Contains(item)))
                {
                    list2.Add(item);
                }
                else
                {
                    if (!(!list.Contains(item) || list2.Contains(item)))
                    {
                        list2.Add(item);
                    }
                    continue;
                }
            }
            List<string> list3 = new List<string>();
            for (int i = 0; i < count; i++)
            {
                int num5;
                int num9;
                switch (list2[i])
                {
                    case 1:
                    {
                        if (this.random.Next(1, 3) != 1)
                        {
                            break;
                        }
                        list3.Add("g_one_1.xml");
                        continue;
                    }
                    case 2:
                    {
                        if (this.random.Next(1, 3) != 1)
                        {
                            goto Label_0129;
                        }
                        list3.Add("g_two_1.xml");
                        continue;
                    }
                    case 3:
                    {
                        if (this.random.Next(1, 3) != 1)
                        {
                            goto Label_0213;
                        }
                        list3.Add("g_three_1.xml");
                        continue;
                    }
                    case 4:
                    {
                        if (this.random.Next(1, 3) != 1)
                        {
                            goto Label_0253;
                        }
                        list3.Add("g_four_1.xml");
                        continue;
                    }
                    case 5:
                    {
                        list3.Add("g_five_1.xml");
                        continue;
                    }
                    case 6:
                    {
                        list3.Add("g_six_1.xml");
                        continue;
                    }
                    case 7:
                    {
                        if (this.random.Next(1, 3) != 2)
                        {
                            goto Label_02B5;
                        }
                        list3.Add("g_seven_2.xml");
                        continue;
                    }
                    default:
                    {
                        continue;
                    }
                }
                list3.Add("g_one_2.xml");
                continue;
            Label_0129:
                num5 = this.random.Next(1, 7);
                if (num5 == 1)
                {
                    list3.Add("g_two_2_1.xml");
                }
                else if (num5 == 2)
                {
                    list3.Add("g_two_2_2.xml");
                }
                else if (num5 == 3)
                {
                    list3.Add("g_two_2_3.xml");
                }
                else if (num5 == 4)
                {
                    list3.Add("g_two_2_4.xml");
                }
                else if (num5 == 5)
                {
                    list3.Add("g_two_2_5.xml");
                }
                else
                {
                    list3.Add("g_two_2_6.xml");
                }
                continue;
            Label_0213:
                list3.Add("g_three_2.xml");
                continue;
            Label_0253:
                list3.Add("g_four_2.xml");
                continue;
            Label_02B5:
                num9 = this.random.Next(1, 4);
                if (num9 == 1)
                {
                    list3.Add("g_seven_1_1.xml");
                }
                else if (num9 == 2)
                {
                    list3.Add("g_seven_1_2.xml");
                }
                else
                {
                    list3.Add("g_seven_1_3.xml");
                }
            }
            return list3;
        }

        private List<int> GenerateCalculationNumber(int count, int p)
        {
            List<int> list = new List<int> {
                this.random.Next(7, 10),
                this.random.Next(1, 3),
                this.random.Next(3, 6)
            };
            int item = 0;
            while (true)
            {
                item = this.random.Next(6, 12);
                switch (item)
                {
                    case 6:
                    case 10:
                    case 11:
                        list.Add(item);
                        return list;
                }
            }
        }

        public List<int> NumberGenerate(int count, int gapcount)
        {
            List<int> list = new List<int>();
            while (list.Count < count)
            {
                int item = this.random.Next(1, gapcount + 1);
                if (!list.Contains(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}

